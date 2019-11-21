// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.Core.frmJobDetail
// Assembly: JobCard, Version=1.0.0.2, Culture=neutral, PublicKeyToken=null
// MVID: 355A629F-A2FA-4599-879B-59162A296DD0
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCard.exe

using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Reytec.GUI.Controls;
using Reytec.GUI.Controls.DataLookupWindow;
using Reytec.JobCard.DAL;
using Reytec.JobCard.Functions.GUITransformation;
using Reytec.JobCard.Reports;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Reytec.JobCard.Core
{
    [DesignerGenerated]
    public class frmJobDetail : Form
    {
        private IContainer components;
        [AccessedThroughProperty("Label1")]
        private System.Windows.Forms.Label _Label1;
        [AccessedThroughProperty("txtdate")]
        private DateTimePicker _txtdate;
        [AccessedThroughProperty("Label2")]
        private System.Windows.Forms.Label _Label2;
        [AccessedThroughProperty("txtteam")]
        private System.Windows.Forms.TextBox _txtteam;
        [AccessedThroughProperty("custcode")]
        private System.Windows.Forms.Label _custcode;
        [AccessedThroughProperty("GroupBox1")]
        private GroupBox _GroupBox1;
        [AccessedThroughProperty("btnAddCustomer")]
        private SoftButton _btnAddCustomer;
        [AccessedThroughProperty("txtCustomerAccount")]
        private System.Windows.Forms.TextBox _txtCustomerAccount;
        [AccessedThroughProperty("Label4")]
        private System.Windows.Forms.Label _Label4;
        [AccessedThroughProperty("Tip")]
        private ToolTip _Tip;
        [AccessedThroughProperty("txtCustomerName")]
        private System.Windows.Forms.Label _txtCustomerName;
        [AccessedThroughProperty("btnEditCustomer")]
        private SoftButton _btnEditCustomer;
        [AccessedThroughProperty("btnLookupCustomer")]
        private SoftButton _btnLookupCustomer;
        [AccessedThroughProperty("lblCustomerType")]
        private System.Windows.Forms.Label _lblCustomerType;
        [AccessedThroughProperty("grdCustImg")]
        private ImageList _grdCustImg;
        [AccessedThroughProperty("nocust")]
        private System.Windows.Forms.Label _nocust;
        [AccessedThroughProperty("TabControl1")]
        private TabControl _TabControl1;
        [AccessedThroughProperty("TabPage1")]
        private TabPage _TabPage1;
        [AccessedThroughProperty("TabPage2")]
        private TabPage _TabPage2;
        [AccessedThroughProperty("TabPage3")]
        private TabPage _TabPage3;
        [AccessedThroughProperty("TabPage4")]
        private TabPage _TabPage4;
        [AccessedThroughProperty("txtJobAddress")]
        private System.Windows.Forms.TextBox _txtJobAddress;
        [AccessedThroughProperty("Label3")]
        private System.Windows.Forms.Label _Label3;
        [AccessedThroughProperty("grpIsTenant")]
        private GroupBox _grpIsTenant;
        [AccessedThroughProperty("txtTenantCell")]
        private System.Windows.Forms.TextBox _txtTenantCell;
        [AccessedThroughProperty("Label9")]
        private System.Windows.Forms.Label _Label9;
        [AccessedThroughProperty("txtTenantTel2")]
        private System.Windows.Forms.TextBox _txtTenantTel2;
        [AccessedThroughProperty("Label8")]
        private System.Windows.Forms.Label _Label8;
        [AccessedThroughProperty("txtTenantTel1")]
        private System.Windows.Forms.TextBox _txtTenantTel1;
        [AccessedThroughProperty("Label7")]
        private System.Windows.Forms.Label _Label7;
        [AccessedThroughProperty("txtTenantName")]
        private System.Windows.Forms.TextBox _txtTenantName;
        [AccessedThroughProperty("txtTenantID")]
        private System.Windows.Forms.TextBox _txtTenantID;
        [AccessedThroughProperty("Label5")]
        private System.Windows.Forms.Label _Label5;
        [AccessedThroughProperty("Label6")]
        private System.Windows.Forms.Label _Label6;
        [AccessedThroughProperty("chkRented")]
        private System.Windows.Forms.CheckBox _chkRented;
        [AccessedThroughProperty("txtInvoiceNr")]
        private System.Windows.Forms.TextBox _txtInvoiceNr;
        [AccessedThroughProperty("Label11")]
        private System.Windows.Forms.Label _Label11;
        [AccessedThroughProperty("txtQuote")]
        private System.Windows.Forms.TextBox _txtQuote;
        [AccessedThroughProperty("Label10")]
        private System.Windows.Forms.Label _Label10;
        [AccessedThroughProperty("cmbPayment")]
        private ComboBox _cmbPayment;
        [AccessedThroughProperty("Label12")]
        private System.Windows.Forms.Label _Label12;
        [AccessedThroughProperty("grdProblem")]
        private DataGridView _grdProblem;
        [AccessedThroughProperty("TabPage5")]
        private TabPage _TabPage5;
        [AccessedThroughProperty("grdTimesheet")]
        private DataGridView _grdTimesheet;
        [AccessedThroughProperty("grdKM")]
        private DataGridView _grdKM;
        [AccessedThroughProperty("txtNotes")]
        private System.Windows.Forms.TextBox _txtNotes;
        [AccessedThroughProperty("btnCancel")]
        private SoftButton _btnCancel;
        [AccessedThroughProperty("btnSave")]
        private SoftButton _btnSave;
        [AccessedThroughProperty("TableLayoutPanel1")]
        private TableLayoutPanel _TableLayoutPanel1;
        [AccessedThroughProperty("Panel2")]
        private Panel _Panel2;
        [AccessedThroughProperty("Panel3")]
        private Panel _Panel3;
        [AccessedThroughProperty("TableLayoutPanel2")]
        private TableLayoutPanel _TableLayoutPanel2;
        [AccessedThroughProperty("Panel4")]
        private Panel _Panel4;
        [AccessedThroughProperty("Panel5")]
        private Panel _Panel5;
        [AccessedThroughProperty("TableLayoutPanel3")]
        private TableLayoutPanel _TableLayoutPanel3;
        [AccessedThroughProperty("Panel6")]
        private Panel _Panel6;
        [AccessedThroughProperty("TableLayoutPanel4")]
        private TableLayoutPanel _TableLayoutPanel4;
        [AccessedThroughProperty("Panel7")]
        private Panel _Panel7;
        [AccessedThroughProperty("Panel8")]
        private Panel _Panel8;
        [AccessedThroughProperty("chkComplete")]
        private System.Windows.Forms.CheckBox _chkComplete;
        [AccessedThroughProperty("DataGridViewTextBoxColumn1")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;
        [AccessedThroughProperty("DataGridViewTextBoxColumn5")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn5;
        [AccessedThroughProperty("DataGridViewTextBoxColumn6")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn6;
        [AccessedThroughProperty("DataGridViewTextBoxColumn7")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn7;
        [AccessedThroughProperty("DataGridViewTextBoxColumn8")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn8;
        [AccessedThroughProperty("DataGridViewTextBoxColumn2")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;
        [AccessedThroughProperty("Column4")]
        private DataGridViewTextBoxColumn _Column4;
        [AccessedThroughProperty("Column5")]
        private DataGridViewTextBoxColumn _Column5;
        [AccessedThroughProperty("Column1")]
        private DataGridViewTextBoxColumn _Column1;
        [AccessedThroughProperty("Column2")]
        private DataGridViewTextBoxColumn _Column2;
        [AccessedThroughProperty("DataGridViewTextBoxColumn3")]
        private CalendarColumn _DataGridViewTextBoxColumn3;
        [AccessedThroughProperty("DataGridViewTextBoxColumn4")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;
        [AccessedThroughProperty("Column6")]
        private DataGridViewTextBoxColumn _Column6;
        [AccessedThroughProperty("Column3")]
        private DataGridViewTextBoxColumn _Column3;
        [AccessedThroughProperty("btnPrint")]
        private SoftButton _btnPrint;
        [AccessedThroughProperty("tmr")]
        private Timer _tmr;
        [AccessedThroughProperty("Label14")]
        private System.Windows.Forms.Label _Label14;
        [AccessedThroughProperty("lblcompulsoryacc")]
        private System.Windows.Forms.Label _lblcompulsoryacc;
        [AccessedThroughProperty("lblcompulsoryinvoice")]
        private System.Windows.Forms.Label _lblcompulsoryinvoice;
        [AccessedThroughProperty("Label16")]
        private System.Windows.Forms.Label _Label16;
        [AccessedThroughProperty("Label19")]
        private System.Windows.Forms.Label _Label19;
        [AccessedThroughProperty("Label18")]
        private System.Windows.Forms.Label _Label18;
        [AccessedThroughProperty("Label17")]
        private System.Windows.Forms.Label _Label17;
        [AccessedThroughProperty("Label25")]
        private System.Windows.Forms.Label _Label25;
        [AccessedThroughProperty("Label13")]
        private System.Windows.Forms.Label _Label13;
        private LookupButton lookup;
        private object _isCustomerCompany;
        private Reytec.JobCard.DAL.JobCard dboJob;
        private int _JobID;
        private Customer c;
        private bool saved;

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
            this.components = (IContainer)new System.ComponentModel.Container();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmJobDetail));
            DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle10 = new DataGridViewCellStyle();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtdate = new DateTimePicker();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtteam = new System.Windows.Forms.TextBox();
            this.custcode = new System.Windows.Forms.Label();
            this.GroupBox1 = new GroupBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Panel6 = new Panel();
            this.lblcompulsoryacc = new System.Windows.Forms.Label();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtCustomerAccount = new System.Windows.Forms.TextBox();
            this.nocust = new System.Windows.Forms.Label();
            this.btnLookupCustomer = new SoftButton();
            this.btnEditCustomer = new SoftButton();
            this.txtCustomerName = new System.Windows.Forms.Label();
            this.btnAddCustomer = new SoftButton();
            this.Tip = new ToolTip(this.components);
            this.grdCustImg = new ImageList(this.components);
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.TableLayoutPanel2 = new TableLayoutPanel();
            this.Panel4 = new Panel();
            this.lblcompulsoryinvoice = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.cmbPayment = new ComboBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtQuote = new System.Windows.Forms.TextBox();
            this.txtInvoiceNr = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtJobAddress = new System.Windows.Forms.TextBox();
            this.Panel5 = new Panel();
            this.TableLayoutPanel3 = new TableLayoutPanel();
            this.chkRented = new System.Windows.Forms.CheckBox();
            this.grpIsTenant = new GroupBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.txtTenantCell = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtTenantTel2 = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtTenantTel1 = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtTenantName = new System.Windows.Forms.TextBox();
            this.txtTenantID = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.TabPage2 = new TabPage();
            this.grdProblem = new DataGridView();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.Column2 = new DataGridViewTextBoxColumn();
            this.TabPage3 = new TabPage();
            this.grdTimesheet = new DataGridView();
            this.DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            this.Column4 = new DataGridViewTextBoxColumn();
            this.Column5 = new DataGridViewTextBoxColumn();
            this.TabPage4 = new TabPage();
            this.grdKM = new DataGridView();
            this.DataGridViewTextBoxColumn3 = new CalendarColumn();
            this.DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            this.Column6 = new DataGridViewTextBoxColumn();
            this.Column3 = new DataGridViewTextBoxColumn();
            this.TabPage5 = new TabPage();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnCancel = new SoftButton();
            this.btnSave = new SoftButton();
            this.TableLayoutPanel1 = new TableLayoutPanel();
            this.TableLayoutPanel4 = new TableLayoutPanel();
            this.Panel7 = new Panel();
            this.Label25 = new System.Windows.Forms.Label();
            this.Panel8 = new Panel();
            this.Label13 = new System.Windows.Forms.Label();
            this.Panel2 = new Panel();
            this.chkComplete = new System.Windows.Forms.CheckBox();
            this.Panel3 = new Panel();
            this.btnPrint = new SoftButton();
            this.DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            this.tmr = new Timer(this.components);
            this.GroupBox1.SuspendLayout();
            this.Panel6.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TableLayoutPanel2.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.TableLayoutPanel3.SuspendLayout();
            this.grpIsTenant.SuspendLayout();
            this.TabPage2.SuspendLayout();
            ((ISupportInitialize)this.grdProblem).BeginInit();
            this.TabPage3.SuspendLayout();
            ((ISupportInitialize)this.grdTimesheet).BeginInit();
            this.TabPage4.SuspendLayout();
            ((ISupportInitialize)this.grdKM).BeginInit();
            this.TabPage5.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.TableLayoutPanel4.SuspendLayout();
            this.Panel7.SuspendLayout();
            this.Panel8.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            this.Label1.AutoSize = true;
            System.Windows.Forms.Label label1_1 = this.Label1;
            Point point1 = new Point(4, 4);
            Point point2 = point1;
            label1_1.Location = point2;
            this.Label1.Name = "Label1";
            System.Windows.Forms.Label label1_2 = this.Label1;
            Size size1 = new Size(34, 13);
            Size size2 = size1;
            label1_2.Size = size2;
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Date:";
            DateTimePicker txtdate1 = this.txtdate;
            point1 = new Point(65, 0);
            Point point3 = point1;
            txtdate1.Location = point3;
            this.txtdate.Name = "txtdate";
            DateTimePicker txtdate2 = this.txtdate;
            size1 = new Size(131, 21);
            Size size3 = size1;
            txtdate2.Size = size3;
            this.txtdate.TabIndex = 1;
            this.Label2.AutoSize = true;
            System.Windows.Forms.Label label2_1 = this.Label2;
            point1 = new Point(230, 4);
            Point point4 = point1;
            label2_1.Location = point4;
            this.Label2.Name = "Label2";
            System.Windows.Forms.Label label2_2 = this.Label2;
            size1 = new Size(83, 13);
            Size size4 = size1;
            label2_2.Size = size4;
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Team allocated:";
            this.txtteam.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            System.Windows.Forms.TextBox txtteam1 = this.txtteam;
            point1 = new Point(3, 1);
            Point point5 = point1;
            txtteam1.Location = point5;
            this.txtteam.Name = "txtteam";
            System.Windows.Forms.TextBox txtteam2 = this.txtteam;
            size1 = new Size(317, 21);
            Size size5 = size1;
            txtteam2.Size = size5;
            this.txtteam.TabIndex = 3;
            this.custcode.AutoSize = true;
            System.Windows.Forms.Label custcode1 = this.custcode;
            point1 = new Point(294, 20);
            Point point6 = point1;
            custcode1.Location = point6;
            this.custcode.Name = "custcode";
            System.Windows.Forms.Label custcode2 = this.custcode;
            size1 = new Size(17, 13);
            Size size6 = size1;
            custcode2.Size = size6;
            this.custcode.TabIndex = 4;
            this.custcode.Text = "-1";
            this.custcode.Visible = false;
            this.GroupBox1.Controls.Add((Control)this.Label14);
            this.GroupBox1.Controls.Add((Control)this.Panel6);
            this.GroupBox1.Controls.Add((Control)this.nocust);
            this.GroupBox1.Controls.Add((Control)this.btnLookupCustomer);
            this.GroupBox1.Controls.Add((Control)this.custcode);
            this.GroupBox1.Controls.Add((Control)this.btnEditCustomer);
            this.GroupBox1.Controls.Add((Control)this.txtCustomerName);
            this.GroupBox1.Controls.Add((Control)this.btnAddCustomer);
            this.GroupBox1.Dock = DockStyle.Fill;
            GroupBox groupBox1_1 = this.GroupBox1;
            point1 = new Point(6, 44);
            Point point7 = point1;
            groupBox1_1.Location = point7;
            this.GroupBox1.Name = "GroupBox1";
            GroupBox groupBox1_2 = this.GroupBox1;
            size1 = new Size(664, 46);
            Size size7 = size1;
            groupBox1_2.Size = size7;
            this.GroupBox1.TabIndex = 6;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Customer information";
            this.Label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.Label14.AutoSize = true;
            this.Label14.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label14.ForeColor = Color.Red;
            System.Windows.Forms.Label label14_1 = this.Label14;
            point1 = new Point(317, 17);
            Point point8 = point1;
            label14_1.Location = point8;
            this.Label14.Name = "Label14";
            System.Windows.Forms.Label label14_2 = this.Label14;
            size1 = new Size(16, 16);
            Size size8 = size1;
            label14_2.Size = size8;
            this.Label14.TabIndex = 63;
            this.Label14.Text = "*";
            this.Panel6.Controls.Add((Control)this.lblcompulsoryacc);
            this.Panel6.Controls.Add((Control)this.lblCustomerType);
            this.Panel6.Controls.Add((Control)this.Label4);
            this.Panel6.Controls.Add((Control)this.txtCustomerAccount);
            this.Panel6.Dock = DockStyle.Right;
            Panel panel6_1 = this.Panel6;
            point1 = new Point(363, 17);
            Point point9 = point1;
            panel6_1.Location = point9;
            this.Panel6.Name = "Panel6";
            Panel panel6_2 = this.Panel6;
            size1 = new Size(298, 26);
            Size size9 = size1;
            panel6_2.Size = size9;
            this.Panel6.TabIndex = 13;
            this.lblcompulsoryacc.AutoSize = true;
            this.lblcompulsoryacc.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.lblcompulsoryacc.ForeColor = Color.Red;
            System.Windows.Forms.Label lblcompulsoryacc1 = this.lblcompulsoryacc;
            point1 = new Point(283, 0);
            Point point10 = point1;
            lblcompulsoryacc1.Location = point10;
            this.lblcompulsoryacc.Name = "lblcompulsoryacc";
            System.Windows.Forms.Label lblcompulsoryacc2 = this.lblcompulsoryacc;
            size1 = new Size(16, 16);
            Size size10 = size1;
            lblcompulsoryacc2.Size = size10;
            this.lblcompulsoryacc.TabIndex = 63;
            this.lblcompulsoryacc.Text = "*";
            this.lblcompulsoryacc.Visible = false;
            this.lblCustomerType.ImageAlign = ContentAlignment.MiddleLeft;
            System.Windows.Forms.Label lblCustomerType1 = this.lblCustomerType;
            point1 = new Point(1, 0);
            Point point11 = point1;
            lblCustomerType1.Location = point11;
            this.lblCustomerType.Name = "lblCustomerType";
            System.Windows.Forms.Label lblCustomerType2 = this.lblCustomerType;
            size1 = new Size(94, 22);
            Size size11 = size1;
            lblCustomerType2.Size = size11;
            this.lblCustomerType.TabIndex = 12;
            this.lblCustomerType.TextAlign = ContentAlignment.MiddleCenter;
            this.Label4.AutoSize = true;
            System.Windows.Forms.Label label4_1 = this.Label4;
            point1 = new Point(101, 5);
            Point point12 = point1;
            label4_1.Location = point12;
            this.Label4.Name = "Label4";
            System.Windows.Forms.Label label4_2 = this.Label4;
            size1 = new Size(89, 13);
            Size size12 = size1;
            label4_2.Size = size12;
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Account number:";
            System.Windows.Forms.TextBox txtCustomerAccount1 = this.txtCustomerAccount;
            point1 = new Point(196, 0);
            Point point13 = point1;
            txtCustomerAccount1.Location = point13;
            this.txtCustomerAccount.Name = "txtCustomerAccount";
            System.Windows.Forms.TextBox txtCustomerAccount2 = this.txtCustomerAccount;
            size1 = new Size(86, 21);
            Size size13 = size1;
            txtCustomerAccount2.Size = size13;
            this.txtCustomerAccount.TabIndex = 7;
            this.nocust.AutoSize = true;
            this.nocust.Font = new Font("Segoe UI", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte)0);
            System.Windows.Forms.Label nocust1 = this.nocust;
            point1 = new Point(70, 19);
            Point point14 = point1;
            nocust1.Location = point14;
            this.nocust.Name = "nocust";
            System.Windows.Forms.Label nocust2 = this.nocust;
            size1 = new Size(120, 15);
            Size size14 = size1;
            nocust2.Size = size14;
            this.nocust.TabIndex = 6;
            this.nocust.Text = "No Customer selected";
            this.btnLookupCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnLookupCustomer.BackColor = Color.Transparent;
            this.btnLookupCustomer.BaseColor = SystemColors.ButtonFace;
            this.btnLookupCustomer.ButtonColor = SystemColors.ButtonShadow;
            this.btnLookupCustomer.ButtonStyle = SoftButton.Style.Flat;
            this.btnLookupCustomer.ButtonText = (string)null;
            this.btnLookupCustomer.CornerRadius = 3;
            this.btnLookupCustomer.Glow2Color = Color.White;
            this.btnLookupCustomer.GlowColor = SystemColors.Info;
            this.btnLookupCustomer.HighlightColor = SystemColors.ControlLightLight;
            //this.btnLookupCustomer.Image = (System.Drawing.Image)Reytec.JobCard.Core.My.Resources.Resources.ZoomHS;
            this.btnLookupCustomer.ImageAlign = ContentAlignment.MiddleCenter;
            SoftButton btnLookupCustomer1 = this.btnLookupCustomer;
            size1 = new Size(16, 16);
            Size size15 = size1;
            btnLookupCustomer1.ImageSize = size15;
            SoftButton btnLookupCustomer2 = this.btnLookupCustomer;
            point1 = new Point(336, 17);
            Point point15 = point1;
            btnLookupCustomer2.Location = point15;
            SoftButton btnLookupCustomer3 = this.btnLookupCustomer;
            System.Windows.Forms.Padding padding1 = new System.Windows.Forms.Padding(0);
            System.Windows.Forms.Padding padding2 = padding1;
            btnLookupCustomer3.Margin = padding2;
            this.btnLookupCustomer.Name = "btnLookupCustomer";
            SoftButton btnLookupCustomer4 = this.btnLookupCustomer;
            size1 = new Size(24, 21);
            Size size16 = size1;
            btnLookupCustomer4.Size = size16;
            this.btnLookupCustomer.TabIndex = 11;
            this.btnLookupCustomer.TabStop = false;
            this.Tip.SetToolTip((Control)this.btnLookupCustomer, "Lookup Customer");
            this.btnEditCustomer.BackColor = Color.Transparent;
            this.btnEditCustomer.BaseColor = SystemColors.ButtonFace;
            this.btnEditCustomer.ButtonColor = SystemColors.ButtonShadow;
            this.btnEditCustomer.ButtonStyle = SoftButton.Style.Flat;
            this.btnEditCustomer.ButtonText = (string)null;
            this.btnEditCustomer.CornerRadius = 3;
            this.btnEditCustomer.Enabled = false;
            this.btnEditCustomer.Glow2Color = Color.White;
            this.btnEditCustomer.GlowColor = SystemColors.Info;
            this.btnEditCustomer.HighlightColor = SystemColors.ControlLightLight;
            //this.btnEditCustomer.Image = (System.Drawing.Image)Reytec.JobCard.Core.My.Resources.Resources.EditTableHS;
            this.btnEditCustomer.ImageAlign = ContentAlignment.MiddleCenter;
            SoftButton btnEditCustomer1 = this.btnEditCustomer;
            size1 = new Size(16, 16);
            Size size17 = size1;
            btnEditCustomer1.ImageSize = size17;
            SoftButton btnEditCustomer2 = this.btnEditCustomer;
            point1 = new Point(34, 18);
            Point point16 = point1;
            btnEditCustomer2.Location = point16;
            SoftButton btnEditCustomer3 = this.btnEditCustomer;
            padding1 = new System.Windows.Forms.Padding(0);
            System.Windows.Forms.Padding padding3 = padding1;
            btnEditCustomer3.Margin = padding3;
            this.btnEditCustomer.Name = "btnEditCustomer";
            SoftButton btnEditCustomer4 = this.btnEditCustomer;
            size1 = new Size(24, 21);
            Size size18 = size1;
            btnEditCustomer4.Size = size18;
            this.btnEditCustomer.TabIndex = 10;
            this.Tip.SetToolTip((Control)this.btnEditCustomer, "Edit the selected customer's details");
            this.txtCustomerName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.txtCustomerName.BorderStyle = BorderStyle.Fixed3D;
            this.txtCustomerName.ImageAlign = ContentAlignment.MiddleLeft;
            System.Windows.Forms.Label txtCustomerName1 = this.txtCustomerName;
            point1 = new Point(61, 17);
            Point point17 = point1;
            txtCustomerName1.Location = point17;
            this.txtCustomerName.Name = "txtCustomerName";
            System.Windows.Forms.Label txtCustomerName2 = this.txtCustomerName;
            size1 = new Size((int)byte.MaxValue, 21);
            Size size19 = size1;
            txtCustomerName2.Size = size19;
            this.txtCustomerName.TabIndex = 9;
            this.txtCustomerName.TextAlign = ContentAlignment.MiddleLeft;
            this.btnAddCustomer.BackColor = Color.Transparent;
            this.btnAddCustomer.BaseColor = SystemColors.ButtonFace;
            this.btnAddCustomer.ButtonColor = SystemColors.ButtonShadow;
            this.btnAddCustomer.ButtonStyle = SoftButton.Style.Flat;
            this.btnAddCustomer.ButtonText = (string)null;
            this.btnAddCustomer.CornerRadius = 3;
            this.btnAddCustomer.Glow2Color = Color.White;
            this.btnAddCustomer.GlowColor = SystemColors.Info;
            this.btnAddCustomer.HighlightColor = SystemColors.ControlLightLight;
           // this.btnAddCustomer.Image = (System.Drawing.Image)Reytec.JobCard.Core.My.Resources.Resources.NewDocumentHS;
            this.btnAddCustomer.ImageAlign = ContentAlignment.MiddleCenter;
            SoftButton btnAddCustomer1 = this.btnAddCustomer;
            size1 = new Size(16, 16);
            Size size20 = size1;
            btnAddCustomer1.ImageSize = size20;
            SoftButton btnAddCustomer2 = this.btnAddCustomer;
            point1 = new Point(10, 18);
            Point point18 = point1;
            btnAddCustomer2.Location = point18;
            SoftButton btnAddCustomer3 = this.btnAddCustomer;
            padding1 = new System.Windows.Forms.Padding(0);
            System.Windows.Forms.Padding padding4 = padding1;
            btnAddCustomer3.Margin = padding4;
            this.btnAddCustomer.Name = "btnAddCustomer";
            SoftButton btnAddCustomer4 = this.btnAddCustomer;
            size1 = new Size(24, 21);
            Size size21 = size1;
            btnAddCustomer4.Size = size21;
            this.btnAddCustomer.TabIndex = 6;
            this.Tip.SetToolTip((Control)this.btnAddCustomer, "Add new customer");
            this.grdCustImg.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("grdCustImg.ImageStream");
            this.grdCustImg.TransparentColor = Color.Transparent;
            this.grdCustImg.Images.SetKeyName(0, "users.ico");
            this.grdCustImg.Images.SetKeyName(1, "user.ico");
            this.TabControl1.Controls.Add((Control)this.TabPage1);
            this.TabControl1.Controls.Add((Control)this.TabPage2);
            this.TabControl1.Controls.Add((Control)this.TabPage3);
            this.TabControl1.Controls.Add((Control)this.TabPage4);
            this.TabControl1.Controls.Add((Control)this.TabPage5);
            this.TabControl1.Dock = DockStyle.Fill;
            TabControl tabControl1_1 = this.TabControl1;
            point1 = new Point(6, 96);
            Point point19 = point1;
            tabControl1_1.Location = point19;
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            TabControl tabControl1_2 = this.TabControl1;
            size1 = new Size(664, 271);
            Size size22 = size1;
            tabControl1_2.Size = size22;
            this.TabControl1.TabIndex = 7;
            this.TabPage1.Controls.Add((Control)this.TableLayoutPanel2);
            TabPage tabPage1_1 = this.TabPage1;
            point1 = new Point(4, 22);
            Point point20 = point1;
            tabPage1_1.Location = point20;
            this.TabPage1.Name = "TabPage1";
            TabPage tabPage1_2 = this.TabPage1;
            padding1 = new System.Windows.Forms.Padding(3);
            System.Windows.Forms.Padding padding5 = padding1;
            tabPage1_2.Padding = padding5;
            TabPage tabPage1_3 = this.TabPage1;
            size1 = new Size(656, 245);
            Size size23 = size1;
            tabPage1_3.Size = size23;
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "General";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.TableLayoutPanel2.ColumnCount = 2;
            this.TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            this.TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            this.TableLayoutPanel2.Controls.Add((Control)this.Panel4, 0, 0);
            this.TableLayoutPanel2.Controls.Add((Control)this.Panel5, 1, 0);
            this.TableLayoutPanel2.Dock = DockStyle.Fill;
            TableLayoutPanel tableLayoutPanel2_1 = this.TableLayoutPanel2;
            point1 = new Point(3, 3);
            Point point21 = point1;
            tableLayoutPanel2_1.Location = point21;
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 1;
            this.TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
            TableLayoutPanel tableLayoutPanel2_2 = this.TableLayoutPanel2;
            size1 = new Size(650, 239);
            Size size24 = size1;
            tableLayoutPanel2_2.Size = size24;
            this.TableLayoutPanel2.TabIndex = 16;
            this.Panel4.Controls.Add((Control)this.lblcompulsoryinvoice);
            this.Panel4.Controls.Add((Control)this.Label16);
            this.Panel4.Controls.Add((Control)this.Label3);
            this.Panel4.Controls.Add((Control)this.cmbPayment);
            this.Panel4.Controls.Add((Control)this.Label10);
            this.Panel4.Controls.Add((Control)this.Label12);
            this.Panel4.Controls.Add((Control)this.txtQuote);
            this.Panel4.Controls.Add((Control)this.txtInvoiceNr);
            this.Panel4.Controls.Add((Control)this.Label11);
            this.Panel4.Controls.Add((Control)this.txtJobAddress);
            this.Panel4.Dock = DockStyle.Fill;
            Panel panel4_1 = this.Panel4;
            point1 = new Point(3, 3);
            Point point22 = point1;
            panel4_1.Location = point22;
            this.Panel4.Name = "Panel4";
            Panel panel4_2 = this.Panel4;
            size1 = new Size(319, 233);
            Size size25 = size1;
            panel4_2.Size = size25;
            this.Panel4.TabIndex = 0;
            this.lblcompulsoryinvoice.AutoSize = true;
            this.lblcompulsoryinvoice.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.lblcompulsoryinvoice.ForeColor = Color.Red;
            System.Windows.Forms.Label lblcompulsoryinvoice1 = this.lblcompulsoryinvoice;
            point1 = new Point(194, 146);
            Point point23 = point1;
            lblcompulsoryinvoice1.Location = point23;
            this.lblcompulsoryinvoice.Name = "lblcompulsoryinvoice";
            System.Windows.Forms.Label lblcompulsoryinvoice2 = this.lblcompulsoryinvoice;
            size1 = new Size(16, 16);
            Size size26 = size1;
            lblcompulsoryinvoice2.Size = size26;
            this.lblcompulsoryinvoice.TabIndex = 64;
            this.lblcompulsoryinvoice.Text = "*";
            this.lblcompulsoryinvoice.Visible = false;
            this.Label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.Label16.AutoSize = true;
            this.Label16.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label16.ForeColor = Color.Red;
            System.Windows.Forms.Label label16_1 = this.Label16;
            point1 = new Point(293, 16);
            Point point24 = point1;
            label16_1.Location = point24;
            this.Label16.Name = "Label16";
            System.Windows.Forms.Label label16_2 = this.Label16;
            size1 = new Size(16, 16);
            Size size27 = size1;
            label16_2.Size = size27;
            this.Label16.TabIndex = 63;
            this.Label16.Text = "*";
            this.Label3.AutoSize = true;
            System.Windows.Forms.Label label3_1 = this.Label3;
            point1 = new Point(0, 0);
            Point point25 = point1;
            label3_1.Location = point25;
            this.Label3.Name = "Label3";
            System.Windows.Forms.Label label3_2 = this.Label3;
            size1 = new Size(104, 13);
            Size size28 = size1;
            label3_2.Size = size28;
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Address of problem:";
            this.cmbPayment.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbPayment.FormattingEnabled = true;
            ComboBox cmbPayment1 = this.cmbPayment;
            point1 = new Point(98, 173);
            Point point26 = point1;
            cmbPayment1.Location = point26;
            this.cmbPayment.Name = "cmbPayment";
            ComboBox cmbPayment2 = this.cmbPayment;
            size1 = new Size(90, 21);
            Size size29 = size1;
            cmbPayment2.Size = size29;
            this.cmbPayment.TabIndex = 14;
            this.Label10.AutoSize = true;
            System.Windows.Forms.Label label10_1 = this.Label10;
            point1 = new Point(0, 122);
            Point point27 = point1;
            label10_1.Location = point27;
            this.Label10.Name = "Label10";
            System.Windows.Forms.Label label10_2 = this.Label10;
            size1 = new Size(73, 13);
            Size size30 = size1;
            label10_2.Size = size30;
            this.Label10.TabIndex = 9;
            this.Label10.Text = "Quoted price:";
            this.Label12.AutoSize = true;
            System.Windows.Forms.Label label12_1 = this.Label12;
            point1 = new Point(0, 176);
            Point point28 = point1;
            label12_1.Location = point28;
            this.Label12.Name = "Label12";
            System.Windows.Forms.Label label12_2 = this.Label12;
            size1 = new Size(92, 13);
            Size size31 = size1;
            label12_2.Size = size31;
            this.Label12.TabIndex = 13;
            this.Label12.Text = "Payment method:";
            System.Windows.Forms.TextBox txtQuote1 = this.txtQuote;
            point1 = new Point(98, 119);
            Point point29 = point1;
            txtQuote1.Location = point29;
            this.txtQuote.Name = "txtQuote";
            System.Windows.Forms.TextBox txtQuote2 = this.txtQuote;
            size1 = new Size(90, 21);
            Size size32 = size1;
            txtQuote2.Size = size32;
            this.txtQuote.TabIndex = 10;
            System.Windows.Forms.TextBox txtInvoiceNr1 = this.txtInvoiceNr;
            point1 = new Point(98, 146);
            Point point30 = point1;
            txtInvoiceNr1.Location = point30;
            this.txtInvoiceNr.Name = "txtInvoiceNr";
            System.Windows.Forms.TextBox txtInvoiceNr2 = this.txtInvoiceNr;
            size1 = new Size(90, 21);
            Size size33 = size1;
            txtInvoiceNr2.Size = size33;
            this.txtInvoiceNr.TabIndex = 12;
            this.Label11.AutoSize = true;
            System.Windows.Forms.Label label11_1 = this.Label11;
            point1 = new Point(0, 149);
            Point point31 = point1;
            label11_1.Location = point31;
            this.Label11.Name = "Label11";
            System.Windows.Forms.Label label11_2 = this.Label11;
            size1 = new Size(85, 13);
            Size size34 = size1;
            label11_2.Size = size34;
            this.Label11.TabIndex = 11;
            this.Label11.Text = "Invoice number:";
            this.txtJobAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            System.Windows.Forms.TextBox txtJobAddress1 = this.txtJobAddress;
            point1 = new Point(3, 16);
            Point point32 = point1;
            txtJobAddress1.Location = point32;
            this.txtJobAddress.Multiline = true;
            this.txtJobAddress.Name = "txtJobAddress";
            System.Windows.Forms.TextBox txtJobAddress2 = this.txtJobAddress;
            size1 = new Size(288, 97);
            Size size35 = size1;
            txtJobAddress2.Size = size35;
            this.txtJobAddress.TabIndex = 1;
            this.Panel5.Controls.Add((Control)this.TableLayoutPanel3);
            this.Panel5.Dock = DockStyle.Fill;
            Panel panel5_1 = this.Panel5;
            point1 = new Point(328, 3);
            Point point33 = point1;
            panel5_1.Location = point33;
            this.Panel5.Name = "Panel5";
            Panel panel5_2 = this.Panel5;
            size1 = new Size(319, 233);
            Size size36 = size1;
            panel5_2.Size = size36;
            this.Panel5.TabIndex = 1;
            this.TableLayoutPanel3.ColumnCount = 1;
            this.TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.TableLayoutPanel3.Controls.Add((Control)this.chkRented, 0, 0);
            this.TableLayoutPanel3.Controls.Add((Control)this.grpIsTenant, 0, 1);
            this.TableLayoutPanel3.Dock = DockStyle.Fill;
            TableLayoutPanel tableLayoutPanel3_1 = this.TableLayoutPanel3;
            point1 = new Point(0, 0);
            Point point34 = point1;
            tableLayoutPanel3_1.Location = point34;
            this.TableLayoutPanel3.Name = "TableLayoutPanel3";
            this.TableLayoutPanel3.RowCount = 2;
            this.TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 24f));
            this.TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            TableLayoutPanel tableLayoutPanel3_2 = this.TableLayoutPanel3;
            size1 = new Size(319, 233);
            Size size37 = size1;
            tableLayoutPanel3_2.Size = size37;
            this.TableLayoutPanel3.TabIndex = 8;
            this.chkRented.AutoSize = true;
            System.Windows.Forms.CheckBox chkRented1 = this.chkRented;
            point1 = new Point(3, 3);
            Point point35 = point1;
            chkRented1.Location = point35;
            this.chkRented.Name = "chkRented";
            System.Windows.Forms.CheckBox chkRented2 = this.chkRented;
            size1 = new Size(154, 17);
            Size size38 = size1;
            chkRented2.Size = size38;
            this.chkRented.TabIndex = 2;
            this.chkRented.Text = "This property is rented out";
            this.chkRented.UseVisualStyleBackColor = true;
            this.grpIsTenant.Controls.Add((Control)this.Label19);
            this.grpIsTenant.Controls.Add((Control)this.Label18);
            this.grpIsTenant.Controls.Add((Control)this.Label17);
            this.grpIsTenant.Controls.Add((Control)this.txtTenantCell);
            this.grpIsTenant.Controls.Add((Control)this.Label9);
            this.grpIsTenant.Controls.Add((Control)this.txtTenantTel2);
            this.grpIsTenant.Controls.Add((Control)this.Label8);
            this.grpIsTenant.Controls.Add((Control)this.txtTenantTel1);
            this.grpIsTenant.Controls.Add((Control)this.Label7);
            this.grpIsTenant.Controls.Add((Control)this.txtTenantName);
            this.grpIsTenant.Controls.Add((Control)this.txtTenantID);
            this.grpIsTenant.Controls.Add((Control)this.Label5);
            this.grpIsTenant.Controls.Add((Control)this.Label6);
            this.grpIsTenant.Dock = DockStyle.Top;
            GroupBox grpIsTenant1 = this.grpIsTenant;
            point1 = new Point(3, 27);
            Point point36 = point1;
            grpIsTenant1.Location = point36;
            this.grpIsTenant.Name = "grpIsTenant";
            GroupBox grpIsTenant2 = this.grpIsTenant;
            size1 = new Size(313, 164);
            Size size39 = size1;
            grpIsTenant2.Size = size39;
            this.grpIsTenant.TabIndex = 7;
            this.grpIsTenant.TabStop = false;
            this.grpIsTenant.Text = "Tenant details";
            this.grpIsTenant.Visible = false;
            this.Label19.AutoSize = true;
            this.Label19.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label19.ForeColor = Color.Red;
            System.Windows.Forms.Label label19_1 = this.Label19;
            point1 = new Point(289, 75);
            Point point37 = point1;
            label19_1.Location = point37;
            this.Label19.Name = "Label19";
            System.Windows.Forms.Label label19_2 = this.Label19;
            size1 = new Size(16, 16);
            Size size40 = size1;
            label19_2.Size = size40;
            this.Label19.TabIndex = 65;
            this.Label19.Text = "*";
            this.Label18.AutoSize = true;
            this.Label18.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label18.ForeColor = Color.Red;
            System.Windows.Forms.Label label18_1 = this.Label18;
            point1 = new Point(289, 47);
            Point point38 = point1;
            label18_1.Location = point38;
            this.Label18.Name = "Label18";
            System.Windows.Forms.Label label18_2 = this.Label18;
            size1 = new Size(16, 16);
            Size size41 = size1;
            label18_2.Size = size41;
            this.Label18.TabIndex = 64;
            this.Label18.Text = "*";
            this.Label17.AutoSize = true;
            this.Label17.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label17.ForeColor = Color.Red;
            System.Windows.Forms.Label label17_1 = this.Label17;
            point1 = new Point(289, 20);
            Point point39 = point1;
            label17_1.Location = point39;
            this.Label17.Name = "Label17";
            System.Windows.Forms.Label label17_2 = this.Label17;
            size1 = new Size(16, 16);
            Size size42 = size1;
            label17_2.Size = size42;
            this.Label17.TabIndex = 63;
            this.Label17.Text = "*";
            System.Windows.Forms.TextBox txtTenantCell1 = this.txtTenantCell;
            point1 = new Point(98, 129);
            Point point40 = point1;
            txtTenantCell1.Location = point40;
            this.txtTenantCell.Name = "txtTenantCell";
            System.Windows.Forms.TextBox txtTenantCell2 = this.txtTenantCell;
            size1 = new Size(185, 21);
            Size size43 = size1;
            txtTenantCell2.Size = size43;
            this.txtTenantCell.TabIndex = 12;
            this.Label9.AutoSize = true;
            System.Windows.Forms.Label label9_1 = this.Label9;
            point1 = new Point(6, 132);
            Point point41 = point1;
            label9_1.Location = point41;
            this.Label9.Name = "Label9";
            System.Windows.Forms.Label label9_2 = this.Label9;
            size1 = new Size(28, 13);
            Size size44 = size1;
            label9_2.Size = size44;
            this.Label9.TabIndex = 11;
            this.Label9.Text = "Cell:";
            System.Windows.Forms.TextBox txtTenantTel2_1 = this.txtTenantTel2;
            point1 = new Point(98, 102);
            Point point42 = point1;
            txtTenantTel2_1.Location = point42;
            this.txtTenantTel2.Name = "txtTenantTel2";
            System.Windows.Forms.TextBox txtTenantTel2_2 = this.txtTenantTel2;
            size1 = new Size(185, 21);
            Size size45 = size1;
            txtTenantTel2_2.Size = size45;
            this.txtTenantTel2.TabIndex = 10;
            this.Label8.AutoSize = true;
            System.Windows.Forms.Label label8_1 = this.Label8;
            point1 = new Point(6, 105);
            Point point43 = point1;
            label8_1.Location = point43;
            this.Label8.Name = "Label8";
            System.Windows.Forms.Label label8_2 = this.Label8;
            size1 = new Size(70, 13);
            Size size46 = size1;
            label8_2.Size = size46;
            this.Label8.TabIndex = 9;
            this.Label8.Text = "Telephone 2:";
            System.Windows.Forms.TextBox txtTenantTel1_1 = this.txtTenantTel1;
            point1 = new Point(98, 75);
            Point point44 = point1;
            txtTenantTel1_1.Location = point44;
            this.txtTenantTel1.Name = "txtTenantTel1";
            System.Windows.Forms.TextBox txtTenantTel1_2 = this.txtTenantTel1;
            size1 = new Size(185, 21);
            Size size47 = size1;
            txtTenantTel1_2.Size = size47;
            this.txtTenantTel1.TabIndex = 8;
            this.Label7.AutoSize = true;
            System.Windows.Forms.Label label7_1 = this.Label7;
            point1 = new Point(6, 78);
            Point point45 = point1;
            label7_1.Location = point45;
            this.Label7.Name = "Label7";
            System.Windows.Forms.Label label7_2 = this.Label7;
            size1 = new Size(70, 13);
            Size size48 = size1;
            label7_2.Size = size48;
            this.Label7.TabIndex = 7;
            this.Label7.Text = "Telephone 1:";
            System.Windows.Forms.TextBox txtTenantName1 = this.txtTenantName;
            point1 = new Point(98, 20);
            Point point46 = point1;
            txtTenantName1.Location = point46;
            this.txtTenantName.Name = "txtTenantName";
            System.Windows.Forms.TextBox txtTenantName2 = this.txtTenantName;
            size1 = new Size(185, 21);
            Size size49 = size1;
            txtTenantName2.Size = size49;
            this.txtTenantName.TabIndex = 4;
            System.Windows.Forms.TextBox txtTenantId1 = this.txtTenantID;
            point1 = new Point(98, 47);
            Point point47 = point1;
            txtTenantId1.Location = point47;
            this.txtTenantID.Name = "txtTenantID";
            System.Windows.Forms.TextBox txtTenantId2 = this.txtTenantID;
            size1 = new Size(185, 21);
            Size size50 = size1;
            txtTenantId2.Size = size50;
            this.txtTenantID.TabIndex = 6;
            this.Label5.AutoSize = true;
            System.Windows.Forms.Label label5_1 = this.Label5;
            point1 = new Point(6, 23);
            Point point48 = point1;
            label5_1.Location = point48;
            this.Label5.Name = "Label5";
            System.Windows.Forms.Label label5_2 = this.Label5;
            size1 = new Size(38, 13);
            Size size51 = size1;
            label5_2.Size = size51;
            this.Label5.TabIndex = 3;
            this.Label5.Text = "Name:";
            this.Label6.AutoSize = true;
            System.Windows.Forms.Label label6_1 = this.Label6;
            point1 = new Point(6, 50);
            Point point49 = point1;
            label6_1.Location = point49;
            this.Label6.Name = "Label6";
            System.Windows.Forms.Label label6_2 = this.Label6;
            size1 = new Size(61, 13);
            Size size52 = size1;
            label6_2.Size = size52;
            this.Label6.TabIndex = 5;
            this.Label6.Text = "ID number:";
            this.TabPage2.Controls.Add((Control)this.grdProblem);
            TabPage tabPage2_1 = this.TabPage2;
            point1 = new Point(4, 22);
            Point point50 = point1;
            tabPage2_1.Location = point50;
            this.TabPage2.Name = "TabPage2";
            TabPage tabPage2_2 = this.TabPage2;
            padding1 = new System.Windows.Forms.Padding(3);
            System.Windows.Forms.Padding padding6 = padding1;
            tabPage2_2.Padding = padding6;
            TabPage tabPage2_3 = this.TabPage2;
            size1 = new Size(656, 245);
            Size size53 = size1;
            tabPage2_3.Size = size53;
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Problem & Feedback";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.grdProblem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProblem.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.grdProblem.BackgroundColor = SystemColors.Window;
            this.grdProblem.BorderStyle = BorderStyle.Fixed3D;
            this.grdProblem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProblem.Columns.AddRange((DataGridViewColumn)this.Column1, (DataGridViewColumn)this.Column2);
            this.grdProblem.Dock = DockStyle.Fill;
            DataGridView grdProblem1 = this.grdProblem;
            point1 = new Point(3, 3);
            Point point51 = point1;
            grdProblem1.Location = point51;
            this.grdProblem.MultiSelect = false;
            this.grdProblem.Name = "grdProblem";
            this.grdProblem.RowHeadersVisible = false;
            gridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            this.grdProblem.RowsDefaultCellStyle = gridViewCellStyle1;
            this.grdProblem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView grdProblem2 = this.grdProblem;
            size1 = new Size(650, 239);
            Size size54 = size1;
            grdProblem2.Size = size54;
            this.grdProblem.TabIndex = 0;
            this.Column1.HeaderText = "Problem";
            this.Column1.Name = "Column1";
            this.Column2.HeaderText = "Feedback";
            this.Column2.Name = "Column2";
            this.TabPage3.Controls.Add((Control)this.grdTimesheet);
            TabPage tabPage3_1 = this.TabPage3;
            point1 = new Point(4, 22);
            Point point52 = point1;
            tabPage3_1.Location = point52;
            this.TabPage3.Name = "TabPage3";
            TabPage tabPage3_2 = this.TabPage3;
            padding1 = new System.Windows.Forms.Padding(3);
            System.Windows.Forms.Padding padding7 = padding1;
            tabPage3_2.Padding = padding7;
            TabPage tabPage3_3 = this.TabPage3;
            size1 = new Size(656, 245);
            Size size55 = size1;
            tabPage3_3.Size = size55;
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Timesheet";
            this.TabPage3.UseVisualStyleBackColor = true;
            this.grdTimesheet.AllowUserToResizeRows = false;
            this.grdTimesheet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTimesheet.BackgroundColor = SystemColors.Window;
            this.grdTimesheet.BorderStyle = BorderStyle.Fixed3D;
            this.grdTimesheet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTimesheet.Columns.AddRange((DataGridViewColumn)this.DataGridViewTextBoxColumn2, (DataGridViewColumn)this.Column4, (DataGridViewColumn)this.Column5);
            this.grdTimesheet.Dock = DockStyle.Fill;
            DataGridView grdTimesheet1 = this.grdTimesheet;
            point1 = new Point(3, 3);
            Point point53 = point1;
            grdTimesheet1.Location = point53;
            this.grdTimesheet.Name = "grdTimesheet";
            this.grdTimesheet.RowHeadersVisible = false;
            this.grdTimesheet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView grdTimesheet2 = this.grdTimesheet;
            size1 = new Size(650, 239);
            Size size56 = size1;
            grdTimesheet2.Size = size56;
            this.grdTimesheet.TabIndex = 1;
            gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            this.DataGridViewTextBoxColumn2.DefaultCellStyle = gridViewCellStyle2;
            this.DataGridViewTextBoxColumn2.HeaderText = "Time Started (HH:MM)";
            this.DataGridViewTextBoxColumn2.MaxInputLength = 5;
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            gridViewCellStyle3.NullValue = (object)null;
            this.Column4.DefaultCellStyle = gridViewCellStyle3;
            this.Column4.HeaderText = "Time ended (HH:MM)";
            this.Column4.MaxInputLength = 5;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = DataGridViewTriState.True;
            gridViewCellStyle4.BackColor = SystemColors.Window;
            gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            this.Column5.DefaultCellStyle = gridViewCellStyle4;
            this.Column5.HeaderText = "Hours spend";
            this.Column5.Name = "Column5";
            this.TabPage4.Controls.Add((Control)this.grdKM);
            TabPage tabPage4_1 = this.TabPage4;
            point1 = new Point(4, 22);
            Point point54 = point1;
            tabPage4_1.Location = point54;
            this.TabPage4.Name = "TabPage4";
            TabPage tabPage4_2 = this.TabPage4;
            padding1 = new System.Windows.Forms.Padding(3);
            System.Windows.Forms.Padding padding8 = padding1;
            tabPage4_2.Padding = padding8;
            TabPage tabPage4_3 = this.TabPage4;
            size1 = new Size(656, 245);
            Size size57 = size1;
            tabPage4_3.Size = size57;
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "Travel & Mileage";
            this.TabPage4.UseVisualStyleBackColor = true;
            this.grdKM.AllowUserToResizeRows = false;
            this.grdKM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grdKM.BackgroundColor = Color.White;
            this.grdKM.BorderStyle = BorderStyle.Fixed3D;
            this.grdKM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdKM.Columns.AddRange((DataGridViewColumn)this.DataGridViewTextBoxColumn3, (DataGridViewColumn)this.DataGridViewTextBoxColumn4, (DataGridViewColumn)this.Column6, (DataGridViewColumn)this.Column3);
            this.grdKM.Dock = DockStyle.Fill;
            DataGridView grdKm1 = this.grdKM;
            point1 = new Point(3, 3);
            Point point55 = point1;
            grdKm1.Location = point55;
            this.grdKM.Name = "grdKM";
            this.grdKM.RowHeadersVisible = false;
            this.grdKM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView grdKm2 = this.grdKM;
            size1 = new Size(650, 239);
            Size size58 = size1;
            grdKm2.Size = size58;
            this.grdKM.TabIndex = 1;
            gridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            this.DataGridViewTextBoxColumn3.DefaultCellStyle = gridViewCellStyle5;
            this.DataGridViewTextBoxColumn3.HeaderText = "Date";
            this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.Resizable = DataGridViewTriState.True;
            this.DataGridViewTextBoxColumn3.SortMode = DataGridViewColumnSortMode.Automatic;
            gridViewCellStyle6.NullValue = (object)null;
            this.DataGridViewTextBoxColumn4.DefaultCellStyle = gridViewCellStyle6;
            this.DataGridViewTextBoxColumn4.HeaderText = "Start KM";
            this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            this.DataGridViewTextBoxColumn4.Resizable = DataGridViewTriState.True;
            this.Column6.HeaderText = "End KM";
            this.Column6.Name = "Column6";
            this.Column3.HeaderText = "Vehicle Reg Nr";
            this.Column3.Name = "Column3";
            this.TabPage5.Controls.Add((Control)this.txtNotes);
            TabPage tabPage5_1 = this.TabPage5;
            point1 = new Point(4, 22);
            Point point56 = point1;
            tabPage5_1.Location = point56;
            this.TabPage5.Name = "TabPage5";
            TabPage tabPage5_2 = this.TabPage5;
            padding1 = new System.Windows.Forms.Padding(3);
            System.Windows.Forms.Padding padding9 = padding1;
            tabPage5_2.Padding = padding9;
            TabPage tabPage5_3 = this.TabPage5;
            size1 = new Size(656, 245);
            Size size59 = size1;
            tabPage5_3.Size = size59;
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "Notes";
            this.TabPage5.UseVisualStyleBackColor = true;
            this.txtNotes.Dock = DockStyle.Fill;
            System.Windows.Forms.TextBox txtNotes1 = this.txtNotes;
            point1 = new Point(3, 3);
            Point point57 = point1;
            txtNotes1.Location = point57;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = ScrollBars.Vertical;
            System.Windows.Forms.TextBox txtNotes2 = this.txtNotes;
            size1 = new Size(650, 239);
            Size size60 = size1;
            txtNotes2.Size = size60;
            this.txtNotes.TabIndex = 2;
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
            this.btnCancel.Image = (System.Drawing.Image)componentResourceManager.GetObject("btnCancel.Image");
            SoftButton btnCancel1 = this.btnCancel;
            size1 = new Size(16, 16);
            Size size61 = size1;
            btnCancel1.ImageSize = size61;
            SoftButton btnCancel2 = this.btnCancel;
            point1 = new Point(376, 3);
            Point point58 = point1;
            btnCancel2.Location = point58;
            this.btnCancel.Name = "btnCancel";
            SoftButton btnCancel3 = this.btnCancel;
            size1 = new Size(76, 30);
            Size size62 = size1;
            btnCancel3.Size = size62;
            this.btnCancel.TabIndex = 67;
            this.btnCancel.TextAlign = ContentAlignment.MiddleRight;
            this.btnSave.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnSave.BackColor = Color.Transparent;
            this.btnSave.BaseColor = SystemColors.ButtonFace;
            this.btnSave.ButtonColor = SystemColors.ButtonShadow;
            this.btnSave.ButtonText = "Save";
            this.btnSave.CornerRadius = 3;
            this.btnSave.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnSave.ForeColor = SystemColors.ControlText;
            this.btnSave.Glow2Color = Color.White;
            this.btnSave.GlowColor = SystemColors.Info;
            this.btnSave.HighlightColor = SystemColors.ControlLightLight;
            this.btnSave.Image = (System.Drawing.Image)componentResourceManager.GetObject("btnSave.Image");
            SoftButton btnSave1 = this.btnSave;
            size1 = new Size(16, 16);
            Size size63 = size1;
            btnSave1.ImageSize = size63;
            SoftButton btnSave2 = this.btnSave;
            point1 = new Point(304, 3);
            Point point59 = point1;
            btnSave2.Location = point59;
            this.btnSave.Name = "btnSave";
            SoftButton btnSave3 = this.btnSave;
            size1 = new Size(66, 30);
            Size size64 = size1;
            btnSave3.Size = size64;
            this.btnSave.TabIndex = 66;
            this.btnSave.TextAlign = ContentAlignment.MiddleRight;
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.TableLayoutPanel1.Controls.Add((Control)this.TableLayoutPanel4, 0, 0);
            this.TableLayoutPanel1.Controls.Add((Control)this.GroupBox1, 0, 1);
            this.TableLayoutPanel1.Controls.Add((Control)this.TabControl1, 0, 2);
            this.TableLayoutPanel1.Controls.Add((Control)this.Panel2, 0, 3);
            this.TableLayoutPanel1.Dock = DockStyle.Fill;
            TableLayoutPanel tableLayoutPanel1_1 = this.TableLayoutPanel1;
            point1 = new Point(0, 0);
            Point point60 = point1;
            tableLayoutPanel1_1.Location = point60;
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel tableLayoutPanel1_2 = this.TableLayoutPanel1;
            padding1 = new System.Windows.Forms.Padding(3);
            System.Windows.Forms.Padding padding10 = padding1;
            tableLayoutPanel1_2.Padding = padding10;
            this.TableLayoutPanel1.RowCount = 4;
            this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38f));
            this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52f));
            this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42f));
            this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
            TableLayoutPanel tableLayoutPanel1_3 = this.TableLayoutPanel1;
            size1 = new Size(676, 415);
            Size size65 = size1;
            tableLayoutPanel1_3.Size = size65;
            this.TableLayoutPanel1.TabIndex = 69;
            this.TableLayoutPanel4.ColumnCount = 2;
            this.TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 322f));
            this.TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.TableLayoutPanel4.Controls.Add((Control)this.Panel7, 0, 0);
            this.TableLayoutPanel4.Controls.Add((Control)this.Panel8, 1, 0);
            this.TableLayoutPanel4.Dock = DockStyle.Fill;
            TableLayoutPanel tableLayoutPanel4_1 = this.TableLayoutPanel4;
            point1 = new Point(6, 6);
            Point point61 = point1;
            tableLayoutPanel4_1.Location = point61;
            this.TableLayoutPanel4.Name = "TableLayoutPanel4";
            this.TableLayoutPanel4.RowCount = 1;
            this.TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            TableLayoutPanel tableLayoutPanel4_2 = this.TableLayoutPanel4;
            size1 = new Size(664, 32);
            Size size66 = size1;
            tableLayoutPanel4_2.Size = size66;
            this.TableLayoutPanel4.TabIndex = 4;
            this.Panel7.Controls.Add((Control)this.Label25);
            this.Panel7.Controls.Add((Control)this.Label1);
            this.Panel7.Controls.Add((Control)this.Label2);
            this.Panel7.Controls.Add((Control)this.txtdate);
            this.Panel7.Dock = DockStyle.Fill;
            Panel panel7_1 = this.Panel7;
            point1 = new Point(3, 3);
            Point point62 = point1;
            panel7_1.Location = point62;
            this.Panel7.Name = "Panel7";
            Panel panel7_2 = this.Panel7;
            size1 = new Size(316, 26);
            Size size67 = size1;
            panel7_2.Size = size67;
            this.Panel7.TabIndex = 0;
            this.Label25.AutoSize = true;
            this.Label25.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label25.ForeColor = Color.Red;
            System.Windows.Forms.Label label25_1 = this.Label25;
            point1 = new Point(201, 0);
            Point point63 = point1;
            label25_1.Location = point63;
            this.Label25.Name = "Label25";
            System.Windows.Forms.Label label25_2 = this.Label25;
            size1 = new Size(16, 16);
            Size size68 = size1;
            label25_2.Size = size68;
            this.Label25.TabIndex = 63;
            this.Label25.Text = "*";
            this.Panel8.Controls.Add((Control)this.Label13);
            this.Panel8.Controls.Add((Control)this.txtteam);
            this.Panel8.Dock = DockStyle.Fill;
            Panel panel8_1 = this.Panel8;
            point1 = new Point(325, 3);
            Point point64 = point1;
            panel8_1.Location = point64;
            this.Panel8.Name = "Panel8";
            Panel panel8_2 = this.Panel8;
            size1 = new Size(336, 26);
            Size size69 = size1;
            panel8_2.Size = size69;
            this.Panel8.TabIndex = 1;
            this.Label13.AutoSize = true;
            this.Label13.Dock = DockStyle.Right;
            this.Label13.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label13.ForeColor = Color.Red;
            System.Windows.Forms.Label label13_1 = this.Label13;
            point1 = new Point(320, 0);
            Point point65 = point1;
            label13_1.Location = point65;
            this.Label13.Name = "Label13";
            System.Windows.Forms.Label label13_2 = this.Label13;
            size1 = new Size(16, 16);
            Size size70 = size1;
            label13_2.Size = size70;
            this.Label13.TabIndex = 63;
            this.Label13.Text = "*";
            this.Panel2.Controls.Add((Control)this.chkComplete);
            this.Panel2.Controls.Add((Control)this.Panel3);
            this.Panel2.Dock = DockStyle.Fill;
            Panel panel2_1 = this.Panel2;
            point1 = new Point(6, 373);
            Point point66 = point1;
            panel2_1.Location = point66;
            this.Panel2.Name = "Panel2";
            Panel panel2_2 = this.Panel2;
            size1 = new Size(664, 36);
            Size size71 = size1;
            panel2_2.Size = size71;
            this.Panel2.TabIndex = 8;
            this.chkComplete.AutoSize = true;
            System.Windows.Forms.CheckBox chkComplete1 = this.chkComplete;
            point1 = new Point(0, 3);
            Point point67 = point1;
            chkComplete1.Location = point67;
            this.chkComplete.Name = "chkComplete";
            System.Windows.Forms.CheckBox chkComplete2 = this.chkComplete;
            size1 = new Size(109, 17);
            Size size72 = size1;
            chkComplete2.Size = size72;
            this.chkComplete.TabIndex = 70;
            this.chkComplete.Text = "Complete this job";
            this.chkComplete.UseVisualStyleBackColor = true;
            this.Panel3.Controls.Add((Control)this.btnPrint);
            this.Panel3.Controls.Add((Control)this.btnSave);
            this.Panel3.Controls.Add((Control)this.btnCancel);
            this.Panel3.Dock = DockStyle.Right;
            Panel panel3_1 = this.Panel3;
            point1 = new Point(209, 0);
            Point point68 = point1;
            panel3_1.Location = point68;
            this.Panel3.Name = "Panel3";
            Panel panel3_2 = this.Panel3;
            size1 = new Size(455, 36);
            Size size73 = size1;
            panel3_2.Size = size73;
            this.Panel3.TabIndex = 69;
            this.btnPrint.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnPrint.BackColor = Color.Transparent;
            this.btnPrint.BaseColor = SystemColors.ButtonFace;
            this.btnPrint.ButtonColor = SystemColors.ButtonShadow;
            this.btnPrint.ButtonText = "Print...";
            this.btnPrint.CornerRadius = 3;
            this.btnPrint.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnPrint.ForeColor = SystemColors.ControlText;
            this.btnPrint.Glow2Color = Color.White;
            this.btnPrint.GlowColor = SystemColors.Info;
            this.btnPrint.HighlightColor = SystemColors.ControlLightLight;
          //  this.btnPrint.Image = (System.Drawing.Image)Reytec.JobCard.Core.My.Resources.Resources.PrintHS1;
            SoftButton btnPrint1 = this.btnPrint;
            size1 = new Size(16, 16);
            Size size74 = size1;
            btnPrint1.ImageSize = size74;
            SoftButton btnPrint2 = this.btnPrint;
            point1 = new Point(228, 3);
            Point point69 = point1;
            btnPrint2.Location = point69;
            this.btnPrint.Name = "btnPrint";
            SoftButton btnPrint3 = this.btnPrint;
            size1 = new Size(70, 30);
            Size size75 = size1;
            btnPrint3.Size = size75;
            this.btnPrint.TabIndex = 68;
            this.btnPrint.TextAlign = ContentAlignment.MiddleRight;
            gridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            this.DataGridViewTextBoxColumn1.DefaultCellStyle = gridViewCellStyle7;
            this.DataGridViewTextBoxColumn1.HeaderText = "Problem";
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.Width = 323;
            gridViewCellStyle8.BackColor = SystemColors.Window;
            gridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            this.DataGridViewTextBoxColumn5.DefaultCellStyle = gridViewCellStyle8;
            this.DataGridViewTextBoxColumn5.HeaderText = "Hours spend";
            this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            this.DataGridViewTextBoxColumn5.Width = 215;
            gridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            this.DataGridViewTextBoxColumn6.DefaultCellStyle = gridViewCellStyle9;
            this.DataGridViewTextBoxColumn6.HeaderText = "Feedback";
            this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            this.DataGridViewTextBoxColumn6.Width = 215;
            gridViewCellStyle10.Format = "t";
            gridViewCellStyle10.NullValue = (object)null;
            this.DataGridViewTextBoxColumn7.DefaultCellStyle = gridViewCellStyle10;
            this.DataGridViewTextBoxColumn7.HeaderText = "Start KM";
            this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            this.DataGridViewTextBoxColumn7.Resizable = DataGridViewTriState.True;
            this.DataGridViewTextBoxColumn7.Width = 215;
            this.DataGridViewTextBoxColumn8.HeaderText = "End KM";
            this.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
            this.DataGridViewTextBoxColumn8.Width = 215;
            this.tmr.Interval = 500;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            size1 = new Size(676, 415);
            this.ClientSize = size1;
            this.Controls.Add((Control)this.TableLayoutPanel1);
            this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            size1 = new Size(682, 427);
            this.MinimumSize = size1;
            this.Name = nameof(frmJobDetail);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = nameof(frmJobDetail);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.Panel6.ResumeLayout(false);
            this.Panel6.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TableLayoutPanel2.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.Panel5.ResumeLayout(false);
            this.TableLayoutPanel3.ResumeLayout(false);
            this.TableLayoutPanel3.PerformLayout();
            this.grpIsTenant.ResumeLayout(false);
            this.grpIsTenant.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            ((ISupportInitialize)this.grdProblem).EndInit();
            this.TabPage3.ResumeLayout(false);
            ((ISupportInitialize)this.grdTimesheet).EndInit();
            this.TabPage4.ResumeLayout(false);
            ((ISupportInitialize)this.grdKM).EndInit();
            this.TabPage5.ResumeLayout(false);
            this.TabPage5.PerformLayout();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel4.ResumeLayout(false);
            this.Panel7.ResumeLayout(false);
            this.Panel7.PerformLayout();
            this.Panel8.ResumeLayout(false);
            this.Panel8.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        internal virtual System.Windows.Forms.Label Label1
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

        internal virtual DateTimePicker txtdate
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtdate;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtdate != null)
                    this._txtdate.ValueChanged -= eventHandler;
                this._txtdate = value;
                if (this._txtdate == null)
                    return;
                this._txtdate.ValueChanged += eventHandler;
            }
        }

        internal virtual System.Windows.Forms.Label Label2
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

        internal virtual System.Windows.Forms.TextBox txtteam
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtteam;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler1 = new EventHandler(this.txtteam_TextChanged);
                EventHandler eventHandler2 = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtteam != null)
                {
                    this._txtteam.TextChanged -= eventHandler1;
                    this._txtteam.TextChanged -= eventHandler2;
                }
                this._txtteam = value;
                if (this._txtteam == null)
                    return;
                this._txtteam.TextChanged += eventHandler1;
                this._txtteam.TextChanged += eventHandler2;
            }
        }

        internal virtual System.Windows.Forms.Label custcode
        {
            [DebuggerNonUserCode]
            get
            {
                return this._custcode;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler1 = (EventHandler)((a0, a1) => this.SetDirty());
                EventHandler eventHandler2 = new EventHandler(this.custcode_Click);
                if (this._custcode != null)
                {
                    this._custcode.TextChanged -= eventHandler1;
                    this._custcode.Click -= eventHandler2;
                }
                this._custcode = value;
                if (this._custcode == null)
                    return;
                this._custcode.TextChanged += eventHandler1;
                this._custcode.Click += eventHandler2;
            }
        }

        internal virtual GroupBox GroupBox1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._GroupBox1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBox1 = value;
            }
        }

        internal virtual SoftButton btnAddCustomer
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnAddCustomer;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btn_Click);
                if (this._btnAddCustomer != null)
                    this._btnAddCustomer.Click -= eventHandler;
                this._btnAddCustomer = value;
                if (this._btnAddCustomer == null)
                    return;
                this._btnAddCustomer.Click += eventHandler;
            }
        }

        internal virtual System.Windows.Forms.TextBox txtCustomerAccount
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtCustomerAccount;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtCustomerAccount != null)
                    this._txtCustomerAccount.TextChanged -= eventHandler;
                this._txtCustomerAccount = value;
                if (this._txtCustomerAccount == null)
                    return;
                this._txtCustomerAccount.TextChanged += eventHandler;
            }
        }

        internal virtual System.Windows.Forms.Label Label4
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

        internal virtual ToolTip Tip
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Tip;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Tip = value;
            }
        }

        internal virtual System.Windows.Forms.Label txtCustomerName
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtCustomerName;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtCustomerName = value;
            }
        }

        internal virtual SoftButton btnEditCustomer
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnEditCustomer;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnEditCustomer_Click);
                if (this._btnEditCustomer != null)
                    this._btnEditCustomer.Click -= eventHandler;
                this._btnEditCustomer = value;
                if (this._btnEditCustomer == null)
                    return;
                this._btnEditCustomer.Click += eventHandler;
            }
        }

        internal virtual SoftButton btnLookupCustomer
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnLookupCustomer;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnLookupCustomer_Click);
                if (this._btnLookupCustomer != null)
                    this._btnLookupCustomer.Click -= eventHandler;
                this._btnLookupCustomer = value;
                if (this._btnLookupCustomer == null)
                    return;
                this._btnLookupCustomer.Click += eventHandler;
            }
        }

        internal virtual System.Windows.Forms.Label lblCustomerType
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblCustomerType;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblCustomerType = value;
            }
        }

        internal virtual ImageList grdCustImg
        {
            [DebuggerNonUserCode]
            get
            {
                return this._grdCustImg;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._grdCustImg = value;
            }
        }

        internal virtual System.Windows.Forms.Label nocust
        {
            [DebuggerNonUserCode]
            get
            {
                return this._nocust;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._nocust = value;
            }
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
                EventHandler eventHandler = new EventHandler(this.TabControl1_SelectedIndexChanged);
                if (this._TabControl1 != null)
                    this._TabControl1.SelectedIndexChanged -= eventHandler;
                this._TabControl1 = value;
                if (this._TabControl1 == null)
                    return;
                this._TabControl1.SelectedIndexChanged += eventHandler;
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
                EventHandler eventHandler = new EventHandler(this.TabPage2_Click);
                if (this._TabPage2 != null)
                    this._TabPage2.Click -= eventHandler;
                this._TabPage2 = value;
                if (this._TabPage2 == null)
                    return;
                this._TabPage2.Click += eventHandler;
            }
        }

        internal virtual TabPage TabPage3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TabPage3;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._TabPage3 = value;
            }
        }

        internal virtual TabPage TabPage4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TabPage4;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._TabPage4 = value;
            }
        }

        internal virtual System.Windows.Forms.TextBox txtJobAddress
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtJobAddress;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtJobAddress != null)
                    this._txtJobAddress.TextChanged -= eventHandler;
                this._txtJobAddress = value;
                if (this._txtJobAddress == null)
                    return;
                this._txtJobAddress.TextChanged += eventHandler;
            }
        }

        internal virtual System.Windows.Forms.Label Label3
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

        internal virtual GroupBox grpIsTenant
        {
            [DebuggerNonUserCode]
            get
            {
                return this._grpIsTenant;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._grpIsTenant = value;
            }
        }

        internal virtual System.Windows.Forms.TextBox txtTenantCell
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtTenantCell;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtTenantCell != null)
                    this._txtTenantCell.TextChanged -= eventHandler;
                this._txtTenantCell = value;
                if (this._txtTenantCell == null)
                    return;
                this._txtTenantCell.TextChanged += eventHandler;
            }
        }

        internal virtual System.Windows.Forms.Label Label9
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label9;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label9 = value;
            }
        }

        internal virtual System.Windows.Forms.TextBox txtTenantTel2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtTenantTel2;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtTenantTel2 != null)
                    this._txtTenantTel2.TextChanged -= eventHandler;
                this._txtTenantTel2 = value;
                if (this._txtTenantTel2 == null)
                    return;
                this._txtTenantTel2.TextChanged += eventHandler;
            }
        }

        internal virtual System.Windows.Forms.Label Label8
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label8;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label8 = value;
            }
        }

        internal virtual System.Windows.Forms.TextBox txtTenantTel1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtTenantTel1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtTenantTel1 != null)
                    this._txtTenantTel1.TextChanged -= eventHandler;
                this._txtTenantTel1 = value;
                if (this._txtTenantTel1 == null)
                    return;
                this._txtTenantTel1.TextChanged += eventHandler;
            }
        }

        internal virtual System.Windows.Forms.Label Label7
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label7;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label7 = value;
            }
        }

        internal virtual System.Windows.Forms.TextBox txtTenantName
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtTenantName;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtTenantName != null)
                    this._txtTenantName.TextChanged -= eventHandler;
                this._txtTenantName = value;
                if (this._txtTenantName == null)
                    return;
                this._txtTenantName.TextChanged += eventHandler;
            }
        }

        internal virtual System.Windows.Forms.TextBox txtTenantID
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtTenantID;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtTenantID != null)
                    this._txtTenantID.TextChanged -= eventHandler;
                this._txtTenantID = value;
                if (this._txtTenantID == null)
                    return;
                this._txtTenantID.TextChanged += eventHandler;
            }
        }

        internal virtual System.Windows.Forms.Label Label5
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

        internal virtual System.Windows.Forms.Label Label6
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label6;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label6 = value;
            }
        }

        internal virtual System.Windows.Forms.CheckBox chkRented
        {
            [DebuggerNonUserCode]
            get
            {
                return this._chkRented;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler1 = new EventHandler(this.chkRented_CheckedChanged);
                EventHandler eventHandler2 = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._chkRented != null)
                {
                    this._chkRented.CheckedChanged -= eventHandler1;
                    this._chkRented.Click -= eventHandler2;
                }
                this._chkRented = value;
                if (this._chkRented == null)
                    return;
                this._chkRented.CheckedChanged += eventHandler1;
                this._chkRented.Click += eventHandler2;
            }
        }

        internal virtual System.Windows.Forms.TextBox txtInvoiceNr
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtInvoiceNr;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtInvoiceNr != null)
                    this._txtInvoiceNr.TextChanged -= eventHandler;
                this._txtInvoiceNr = value;
                if (this._txtInvoiceNr == null)
                    return;
                this._txtInvoiceNr.TextChanged += eventHandler;
            }
        }

        internal virtual System.Windows.Forms.Label Label11
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label11;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label11 = value;
            }
        }

        internal virtual System.Windows.Forms.TextBox txtQuote
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtQuote;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtQuote != null)
                    this._txtQuote.TextChanged -= eventHandler;
                this._txtQuote = value;
                if (this._txtQuote == null)
                    return;
                this._txtQuote.TextChanged += eventHandler;
            }
        }

        internal virtual System.Windows.Forms.Label Label10
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label10;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label10 = value;
            }
        }

        internal virtual ComboBox cmbPayment
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cmbPayment;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._cmbPayment != null)
                    this._cmbPayment.ValueMemberChanged -= eventHandler;
                this._cmbPayment = value;
                if (this._cmbPayment == null)
                    return;
                this._cmbPayment.ValueMemberChanged += eventHandler;
            }
        }

        internal virtual System.Windows.Forms.Label Label12
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label12;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label12 = value;
            }
        }

        internal virtual DataGridView grdProblem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._grdProblem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.grdProblem_CellClick);
                DataGridViewCellEventHandler cellEventHandler2 = (DataGridViewCellEventHandler)((a0, a1) => this.SetDirty());
                DataGridViewCellStyleContentChangedEventHandler changedEventHandler = (DataGridViewCellStyleContentChangedEventHandler)((a0, a1) => this.SetDirty());
                if (this._grdProblem != null)
                {
                    this._grdProblem.CellClick -= cellEventHandler1;
                    this._grdProblem.CellValueChanged -= cellEventHandler2;
                    this._grdProblem.CellStyleContentChanged -= changedEventHandler;
                }
                this._grdProblem = value;
                if (this._grdProblem == null)
                    return;
                this._grdProblem.CellClick += cellEventHandler1;
                this._grdProblem.CellValueChanged += cellEventHandler2;
                this._grdProblem.CellStyleContentChanged += changedEventHandler;
            }
        }

        internal virtual TabPage TabPage5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TabPage5;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._TabPage5 = value;
            }
        }

        internal virtual DataGridView grdTimesheet
        {
            [DebuggerNonUserCode]
            get
            {
                return this._grdTimesheet;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                DataGridViewCellEventHandler cellEventHandler = (DataGridViewCellEventHandler)((a0, a1) => this.SetDirty());
                if (this._grdTimesheet != null)
                    this._grdTimesheet.CellValueChanged -= cellEventHandler;
                this._grdTimesheet = value;
                if (this._grdTimesheet == null)
                    return;
                this._grdTimesheet.CellValueChanged += cellEventHandler;
            }
        }

        internal virtual DataGridView grdKM
        {
            [DebuggerNonUserCode]
            get
            {
                return this._grdKM;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                DataGridViewCellEventHandler cellEventHandler = (DataGridViewCellEventHandler)((a0, a1) => this.SetDirty());
                if (this._grdKM != null)
                    this._grdKM.CellValueChanged -= cellEventHandler;
                this._grdKM = value;
                if (this._grdKM == null)
                    return;
                this._grdKM.CellValueChanged += cellEventHandler;
            }
        }

        internal virtual System.Windows.Forms.TextBox txtNotes
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtNotes;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtNotes != null)
                    this._txtNotes.TextChanged -= eventHandler;
                this._txtNotes = value;
                if (this._txtNotes == null)
                    return;
                this._txtNotes.TextChanged += eventHandler;
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

        internal virtual SoftButton btnSave
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnSave;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnSave_Click);
                if (this._btnSave != null)
                    this._btnSave.Click -= eventHandler;
                this._btnSave = value;
                if (this._btnSave == null)
                    return;
                this._btnSave.Click += eventHandler;
            }
        }

        internal virtual TableLayoutPanel TableLayoutPanel1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TableLayoutPanel1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._TableLayoutPanel1 = value;
            }
        }

        internal virtual Panel Panel2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Panel2;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Panel2 = value;
            }
        }

        internal virtual Panel Panel3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Panel3;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Panel3 = value;
            }
        }

        internal virtual TableLayoutPanel TableLayoutPanel2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TableLayoutPanel2;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._TableLayoutPanel2 = value;
            }
        }

        internal virtual Panel Panel4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Panel4;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Panel4 = value;
            }
        }

        internal virtual Panel Panel5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Panel5;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Panel5 = value;
            }
        }

        internal virtual TableLayoutPanel TableLayoutPanel3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TableLayoutPanel3;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._TableLayoutPanel3 = value;
            }
        }

        internal virtual Panel Panel6
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Panel6;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Panel6 = value;
            }
        }

        internal virtual TableLayoutPanel TableLayoutPanel4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TableLayoutPanel4;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._TableLayoutPanel4 = value;
            }
        }

        internal virtual Panel Panel7
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Panel7;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Panel7 = value;
            }
        }

        internal virtual Panel Panel8
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Panel8;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Panel8 = value;
            }
        }

        internal virtual System.Windows.Forms.CheckBox chkComplete
        {
            [DebuggerNonUserCode]
            get
            {
                return this._chkComplete;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler1 = new EventHandler(this.chkComplete_CheckedChanged);
                EventHandler eventHandler2 = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._chkComplete != null)
                {
                    this._chkComplete.CheckedChanged -= eventHandler1;
                    this._chkComplete.Click -= eventHandler2;
                }
                this._chkComplete = value;
                if (this._chkComplete == null)
                    return;
                this._chkComplete.CheckedChanged += eventHandler1;
                this._chkComplete.Click += eventHandler2;
            }
        }

        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DataGridViewTextBoxColumn1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn1 = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DataGridViewTextBoxColumn5;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn5 = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn6
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DataGridViewTextBoxColumn6;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn6 = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn7
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DataGridViewTextBoxColumn7;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn7 = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn8
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DataGridViewTextBoxColumn8;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn8 = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DataGridViewTextBoxColumn2;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn2 = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn Column4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Column4;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Column4 = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn Column5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Column5;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Column5 = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn Column1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Column1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Column1 = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn Column2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Column2;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Column2 = value;
            }
        }

        internal virtual CalendarColumn DataGridViewTextBoxColumn3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DataGridViewTextBoxColumn3;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn3 = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DataGridViewTextBoxColumn4;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn4 = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn Column6
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Column6;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Column6 = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn Column3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Column3;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Column3 = value;
            }
        }

        internal virtual SoftButton btnPrint
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnPrint;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnPrint_Click);
                if (this._btnPrint != null)
                    this._btnPrint.Click -= eventHandler;
                this._btnPrint = value;
                if (this._btnPrint == null)
                    return;
                this._btnPrint.Click += eventHandler;
            }
        }

        internal virtual Timer tmr
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tmr;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.tmr_Tick);
                if (this._tmr != null)
                    this._tmr.Tick -= eventHandler;
                this._tmr = value;
                if (this._tmr == null)
                    return;
                this._tmr.Tick += eventHandler;
            }
        }

        internal virtual System.Windows.Forms.Label Label14
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label14;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label14 = value;
            }
        }

        internal virtual System.Windows.Forms.Label lblcompulsoryacc
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblcompulsoryacc;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblcompulsoryacc = value;
            }
        }

        internal virtual System.Windows.Forms.Label lblcompulsoryinvoice
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblcompulsoryinvoice;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblcompulsoryinvoice = value;
            }
        }

        internal virtual System.Windows.Forms.Label Label16
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label16;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label16 = value;
            }
        }

        internal virtual System.Windows.Forms.Label Label19
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label19;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label19 = value;
            }
        }

        internal virtual System.Windows.Forms.Label Label18
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label18;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label18 = value;
            }
        }

        internal virtual System.Windows.Forms.Label Label17
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label17;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label17 = value;
            }
        }

        internal virtual System.Windows.Forms.Label Label25
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label25;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label25 = value;
            }
        }

        internal virtual System.Windows.Forms.Label Label13
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label13;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label13 = value;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.ResetCustomerButtons();
            int num = (int)new frmCustomerDetail(-1).ShowDialog((IWin32Window)this);
            Customer customer = new Customer(ConnectionInfo.GlobalConnection);
            customer.GetLatestOne();
            this.custcode.Text = Conversions.ToString(customer.ID);
            this.RefreshCustomerDetail(Conversions.ToInteger(this.custcode.Text));
        }

        public object ValidatePage()
        {
            if (Operators.CompareString(this.txtteam.Text, "", false) == 0)
            {
                this.TabControl1.SelectedIndex = 0;
                return General.ShowValidationMessage("Please enter a team or employee name", (Control)this.txtteam);
            }
            if (Operators.CompareString(this.custcode.Text, "-1", false) == 0)
            {
                this.tmr.Enabled = true;
                this.TabControl1.SelectedIndex = 0;
                return General.ShowValidationMessage("Please choose a existing customer or add a new one", (Control)this.btnEditCustomer);
            }
            if (Operators.CompareString(this.txtJobAddress.Text, "", false) == 0)
            {
                this.TabControl1.SelectedIndex = 0;
                return General.ShowValidationMessage("Please enter the address or location of the job", (Control)this.txtJobAddress);
            }
            if (!Versioned.IsNumeric((object)this.txtQuote.Text) & Operators.CompareString(this.txtQuote.Text, "", false) != 0)
            {
                this.TabControl1.SelectedIndex = 0;
                return General.ShowValidationMessage("The quoted price is a numeric only field", (Control)this.txtQuote);
            }
            if (this.chkRented.Checked)
            {
                if (Operators.CompareString(this.txtTenantName.Text, "", false) == 0)
                {
                    this.TabControl1.SelectedIndex = 0;
                    return General.ShowValidationMessage("Please enter the tenant name", (Control)this.txtTenantName);
                }
                if (Operators.CompareString(this.txtTenantID.Text, "", false) == 0)
                {
                    this.TabControl1.SelectedIndex = 0;
                    return General.ShowValidationMessage("Please enter the tenant ID number", (Control)this.txtTenantID);
                }
                if (this.txtTenantID.Text.Length != 13 | !Versioned.IsNumeric((object)this.txtTenantID.Text))
                {
                    this.TabControl1.SelectedIndex = 0;
                    return General.ShowValidationMessage("The tenant ID number must be 13 numeric characters", (Control)this.txtTenantID);
                }
                if (Operators.CompareString(this.txtTenantTel1.Text, "", false) == 0 & Operators.CompareString(this.txtTenantTel2.Text, "", false) == 0 & Operators.CompareString(this.txtTenantCell.Text, "", false) == 0)
                {
                    this.TabControl1.SelectedIndex = 0;
                    return General.ShowValidationMessage("Please enter atleast one contact number for the tenant", (Control)this.txtTenantTel1);
                }
            }
            if (this.chkComplete.Checked)
            {
                if (Operators.CompareString(this.txtCustomerAccount.Text, "", false) == 0)
                {
                    this.TabControl1.SelectedIndex = 0;
                    return General.ShowValidationMessage("Please enter the customer account number", (Control)this.txtCustomerAccount);
                }
                if (Operators.CompareString(this.txtInvoiceNr.Text, "", false) == 0)
                {
                    this.TabControl1.SelectedIndex = 0;
                    return General.ShowValidationMessage("Please enter the the invoice number", (Control)this.txtInvoiceNr);
                }
            }
            if (!Operators.ConditionalCompareObjectEqual(this.grdProblem.Rows[0].Cells[0].Value, (object)"", false))
                return (object)true;
            this.TabControl1.SelectedIndex = 1;
            return General.ShowValidationMessage("Please enter atleast one problem description for this job", (Control)this.grdProblem);
        }

        private void frmJobDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.saved)
                return;
            switch (MessageBox.Show("Do you want to save your changes?", "Save changes", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    this.btnSave.Focus();
                    if (this.SaveJob())
                        break;
                    e.Cancel = true;
                    break;
            }
        }

        private void frmJobDetail_Load(object sender, EventArgs e)
        {
        }

        public void GetDetails()
        {
            Reytec.JobCard.DAL.JobCard dboJob = this.dboJob;
            dboJob.GetOne((object)this._JobID);
            this.txtdate.Value = Conversions.ToDate(dboJob.JobDate);
            this.txtteam.Text = Conversions.ToString(dboJob.JobTeam);
            this.custcode.Text = Conversions.ToString(dboJob.CustomerID);
            this.txtJobAddress.Text = Conversions.ToString(dboJob.ProblemAddress);
            this.txtQuote.Text = Conversions.ToString(dboJob.QuotedAmount);
            this.cmbPayment.SelectedValue = RuntimeHelpers.GetObjectValue(dboJob.PayID);
            this.chkRented.Checked = Conversions.ToBoolean(dboJob.isPropertyRental);
            this.txtTenantName.Text = Conversions.ToString(dboJob.JobTenantName);
            this.txtTenantID.Text = Conversions.ToString(dboJob.JobTenantID);
            this.txtTenantTel1.Text = Conversions.ToString(dboJob.JobTenantTel1);
            this.txtTenantTel2.Text = Conversions.ToString(dboJob.JobTenantTel2);
            this.txtTenantCell.Text = Conversions.ToString(dboJob.JobTenantCell);
            this.chkComplete.Checked = Conversions.ToBoolean(dboJob.JobCompleted);
            this.txtInvoiceNr.Text = Conversions.ToString(dboJob.JobInvoiceNr);
            this.txtNotes.Text = Conversions.ToString(dboJob.JobNote);
            dboJob.GetProblems(this.grdProblem);
            dboJob.GetTimeSheet(this.grdTimesheet);
            dboJob.GetTravel(this.grdKM);
            this.RefreshCustomerDetail(Conversions.ToInteger(this.custcode.Text));
            this.saved = true;
        }

        public void GetWindowType(int JobID)
        {
            if (JobID != -1)
            {
                this._JobID = JobID;
                this.Text = "Edit Job";
                this.GetDetails();
            }
            else
                this.Text = "New Job";
        }

        public frmJobDetail(int JobID = -1)
        {
            this.FormClosing += new FormClosingEventHandler(this.frmJobDetail_FormClosing);
            this.Load += new EventHandler(this.frmJobDetail_Load);
            this.Paint += new PaintEventHandler(this.frmJobDetail_Paint);
            this.lookup = new LookupButton();
            this.dboJob = new Reytec.JobCard.DAL.JobCard(ConnectionInfo.GlobalConnection);
            this._JobID = -1;
            this.c = new Customer(ConnectionInfo.GlobalConnection);
            this.saved = true;
            this.InitializeComponent();
            this.cmbPayment.DataSource = (object)General.GetPaymentMethods(ConnectionInfo.GlobalConnection);
            this.cmbPayment.DisplayMember = "PaymentMethod";
            this.cmbPayment.ValueMember = "PayID";
            this.GetWindowType(JobID);
            this.lookup.DataSource = this.c.GetList();
            this.lookup.AddHiddenFields((object)"CustomerID");
            this.lookup.AddHiddenFields((object)"isCompany");
            this.lookup.LookupCaption = "Lookup Customer";
            this.lookup.AddControlMapping((object)this.custcode, (object)"CustomerID");
        }

        public void RefreshCustomerDetail(int ID)
        {
            this.btnEditCustomer.Enabled = false;
            this.nocust.Visible = true;
            int num = ID;
            switch (num)
            {
                case -2:
                    this.txtCustomerName.Text = "";
                    break;
                case -1:
                    break;
                default:
                    if (num <= 0)
                        break;
                    this.nocust.Visible = false;
                    this.btnEditCustomer.Enabled = true;
                    this.c.GetOne((object)ID);
                    this.txtCustomerAccount.Text = Conversions.ToString(this.c.AccountNumber);
                    this.txtCustomerName.Text = Conversions.ToString(this.c.Name);
                    if (Conversions.ToBoolean(this.c.isCompany))
                    {
                        this.lblCustomerType.Image = this.grdCustImg.Images[0];
                        this.lblCustomerType.Text = "Company";
                        break;
                    }
                    this.lblCustomerType.Image = this.grdCustImg.Images[1];
                    this.lblCustomerType.Text = "Private";
                    break;
            }
        }

        private void frmJobDetail_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            int num = (int)new frmCustomerDetail(Conversions.ToInteger(this.custcode.Text)).ShowDialog((IWin32Window)this);
        }

        private void chkRented_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkRented.Checked)
                this.grpIsTenant.Visible = true;
            else
                this.grpIsTenant.Visible = false;
        }

        private void grdProblem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public bool SaveJob()
        {
            if (Operators.ConditionalCompareObjectEqual(this.ValidatePage(), (object)false, false))
            {
                bool flag = true;
                return flag;
            }
            Reytec.JobCard.DAL.JobCard dboJob = this.dboJob;
            dboJob.JobDate = (object)this.txtdate.Value;
            dboJob.JobTeam = (object)this.txtteam.Text;
            dboJob.CustomerID = (object)this.custcode.Text;
            dboJob.ProblemAddress = (object)this.txtJobAddress.Text;
            dboJob.QuotedAmount = (object)this.txtQuote.Text;
            dboJob.PayID = RuntimeHelpers.GetObjectValue(this.cmbPayment.SelectedValue);
            dboJob.isPropertyRental = (object)this.chkRented.Checked;
            dboJob.JobTenantName = (object)this.txtTenantName.Text;
            dboJob.JobTenantID = (object)this.txtTenantID.Text;
            dboJob.JobTenantTel1 = (object)this.txtTenantTel1.Text;
            dboJob.JobTenantTel2 = (object)this.txtTenantTel2.Text;
            dboJob.JobTenantCell = (object)this.txtTenantCell.Text;
            dboJob.JobCompleted = (object)this.chkComplete.Checked;
            dboJob.JobInvoiceNr = (object)this.txtInvoiceNr.Text;
            dboJob.JobNote = (object)this.txtNotes.Text;
            dboJob.SystemUserID = (object)JobFunctions.LoggedUserID;
            dboJob.ProblemDetail = (object)this.grdProblem;
            dboJob.Timesheet = (object)this.grdTimesheet;
            dboJob.Travel = (object)this.grdKM;
            dboJob.JobCompleted = (object)this.chkComplete.Checked;
            this.c.GetOne((object)this.custcode.Text);
            this.c.AccountNumber = (object)this.txtCustomerAccount.Text;
            this.c.Update((object)this.custcode.Text);
            if (this._JobID != -1)
                dboJob.Update((object)this._JobID);
            else
                dboJob.Add();
            if (this.chkComplete.Checked)
                this.SaveJobImage();
            this.saved = true;
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.SaveJob())
                return;


            MessageBox.Show("Job card successfully saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        public void SaveJobImage()
        {
            DataDynamics.ActiveReports.Viewer.Viewer viewer = new DataDynamics.ActiveReports.Viewer.Viewer();
            ActiveReport3 activeReport3 = (ActiveReport3)new rptJobCard((object)ConnectionInfo.GlobalConnection);
            activeReport3.Parameters["pJobID"].Value = Conversions.ToString(this.dboJob.JobID);
            activeReport3.Run();
            MemoryStream memoryStream = new MemoryStream();
            viewer.Document = activeReport3.Document;
            viewer.Document.Save((Stream)memoryStream, RdfFormat.ARNet, SaveOptions.Compressed);
            byte[] numArray = new byte[checked((int)memoryStream.Length + 1)];
            memoryStream.Position = 0L;
            memoryStream.Read(numArray, 0, checked((int)Conversion.Int(memoryStream.Length)));
            memoryStream.Close();
            this.dboJob.SaveCompletedImage(numArray);
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void MaskedTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnLookupCustomer_Click(object sender, EventArgs e)
        {
            this.ResetCustomerButtons();
            this.lookup.PopupWindow();
            this.RefreshCustomerDetail(Conversions.ToInteger(this.custcode.Text));
        }

        private void custcode_Click(object sender, EventArgs e)
        {
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {
        }

        public void ResetCustomerButtons()
        {
            this.tmr.Enabled = false;
            this.btnLookupCustomer.ButtonStyle = SoftButton.Style.Flat;
            this.btnAddCustomer.ButtonStyle = SoftButton.Style.Flat;
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            this.btnLookupCustomer.ButtonStyle = this.btnLookupCustomer.ButtonStyle != SoftButton.Style.Flat ? SoftButton.Style.Flat : SoftButton.Style.Default;
            if (this.btnAddCustomer.ButtonStyle == SoftButton.Style.Flat)
                this.btnAddCustomer.ButtonStyle = SoftButton.Style.Default;
            else
                this.btnAddCustomer.ButtonStyle = SoftButton.Style.Flat;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            if (!this.saved && (MessageBox.Show("To peview this job card it needs to be saved. Would you like to save it?", "Save Required", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes || !this.SaveJob()))
                return;
            if (this._JobID == -1)
                this.GetWindowType(this.dboJob.GetLatestOneID());
            frmPrint frmPrint = new frmPrint(1, (object)this._JobID, false);
            int num = (int)frmPrint.ShowDialog((IWin32Window)this);
            frmPrint.Dispose();
        }

        public void SetDirty()
        {
            this.saved = false;
        }

        private void txtteam_TextChanged(object sender, EventArgs e)
        {
        }

        private void chkComplete_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkComplete.Checked)
            {
                this.lblcompulsoryacc.Visible = true;
                this.lblcompulsoryinvoice.Visible = true;
            }
            else
            {
                this.lblcompulsoryacc.Visible = false;
                this.lblcompulsoryinvoice.Visible = false;
            }
        }
    }
}
