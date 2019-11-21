// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.Core.frmBackup
// Assembly: JobCard, Version=1.0.0.2, Culture=neutral, PublicKeyToken=null
// MVID: 355A629F-A2FA-4599-879B-59162A296DD0
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCard.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Reytec.Data.Connection;
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
    public class frmBackup : Form
    {
        private IContainer components;
        [AccessedThroughProperty("TabControl1")]
        private TabControl _TabControl1;
        [AccessedThroughProperty("TabPage1")]
        private TabPage _TabPage1;
        [AccessedThroughProperty("TabPage2")]
        private TabPage _TabPage2;
        [AccessedThroughProperty("txtTo")]
        private TextBox _txtTo;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("btnBackup")]
        private SoftButton _btnBackup;
        [AccessedThroughProperty("btnBrowse1")]
        private SoftButton _btnBrowse1;
        [AccessedThroughProperty("btnClose")]
        private SoftButton _btnClose;
        [AccessedThroughProperty("btnRestore")]
        private SoftButton _btnRestore;
        [AccessedThroughProperty("btnBrowse2")]
        private SoftButton _btnBrowse2;
        [AccessedThroughProperty("txtFrom")]
        private TextBox _txtFrom;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("dlg")]
        private SaveFileDialog _dlg;
        [AccessedThroughProperty("frmPath")]
        private OpenFileDialog _frmPath;

        [DebuggerNonUserCode]
        public frmBackup()
        {
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
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.btnBackup = new SoftButton();
            this.btnBrowse1 = new SoftButton();
            this.txtTo = new TextBox();
            this.Label1 = new Label();
            this.TabPage2 = new TabPage();
            this.btnRestore = new SoftButton();
            this.btnBrowse2 = new SoftButton();
            this.txtFrom = new TextBox();
            this.Label2 = new Label();
            this.btnClose = new SoftButton();
            this.dlg = new SaveFileDialog();
            this.frmPath = new OpenFileDialog();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.SuspendLayout();
            this.TabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.TabControl1.Controls.Add((Control)this.TabPage1);
            this.TabControl1.Controls.Add((Control)this.TabPage2);
            TabControl tabControl1_1 = this.TabControl1;
            Point point1 = new Point(12, 12);
            Point point2 = point1;
            tabControl1_1.Location = point2;
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            TabControl tabControl1_2 = this.TabControl1;
            Size size1 = new Size(551, 270);
            Size size2 = size1;
            tabControl1_2.Size = size2;
            this.TabControl1.TabIndex = 0;
            this.TabPage1.Controls.Add((Control)this.btnBackup);
            this.TabPage1.Controls.Add((Control)this.btnBrowse1);
            this.TabPage1.Controls.Add((Control)this.txtTo);
            this.TabPage1.Controls.Add((Control)this.Label1);
            TabPage tabPage1_1 = this.TabPage1;
            point1 = new Point(4, 22);
            Point point3 = point1;
            tabPage1_1.Location = point3;
            this.TabPage1.Name = "TabPage1";
            TabPage tabPage1_2 = this.TabPage1;
            Padding padding1 = new Padding(3);
            Padding padding2 = padding1;
            tabPage1_2.Padding = padding2;
            TabPage tabPage1_3 = this.TabPage1;
            size1 = new Size(543, 244);
            Size size3 = size1;
            tabPage1_3.Size = size3;
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Backup Data";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.btnBackup.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnBackup.BackColor = Color.Transparent;
            this.btnBackup.BaseColor = SystemColors.ButtonFace;
            this.btnBackup.ButtonColor = SystemColors.ButtonShadow;
            this.btnBackup.ButtonText = "Backup Now!";
            this.btnBackup.CornerRadius = 3;
            this.btnBackup.Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnBackup.ForeColor = SystemColors.ControlText;
            this.btnBackup.Glow2Color = Color.White;
            this.btnBackup.GlowColor = SystemColors.Info;
            this.btnBackup.HighlightColor = SystemColors.ControlLightLight;
            //this.btnBackup.Image = (Image) Reytec.JobCard.Core.My.Resources.Resources._3_5_Disk_Drive;
            SoftButton btnBackup1 = this.btnBackup;
            size1 = new Size(48, 48);
            Size size4 = size1;
            btnBackup1.ImageSize = size4;
            SoftButton btnBackup2 = this.btnBackup;
            point1 = new Point(173, 109);
            Point point4 = point1;
            btnBackup2.Location = point4;
            this.btnBackup.Name = "btnBackup";
            SoftButton btnBackup3 = this.btnBackup;
            size1 = new Size(172, 63);
            Size size5 = size1;
            btnBackup3.Size = size5;
            this.btnBackup.TabIndex = 16;
            this.btnBackup.TextAlign = ContentAlignment.MiddleRight;
            this.btnBrowse1.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnBrowse1.BackColor = Color.Transparent;
            this.btnBrowse1.BaseColor = SystemColors.ButtonFace;
            this.btnBrowse1.ButtonColor = SystemColors.ButtonShadow;
            this.btnBrowse1.ButtonText = "Browse...";
            this.btnBrowse1.CornerRadius = 3;
            this.btnBrowse1.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnBrowse1.ForeColor = SystemColors.ControlText;
            this.btnBrowse1.Glow2Color = Color.White;
            this.btnBrowse1.GlowColor = SystemColors.Info;
            this.btnBrowse1.HighlightColor = SystemColors.ControlLightLight;
            SoftButton btnBrowse1_1 = this.btnBrowse1;
            size1 = new Size(16, 16);
            Size size6 = size1;
            btnBrowse1_1.ImageSize = size6;
            SoftButton btnBrowse1_2 = this.btnBrowse1;
            point1 = new Point(448, 32);
            Point point5 = point1;
            btnBrowse1_2.Location = point5;
            this.btnBrowse1.Name = "btnBrowse1";
            SoftButton btnBrowse1_3 = this.btnBrowse1;
            size1 = new Size(89, 27);
            Size size7 = size1;
            btnBrowse1_3.Size = size7;
            this.btnBrowse1.TabIndex = 15;
            TextBox txtTo1 = this.txtTo;
            point1 = new Point(6, 32);
            Point point6 = point1;
            txtTo1.Location = point6;
            this.txtTo.Name = "txtTo";
            TextBox txtTo2 = this.txtTo;
            size1 = new Size(433, 21);
            Size size8 = size1;
            txtTo2.Size = size8;
            this.txtTo.TabIndex = 1;
            this.Label1.AutoSize = true;
            Label label1_1 = this.Label1;
            point1 = new Point(3, 16);
            Point point7 = point1;
            label1_1.Location = point7;
            this.Label1.Name = "Label1";
            Label label1_2 = this.Label1;
            size1 = new Size(139, 13);
            Size size9 = size1;
            label1_2.Size = size9;
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Backup data to destination:";
            this.TabPage2.Controls.Add((Control)this.btnRestore);
            this.TabPage2.Controls.Add((Control)this.btnBrowse2);
            this.TabPage2.Controls.Add((Control)this.txtFrom);
            this.TabPage2.Controls.Add((Control)this.Label2);
            TabPage tabPage2_1 = this.TabPage2;
            point1 = new Point(4, 22);
            Point point8 = point1;
            tabPage2_1.Location = point8;
            this.TabPage2.Name = "TabPage2";
            TabPage tabPage2_2 = this.TabPage2;
            padding1 = new Padding(3);
            Padding padding3 = padding1;
            tabPage2_2.Padding = padding3;
            TabPage tabPage2_3 = this.TabPage2;
            size1 = new Size(543, 244);
            Size size10 = size1;
            tabPage2_3.Size = size10;
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Restore Data";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.btnRestore.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnRestore.BackColor = Color.Transparent;
            this.btnRestore.BaseColor = SystemColors.ButtonFace;
            this.btnRestore.ButtonColor = SystemColors.ButtonShadow;
            this.btnRestore.ButtonText = "Restore Now!";
            this.btnRestore.CornerRadius = 3;
            this.btnRestore.Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnRestore.ForeColor = SystemColors.ControlText;
            this.btnRestore.Glow2Color = Color.White;
            this.btnRestore.GlowColor = SystemColors.Info;
            this.btnRestore.HighlightColor = SystemColors.ControlLightLight;
            //this.btnRestore.Image = (Image) Reytec.JobCard.Core.My.Resources.Resources.emd;
            SoftButton btnRestore1 = this.btnRestore;
            size1 = new Size(48, 48);
            Size size11 = size1;
            btnRestore1.ImageSize = size11;
            SoftButton btnRestore2 = this.btnRestore;
            point1 = new Point(170, 108);
            Point point9 = point1;
            btnRestore2.Location = point9;
            this.btnRestore.Name = "btnRestore";
            SoftButton btnRestore3 = this.btnRestore;
            size1 = new Size(172, 63);
            Size size12 = size1;
            btnRestore3.Size = size12;
            this.btnRestore.TabIndex = 20;
            this.btnRestore.TextAlign = ContentAlignment.MiddleRight;
            this.btnBrowse2.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnBrowse2.BackColor = Color.Transparent;
            this.btnBrowse2.BaseColor = SystemColors.ButtonFace;
            this.btnBrowse2.ButtonColor = SystemColors.ButtonShadow;
            this.btnBrowse2.ButtonText = "Browse...";
            this.btnBrowse2.CornerRadius = 3;
            this.btnBrowse2.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnBrowse2.ForeColor = SystemColors.ControlText;
            this.btnBrowse2.Glow2Color = Color.White;
            this.btnBrowse2.GlowColor = SystemColors.Info;
            this.btnBrowse2.HighlightColor = SystemColors.ControlLightLight;
            SoftButton btnBrowse2_1 = this.btnBrowse2;
            size1 = new Size(16, 16);
            Size size13 = size1;
            btnBrowse2_1.ImageSize = size13;
            SoftButton btnBrowse2_2 = this.btnBrowse2;
            point1 = new Point(445, 31);
            Point point10 = point1;
            btnBrowse2_2.Location = point10;
            this.btnBrowse2.Name = "btnBrowse2";
            SoftButton btnBrowse2_3 = this.btnBrowse2;
            size1 = new Size(89, 27);
            Size size14 = size1;
            btnBrowse2_3.Size = size14;
            this.btnBrowse2.TabIndex = 19;
            TextBox txtFrom1 = this.txtFrom;
            point1 = new Point(6, 31);
            Point point11 = point1;
            txtFrom1.Location = point11;
            this.txtFrom.Name = "txtFrom";
            TextBox txtFrom2 = this.txtFrom;
            size1 = new Size(433, 21);
            Size size15 = size1;
            txtFrom2.Size = size15;
            this.txtFrom.TabIndex = 18;
            this.Label2.AutoSize = true;
            Label label2_1 = this.Label2;
            point1 = new Point(3, 15);
            Point point12 = point1;
            label2_1.Location = point12;
            this.Label2.Name = "Label2";
            Label label2_2 = this.Label2;
            size1 = new Size(174, 13);
            Size size16 = size1;
            label2_2.Size = size16;
            this.Label2.TabIndex = 17;
            this.Label2.Text = "Restore data from source location:";
            this.btnClose.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnClose.BackColor = Color.Transparent;
            this.btnClose.BaseColor = SystemColors.ButtonFace;
            this.btnClose.ButtonColor = SystemColors.ButtonShadow;
            this.btnClose.ButtonText = "Close";
            this.btnClose.CornerRadius = 3;
            this.btnClose.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnClose.ForeColor = SystemColors.ControlText;
            this.btnClose.Glow2Color = Color.White;
            this.btnClose.GlowColor = SystemColors.Info;
            this.btnClose.HighlightColor = SystemColors.ControlLightLight;
            SoftButton btnClose1 = this.btnClose;
            size1 = new Size(16, 16);
            Size size17 = size1;
            btnClose1.ImageSize = size17;
            SoftButton btnClose2 = this.btnClose;
            point1 = new Point(492, 288);
            Point point13 = point1;
            btnClose2.Location = point13;
            this.btnClose.Name = "btnClose";
            SoftButton btnClose3 = this.btnClose;
            size1 = new Size(67, 30);
            Size size18 = size1;
            btnClose3.Size = size18;
            this.btnClose.TabIndex = 14;
            this.frmPath.FileName = "OpenFileDialog1";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            size1 = new Size(575, 330);
            this.ClientSize = size1;
            this.ControlBox = false;
            this.Controls.Add((Control)this.btnClose);
            this.Controls.Add((Control)this.TabControl1);
            this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Name = nameof(frmBackup);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Backup & Restore";
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.ResumeLayout(false);
        }

        internal virtual TabControl TabControl1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TabControl1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._TabControl1 = value;
            }
        }

        internal virtual TabPage TabPage1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TabPage1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._TabPage1 = value;
            }
        }

        internal virtual TabPage TabPage2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TabPage2;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._TabPage2 = value;
            }
        }

        internal virtual TextBox txtTo
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtTo;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtTo = value;
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

        internal virtual SoftButton btnBackup
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnBackup;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnBackup_Click);
                if (this._btnBackup != null)
                    this._btnBackup.Click -= eventHandler;
                this._btnBackup = value;
                if (this._btnBackup == null)
                    return;
                this._btnBackup.Click += eventHandler;
            }
        }

        internal virtual SoftButton btnBrowse1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnBrowse1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnBrowse1_Click);
                if (this._btnBrowse1 != null)
                    this._btnBrowse1.Click -= eventHandler;
                this._btnBrowse1 = value;
                if (this._btnBrowse1 == null)
                    return;
                this._btnBrowse1.Click += eventHandler;
            }
        }

        internal virtual SoftButton btnClose
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnClose;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnClose_Click);
                if (this._btnClose != null)
                    this._btnClose.Click -= eventHandler;
                this._btnClose = value;
                if (this._btnClose == null)
                    return;
                this._btnClose.Click += eventHandler;
            }
        }

        internal virtual SoftButton btnRestore
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnRestore;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnRestore_Click);
                if (this._btnRestore != null)
                    this._btnRestore.Click -= eventHandler;
                this._btnRestore = value;
                if (this._btnRestore == null)
                    return;
                this._btnRestore.Click += eventHandler;
            }
        }

        internal virtual SoftButton btnBrowse2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnBrowse2;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnBrowse2_Click);
                if (this._btnBrowse2 != null)
                    this._btnBrowse2.Click -= eventHandler;
                this._btnBrowse2 = value;
                if (this._btnBrowse2 == null)
                    return;
                this._btnBrowse2.Click += eventHandler;
            }
        }

        internal virtual TextBox txtFrom
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtFrom;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtFrom = value;
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

        internal virtual SaveFileDialog dlg
        {
            [DebuggerNonUserCode]
            get
            {
                return this._dlg;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._dlg = value;
            }
        }

        internal virtual OpenFileDialog frmPath
        {
            [DebuggerNonUserCode]
            get
            {
                return this._frmPath;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._frmPath = value;
            }
        }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            this.dlg.Filter = "Backup Files|*.bak";
            this.dlg.FileName = ConnectionInfo.GetDatabaseName() + "_backup_" + Strings.Format((object)DateAndTime.Now, "ddMMMyyyy") + ".bak";
            int num = (int)this.dlg.ShowDialog();
            this.txtTo.Text = this.dlg.FileName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (Conversions.ToBoolean(General.BackUpData(new DataConnection(ConnectionInfo.GetServerName(), "master", DataConnection.ProviderType.SQL), ConnectionInfo.GetDatabaseName(), this.txtTo.Text)))
            {
                MessageBox.Show($"Database successfully backed up to:{this.txtTo.Text}", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show($"An error occured!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (Conversions.ToBoolean(General.RestoreData(new DataConnection(ConnectionInfo.GetServerName(), "master", DataConnection.ProviderType.SQL), ConnectionInfo.GetDatabaseName(), this.txtFrom.Text)))
            {
                MessageBox.Show($"Database successfully restored. You need to re-open Reytec JobCard. The program will now close.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ProjectData.EndApp();
            }
            else
            {
                MessageBox.Show($"An error occured!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            this.frmPath.Filter = "Backup Files|*.bak";
            int num = (int)this.frmPath.ShowDialog();
            this.txtFrom.Text = this.frmPath.FileName;
        }
    }
}
