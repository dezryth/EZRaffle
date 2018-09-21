namespace EZRaffle
{
  partial class FrmMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.tbName = new System.Windows.Forms.TextBox();
      this.tbPhone = new System.Windows.Forms.TextBox();
      this.tbEmail = new System.Windows.Forms.TextBox();
      this.tbNumEntries = new System.Windows.Forms.TextBox();
      this.btnEnter = new System.Windows.Forms.Button();
      this.btnLock = new System.Windows.Forms.Button();
      this.tcRaffle = new System.Windows.Forms.TabControl();
      this.tpEnter = new System.Windows.Forms.TabPage();
      this.lblEmailError = new System.Windows.Forms.Label();
      this.cbEnterContests = new System.Windows.Forms.ComboBox();
      this.gbEntrant = new System.Windows.Forms.GroupBox();
      this.tpView = new System.Windows.Forms.TabPage();
      this.dgvEntries = new System.Windows.Forms.DataGridView();
      this.tpPick = new System.Windows.Forms.TabPage();
      this.gbWinner = new System.Windows.Forms.GroupBox();
      this.lblWinnerIntro = new System.Windows.Forms.Label();
      this.lblWinnerName = new System.Windows.Forms.Label();
      this.lblWinnerPhone = new System.Windows.Forms.Label();
      this.lblWinnerEmail = new System.Windows.Forms.Label();
      this.cbPickContests = new System.Windows.Forms.ComboBox();
      this.lblPickContest = new System.Windows.Forms.Label();
      this.btnPickWinner = new System.Windows.Forms.Button();
      this.tpManage = new System.Windows.Forms.TabPage();
      this.cbEmail = new System.Windows.Forms.CheckBox();
      this.lblDelete = new System.Windows.Forms.Label();
      this.btnDeleteDB = new System.Windows.Forms.Button();
      this.tcRaffle.SuspendLayout();
      this.tpEnter.SuspendLayout();
      this.gbEntrant.SuspendLayout();
      this.tpView.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvEntries)).BeginInit();
      this.tpPick.SuspendLayout();
      this.gbWinner.SuspendLayout();
      this.tpManage.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(263, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(102, 29);
      this.label1.TabIndex = 0;
      this.label1.Text = "Contest";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(229, 66);
      this.label2.Name = "label2";
      this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
      this.label2.Size = new System.Drawing.Size(100, 31);
      this.label2.TabIndex = 1;
      this.label2.Text = "Name";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(112, 126);
      this.label3.Name = "label3";
      this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
      this.label3.Size = new System.Drawing.Size(217, 31);
      this.label3.TabIndex = 2;
      this.label3.Text = "Phone Number";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(233, 186);
      this.label4.Name = "label4";
      this.label4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
      this.label4.Size = new System.Drawing.Size(96, 31);
      this.label4.TabIndex = 3;
      this.label4.Text = "Email";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(156, 246);
      this.label5.Name = "label5";
      this.label5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
      this.label5.Size = new System.Drawing.Size(173, 31);
      this.label5.TabIndex = 4;
      this.label5.Text = "# of Entries";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tbName
      // 
      this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbName.Location = new System.Drawing.Point(362, 65);
      this.tbName.Name = "tbName";
      this.tbName.Size = new System.Drawing.Size(483, 40);
      this.tbName.TabIndex = 6;
      // 
      // tbPhone
      // 
      this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbPhone.Location = new System.Drawing.Point(362, 123);
      this.tbPhone.Name = "tbPhone";
      this.tbPhone.Size = new System.Drawing.Size(483, 40);
      this.tbPhone.TabIndex = 7;
      // 
      // tbEmail
      // 
      this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbEmail.Location = new System.Drawing.Point(362, 186);
      this.tbEmail.Name = "tbEmail";
      this.tbEmail.Size = new System.Drawing.Size(483, 40);
      this.tbEmail.TabIndex = 8;
      // 
      // tbNumEntries
      // 
      this.tbNumEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbNumEntries.Location = new System.Drawing.Point(362, 247);
      this.tbNumEntries.Name = "tbNumEntries";
      this.tbNumEntries.Size = new System.Drawing.Size(211, 40);
      this.tbNumEntries.TabIndex = 9;
      // 
      // btnEnter
      // 
      this.btnEnter.BackColor = System.Drawing.Color.ForestGreen;
      this.btnEnter.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEnter.ForeColor = System.Drawing.SystemColors.Control;
      this.btnEnter.Location = new System.Drawing.Point(319, 405);
      this.btnEnter.Name = "btnEnter";
      this.btnEnter.Size = new System.Drawing.Size(315, 69);
      this.btnEnter.TabIndex = 10;
      this.btnEnter.Text = "Enter";
      this.btnEnter.UseVisualStyleBackColor = false;
      this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
      // 
      // btnLock
      // 
      this.btnLock.Location = new System.Drawing.Point(741, 9);
      this.btnLock.Name = "btnLock";
      this.btnLock.Size = new System.Drawing.Size(23, 32);
      this.btnLock.TabIndex = 11;
      this.btnLock.Text = "🔒";
      this.btnLock.UseVisualStyleBackColor = true;
      this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
      // 
      // tcRaffle
      // 
      this.tcRaffle.Controls.Add(this.tpEnter);
      this.tcRaffle.Controls.Add(this.tpView);
      this.tcRaffle.Controls.Add(this.tpPick);
      this.tcRaffle.Controls.Add(this.tpManage);
      this.tcRaffle.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tcRaffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tcRaffle.Location = new System.Drawing.Point(0, 0);
      this.tcRaffle.Name = "tcRaffle";
      this.tcRaffle.SelectedIndex = 0;
      this.tcRaffle.Size = new System.Drawing.Size(970, 593);
      this.tcRaffle.TabIndex = 12;
      this.tcRaffle.SelectedIndexChanged += new System.EventHandler(this.tcRaffle_SelectedIndexChanged);
      // 
      // tpEnter
      // 
      this.tpEnter.Controls.Add(this.lblEmailError);
      this.tpEnter.Controls.Add(this.cbEnterContests);
      this.tpEnter.Controls.Add(this.gbEntrant);
      this.tpEnter.Controls.Add(this.label1);
      this.tpEnter.Controls.Add(this.btnLock);
      this.tpEnter.Controls.Add(this.btnEnter);
      this.tpEnter.Location = new System.Drawing.Point(4, 33);
      this.tpEnter.Name = "tpEnter";
      this.tpEnter.Padding = new System.Windows.Forms.Padding(3);
      this.tpEnter.Size = new System.Drawing.Size(962, 556);
      this.tpEnter.TabIndex = 0;
      this.tpEnter.Text = "Enter";
      this.tpEnter.UseVisualStyleBackColor = true;
      // 
      // lblEmailError
      // 
      this.lblEmailError.AutoSize = true;
      this.lblEmailError.Location = new System.Drawing.Point(350, 477);
      this.lblEmailError.Name = "lblEmailError";
      this.lblEmailError.Size = new System.Drawing.Size(15, 24);
      this.lblEmailError.TabIndex = 14;
      this.lblEmailError.Text = " ";
      // 
      // cbEnterContests
      // 
      this.cbEnterContests.FormattingEnabled = true;
      this.cbEnterContests.Location = new System.Drawing.Point(371, 9);
      this.cbEnterContests.Name = "cbEnterContests";
      this.cbEnterContests.Size = new System.Drawing.Size(364, 32);
      this.cbEnterContests.TabIndex = 13;
      // 
      // gbEntrant
      // 
      this.gbEntrant.Controls.Add(this.tbName);
      this.gbEntrant.Controls.Add(this.tbPhone);
      this.gbEntrant.Controls.Add(this.label5);
      this.gbEntrant.Controls.Add(this.tbEmail);
      this.gbEntrant.Controls.Add(this.label2);
      this.gbEntrant.Controls.Add(this.label4);
      this.gbEntrant.Controls.Add(this.tbNumEntries);
      this.gbEntrant.Controls.Add(this.label3);
      this.gbEntrant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbEntrant.Location = new System.Drawing.Point(23, 41);
      this.gbEntrant.Name = "gbEntrant";
      this.gbEntrant.Size = new System.Drawing.Size(918, 335);
      this.gbEntrant.TabIndex = 12;
      this.gbEntrant.TabStop = false;
      this.gbEntrant.Text = "Entrant Details";
      // 
      // tpView
      // 
      this.tpView.Controls.Add(this.dgvEntries);
      this.tpView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tpView.Location = new System.Drawing.Point(4, 22);
      this.tpView.Name = "tpView";
      this.tpView.Padding = new System.Windows.Forms.Padding(3);
      this.tpView.Size = new System.Drawing.Size(962, 567);
      this.tpView.TabIndex = 1;
      this.tpView.Text = "View";
      this.tpView.UseVisualStyleBackColor = true;
      // 
      // dgvEntries
      // 
      this.dgvEntries.AllowUserToAddRows = false;
      this.dgvEntries.AllowUserToDeleteRows = false;
      this.dgvEntries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dgvEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvEntries.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvEntries.Location = new System.Drawing.Point(3, 3);
      this.dgvEntries.Name = "dgvEntries";
      this.dgvEntries.ReadOnly = true;
      this.dgvEntries.Size = new System.Drawing.Size(956, 561);
      this.dgvEntries.TabIndex = 0;
      // 
      // tpPick
      // 
      this.tpPick.Controls.Add(this.gbWinner);
      this.tpPick.Controls.Add(this.cbPickContests);
      this.tpPick.Controls.Add(this.lblPickContest);
      this.tpPick.Controls.Add(this.btnPickWinner);
      this.tpPick.Location = new System.Drawing.Point(4, 33);
      this.tpPick.Name = "tpPick";
      this.tpPick.Size = new System.Drawing.Size(962, 556);
      this.tpPick.TabIndex = 2;
      this.tpPick.Text = "Pick";
      this.tpPick.UseVisualStyleBackColor = true;
      // 
      // gbWinner
      // 
      this.gbWinner.Controls.Add(this.lblWinnerIntro);
      this.gbWinner.Controls.Add(this.lblWinnerName);
      this.gbWinner.Controls.Add(this.lblWinnerPhone);
      this.gbWinner.Controls.Add(this.lblWinnerEmail);
      this.gbWinner.Location = new System.Drawing.Point(46, 75);
      this.gbWinner.Name = "gbWinner";
      this.gbWinner.Size = new System.Drawing.Size(873, 339);
      this.gbWinner.TabIndex = 7;
      this.gbWinner.TabStop = false;
      // 
      // lblWinnerIntro
      // 
      this.lblWinnerIntro.AutoSize = true;
      this.lblWinnerIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblWinnerIntro.Location = new System.Drawing.Point(28, 28);
      this.lblWinnerIntro.Name = "lblWinnerIntro";
      this.lblWinnerIntro.Size = new System.Drawing.Size(189, 25);
      this.lblWinnerIntro.TabIndex = 2;
      this.lblWinnerIntro.Text = "And the winner is..";
      // 
      // lblWinnerName
      // 
      this.lblWinnerName.AutoSize = true;
      this.lblWinnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblWinnerName.Location = new System.Drawing.Point(344, 78);
      this.lblWinnerName.Name = "lblWinnerName";
      this.lblWinnerName.Size = new System.Drawing.Size(0, 25);
      this.lblWinnerName.TabIndex = 1;
      // 
      // lblWinnerPhone
      // 
      this.lblWinnerPhone.AutoSize = true;
      this.lblWinnerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblWinnerPhone.Location = new System.Drawing.Point(344, 109);
      this.lblWinnerPhone.Name = "lblWinnerPhone";
      this.lblWinnerPhone.Size = new System.Drawing.Size(0, 25);
      this.lblWinnerPhone.TabIndex = 3;
      // 
      // lblWinnerEmail
      // 
      this.lblWinnerEmail.AutoSize = true;
      this.lblWinnerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblWinnerEmail.Location = new System.Drawing.Point(344, 137);
      this.lblWinnerEmail.Name = "lblWinnerEmail";
      this.lblWinnerEmail.Size = new System.Drawing.Size(0, 25);
      this.lblWinnerEmail.TabIndex = 4;
      // 
      // cbPickContests
      // 
      this.cbPickContests.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbPickContests.FormattingEnabled = true;
      this.cbPickContests.Location = new System.Drawing.Point(198, 33);
      this.cbPickContests.Name = "cbPickContests";
      this.cbPickContests.Size = new System.Drawing.Size(192, 32);
      this.cbPickContests.TabIndex = 6;
      // 
      // lblPickContest
      // 
      this.lblPickContest.AutoSize = true;
      this.lblPickContest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPickContest.Location = new System.Drawing.Point(23, 28);
      this.lblPickContest.Name = "lblPickContest";
      this.lblPickContest.Size = new System.Drawing.Size(160, 25);
      this.lblPickContest.TabIndex = 5;
      this.lblPickContest.Text = "Which contest?";
      // 
      // btnPickWinner
      // 
      this.btnPickWinner.BackColor = System.Drawing.Color.ForestGreen;
      this.btnPickWinner.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPickWinner.ForeColor = System.Drawing.SystemColors.Control;
      this.btnPickWinner.Location = new System.Drawing.Point(409, 32);
      this.btnPickWinner.Name = "btnPickWinner";
      this.btnPickWinner.Size = new System.Drawing.Size(212, 33);
      this.btnPickWinner.TabIndex = 0;
      this.btnPickWinner.Text = "Pick a Winner!";
      this.btnPickWinner.UseVisualStyleBackColor = false;
      this.btnPickWinner.Click += new System.EventHandler(this.btnPickWinner_Click);
      // 
      // tpManage
      // 
      this.tpManage.Controls.Add(this.cbEmail);
      this.tpManage.Controls.Add(this.lblDelete);
      this.tpManage.Controls.Add(this.btnDeleteDB);
      this.tpManage.Location = new System.Drawing.Point(4, 33);
      this.tpManage.Name = "tpManage";
      this.tpManage.Size = new System.Drawing.Size(962, 556);
      this.tpManage.TabIndex = 3;
      this.tpManage.Text = "Manage";
      this.tpManage.UseVisualStyleBackColor = true;
      // 
      // cbEmail
      // 
      this.cbEmail.AutoSize = true;
      this.cbEmail.Checked = true;
      this.cbEmail.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbEmail.Location = new System.Drawing.Point(11, 24);
      this.cbEmail.Name = "cbEmail";
      this.cbEmail.Size = new System.Drawing.Size(295, 29);
      this.cbEmail.TabIndex = 2;
      this.cbEmail.Text = "Email Customers On Entry?";
      this.cbEmail.UseVisualStyleBackColor = true;
      // 
      // lblDelete
      // 
      this.lblDelete.AutoSize = true;
      this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDelete.Location = new System.Drawing.Point(6, 79);
      this.lblDelete.Name = "lblDelete";
      this.lblDelete.Size = new System.Drawing.Size(431, 25);
      this.lblDelete.TabIndex = 1;
      this.lblDelete.Text = "Make sure you are sure you want to do this:";
      // 
      // btnDeleteDB
      // 
      this.btnDeleteDB.Location = new System.Drawing.Point(9, 116);
      this.btnDeleteDB.Name = "btnDeleteDB";
      this.btnDeleteDB.Size = new System.Drawing.Size(178, 41);
      this.btnDeleteDB.TabIndex = 0;
      this.btnDeleteDB.Text = "Delete Database?";
      this.btnDeleteDB.UseVisualStyleBackColor = true;
      this.btnDeleteDB.Click += new System.EventHandler(this.btnDeleteDB_Click);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(970, 593);
      this.Controls.Add(this.tcRaffle);
      this.Name = "FrmMain";
      this.Text = "EZRaffle Version 1.0";
      this.tcRaffle.ResumeLayout(false);
      this.tpEnter.ResumeLayout(false);
      this.tpEnter.PerformLayout();
      this.gbEntrant.ResumeLayout(false);
      this.gbEntrant.PerformLayout();
      this.tpView.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvEntries)).EndInit();
      this.tpPick.ResumeLayout(false);
      this.tpPick.PerformLayout();
      this.gbWinner.ResumeLayout(false);
      this.gbWinner.PerformLayout();
      this.tpManage.ResumeLayout(false);
      this.tpManage.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox tbName;
    private System.Windows.Forms.TextBox tbPhone;
    private System.Windows.Forms.TextBox tbEmail;
    private System.Windows.Forms.TextBox tbNumEntries;
    private System.Windows.Forms.Button btnEnter;
    private System.Windows.Forms.Button btnLock;
    private System.Windows.Forms.TabControl tcRaffle;
    private System.Windows.Forms.TabPage tpEnter;
    private System.Windows.Forms.TabPage tpView;
    private System.Windows.Forms.TabPage tpPick;
    private System.Windows.Forms.DataGridView dgvEntries;
    private System.Windows.Forms.Label lblWinnerEmail;
    private System.Windows.Forms.Label lblWinnerPhone;
    private System.Windows.Forms.Label lblWinnerIntro;
    private System.Windows.Forms.Label lblWinnerName;
    private System.Windows.Forms.Button btnPickWinner;
    private System.Windows.Forms.Label lblPickContest;
    private System.Windows.Forms.ComboBox cbPickContests;
    private System.Windows.Forms.GroupBox gbWinner;
    private System.Windows.Forms.GroupBox gbEntrant;
    private System.Windows.Forms.ComboBox cbEnterContests;
    private System.Windows.Forms.TabPage tpManage;
    private System.Windows.Forms.Label lblDelete;
    private System.Windows.Forms.Button btnDeleteDB;
    private System.Windows.Forms.Label lblEmailError;
    private System.Windows.Forms.CheckBox cbEmail;
  }
}

