// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.Core.frmUserDetail
// Assembly: JobCard, Version=1.0.0.2, Culture=neutral, PublicKeyToken=null
// MVID: 355A629F-A2FA-4599-879B-59162A296DD0
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCard.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Reytec.Data.Engine;
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
    public class frmUserDetail : Form
    {
        private IContainer components;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("txtFirstname")]
        private TextBox _txtFirstname;
        [AccessedThroughProperty("txtlastname")]
        private TextBox _txtlastname;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("txtpassword")]
        private TextBox _txtpassword;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("cmbtype")]
        private ComboBox _cmbtype;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("txtconfirm")]
        private TextBox _txtconfirm;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("pnlConfirm")]
        private Panel _pnlConfirm;
        [AccessedThroughProperty("btnOK")]
        private SoftButton _btnOK;
        [AccessedThroughProperty("VistaButton1")]
        private SoftButton _VistaButton1;
        private DataAccess sql;
        private int _UserID;
        private bool isAdmin;
        private Collection blankFields;
        private SystemUser dboUser;

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
            this.Label1 = new Label();
            this.txtFirstname = new TextBox();
            this.txtlastname = new TextBox();
            this.Label2 = new Label();
            this.txtpassword = new TextBox();
            this.Label3 = new Label();
            this.cmbtype = new ComboBox();
            this.Label4 = new Label();
            this.txtconfirm = new TextBox();
            this.Label5 = new Label();
            this.pnlConfirm = new Panel();
            this.btnOK = new SoftButton();
            this.VistaButton1 = new SoftButton();
            this.pnlConfirm.SuspendLayout();
            this.SuspendLayout();
            this.Label1.AutoSize = true;
            Label label1_1 = this.Label1;
            Point point1 = new Point(12, 9);
            Point point2 = point1;
            label1_1.Location = point2;
            this.Label1.Name = "Label1";
            Label label1_2 = this.Label1;
            Size size1 = new Size(61, 13);
            Size size2 = size1;
            label1_2.Size = size2;
            this.Label1.TabIndex = 0;
            this.Label1.Text = "First name:";
            TextBox txtFirstname1 = this.txtFirstname;
            point1 = new Point(119, 6);
            Point point3 = point1;
            txtFirstname1.Location = point3;
            this.txtFirstname.Name = "txtFirstname";
            TextBox txtFirstname2 = this.txtFirstname;
            size1 = new Size(199, 21);
            Size size3 = size1;
            txtFirstname2.Size = size3;
            this.txtFirstname.TabIndex = 1;
            TextBox txtlastname1 = this.txtlastname;
            point1 = new Point(119, 33);
            Point point4 = point1;
            txtlastname1.Location = point4;
            this.txtlastname.Name = "txtlastname";
            TextBox txtlastname2 = this.txtlastname;
            size1 = new Size(199, 21);
            Size size4 = size1;
            txtlastname2.Size = size4;
            this.txtlastname.TabIndex = 2;
            this.Label2.AutoSize = true;
            Label label2_1 = this.Label2;
            point1 = new Point(12, 36);
            Point point5 = point1;
            label2_1.Location = point5;
            this.Label2.Name = "Label2";
            Label label2_2 = this.Label2;
            size1 = new Size(60, 13);
            Size size5 = size1;
            label2_2.Size = size5;
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Last name:";
            TextBox txtpassword1 = this.txtpassword;
            point1 = new Point(119, 87);
            Point point6 = point1;
            txtpassword1.Location = point6;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            TextBox txtpassword2 = this.txtpassword;
            size1 = new Size(199, 21);
            Size size6 = size1;
            txtpassword2.Size = size6;
            this.txtpassword.TabIndex = 4;
            this.txtpassword.UseSystemPasswordChar = true;
            this.Label3.AutoSize = true;
            Label label3_1 = this.Label3;
            point1 = new Point(12, 90);
            Point point7 = point1;
            label3_1.Location = point7;
            this.Label3.Name = "Label3";
            Label label3_2 = this.Label3;
            size1 = new Size(57, 13);
            Size size7 = size1;
            label3_2.Size = size7;
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Password:";
            this.cmbtype.DisplayMember = "1";
            this.cmbtype.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Items.AddRange(new object[2]
            {
        (object) "Administrator",
        (object) "User"
            });
            ComboBox cmbtype1 = this.cmbtype;
            point1 = new Point(119, 60);
            Point point8 = point1;
            cmbtype1.Location = point8;
            this.cmbtype.Name = "cmbtype";
            ComboBox cmbtype2 = this.cmbtype;
            size1 = new Size(199, 21);
            Size size8 = size1;
            cmbtype2.Size = size8;
            this.cmbtype.TabIndex = 3;
            this.cmbtype.ValueMember = "1";
            this.Label4.AutoSize = true;
            Label label4_1 = this.Label4;
            point1 = new Point(12, 63);
            Point point9 = point1;
            label4_1.Location = point9;
            this.Label4.Name = "Label4";
            Label label4_2 = this.Label4;
            size1 = new Size(35, 13);
            Size size9 = size1;
            label4_2.Size = size9;
            this.Label4.TabIndex = 7;
            this.Label4.Text = "Type:";
            TextBox txtconfirm1 = this.txtconfirm;
            point1 = new Point(104, 0);
            Point point10 = point1;
            txtconfirm1.Location = point10;
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.PasswordChar = '*';
            TextBox txtconfirm2 = this.txtconfirm;
            size1 = new Size(199, 21);
            Size size10 = size1;
            txtconfirm2.Size = size10;
            this.txtconfirm.TabIndex = 6;
            this.txtconfirm.UseSystemPasswordChar = true;
            this.Label5.AutoSize = true;
            Label label5_1 = this.Label5;
            point1 = new Point(-3, 3);
            Point point11 = point1;
            label5_1.Location = point11;
            this.Label5.Name = "Label5";
            Label label5_2 = this.Label5;
            size1 = new Size(97, 13);
            Size size11 = size1;
            label5_2.Size = size11;
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Confirm password:";
            this.pnlConfirm.Controls.Add((Control)this.Label5);
            this.pnlConfirm.Controls.Add((Control)this.txtconfirm);
            Panel pnlConfirm1 = this.pnlConfirm;
            point1 = new Point(15, 114);
            Point point12 = point1;
            pnlConfirm1.Location = point12;
            this.pnlConfirm.Name = "pnlConfirm";
            Panel pnlConfirm2 = this.pnlConfirm;
            size1 = new Size(305, 22);
            Size size12 = size1;
            pnlConfirm2.Size = size12;
            this.pnlConfirm.TabIndex = 10;
            this.pnlConfirm.Visible = false;
            this.btnOK.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnOK.BackColor = Color.Transparent;
            this.btnOK.BaseColor = SystemColors.ButtonFace;
            this.btnOK.ButtonColor = SystemColors.ButtonShadow;
            this.btnOK.ButtonText = "OK";
            this.btnOK.CornerRadius = 3;
            this.btnOK.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnOK.ForeColor = SystemColors.ControlText;
            this.btnOK.Glow2Color = Color.White;
            this.btnOK.GlowColor = SystemColors.Info;
            this.btnOK.HighlightColor = SystemColors.ControlLightLight;
            SoftButton btnOk1 = this.btnOK;
            size1 = new Size(16, 16);
            Size size13 = size1;
            btnOk1.ImageSize = size13;
            SoftButton btnOk2 = this.btnOK;
            point1 = new Point(190, 142);
            Point point13 = point1;
            btnOk2.Location = point13;
            this.btnOK.Name = "btnOK";
            SoftButton btnOk3 = this.btnOK;
            size1 = new Size(61, 30);
            Size size14 = size1;
            btnOk3.Size = size14;
            this.btnOK.TabIndex = 14;
            this.VistaButton1.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.VistaButton1.BackColor = Color.Transparent;
            this.VistaButton1.BaseColor = SystemColors.ButtonFace;
            this.VistaButton1.ButtonColor = SystemColors.ButtonShadow;
            this.VistaButton1.ButtonText = "Cancel";
            this.VistaButton1.CornerRadius = 3;
            this.VistaButton1.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.VistaButton1.ForeColor = SystemColors.ControlText;
            this.VistaButton1.Glow2Color = Color.White;
            this.VistaButton1.GlowColor = SystemColors.Info;
            this.VistaButton1.HighlightColor = SystemColors.ControlLightLight;
            SoftButton vistaButton1_1 = this.VistaButton1;
            size1 = new Size(16, 16);
            Size size15 = size1;
            vistaButton1_1.ImageSize = size15;
            SoftButton vistaButton1_2 = this.VistaButton1;
            point1 = new Point(257, 142);
            Point point14 = point1;
            vistaButton1_2.Location = point14;
            this.VistaButton1.Name = "VistaButton1";
            SoftButton vistaButton1_3 = this.VistaButton1;
            size1 = new Size(61, 30);
            Size size16 = size1;
            vistaButton1_3.Size = size16;
            this.VistaButton1.TabIndex = 15;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            size1 = new Size(325, 182);
            this.ClientSize = size1;
            this.Controls.Add((Control)this.VistaButton1);
            this.Controls.Add((Control)this.btnOK);
            this.Controls.Add((Control)this.pnlConfirm);
            this.Controls.Add((Control)this.Label4);
            this.Controls.Add((Control)this.cmbtype);
            this.Controls.Add((Control)this.txtpassword);
            this.Controls.Add((Control)this.Label3);
            this.Controls.Add((Control)this.txtlastname);
            this.Controls.Add((Control)this.Label2);
            this.Controls.Add((Control)this.txtFirstname);
            this.Controls.Add((Control)this.Label1);
            this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = nameof(frmUserDetail);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Edit User";
            this.pnlConfirm.ResumeLayout(false);
            this.pnlConfirm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        internal virtual Label Label1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label1 = value;
            }
        }

        internal virtual TextBox txtFirstname
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtFirstname;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtFirstname = value;
            }
        }

        internal virtual TextBox txtlastname
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtlastname;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtlastname = value;
            }
        }

        internal virtual Label Label2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label2;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label2 = value;
            }
        }

        internal virtual TextBox txtpassword
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtpassword;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.txtpassword_TextChanged);
                if (this._txtpassword != null)
                    this._txtpassword.TextChanged -= eventHandler;
                this._txtpassword = value;
                if (this._txtpassword == null)
                    return;
                this._txtpassword.TextChanged += eventHandler;
            }
        }

        internal virtual Label Label3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label3;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label3 = value;
            }
        }

        internal virtual ComboBox cmbtype
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cmbtype;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cmbtype = value;
            }
        }

        internal virtual Label Label4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label4;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label4 = value;
            }
        }

        internal virtual TextBox txtconfirm
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtconfirm;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtconfirm = value;
            }
        }

        internal virtual Label Label5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label5;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label5 = value;
            }
        }

        internal virtual Panel pnlConfirm
        {
            [DebuggerNonUserCode]
            get
            {
                return this._pnlConfirm;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pnlConfirm = value;
            }
        }

        internal virtual SoftButton btnOK
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnOK;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnOK_Click);
                if (this._btnOK != null)
                    this._btnOK.Click -= eventHandler;
                this._btnOK = value;
                if (this._btnOK == null)
                    return;
                this._btnOK.Click += eventHandler;
            }
        }

        internal virtual SoftButton VistaButton1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._VistaButton1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
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

        public event frmUserDetail.UserChangedEventHandler UserChanged;

        public void GetUserDetail()
        {
            SystemUser dboUser = this.dboUser;
            dboUser.GetOne((object)this._UserID);
            if (Conversions.ToBoolean(dboUser.isAdmin))
            {
                if (this._UserID == 1)
                    this.cmbtype.Enabled = false;
                else
                    this.cmbtype.Enabled = true;
                this.cmbtype.SelectedIndex = 0;
            }
            else
                this.cmbtype.SelectedIndex = 1;
            this.txtFirstname.Text = Conversions.ToString(dboUser.UserName);
            this.txtlastname.Text = Conversions.ToString(dboUser.UserSurname);
            this.txtpassword.Text = Conversions.ToString(dboUser.UserPassword);
            this.pnlConfirm.Visible = false;
            this.txtconfirm.Text = Conversions.ToString(dboUser.UserPassword);
        }

        public frmUserDetail(int UserID = -1)
        {
            this.Load += new EventHandler(this.frmUserDetail_Load);
            this._UserID = -1;
            this.blankFields = new Collection();
            this.dboUser = new SystemUser(ConnectionInfo.GlobalConnection);
            this.InitializeComponent();
            if (UserID != -1)
            {
                this._UserID = UserID;
                this.sql = new DataAccess(ConnectionInfo.GlobalConnection);
                this.GetUserDetail();
                this.Text = "Edit User";
            }
            else
            {
                this.cmbtype.SelectedIndex = 1;
                this.Text = "New User";
            }
        }

        public bool SaveUser()
        {
            SystemUser dboUser = this.dboUser;
            if (this._UserID == -1 & dboUser.AlreadyExists(this.txtFirstname.Text, this.txtlastname.Text))
            {
                MessageBox.Show("User already exists! Please choose a different Name and Surname combination.", "User Already Exsts", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Operators.CompareString(this.txtconfirm.Text, this.txtpassword.Text, false) != 0)
            {
                MessageBox.Show("The password you typed does not match the confimation password. Please re-type.", "Passwords don't match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            dboUser.UserName = (object)this.txtFirstname.Text;
            dboUser.UserSurname = (object)this.txtlastname.Text;
            dboUser.UserPassword = (object)this.txtpassword.Text;
            dboUser.isAdmin = this.cmbtype.SelectedIndex != 0 ? (object)0 : (object)1;
            if (this._UserID != -1)
                return dboUser.Update((object)this._UserID);
            return dboUser.Add();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!this.SaveUser())
                return;
            frmUserDetail.UserChangedEventHandler userChangedEvent = this.UserChanged;
            if (userChangedEvent != null)
                userChangedEvent();
            this.Close();
        }

        private void frmUserDetail_Load(object sender, EventArgs e)
        {
        }

        private void VistaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            this.txtconfirm.Text = "";
            this.pnlConfirm.Visible = true;
        }

        public delegate void UserChangedEventHandler();
    }
}
