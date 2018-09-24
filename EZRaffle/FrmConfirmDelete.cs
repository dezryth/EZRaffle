using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZRaffle
{
  public partial class FrmConfirmDelete : Form
  {
    public static FrmConfirmDelete openForm = null;

    public static FrmConfirmDelete GetInstance()
    {
      if (openForm == null)
      {
        openForm = new FrmConfirmDelete();
        openForm.FormClosed += delegate { openForm = null; };
      }

      return openForm;
    }

    public bool ConfirmSuccess;

    public FrmConfirmDelete()
    {
      InitializeComponent();
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
      ConfirmSuccess = ValidateInput(tbInput.Text);
      DialogResult = DialogResult.OK;
      openForm = null;
      Close();
    }

    private bool ValidateInput(string tbInputText)
    {
      return tbInputText == "DELETE";
    }
  }
}