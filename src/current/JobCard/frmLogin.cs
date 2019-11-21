// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.Core.frmLogin
// Assembly: JobCard, Version=1.0.0.2, Culture=neutral, PublicKeyToken=null
// MVID: 355A629F-A2FA-4599-879B-59162A296DD0
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCard.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Reytec.Data.Engine;
using Reytec.GUI.Controls;
using Reytec.JobCard.Functions.GUITransformation;
using Reytec.Security.Cryptography;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Reytec.JobCard.Core
{
    [DesignerGenerated]
    public class frmLogin : Form
    {
        private IContainer components;
        [AccessedThroughProperty("PictureBox1")]
        private PictureBox _PictureBox1;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("cmbusers")]
        private ComboBox _cmbusers;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("txtpassword")]
        private TextBox _txtpassword;
        [AccessedThroughProperty("btnSign")]
        private SoftButton _btnSign;
        [AccessedThroughProperty("btnCancel")]
        private SoftButton _btnCancel;
        [AccessedThroughProperty("logo")]
        private Button _logo;
        private DataAccess sql;
        [AccessedThroughProperty("frmCompanyConnect")]
        private frmConnection _frmCompanyConnect;

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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmLogin));
            this.Label1 = new Label();
            this.Label2 = new Label();
            this.cmbusers = new ComboBox();
            this.Label3 = new Label();
            this.txtpassword = new TextBox();
            this.logo = new Button();
            this.btnCancel = new SoftButton();
            this.btnSign = new SoftButton();
            this.PictureBox1 = new PictureBox();
            ((ISupportInitialize)this.PictureBox1).BeginInit();
            this.SuspendLayout();
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label1.ForeColor = SystemColors.ControlText;
            Label label1_1 = this.Label1;
            Point point1 = new Point(98, 131);
            Point point2 = point1;
            label1_1.Location = point2;
            this.Label1.Name = "Label1";
            Label label1_2 = this.Label1;
            Size size1 = new Size(272, 13);
            Size size2 = size1;
            label1_2.Size = size2;
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Welcome! Please sign in using your credentials:";
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = SystemColors.ControlText;
            Label label2_1 = this.Label2;
            point1 = new Point(98, 165);
            Point point3 = point1;
            label2_1.Location = point3;
            this.Label2.Name = "Label2";
            Label label2_2 = this.Label2;
            size1 = new Size(33, 13);
            Size size3 = size1;
            label2_2.Size = size3;
            this.Label2.TabIndex = 2;
            this.Label2.Text = "User:";
            this.cmbusers.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbusers.FormattingEnabled = true;
            ComboBox cmbusers1 = this.cmbusers;
            point1 = new Point(195, 162);
            Point point4 = point1;
            cmbusers1.Location = point4;
            this.cmbusers.Name = "cmbusers";
            ComboBox cmbusers2 = this.cmbusers;
            size1 = new Size(299, 21);
            Size size4 = size1;
            cmbusers2.Size = size4;
            this.cmbusers.TabIndex = 3;
            this.Label3.AutoSize = true;
            this.Label3.ForeColor = SystemColors.ControlText;
            Label label3_1 = this.Label3;
            point1 = new Point(98, 192);
            Point point5 = point1;
            label3_1.Location = point5;
            this.Label3.Name = "Label3";
            Label label3_2 = this.Label3;
            size1 = new Size(57, 13);
            Size size5 = size1;
            label3_2.Size = size5;
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Password:";
            TextBox txtpassword1 = this.txtpassword;
            point1 = new Point(195, 189);
            Point point6 = point1;
            txtpassword1.Location = point6;
            this.txtpassword.Name = "txtpassword";
            TextBox txtpassword2 = this.txtpassword;
            size1 = new Size(299, 21);
            Size size6 = size1;
            txtpassword2.Size = size6;
            this.txtpassword.TabIndex = 5;
            this.txtpassword.UseSystemPasswordChar = true;
            this.logo.BackColor = Color.White;
            this.logo.BackgroundImageLayout = ImageLayout.Center;
            this.logo.Cursor = Cursors.Hand;
            this.logo.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
            this.logo.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
            this.logo.FlatAppearance.MouseOverBackColor = SystemColors.Info;
            this.logo.FlatStyle = FlatStyle.Flat;
            this.logo.ForeColor = Color.DimGray;
            this.logo.ImageAlign = ContentAlignment.TopCenter;
            Button logo1 = this.logo;
            point1 = new Point(14, 12);
            Point point7 = point1;
            logo1.Location = point7;
            this.logo.Name = "logo";
            Button logo2 = this.logo;
            size1 = new Size(480, 100);
            Size size7 = size1;
            logo2.Size = size7;
            this.logo.TabIndex = 23;
            this.logo.TabStop = false;
            this.logo.TextAlign = ContentAlignment.BottomCenter;
            this.logo.UseCompatibleTextRendering = true;
            this.logo.UseVisualStyleBackColor = true;
            this.btnCancel.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnCancel.BackColor = Color.Transparent;
            this.btnCancel.BaseColor = SystemColors.ButtonFace;
            this.btnCancel.ButtonColor = SystemColors.ButtonShadow;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.CornerRadius = 3;
            this.btnCancel.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnCancel.ForeColor = SystemColors.ControlText;
            this.btnCancel.Glow2Color = Color.White;
            this.btnCancel.GlowColor = SystemColors.Info;
            this.btnCancel.HighlightColor = SystemColors.ControlLightLight;
            this.btnCancel.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
            SoftButton btnCancel1 = this.btnCancel;
            size1 = new Size(16, 16);
            Size size8 = size1;
            btnCancel1.ImageSize = size8;
            SoftButton btnCancel2 = this.btnCancel;
            point1 = new Point(414, 251);
            Point point8 = point1;
            btnCancel2.Location = point8;
            this.btnCancel.Name = "btnCancel";
            SoftButton btnCancel3 = this.btnCancel;
            size1 = new Size(80, 34);
            Size size9 = size1;
            btnCancel3.Size = size9;
            this.btnCancel.TabIndex = 22;
            this.btnCancel.TextAlign = ContentAlignment.MiddleRight;
            this.btnSign.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnSign.BackColor = Color.Transparent;
            this.btnSign.BaseColor = SystemColors.ButtonFace;
            this.btnSign.ButtonColor = SystemColors.ButtonShadow;
            this.btnSign.ButtonText = "Sign In";
            this.btnSign.CornerRadius = 3;
            this.btnSign.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnSign.ForeColor = SystemColors.ControlText;
            this.btnSign.Glow2Color = Color.White;
            this.btnSign.GlowColor = SystemColors.Info;
            this.btnSign.HighlightColor = SystemColors.ControlLightLight;
            this.btnSign.Image = (Image)componentResourceManager.GetObject("btnSign.Image");
            SoftButton btnSign1 = this.btnSign;
            size1 = new Size(16, 16);
            Size size10 = size1;
            btnSign1.ImageSize = size10;
            SoftButton btnSign2 = this.btnSign;
            point1 = new Point(328, 251);
            Point point9 = point1;
            btnSign2.Location = point9;
            this.btnSign.Name = "btnSign";
            SoftButton btnSign3 = this.btnSign;
            size1 = new Size(80, 34);
            Size size11 = size1;
            btnSign3.Size = size11;
            this.btnSign.TabIndex = 21;
            this.btnSign.TextAlign = ContentAlignment.MiddleRight;
            //this.PictureBox1.Image = (Image) Reytec.JobCard.Core.My.Resources.Resources.SecurityLock;
            PictureBox pictureBox1_1 = this.PictureBox1;
            point1 = new Point(12, 131);
            Point point10 = point1;
            pictureBox1_1.Location = point10;
            this.PictureBox1.Name = "PictureBox1";
            PictureBox pictureBox1_2 = this.PictureBox1;
            size1 = new Size(48, 55);
            Size size12 = size1;
            pictureBox1_2.Size = size12;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.ButtonFace;
            size1 = new Size(506, 307);
            this.ClientSize = size1;
            this.ControlBox = false;
            this.Controls.Add((Control)this.logo);
            this.Controls.Add((Control)this.btnCancel);
            this.Controls.Add((Control)this.btnSign);
            this.Controls.Add((Control)this.txtpassword);
            this.Controls.Add((Control)this.Label3);
            this.Controls.Add((Control)this.cmbusers);
            this.Controls.Add((Control)this.Label2);
            this.Controls.Add((Control)this.Label1);
            this.Controls.Add((Control)this.PictureBox1);
            this.Cursor = Cursors.Default;
            this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.ForeColor = SystemColors.ControlText;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Name = nameof(frmLogin);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = nameof(frmLogin);
            ((ISupportInitialize)this.PictureBox1).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        internal virtual PictureBox PictureBox1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._PictureBox1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._PictureBox1 = value;
            }
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

        internal virtual ComboBox cmbusers
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cmbusers;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.cmbusers_SelectedIndexChanged);
                if (this._cmbusers != null)
                    this._cmbusers.SelectedIndexChanged -= eventHandler;
                this._cmbusers = value;
                if (this._cmbusers == null)
                    return;
                this._cmbusers.SelectedIndexChanged += eventHandler;
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
                this._txtpassword = value;
            }
        }

        internal virtual SoftButton btnSign
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnSign;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnSign_Click);
                if (this._btnSign != null)
                    this._btnSign.Click -= eventHandler;
                this._btnSign = value;
                if (this._btnSign == null)
                    return;
                this._btnSign.Click += eventHandler;
            }
        }

        internal virtual SoftButton btnCancel
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnCancel;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
                if (this._btnCancel != null)
                    this._btnCancel.Click -= eventHandler;
                this._btnCancel = value;
                if (this._btnCancel == null)
                    return;
                this._btnCancel.Click += eventHandler;
            }
        }

        internal virtual Button logo
        {
            [DebuggerNonUserCode]
            get
            {
                return this._logo;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._logo = value;
            }
        }

        public virtual frmConnection frmCompanyConnect
        {
            [DebuggerNonUserCode]
            get
            {
                return this._frmCompanyConnect;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._frmCompanyConnect = value;
            }
        }

        public event frmLogin.LoginSuccessfullEventHandler LoginSuccessfull;

        public void DoSignIn()
        {
            DataTable table = this.sql.GetDataset(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object)"SELECT  systemuserpassword FROM SystemUser WHERE deleted=0 and systemuserid=", this.cmbusers.SelectedValue))).Tables[0];
            if (table.Rows.Count <= 0)
                return;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtpassword.Text, StringCrypography.DecryptString(Conversions.ToString(table.Rows[0]["SystemUserPassword"])), false) == 0)
            {
                JobFunctions.LoggedUser = this.cmbusers.Text + " signed in";
                JobFunctions.LoggedUserID = Conversions.ToInteger(this.cmbusers.SelectedValue);
                frmLogin.LoginSuccessfullEventHandler successfullEvent = this.LoginSuccessfull;
                if (successfullEvent != null)
                    successfullEvent();
                this.Close();
            }
            else
            {
                MessageBox.Show($"Unable to sign you in. Incorrect password.", "Authentication failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.txtpassword.Text = "";
            }
        }

        public void LoadLogo()
        {
            DataTable dataTable = new DataTable();
            DataTable table = this.sql.GetDataset("SELECT TOP(1) * FROM CompanyInfo WHERE CompanyID=1").Tables[0];
            if (table.Rows.Count > 0)
            {
                DataAccess sql = this.sql;
                string str = "JPEG";
                ref string local1 = ref str;
                byte[] buffer = null;
                ref byte[] local2 = ref buffer;
                if (sql.ReadImageFromDB("select * from CompanyInfo where CompanyID= 1", "CompanyLogo", ref local1, ref local2))
                {
                    using (MemoryStream memoryStream = new MemoryStream(buffer, 0, buffer.Length))
                    {
                        memoryStream.Write(buffer, 0, buffer.Length);
                        this.logo.BackgroundImage = Image.FromStream((Stream)memoryStream, true);
                    }
                }
            }
            table.Dispose();
            dataTable = (DataTable)null;
        }

        public bool LoadUsers()
        {
            DataTable dataTable = new DataTable();
            this.cmbusers.Items.Clear();
            DataTable table = this.sql.GetDataset("SELECT SystemUserID,SystemUserName + ' ' + SystemUserSurname as usr,systemuserpassword  FROM SystemUser WHERE  deleted=0 ").Tables[0];
            this.cmbusers.DataSource = (object)table;
            this.cmbusers.DisplayMember = "usr";
            this.cmbusers.ValueMember = "SystemUserID";
            if (table.Rows.Count != 1 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(StringCrypography.DecryptString(Conversions.ToString(table.Rows[0]["SystemUserPassword"])), "", false) != 0)
                return true;
            this.cmbusers.SelectedValue = RuntimeHelpers.GetObjectValue(table.Rows[0]["SystemUserID"]);
            this.txtpassword.Text = StringCrypography.DecryptString(Conversions.ToString(table.Rows[0]["SystemUserPassword"]));
            return false;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.LoadLogo();
            if (this.LoadUsers())
                return;
            this.DoSignIn();
        }

        private void temp_Click(object sender, EventArgs e)
        {
        }

        public frmLogin()
        {
            this.Load += new EventHandler(this.frmLogin_Load);
            this.InitializeComponent();
            this.sql = new DataAccess(ConnectionInfo.GlobalConnection);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            this.DoSignIn();
        }

        private void cmbusers_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public delegate void LoginSuccessfullEventHandler();
    }
}
