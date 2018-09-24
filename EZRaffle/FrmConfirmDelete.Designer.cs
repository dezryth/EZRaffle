namespace EZRaffle
{
  partial class FrmConfirmDelete
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
      this.lblInstructions = new System.Windows.Forms.Label();
      this.tbInput = new System.Windows.Forms.TextBox();
      this.btnOk = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblInstructions
      // 
      this.lblInstructions.AutoSize = true;
      this.lblInstructions.Location = new System.Drawing.Point(13, 13);
      this.lblInstructions.Name = "lblInstructions";
      this.lblInstructions.Size = new System.Drawing.Size(349, 13);
      this.lblInstructions.TabIndex = 0;
      this.lblInstructions.Text = "In order to delete the database, please type DELETE into the box below:";
      // 
      // tbInput
      // 
      this.tbInput.Location = new System.Drawing.Point(13, 34);
      this.tbInput.Name = "tbInput";
      this.tbInput.Size = new System.Drawing.Size(245, 20);
      this.tbInput.TabIndex = 1;
      // 
      // btnOk
      // 
      this.btnOk.Location = new System.Drawing.Point(284, 34);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new System.Drawing.Size(75, 23);
      this.btnOk.TabIndex = 2;
      this.btnOk.Text = "OK";
      this.btnOk.UseVisualStyleBackColor = true;
      this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
      // 
      // FrmConfirmDelete
      // 
      this.AcceptButton = this.btnOk;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(373, 66);
      this.Controls.Add(this.btnOk);
      this.Controls.Add(this.tbInput);
      this.Controls.Add(this.lblInstructions);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmConfirmDelete";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Are you sure?";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblInstructions;
    private System.Windows.Forms.TextBox tbInput;
    private System.Windows.Forms.Button btnOk;
  }
}