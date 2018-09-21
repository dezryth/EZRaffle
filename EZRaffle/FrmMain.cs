using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using System.Net.Mail;

namespace EZRaffle
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
      InitializeControls();
    }

    private readonly SQLiteConnection _dbConnection = new SQLiteConnection("Data Source=EZRaffle.sqlite;Version=3;");

    private readonly string _sqlCreateTable =
      @"create table entries (contest varchar(100), name varchar(100), phone varchar(20), email varchar(200))";

    private readonly string _sqlSelect =
      @"select * from entries";

    private readonly string _sqlInsert =
      "insert into entries (contest, name, phone, email) values ('{0}', '{1}', '{2}', '{3}')";

    private readonly string _sqlSelectContests =
      @"select distinct contest from entries";

    private readonly string _sqlSelectWinner =
      "select name, phone, email from entries WHERE contest = '{0}' ORDER BY RANDOM() LIMIT 1";

    private void InitializeControls()
    {
      //Check if SqlLite DB File Exists and if not, create it
      if (!File.Exists(Path.Combine(
        Path.GetDirectoryName(Application.ExecutablePath) ?? throw new InvalidOperationException(), "EZRaffle.sqlite")))
      {
        SQLiteConnection.CreateFile("EZRaffle.sqlite");
        _dbConnection.Open();
        var cmdCreateTable = new SQLiteCommand(_sqlCreateTable, _dbConnection);
        cmdCreateTable.ExecuteNonQuery();
        _dbConnection.Close();
      }

      UpdateEnterContests();
      UpdatePickList();
      UpdateViewTable();
    }

    private void UpdateEnterContests()
    {
      _dbConnection.Open();
      var cmdSelect = new SQLiteCommand(_sqlSelectContests, _dbConnection);
      var table = new DataTable();
      var dataAdapter = new SQLiteDataAdapter(cmdSelect);

      dataAdapter.Fill(table);
      _dbConnection.Close();
      dataAdapter.Dispose();
      cmdSelect.Dispose();

      GC.Collect();

      cbEnterContests.DataSource = table;
      cbEnterContests.DisplayMember = "contest";
    }

    private void UpdateViewTable()
    {
      _dbConnection.Open();
      var cmdSelect = new SQLiteCommand(_sqlSelect, _dbConnection);
      var table = new DataTable();
      var dataAdapter = new SQLiteDataAdapter(cmdSelect);

      dataAdapter.Fill(table);
      _dbConnection.Close();
      dataAdapter.Dispose();
      cmdSelect.Dispose();

      GC.Collect();

      dgvEntries.DataSource = table;
    }

    private void btnLock_Click(object sender, EventArgs e)
    {
      cbEnterContests.Enabled = !cbEnterContests.Enabled;
    }

    private void btnEnter_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(cbEnterContests.Text) && !string.IsNullOrEmpty(tbName.Text) &&
          !string.IsNullOrEmpty(tbPhone.Text) && !string.IsNullOrEmpty(tbNumEntries.Text))
      {
        _dbConnection.Open();
        var sqlInsertFormatted = string.Format(_sqlInsert, ScrubString(cbEnterContests.Text), ScrubString(tbName.Text),
          ScrubString(tbPhone.Text), ScrubString(tbEmail.Text));
        var cmdInsert = new SQLiteCommand(sqlInsertFormatted, _dbConnection);

        if (!Int32.TryParse(tbNumEntries.Text, out var numEntries))
        {
          numEntries = -1;
        }

        if (numEntries != -1)
        {
          for (int i = 0; i < numEntries; i++)
          {
            cmdInsert.ExecuteNonQuery();
          }

          _dbConnection.Close();

          if (cbEmail.Checked)
          {
            SendEmail(cbEnterContests.Text, tbEmail.Text, tbName.Text, numEntries);
          }

          if (MessageBox.Show($"{tbName.Text}'s Entries Submitted!") == DialogResult.OK)
            lblEmailError.Text = "";

          ClearFields();
        }
        else
        {
          MessageBox.Show("Something went wrong. Did you enter a number for number of entries?");
          _dbConnection.Close();
        }
      }
      else
      {
        MessageBox.Show("You are missing key fields. Please ensure all fields are complete before submission.");
        _dbConnection.Close();
      }
    }

    private void SendEmail(string contest, string email, string name, int numEntries)
    {
      MailMessage msg = new MailMessage();
      msg.To.Add(new MailAddress(email, name));
      msg.From = new MailAddress(Properties.Settings.Default.EmailUser, Properties.Settings.Default.Company);
      msg.Subject = Properties.Settings.Default.Company + " - Thanks for entering our raffle!";
      msg.Body = name + ",<br /> " + "<p>You have been entered into our <strong>" + contest + "</strong> raffle with " +
                 numEntries + " entries!<br />Thanks for participating.<p/>-" + Properties.Settings.Default.Company;
      msg.IsBodyHtml = true;

      SmtpClient client = new SmtpClient
      {
        UseDefaultCredentials = false,
        Credentials = new System.Net.NetworkCredential(Properties.Settings.Default.EmailUser, Properties.Settings.Default.EmailPW),
        Port = Properties.Settings.Default.SMTPPort,
        Host = Properties.Settings.Default.SMTPHost,
        DeliveryMethod = SmtpDeliveryMethod.Network,
        EnableSsl = true
      };
      // You can use Port 25 if 587 is blocked (mine is!)
      try
      {
        client.Send(msg);
        lblEmailError.Text = "Email Confirmation Sent Successfully";
      }
      catch (Exception ex)
      {
        lblEmailError.Text = ex.ToString();
      }
    }

    private static string ScrubString(string str)
    {
      return str.Replace("\'", string.Empty);
    }

    private void ClearFields()
    {
      tbName.Text = "";
      tbPhone.Text = "";
      tbEmail.Text = "";
      tbNumEntries.Text = "";
    }

    private void tcRaffle_SelectedIndexChanged(object sender, EventArgs e)
    {
      UpdateViewTable();
      UpdatePickList();
    }

    private void UpdatePickList()
    {
      _dbConnection.Open();
      var cmdSelect = new SQLiteCommand(_sqlSelectContests, _dbConnection);
      var table = new DataTable();
      var dataAdapter = new SQLiteDataAdapter(cmdSelect);

      dataAdapter.Fill(table);
      _dbConnection.Close();
      dataAdapter.Dispose();
      cmdSelect.Dispose();

      GC.Collect();

      cbPickContests.DataSource = table;
      cbPickContests.DisplayMember = "contest";
    }

    private void btnPickWinner_Click(object sender, EventArgs e)
    {
      _dbConnection.Open();
      var cmdSelect = new SQLiteCommand(string.Format(_sqlSelectWinner, cbPickContests.Text), _dbConnection);
      var reader = cmdSelect.ExecuteReader();

      while (reader.Read())
      {
        lblWinnerName.Text = reader["name"].ToString();
        lblWinnerPhone.Text = reader["phone"].ToString();
        lblWinnerEmail.Text = reader["email"].ToString();
      }

      _dbConnection.Close();
    }

    private void btnDeleteDB_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Did you think about it? Are you sure?", "Are you sure?", MessageBoxButtons.YesNo) ==
          DialogResult.Yes)
      {
        if (File.Exists(Path.Combine(
          Path.GetDirectoryName(Application.ExecutablePath) ?? throw new InvalidOperationException(),
          "EZRaffle.sqlite")))
          File.Delete(Path.Combine(
            Path.GetDirectoryName(Application.ExecutablePath) ?? throw new InvalidOperationException(),
            "EZRaffle.sqlite"));
      }

      InitializeControls();
    }
  }
}