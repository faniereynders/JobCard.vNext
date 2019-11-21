// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.Core.frmPassword
// Assembly: JobCard, Version=1.0.0.2, Culture=neutral, PublicKeyToken=null
// MVID: 355A629F-A2FA-4599-879B-59162A296DD0
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCard.exe

using Microsoft.VisualBasic.CompilerServices;
using Reytec.GUI.Controls;
using Reytec.JobCard.DAL;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Reytec.JobCard.Core
{
  [DesignerGenerated]
  public class frmPassword : Form
  {
    private IContainer components;
    [AccessedThroughProperty("lblDescription")]
    private Label _lblDescription;
    [AccessedThroughProperty("txtpass")]
    private TextBox _txtpass;
    [AccessedThroughProperty("btnok")]
    private SoftButton _btnok;
    [AccessedThroughProperty("VistaButton1")]
    private SoftButton _VistaButton1;
    public bool isCanceled;

    public frmPassword()
    {
      this.Shown += new EventHandler(this.frmAdmin_Shown);
      this.Load += new EventHandler(this.frmPassword_Load);
      this.isCanceled = false;
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.lblDescription = new Label();
      this.txtpass = new TextBox();
      this.btnok = new SoftButton();
      this.VistaButton1 = new SoftButton();
      this.SuspendLayout();
      this.lblDescription.AutoSize = true;
      Label lblDescription1 = this.lblDescription;
      Point point1 = new Point(12, 9);
      Point point2 = point1;
      lblDescription1.Location = point2;
      this.lblDescription.Name = "lblDescription";
      Label lblDescription2 = this.lblDescription;
      Size size1 = new Size(240, 13);
      Size size2 = size1;
      lblDescription2.Size = size2;
      this.lblDescription.TabIndex = 0;
      this.lblDescription.Text = "Please type the System Administrator password:";
      TextBox txtpass1 = this.txtpass;
      point1 = new Point(12, 34);
      Point point3 = point1;
      txtpass1.Location = point3;
      this.txtpass.Name = "txtpass";
      this.txtpass.PasswordChar = '*';
      TextBox txtpass2 = this.txtpass;
      size1 = new Size(240, 21);
      Size size3 = size1;
      txtpass2.Size = size3;
      this.txtpass.TabIndex = 1;
      this.txtpass.UseSystemPasswordChar = true;
      this.btnok.AutoValidate = AutoValidate.EnableAllowFocusChange;
      this.btnok.BackColor = Color.Transparent;
      this.btnok.BaseColor = SystemColors.ButtonFace;
      this.btnok.ButtonColor = SystemColors.ButtonShadow;
      this.btnok.ButtonText = "OK";
      this.btnok.CornerRadius = 3;
      this.btnok.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnok.ForeColor = SystemColors.ControlText;
      this.btnok.Glow2Color = Color.White;
      this.btnok.GlowColor = SystemColors.Info;
      this.btnok.HighlightColor = SystemColors.ControlLightLight;
      SoftButton btnok1 = this.btnok;
      size1 = new Size(16, 16);
      Size size4 = size1;
      btnok1.ImageSize = size4;
      SoftButton btnok2 = this.btnok;
      point1 = new Point(124, 61);
      Point point4 = point1;
      btnok2.Location = point4;
      this.btnok.Name = "btnok";
      SoftButton btnok3 = this.btnok;
      size1 = new Size(61, 30);
      Size size5 = size1;
      btnok3.Size = size5;
      this.btnok.TabIndex = 14;
      this.VistaButton1.AutoValidate = AutoValidate.EnableAllowFocusChange;
      this.VistaButton1.BackColor = Color.Transparent;
      this.VistaButton1.BaseColor = SystemColors.ButtonFace;
      this.VistaButton1.ButtonColor = SystemColors.ButtonShadow;
      this.VistaButton1.ButtonText = "Cancel";
      this.VistaButton1.CornerRadius = 3;
      this.VistaButton1.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.VistaButton1.ForeColor = SystemColors.ControlText;
      this.VistaButton1.Glow2Color = Color.White;
      this.VistaButton1.GlowColor = SystemColors.Info;
      this.VistaButton1.HighlightColor = SystemColors.ControlLightLight;
      SoftButton vistaButton1_1 = this.VistaButton1;
      size1 = new Size(16, 16);
      Size size6 = size1;
      vistaButton1_1.ImageSize = size6;
      SoftButton vistaButton1_2 = this.VistaButton1;
      point1 = new Point(191, 61);
      Point point5 = point1;
      vistaButton1_2.Location = point5;
      this.VistaButton1.Name = "VistaButton1";
      SoftButton vistaButton1_3 = this.VistaButton1;
      size1 = new Size(61, 30);
      Size size7 = size1;
      vistaButton1_3.Size = size7;
      this.VistaButton1.TabIndex = 15;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(265, 105);
      this.ClientSize = size1;
      this.ControlBox = false;
      this.Controls.Add((Control) this.VistaButton1);
      this.Controls.Add((Control) this.btnok);
      this.Controls.Add((Control) this.txtpass);
      this.Controls.Add((Control) this.lblDescription);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Name = nameof (frmPassword);
      this.SizeGripStyle = SizeGripStyle.Hide;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Administrator Password";
      this.TopMost = true;
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Label lblDescription
    {
      [DebuggerNonUserCode] get
      {
        return this._lblDescription;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblDescription = value;
      }
    }

    internal virtual TextBox txtpass
    {
      [DebuggerNonUserCode] get
      {
        return this._txtpass;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtpass_TextChanged);
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtpass_KeyDown);
        if (this._txtpass != null)
        {
          this._txtpass.TextChanged -= eventHandler;
          this._txtpass.KeyDown -= keyEventHandler;
        }
        this._txtpass = value;
        if (this._txtpass == null)
          return;
        this._txtpass.TextChanged += eventHandler;
        this._txtpass.KeyDown += keyEventHandler;
      }
    }

    internal virtual SoftButton btnok
    {
      [DebuggerNonUserCode] get
      {
        return this._btnok;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnok_Click);
        if (this._btnok != null)
          this._btnok.Click -= eventHandler;
        this._btnok = value;
        if (this._btnok == null)
          return;
        this._btnok.Click += eventHandler;
      }
    }

    internal virtual SoftButton VistaButton1
    {
      [DebuggerNonUserCode] get
      {
        return this._VistaButton1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.VistaButton1_Click);
        if (this._VistaButton1 != null)
          this._VistaButton1.Click -= eventHandler;
        this._VistaButton1 = value;
        if (this._VistaButton1 == null)
          return;
        this._VistaButton1.Click += eventHandler;
      }
    }

    public bool ValidateAdministrator(int LoggedUserID)
    {
      int num = (int) this.ShowDialog();
      return new JobCardCompany(ConnectionInfo.GlobalConnection).ValidateAdminPassword(this.txtpass.Text);
    }

    private void btnok_Click(object sender, EventArgs e)
    {
      this.isCanceled = false;
      this.Close();
    }

    private void VistaButton1_Click(object sender, EventArgs e)
    {
      this.isCanceled = true;
      this.Close();
    }

    private void frmAdmin_Shown(object sender, EventArgs e)
    {
      this.txtpass.Text = "";
      this.txtpass.Focus();
    }

    private void txtpass_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.btnok_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs) e);
    }

    private void txtpass_TextChanged(object sender, EventArgs e)
    {
    }

    private void frmPassword_Load(object sender, EventArgs e)
    {
    }
  }
}
