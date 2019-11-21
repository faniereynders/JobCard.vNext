// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.Core.frmJobList
// Assembly: JobCard, Version=1.0.0.2, Culture=neutral, PublicKeyToken=null
// MVID: 355A629F-A2FA-4599-879B-59162A296DD0
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCard.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Reytec.GUI.Controls;
using Reytec.GUI.Controls.DataLookupWindow;
using Reytec.JobCard.DAL;
using Reytec.JobCard.Functions.GUITransformation;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Reytec.JobCard.Core
{
    [DesignerGenerated]
    public class frmJobList : Form
    {
        private IContainer components;
        [AccessedThroughProperty("lb")]
        private LookupButton _lb;
        [AccessedThroughProperty("TableLayoutPanel1")]
        private TableLayoutPanel _TableLayoutPanel1;
        [AccessedThroughProperty("Panel3")]
        private Panel _Panel3;
        [AccessedThroughProperty("btnDelete")]
        private SoftButton _btnDelete;
        [AccessedThroughProperty("btnEdit")]
        private SoftButton _btnEdit;
        [AccessedThroughProperty("Panel1")]
        private Panel _Panel1;
        [AccessedThroughProperty("lblnosearch")]
        private Label _lblnosearch;
        [AccessedThroughProperty("txtSearch")]
        private TextBox _txtSearch;
        [AccessedThroughProperty("btnNew")]
        private SoftButton _btnNew;
        [AccessedThroughProperty("Panel2")]
        private Panel _Panel2;
        [AccessedThroughProperty("nosearch1")]
        private Panel _nosearch1;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("lnkagain")]
        private LinkLabel _lnkagain;
        [AccessedThroughProperty("grdPendingJobs")]
        private DataGridView _grdPendingJobs;
        [AccessedThroughProperty("TabControl1")]
        private TabControl _TabControl1;
        [AccessedThroughProperty("TabPage1")]
        private TabPage _TabPage1;
        [AccessedThroughProperty("TabPage2")]
        private TabPage _TabPage2;
        [AccessedThroughProperty("TableLayoutPanel2")]
        private TableLayoutPanel _TableLayoutPanel2;
        [AccessedThroughProperty("grdCompletedJobs")]
        private DataGridView _grdCompletedJobs;
        [AccessedThroughProperty("Panel4")]
        private Panel _Panel4;
        [AccessedThroughProperty("btnAll")]
        private SoftButton _btnAll;
        [AccessedThroughProperty("btnMonth")]
        private SoftButton _btnMonth;
        [AccessedThroughProperty("btnWeek")]
        private SoftButton _btnWeek;
        [AccessedThroughProperty("btnToday")]
        private SoftButton _btnToday;
        [AccessedThroughProperty("btnClearSearch")]
        private SoftButton _btnClearSearch;
        [AccessedThroughProperty("Panel5")]
        private Panel _Panel5;
        [AccessedThroughProperty("nosearch2")]
        private Panel _nosearch2;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("LinkLabel1")]
        private LinkLabel _LinkLabel1;
        [AccessedThroughProperty("btnPrint")]
        private SoftButton _btnPrint;
        private Reytec.JobCard.DAL.JobCard dboJob;
        private Reytec.JobCard.DAL.JobCard.CompletedListType filter;

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
            this.TableLayoutPanel1 = new TableLayoutPanel();
            this.Panel3 = new Panel();
            this.btnPrint = new SoftButton();
            this.btnDelete = new SoftButton();
            this.btnEdit = new SoftButton();
            this.Panel1 = new Panel();
            this.btnClearSearch = new SoftButton();
            this.lblnosearch = new Label();
            this.txtSearch = new TextBox();
            this.btnNew = new SoftButton();
            this.Panel2 = new Panel();
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.nosearch1 = new Panel();
            this.Label1 = new Label();
            this.lnkagain = new LinkLabel();
            this.grdPendingJobs = new DataGridView();
            this.TabPage2 = new TabPage();
            this.TableLayoutPanel2 = new TableLayoutPanel();
            this.Panel4 = new Panel();
            this.btnAll = new SoftButton();
            this.btnMonth = new SoftButton();
            this.btnWeek = new SoftButton();
            this.btnToday = new SoftButton();
            this.Panel5 = new Panel();
            this.nosearch2 = new Panel();
            this.Label2 = new Label();
            this.LinkLabel1 = new LinkLabel();
            this.grdCompletedJobs = new DataGridView();
            this.TableLayoutPanel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.nosearch1.SuspendLayout();
            ((ISupportInitialize)this.grdPendingJobs).BeginInit();
            this.TabPage2.SuspendLayout();
            this.TableLayoutPanel2.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.nosearch2.SuspendLayout();
            ((ISupportInitialize)this.grdCompletedJobs).BeginInit();
            this.SuspendLayout();
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.TableLayoutPanel1.Controls.Add((Control)this.Panel3, 0, 0);
            this.TableLayoutPanel1.Controls.Add((Control)this.Panel2, 0, 1);
            this.TableLayoutPanel1.Dock = DockStyle.Fill;
            TableLayoutPanel tableLayoutPanel1_1 = this.TableLayoutPanel1;
            Point point1 = new Point(0, 0);
            Point point2 = point1;
            tableLayoutPanel1_1.Location = point2;
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 2;
            this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36f));
            this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
            TableLayoutPanel tableLayoutPanel1_2 = this.TableLayoutPanel1;
            Size size1 = new Size(732, 480);
            Size size2 = size1;
            tableLayoutPanel1_2.Size = size2;
            this.TableLayoutPanel1.TabIndex = 0;
            this.Panel3.BackColor = Color.Transparent;
            //this.Panel3.BackgroundImage = (Image) Reytec.JobCard.Core.My.Resources.Resources.toolbackt;
            this.Panel3.Controls.Add((Control)this.btnPrint);
            this.Panel3.Controls.Add((Control)this.btnDelete);
            this.Panel3.Controls.Add((Control)this.btnEdit);
            this.Panel3.Controls.Add((Control)this.Panel1);
            this.Panel3.Controls.Add((Control)this.btnNew);
            this.Panel3.Dock = DockStyle.Top;
            Panel panel3_1 = this.Panel3;
            point1 = new Point(0, 0);
            Point point3 = point1;
            panel3_1.Location = point3;
            Panel panel3_2 = this.Panel3;
            Padding padding1 = new Padding(0);
            Padding padding2 = padding1;
            panel3_2.Margin = padding2;
            this.Panel3.Name = "Panel3";
            Panel panel3_3 = this.Panel3;
            size1 = new Size(732, 35);
            Size size3 = size1;
            panel3_3.Size = size3;
            this.Panel3.TabIndex = 5;
            this.btnPrint.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnPrint.BackColor = Color.Transparent;
            this.btnPrint.BaseColor = Color.FromArgb(33, 124, 180);
            this.btnPrint.ButtonColor = Color.FromArgb(23, 87, 125);
            this.btnPrint.ButtonStyle = SoftButton.Style.Flat;
            this.btnPrint.ButtonText = "Print...";
            this.btnPrint.CornerRadius = 3;
            this.btnPrint.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnPrint.Glow2Color = Color.FromArgb(209, 242, 250);
            this.btnPrint.GlowColor = Color.FromArgb(192, (int)byte.MaxValue, (int)byte.MaxValue);
            this.btnPrint.HighlightColor = Color.FromArgb(192, 222, 254);
            // this.btnPrint.Image = (Image) Reytec.JobCard.Core.My.Resources.Resources.PrintHS;
            SoftButton btnPrint1 = this.btnPrint;
            size1 = new Size(16, 16);
            Size size4 = size1;
            btnPrint1.ImageSize = size4;
            SoftButton btnPrint2 = this.btnPrint;
            point1 = new Point(256, 3);
            Point point4 = point1;
            btnPrint2.Location = point4;
            SoftButton btnPrint3 = this.btnPrint;
            padding1 = new Padding(0);
            Padding padding3 = padding1;
            btnPrint3.Margin = padding3;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShadowColor = Color.Black;
            SoftButton btnPrint4 = this.btnPrint;
            size1 = new Size(73, 30);
            Size size5 = size1;
            btnPrint4.Size = size5;
            this.btnPrint.TabIndex = 44;
            this.btnPrint.TextAlign = ContentAlignment.MiddleRight;
            this.btnDelete.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnDelete.BackColor = Color.Transparent;
            this.btnDelete.BaseColor = Color.FromArgb(33, 124, 180);
            this.btnDelete.ButtonColor = Color.FromArgb(23, 87, 125);
            this.btnDelete.ButtonStyle = SoftButton.Style.Flat;
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.CornerRadius = 3;
            this.btnDelete.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnDelete.Glow2Color = Color.FromArgb(209, 242, 250);
            this.btnDelete.GlowColor = Color.FromArgb(192, (int)byte.MaxValue, (int)byte.MaxValue);
            this.btnDelete.HighlightColor = Color.FromArgb(192, 222, 254);
            // this.btnDelete.Image = (Image) Reytec.JobCard.Core.My.Resources.Resources.delete;
            SoftButton btnDelete1 = this.btnDelete;
            size1 = new Size(16, 16);
            Size size6 = size1;
            btnDelete1.ImageSize = size6;
            SoftButton btnDelete2 = this.btnDelete;
            point1 = new Point(182, 3);
            Point point5 = point1;
            btnDelete2.Location = point5;
            SoftButton btnDelete3 = this.btnDelete;
            padding1 = new Padding(0);
            Padding padding4 = padding1;
            btnDelete3.Margin = padding4;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowColor = Color.Black;
            SoftButton btnDelete4 = this.btnDelete;
            size1 = new Size(74, 30);
            Size size7 = size1;
            btnDelete4.Size = size7;
            this.btnDelete.TabIndex = 43;
            this.btnDelete.TextAlign = ContentAlignment.MiddleRight;
            this.btnEdit.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnEdit.BackColor = Color.Transparent;
            this.btnEdit.BaseColor = Color.FromArgb(33, 124, 180);
            this.btnEdit.ButtonColor = Color.FromArgb(23, 87, 125);
            this.btnEdit.ButtonStyle = SoftButton.Style.Flat;
            this.btnEdit.ButtonText = "Edit";
            this.btnEdit.CornerRadius = 3;
            this.btnEdit.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnEdit.Glow2Color = Color.FromArgb(209, 242, 250);
            this.btnEdit.GlowColor = Color.FromArgb(192, (int)byte.MaxValue, (int)byte.MaxValue);
            this.btnEdit.HighlightColor = Color.FromArgb(192, 222, 254);
            //this.btnEdit.Image = (Image) Reytec.JobCard.Core.My.Resources.Resources.EditTableHS;
            SoftButton btnEdit1 = this.btnEdit;
            size1 = new Size(16, 16);
            Size size8 = size1;
            btnEdit1.ImageSize = size8;
            SoftButton btnEdit2 = this.btnEdit;
            point1 = new Point(120, 3);
            Point point6 = point1;
            btnEdit2.Location = point6;
            SoftButton btnEdit3 = this.btnEdit;
            padding1 = new Padding(0);
            Padding padding5 = padding1;
            btnEdit3.Margin = padding5;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowColor = Color.Black;
            SoftButton btnEdit4 = this.btnEdit;
            size1 = new Size(62, 30);
            Size size9 = size1;
            btnEdit4.Size = size9;
            this.btnEdit.TabIndex = 42;
            this.btnEdit.TextAlign = ContentAlignment.MiddleRight;
            this.Panel1.Controls.Add((Control)this.btnClearSearch);
            this.Panel1.Controls.Add((Control)this.lblnosearch);
            this.Panel1.Controls.Add((Control)this.txtSearch);
            this.Panel1.Dock = DockStyle.Right;
            Panel panel1_1 = this.Panel1;
            point1 = new Point(439, 0);
            Point point7 = point1;
            panel1_1.Location = point7;
            this.Panel1.Name = "Panel1";
            Panel panel1_2 = this.Panel1;
            size1 = new Size(293, 35);
            Size size10 = size1;
            panel1_2.Size = size10;
            this.Panel1.TabIndex = 41;
            this.btnClearSearch.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnClearSearch.BackColor = Color.Transparent;
            this.btnClearSearch.BaseColor = Color.FromArgb(33, 124, 180);
            this.btnClearSearch.ButtonColor = Color.FromArgb(23, 87, 125);
            this.btnClearSearch.ButtonStyle = SoftButton.Style.Flat;
            this.btnClearSearch.ButtonText = "Clear";
            this.btnClearSearch.CornerRadius = 3;
            this.btnClearSearch.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnClearSearch.Glow2Color = Color.FromArgb(209, 242, 250);
            this.btnClearSearch.GlowColor = Color.FromArgb(192, (int)byte.MaxValue, (int)byte.MaxValue);
            this.btnClearSearch.HighlightColor = Color.FromArgb(192, 222, 254);
            //this.btnClearSearch.Image = (Image) Reytec.JobCard.Core.My.Resources.Resources.RestartHS1;
            SoftButton btnClearSearch1 = this.btnClearSearch;
            size1 = new Size(16, 16);
            Size size11 = size1;
            btnClearSearch1.ImageSize = size11;
            SoftButton btnClearSearch2 = this.btnClearSearch;
            point1 = new Point(231, 3);
            Point point8 = point1;
            btnClearSearch2.Location = point8;
            SoftButton btnClearSearch3 = this.btnClearSearch;
            padding1 = new Padding(0);
            Padding padding6 = padding1;
            btnClearSearch3.Margin = padding6;
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.ShadowColor = Color.Black;
            SoftButton btnClearSearch4 = this.btnClearSearch;
            size1 = new Size(61, 30);
            Size size12 = size1;
            btnClearSearch4.Size = size12;
            this.btnClearSearch.TabIndex = 44;
            this.btnClearSearch.TextAlign = ContentAlignment.MiddleRight;
            this.lblnosearch.AutoSize = true;
            this.lblnosearch.BackColor = Color.White;
            this.lblnosearch.Cursor = Cursors.IBeam;
            this.lblnosearch.Font = new Font("Segoe UI", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte)0);
            this.lblnosearch.ForeColor = SystemColors.ControlText;
            Label lblnosearch1 = this.lblnosearch;
            point1 = new Point(11, 11);
            Point point9 = point1;
            lblnosearch1.Location = point9;
            Label lblnosearch2 = this.lblnosearch;
            padding1 = new Padding(0);
            Padding padding7 = padding1;
            lblnosearch2.Margin = padding7;
            this.lblnosearch.Name = "lblnosearch";
            Label lblnosearch3 = this.lblnosearch;
            size1 = new Size(117, 15);
            Size size13 = size1;
            lblnosearch3.Size = size13;
            this.lblnosearch.TabIndex = 4;
            this.lblnosearch.Text = "Type search text here";
            TextBox txtSearch1 = this.txtSearch;
            point1 = new Point(4, 9);
            Point point10 = point1;
            txtSearch1.Location = point10;
            this.txtSearch.Name = "txtSearch";
            TextBox txtSearch2 = this.txtSearch;
            size1 = new Size(224, 21);
            Size size14 = size1;
            txtSearch2.Size = size14;
            this.txtSearch.TabIndex = 0;
            this.btnNew.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnNew.BackColor = Color.Transparent;
            this.btnNew.BaseColor = Color.FromArgb(33, 124, 180);
            this.btnNew.ButtonColor = Color.FromArgb(23, 87, 125);
            this.btnNew.ButtonStyle = SoftButton.Style.Flat;
            this.btnNew.ButtonText = "New Job Card";
            this.btnNew.CornerRadius = 3;
            this.btnNew.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnNew.Glow2Color = Color.FromArgb(209, 242, 250);
            this.btnNew.GlowColor = Color.FromArgb(192, (int)byte.MaxValue, (int)byte.MaxValue);
            this.btnNew.HighlightColor = Color.FromArgb(192, 222, 254);
            // this.btnNew.Image = (Image) Reytec.JobCard.Core.My.Resources.Resources.job;
            SoftButton btnNew1 = this.btnNew;
            size1 = new Size(16, 16);
            Size size15 = size1;
            btnNew1.ImageSize = size15;
            SoftButton btnNew2 = this.btnNew;
            point1 = new Point(7, 3);
            Point point11 = point1;
            btnNew2.Location = point11;
            SoftButton btnNew3 = this.btnNew;
            padding1 = new Padding(0);
            Padding padding8 = padding1;
            btnNew3.Margin = padding8;
            this.btnNew.Name = "btnNew";
            this.btnNew.ShadowColor = Color.Black;
            SoftButton btnNew4 = this.btnNew;
            size1 = new Size(113, 30);
            Size size16 = size1;
            btnNew4.Size = size16;
            this.btnNew.TabIndex = 13;
            this.btnNew.TextAlign = ContentAlignment.MiddleRight;
            this.Panel2.Controls.Add((Control)this.TabControl1);
            this.Panel2.Dock = DockStyle.Fill;
            Panel panel2_1 = this.Panel2;
            point1 = new Point(3, 39);
            Point point12 = point1;
            panel2_1.Location = point12;
            this.Panel2.Name = "Panel2";
            Panel panel2_2 = this.Panel2;
            size1 = new Size(726, 438);
            Size size17 = size1;
            panel2_2.Size = size17;
            this.Panel2.TabIndex = 6;
            this.TabControl1.Controls.Add((Control)this.TabPage1);
            this.TabControl1.Controls.Add((Control)this.TabPage2);
            this.TabControl1.Dock = DockStyle.Fill;
            TabControl tabControl1_1 = this.TabControl1;
            point1 = new Point(0, 0);
            Point point13 = point1;
            tabControl1_1.Location = point13;
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            TabControl tabControl1_2 = this.TabControl1;
            size1 = new Size(726, 438);
            Size size18 = size1;
            tabControl1_2.Size = size18;
            this.TabControl1.TabIndex = 8;
            this.TabPage1.Controls.Add((Control)this.nosearch1);
            this.TabPage1.Controls.Add((Control)this.grdPendingJobs);
            TabPage tabPage1_1 = this.TabPage1;
            point1 = new Point(4, 22);
            Point point14 = point1;
            tabPage1_1.Location = point14;
            this.TabPage1.Name = "TabPage1";
            TabPage tabPage1_2 = this.TabPage1;
            padding1 = new Padding(3);
            Padding padding9 = padding1;
            tabPage1_2.Padding = padding9;
            TabPage tabPage1_3 = this.TabPage1;
            size1 = new Size(718, 412);
            Size size19 = size1;
            tabPage1_3.Size = size19;
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Pending Jobs";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.nosearch1.BackColor = SystemColors.Window;
            this.nosearch1.Controls.Add((Control)this.Label1);
            this.nosearch1.Controls.Add((Control)this.lnkagain);
            Panel nosearch1_1 = this.nosearch1;
            point1 = new Point(18, 43);
            Point point15 = point1;
            nosearch1_1.Location = point15;
            this.nosearch1.Name = "nosearch1";
            Panel nosearch1_2 = this.nosearch1;
            size1 = new Size(293, 21);
            Size size20 = size1;
            nosearch1_2.Size = size20;
            this.nosearch1.TabIndex = 7;
            this.nosearch1.Visible = false;
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("Segoe UI", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte)0);
            Label label1_1 = this.Label1;
            point1 = new Point(3, 0);
            Point point16 = point1;
            label1_1.Location = point16;
            this.Label1.Name = "Label1";
            Label label1_2 = this.Label1;
            size1 = new Size(172, 15);
            Size size21 = size1;
            label1_2.Size = size21;
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Your search returned no results.";
            this.lnkagain.AutoSize = true;
            this.lnkagain.Font = new Font("Segoe UI", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte)0);
            this.lnkagain.LinkColor = Color.SteelBlue;
            LinkLabel lnkagain1 = this.lnkagain;
            point1 = new Point(175, 0);
            Point point17 = point1;
            lnkagain1.Location = point17;
            this.lnkagain.Name = "lnkagain";
            LinkLabel lnkagain2 = this.lnkagain;
            size1 = new Size(114, 15);
            Size size22 = size1;
            lnkagain2.Size = size22;
            this.lnkagain.TabIndex = 5;
            this.lnkagain.TabStop = true;
            this.lnkagain.Text = "Try searching again.";
            this.grdPendingJobs.AllowUserToAddRows = false;
            this.grdPendingJobs.AllowUserToDeleteRows = false;
            this.grdPendingJobs.AllowUserToOrderColumns = true;
            this.grdPendingJobs.AllowUserToResizeRows = false;
            this.grdPendingJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPendingJobs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.grdPendingJobs.BackgroundColor = SystemColors.Window;
            this.grdPendingJobs.BorderStyle = BorderStyle.Fixed3D;
            this.grdPendingJobs.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            this.grdPendingJobs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.grdPendingJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPendingJobs.Dock = DockStyle.Fill;
            this.grdPendingJobs.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.grdPendingJobs.GridColor = SystemColors.ActiveBorder;
            DataGridView grdPendingJobs1 = this.grdPendingJobs;
            point1 = new Point(3, 3);
            Point point18 = point1;
            grdPendingJobs1.Location = point18;
            this.grdPendingJobs.MultiSelect = false;
            this.grdPendingJobs.Name = "grdPendingJobs";
            this.grdPendingJobs.ReadOnly = true;
            this.grdPendingJobs.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.grdPendingJobs.RowHeadersVisible = false;
            this.grdPendingJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView grdPendingJobs2 = this.grdPendingJobs;
            size1 = new Size(712, 406);
            Size size23 = size1;
            grdPendingJobs2.Size = size23;
            this.grdPendingJobs.StandardTab = true;
            this.grdPendingJobs.TabIndex = 6;
            this.TabPage2.Controls.Add((Control)this.TableLayoutPanel2);
            TabPage tabPage2_1 = this.TabPage2;
            point1 = new Point(4, 22);
            Point point19 = point1;
            tabPage2_1.Location = point19;
            this.TabPage2.Name = "TabPage2";
            TabPage tabPage2_2 = this.TabPage2;
            padding1 = new Padding(3);
            Padding padding10 = padding1;
            tabPage2_2.Padding = padding10;
            TabPage tabPage2_3 = this.TabPage2;
            size1 = new Size(718, 412);
            Size size24 = size1;
            tabPage2_3.Size = size24;
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Completed Jobs";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.TableLayoutPanel2.ColumnCount = 1;
            this.TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.TableLayoutPanel2.Controls.Add((Control)this.Panel4, 0, 0);
            this.TableLayoutPanel2.Controls.Add((Control)this.Panel5, 0, 1);
            this.TableLayoutPanel2.Dock = DockStyle.Fill;
            TableLayoutPanel tableLayoutPanel2_1 = this.TableLayoutPanel2;
            point1 = new Point(3, 3);
            Point point20 = point1;
            tableLayoutPanel2_1.Location = point20;
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 2;
            this.TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 36f));
            this.TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            TableLayoutPanel tableLayoutPanel2_2 = this.TableLayoutPanel2;
            size1 = new Size(712, 406);
            Size size25 = size1;
            tableLayoutPanel2_2.Size = size25;
            this.TableLayoutPanel2.TabIndex = 8;
            this.Panel4.Controls.Add((Control)this.btnAll);
            this.Panel4.Controls.Add((Control)this.btnMonth);
            this.Panel4.Controls.Add((Control)this.btnWeek);
            this.Panel4.Controls.Add((Control)this.btnToday);
            this.Panel4.Dock = DockStyle.Fill;
            Panel panel4_1 = this.Panel4;
            point1 = new Point(3, 3);
            Point point21 = point1;
            panel4_1.Location = point21;
            this.Panel4.Name = "Panel4";
            Panel panel4_2 = this.Panel4;
            size1 = new Size(706, 30);
            Size size26 = size1;
            panel4_2.Size = size26;
            this.Panel4.TabIndex = 8;
            this.btnAll.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnAll.BackColor = Color.Transparent;
            this.btnAll.BaseColor = SystemColors.ButtonFace;
            this.btnAll.ButtonColor = SystemColors.ButtonShadow;
            this.btnAll.ButtonStyle = SoftButton.Style.Flat;
            this.btnAll.ButtonText = "View All";
            this.btnAll.CornerRadius = 3;
            this.btnAll.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnAll.ForeColor = SystemColors.ControlText;
            this.btnAll.Glow2Color = Color.White;
            this.btnAll.GlowColor = SystemColors.Info;
            this.btnAll.HighlightColor = SystemColors.ControlLightLight;
            //this.btnAll.Image = (Image) Reytec.JobCard.Core.My.Resources.Resources.Calendar_scheduleHS;
            SoftButton btnAll1 = this.btnAll;
            size1 = new Size(16, 16);
            Size size27 = size1;
            btnAll1.ImageSize = size27;
            SoftButton btnAll2 = this.btnAll;
            point1 = new Point(362, 0);
            Point point22 = point1;
            btnAll2.Location = point22;
            this.btnAll.Name = "btnAll";
            SoftButton btnAll3 = this.btnAll;
            size1 = new Size(82, 30);
            Size size28 = size1;
            btnAll3.Size = size28;
            this.btnAll.TabIndex = 68;
            this.btnAll.TextAlign = ContentAlignment.MiddleRight;
            this.btnMonth.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnMonth.BackColor = Color.Transparent;
            this.btnMonth.BaseColor = SystemColors.ButtonFace;
            this.btnMonth.ButtonColor = SystemColors.ButtonShadow;
            this.btnMonth.ButtonStyle = SoftButton.Style.Flat;
            this.btnMonth.ButtonText = "View Past Month";
            this.btnMonth.CornerRadius = 3;
            this.btnMonth.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnMonth.ForeColor = SystemColors.ControlText;
            this.btnMonth.Glow2Color = Color.White;
            this.btnMonth.GlowColor = SystemColors.Info;
            this.btnMonth.HighlightColor = SystemColors.ControlLightLight;
            // this.btnMonth.Image = (Image) Reytec.JobCard.Core.My.Resources.Resources.Calendar_scheduleHS;
            SoftButton btnMonth1 = this.btnMonth;
            size1 = new Size(16, 16);
            Size size29 = size1;
            btnMonth1.ImageSize = size29;
            SoftButton btnMonth2 = this.btnMonth;
            point1 = new Point(231, 0);
            Point point23 = point1;
            btnMonth2.Location = point23;
            this.btnMonth.Name = "btnMonth";
            SoftButton btnMonth3 = this.btnMonth;
            size1 = new Size(125, 30);
            Size size30 = size1;
            btnMonth3.Size = size30;
            this.btnMonth.TabIndex = 67;
            this.btnMonth.TextAlign = ContentAlignment.MiddleRight;
            this.btnWeek.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnWeek.BackColor = Color.Transparent;
            this.btnWeek.BaseColor = SystemColors.ButtonFace;
            this.btnWeek.ButtonColor = SystemColors.ButtonShadow;
            this.btnWeek.ButtonStyle = SoftButton.Style.Flat;
            this.btnWeek.ButtonText = "View Past Week";
            this.btnWeek.CornerRadius = 3;
            this.btnWeek.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnWeek.ForeColor = SystemColors.ControlText;
            this.btnWeek.Glow2Color = Color.White;
            this.btnWeek.GlowColor = SystemColors.Info;
            this.btnWeek.HighlightColor = SystemColors.ControlLightLight;
            // this.btnWeek.Image = (Image) Reytec.JobCard.Core.My.Resources.Resources.Calendar_scheduleHS;
            SoftButton btnWeek1 = this.btnWeek;
            size1 = new Size(16, 16);
            Size size31 = size1;
            btnWeek1.ImageSize = size31;
            SoftButton btnWeek2 = this.btnWeek;
            point1 = new Point(105, 0);
            Point point24 = point1;
            btnWeek2.Location = point24;
            this.btnWeek.Name = "btnWeek";
            SoftButton btnWeek3 = this.btnWeek;
            size1 = new Size(120, 30);
            Size size32 = size1;
            btnWeek3.Size = size32;
            this.btnWeek.TabIndex = 66;
            this.btnWeek.TextAlign = ContentAlignment.MiddleRight;
            this.btnToday.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnToday.BackColor = Color.Transparent;
            this.btnToday.BaseColor = SystemColors.ButtonFace;
            this.btnToday.ButtonColor = SystemColors.ButtonShadow;
            this.btnToday.ButtonText = "View Today";
            this.btnToday.CornerRadius = 3;
            this.btnToday.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnToday.ForeColor = SystemColors.ControlText;
            this.btnToday.Glow2Color = Color.White;
            this.btnToday.GlowColor = SystemColors.Info;
            this.btnToday.HighlightColor = SystemColors.ControlLightLight;
            //this.btnToday.Image = (Image) Reytec.JobCard.Core.My.Resources.Resources.Calendar_scheduleHS;
            SoftButton btnToday1 = this.btnToday;
            size1 = new Size(16, 16);
            Size size33 = size1;
            btnToday1.ImageSize = size33;
            SoftButton btnToday2 = this.btnToday;
            point1 = new Point(0, 0);
            Point point25 = point1;
            btnToday2.Location = point25;
            this.btnToday.Name = "btnToday";
            SoftButton btnToday3 = this.btnToday;
            size1 = new Size(99, 30);
            Size size34 = size1;
            btnToday3.Size = size34;
            this.btnToday.TabIndex = 65;
            this.btnToday.TextAlign = ContentAlignment.MiddleRight;
            this.Panel5.Controls.Add((Control)this.nosearch2);
            this.Panel5.Controls.Add((Control)this.grdCompletedJobs);
            this.Panel5.Dock = DockStyle.Fill;
            Panel panel5_1 = this.Panel5;
            point1 = new Point(3, 39);
            Point point26 = point1;
            panel5_1.Location = point26;
            this.Panel5.Name = "Panel5";
            Panel panel5_2 = this.Panel5;
            size1 = new Size(706, 364);
            Size size35 = size1;
            panel5_2.Size = size35;
            this.Panel5.TabIndex = 9;
            this.nosearch2.BackColor = SystemColors.Window;
            this.nosearch2.Controls.Add((Control)this.Label2);
            this.nosearch2.Controls.Add((Control)this.LinkLabel1);
            Panel nosearch2_1 = this.nosearch2;
            point1 = new Point(18, 43);
            Point point27 = point1;
            nosearch2_1.Location = point27;
            this.nosearch2.Name = "nosearch2";
            Panel nosearch2_2 = this.nosearch2;
            size1 = new Size(293, 21);
            Size size36 = size1;
            nosearch2_2.Size = size36;
            this.nosearch2.TabIndex = 8;
            this.nosearch2.Visible = false;
            this.Label2.AutoSize = true;
            this.Label2.Font = new Font("Segoe UI", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte)0);
            Label label2_1 = this.Label2;
            point1 = new Point(3, 0);
            Point point28 = point1;
            label2_1.Location = point28;
            this.Label2.Name = "Label2";
            Label label2_2 = this.Label2;
            size1 = new Size(172, 15);
            Size size37 = size1;
            label2_2.Size = size37;
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Your search returned no results.";
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.Font = new Font("Segoe UI", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte)0);
            this.LinkLabel1.LinkColor = Color.SteelBlue;
            LinkLabel linkLabel1_1 = this.LinkLabel1;
            point1 = new Point(175, 0);
            Point point29 = point1;
            linkLabel1_1.Location = point29;
            this.LinkLabel1.Name = "LinkLabel1";
            LinkLabel linkLabel1_2 = this.LinkLabel1;
            size1 = new Size(114, 15);
            Size size38 = size1;
            linkLabel1_2.Size = size38;
            this.LinkLabel1.TabIndex = 5;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "Try searching again.";
            this.grdCompletedJobs.AllowUserToAddRows = false;
            this.grdCompletedJobs.AllowUserToDeleteRows = false;
            this.grdCompletedJobs.AllowUserToOrderColumns = true;
            this.grdCompletedJobs.AllowUserToResizeRows = false;
            this.grdCompletedJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCompletedJobs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.grdCompletedJobs.BackgroundColor = SystemColors.Window;
            this.grdCompletedJobs.BorderStyle = BorderStyle.Fixed3D;
            this.grdCompletedJobs.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            this.grdCompletedJobs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.grdCompletedJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCompletedJobs.Dock = DockStyle.Fill;
            this.grdCompletedJobs.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.grdCompletedJobs.GridColor = SystemColors.ActiveBorder;
            DataGridView grdCompletedJobs1 = this.grdCompletedJobs;
            point1 = new Point(0, 0);
            Point point30 = point1;
            grdCompletedJobs1.Location = point30;
            this.grdCompletedJobs.MultiSelect = false;
            this.grdCompletedJobs.Name = "grdCompletedJobs";
            this.grdCompletedJobs.ReadOnly = true;
            this.grdCompletedJobs.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.grdCompletedJobs.RowHeadersVisible = false;
            this.grdCompletedJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView grdCompletedJobs2 = this.grdCompletedJobs;
            size1 = new Size(706, 364);
            Size size39 = size1;
            grdCompletedJobs2.Size = size39;
            this.grdCompletedJobs.StandardTab = true;
            this.grdCompletedJobs.TabIndex = 7;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            size1 = new Size(732, 480);
            this.ClientSize = size1;
            this.Controls.Add((Control)this.TableLayoutPanel1);
            this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Name = nameof(frmJobList);
            this.Text = "Manage Job Cards";
            this.TableLayoutPanel1.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.nosearch1.ResumeLayout(false);
            this.nosearch1.PerformLayout();
            ((ISupportInitialize)this.grdPendingJobs).EndInit();
            this.TabPage2.ResumeLayout(false);
            this.TableLayoutPanel2.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            this.nosearch2.ResumeLayout(false);
            this.nosearch2.PerformLayout();
            ((ISupportInitialize)this.grdCompletedJobs).EndInit();
            this.ResumeLayout(false);
        }

        internal virtual LookupButton lb
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lb;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lb = value;
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

        internal virtual SoftButton btnDelete
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnDelete;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnDelete_Click);
                if (this._btnDelete != null)
                    this._btnDelete.Click -= eventHandler;
                this._btnDelete = value;
                if (this._btnDelete == null)
                    return;
                this._btnDelete.Click += eventHandler;
            }
        }

        internal virtual SoftButton btnEdit
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnEdit;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnEdit_Click);
                if (this._btnEdit != null)
                    this._btnEdit.Click -= eventHandler;
                this._btnEdit = value;
                if (this._btnEdit == null)
                    return;
                this._btnEdit.Click += eventHandler;
            }
        }

        internal virtual Panel Panel1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Panel1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Panel1 = value;
            }
        }

        internal virtual Label lblnosearch
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblnosearch;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.lblnosearch_Click);
                if (this._lblnosearch != null)
                    this._lblnosearch.Click -= eventHandler;
                this._lblnosearch = value;
                if (this._lblnosearch == null)
                    return;
                this._lblnosearch.Click += eventHandler;
            }
        }

        internal virtual TextBox txtSearch
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtSearch;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.txtSearch_TextChanged);
                if (this._txtSearch != null)
                    this._txtSearch.TextChanged -= eventHandler;
                this._txtSearch = value;
                if (this._txtSearch == null)
                    return;
                this._txtSearch.TextChanged += eventHandler;
            }
        }

        internal virtual SoftButton btnNew
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnNew;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnNew_Click);
                if (this._btnNew != null)
                    this._btnNew.Click -= eventHandler;
                this._btnNew = value;
                if (this._btnNew == null)
                    return;
                this._btnNew.Click += eventHandler;
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

        internal virtual Panel nosearch1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._nosearch1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._nosearch1 = value;
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

        internal virtual LinkLabel lnkagain
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lnkagain;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkagain_LinkClicked);
                if (this._lnkagain != null)
                    this._lnkagain.LinkClicked -= clickedEventHandler;
                this._lnkagain = value;
                if (this._lnkagain == null)
                    return;
                this._lnkagain.LinkClicked += clickedEventHandler;
            }
        }

        internal virtual DataGridView grdPendingJobs
        {
            [DebuggerNonUserCode]
            get
            {
                return this._grdPendingJobs;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.grdPendingJobs_CellDoubleClick);
                DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.grdPendingJobs_CellContentClick);
                if (this._grdPendingJobs != null)
                {
                    this._grdPendingJobs.CellDoubleClick -= cellEventHandler1;
                    this._grdPendingJobs.CellContentClick -= cellEventHandler2;
                }
                this._grdPendingJobs = value;
                if (this._grdPendingJobs == null)
                    return;
                this._grdPendingJobs.CellDoubleClick += cellEventHandler1;
                this._grdPendingJobs.CellContentClick += cellEventHandler2;
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
                EventHandler eventHandler1 = new EventHandler(this.TabControl1_SelectedIndexChanged);
                EventHandler eventHandler2 = new EventHandler(this.TabControl1_TabIndexChanged);
                if (this._TabControl1 != null)
                {
                    this._TabControl1.SelectedIndexChanged -= eventHandler1;
                    this._TabControl1.TabIndexChanged -= eventHandler2;
                }
                this._TabControl1 = value;
                if (this._TabControl1 == null)
                    return;
                this._TabControl1.SelectedIndexChanged += eventHandler1;
                this._TabControl1.TabIndexChanged += eventHandler2;
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
                EventHandler eventHandler = new EventHandler(this.TabPage1_Click);
                if (this._TabPage1 != null)
                    this._TabPage1.Click -= eventHandler;
                this._TabPage1 = value;
                if (this._TabPage1 == null)
                    return;
                this._TabPage1.Click += eventHandler;
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

        internal virtual DataGridView grdCompletedJobs
        {
            [DebuggerNonUserCode]
            get
            {
                return this._grdCompletedJobs;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.grdCompletedJobs_CellDoubleClick);
                if (this._grdCompletedJobs != null)
                    this._grdCompletedJobs.CellDoubleClick -= cellEventHandler;
                this._grdCompletedJobs = value;
                if (this._grdCompletedJobs == null)
                    return;
                this._grdCompletedJobs.CellDoubleClick += cellEventHandler;
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

        internal virtual SoftButton btnAll
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnAll;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnAll_Click);
                if (this._btnAll != null)
                    this._btnAll.Click -= eventHandler;
                this._btnAll = value;
                if (this._btnAll == null)
                    return;
                this._btnAll.Click += eventHandler;
            }
        }

        internal virtual SoftButton btnMonth
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnMonth;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnMonth_Click);
                if (this._btnMonth != null)
                    this._btnMonth.Click -= eventHandler;
                this._btnMonth = value;
                if (this._btnMonth == null)
                    return;
                this._btnMonth.Click += eventHandler;
            }
        }

        internal virtual SoftButton btnWeek
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnWeek;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnWeek_Click);
                if (this._btnWeek != null)
                    this._btnWeek.Click -= eventHandler;
                this._btnWeek = value;
                if (this._btnWeek == null)
                    return;
                this._btnWeek.Click += eventHandler;
            }
        }

        internal virtual SoftButton btnToday
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnToday;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnToday_Click);
                if (this._btnToday != null)
                    this._btnToday.Click -= eventHandler;
                this._btnToday = value;
                if (this._btnToday == null)
                    return;
                this._btnToday.Click += eventHandler;
            }
        }

        internal virtual SoftButton btnClearSearch
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnClearSearch;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnClearSearch_Click);
                if (this._btnClearSearch != null)
                    this._btnClearSearch.Click -= eventHandler;
                this._btnClearSearch = value;
                if (this._btnClearSearch == null)
                    return;
                this._btnClearSearch.Click += eventHandler;
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

        internal virtual Panel nosearch2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._nosearch2;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._nosearch2 = value;
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

        internal virtual LinkLabel LinkLabel1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._LinkLabel1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkagain_LinkClicked);
                if (this._LinkLabel1 != null)
                    this._LinkLabel1.LinkClicked -= clickedEventHandler;
                this._LinkLabel1 = value;
                if (this._LinkLabel1 == null)
                    return;
                this._LinkLabel1.LinkClicked += clickedEventHandler;
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

        public void GetPendingJobs()
        {
            label_0:
            int num1 = default(int);
            int num2 = default(int);
            try
            {
                ProjectData.ClearProjectError();
                num1 = -2;
                label_1:
                int num3 = 2;
                this.grdPendingJobs.DataSource = (object)this.dboJob.GetPending();
                label_2:
                num3 = 3;
                this.grdPendingJobs.Columns[0].Visible = false;
                label_3:
                num3 = 4;
                this.txtSearch.Text = "";
                label_4:
                num3 = 5;
                this.CheckList();
                goto label_11;
                label_6:
                num2 = num3;
                switch (num1 > -2 ? num1 : 1)
                {
                    case 1:
                        int num4 = num2 + 1;
                        num2 = 0;
                        switch (num4)
                        {
                            case 1:
                                goto label_0;
                            case 2:
                                goto label_1;
                            case 3:
                                goto label_2;
                            case 4:
                                goto label_3;
                            case 5:
                                goto label_4;
                            case 6:
                                goto label_11;
                        }
                }
            }
            catch (Exception ex) when (ex is Exception & (uint)num1 > 0U & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
                //goto label_6;
            }
            throw ProjectData.CreateProjectError(-2146828237);
            label_11:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void GetCompletedJobs(Reytec.JobCard.DAL.JobCard.CompletedListType filter = Reytec.JobCard.DAL.JobCard.CompletedListType.Today)
        {
            label_0:
            int num1 = default(int);
            int num2 = default(int);
            try
            {
                ProjectData.ClearProjectError();
                num1 = -2;
                label_1:
                int num3 = 2;
                this.grdCompletedJobs.DataSource = (object)this.dboJob.GetCompleted(filter);
                label_2:
                num3 = 3;
                this.grdCompletedJobs.Columns[0].Visible = false;
                label_3:
                num3 = 4;
                this.txtSearch.Text = "";
                label_4:
                num3 = 5;
                this.CheckList();
                goto label_11;
                label_6:
                num2 = num3;
                switch (num1 > -2 ? num1 : 1)
                {
                    case 1:
                        int num4 = num2 + 1;
                        num2 = 0;
                        switch (num4)
                        {
                            case 1:
                                goto label_0;
                            case 2:
                                goto label_1;
                            case 3:
                                goto label_2;
                            case 4:
                                goto label_3;
                            case 5:
                                goto label_4;
                            case 6:
                                goto label_11;
                        }
                }
            }
            catch (Exception ex) when (ex is Exception & (uint)num1 > 0U & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
                //goto label_6;
            }
            throw ProjectData.CreateProjectError(-2146828237);
            label_11:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void frmTaskList_Load(object sender, EventArgs e)
        {
        }

        private void dtTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtTasks_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void dtTasks_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void t_TextChanged(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int num = (int)new frmJobDetail(-1).ShowDialog();
        }

        public void ResetAllButtons()
        {
            this.btnToday.ButtonStyle = SoftButton.Style.Flat;
            this.btnWeek.ButtonStyle = SoftButton.Style.Flat;
            this.btnMonth.ButtonStyle = SoftButton.Style.Flat;
            this.btnAll.ButtonStyle = SoftButton.Style.Flat;
            this.txtSearch.Text = "";
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            this.ResetAllButtons();
            this.btnToday.ButtonStyle = SoftButton.Style.Default;
            this.filter = Reytec.JobCard.DAL.JobCard.CompletedListType.Today;
            this.GetCompletedJobs(this.filter);
            this.CheckList();
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            this.ResetAllButtons();
            this.btnWeek.ButtonStyle = SoftButton.Style.Default;
            this.filter = Reytec.JobCard.DAL.JobCard.CompletedListType.Week;
            this.GetCompletedJobs(this.filter);
            this.CheckList();
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            this.ResetAllButtons();
            this.btnMonth.ButtonStyle = SoftButton.Style.Default;
            this.filter = Reytec.JobCard.DAL.JobCard.CompletedListType.Month;
            this.GetCompletedJobs(this.filter);
            this.CheckList();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            this.ResetAllButtons();
            this.btnAll.ButtonStyle = SoftButton.Style.Default;
            this.filter = Reytec.JobCard.DAL.JobCard.CompletedListType.All;
            this.GetCompletedJobs(this.filter);
            this.CheckList();
        }

        public void editPendingJob()
        {
            int num = (int)new frmJobDetail(Conversions.ToInteger(this.grdPendingJobs.SelectedRows[0].Cells[0].Value)).ShowDialog((IWin32Window)this);
            this.GetPendingJobs();
        }

        public void editCompletedJob()
        {
            int num = (int)new frmJobDetail(Conversions.ToInteger(this.grdCompletedJobs.SelectedRows[0].Cells[0].Value)).ShowDialog((IWin32Window)this);
            this.GetCompletedJobs(this.filter);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.TabControl1.SelectedIndex == 0)
                this.editPendingJob();
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(SystemUserGeneric.isUserAdmin(JobFunctions.LoggedUserID, ConnectionInfo.GlobalConnection), (object)false, false))
            {
                frmPassword frmPassword = new frmPassword();
                if (frmPassword.ValidateAdministrator(JobFunctions.LoggedUserID))
                {
                    if (frmPassword.isCanceled)
                        return;
                    this.editCompletedJob();
                }
                else
                {
                    if (frmPassword.isCanceled)
                        return;
                    MessageBox.Show($"Invalid password!", "Authentication failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                this.editCompletedJob();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int num = (int)new frmJobDetail(-1).ShowDialog((IWin32Window)this);
            this.GetPendingJobs();
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.TabControl1.SelectedIndex == 0)
                this.GetPendingJobs();
            else
                this.GetCompletedJobs(this.filter);
            this.CheckList();
        }

        private void TabControl1_TabIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (this.TabControl1.SelectedIndex == 0)
            {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearch.Text, "", false) != 0)
                {
                    DataView dataView = new DataView(this.dboJob.GetPending());
                    dataView.RowFilter = JobFunctions.DoSearch(dataView.Table, this.txtSearch.Text);
                    this.grdPendingJobs.DataSource = (object)dataView;
                    this.lblnosearch.Visible = false;
                }
                else
                {
                    this.lblnosearch.Visible = true;
                    this.GetPendingJobs();
                }
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearch.Text, "", false) != 0)
            {
                DataView dataView = new DataView(this.dboJob.GetCompleted(Reytec.JobCard.DAL.JobCard.CompletedListType.All));
                dataView.RowFilter = JobFunctions.DoSearch(dataView.Table, this.txtSearch.Text);
                this.grdCompletedJobs.DataSource = (object)dataView;
                this.lblnosearch.Visible = false;
            }
            else
            {
                this.lblnosearch.Visible = true;
                this.GetCompletedJobs(this.filter);
            }
            this.CheckList();
        }

        public void CheckList()
        {
            if (this.TabControl1.SelectedIndex == 0)
            {
                if (this.grdPendingJobs.Rows.Count == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearch.Text, "", false) != 0)
                    this.nosearch1.Visible = true;
                else
                    this.nosearch1.Visible = false;
                if (this.grdPendingJobs.Rows.Count == 0)
                {
                    this.btnEdit.Enabled = false;
                    this.btnDelete.Enabled = false;
                    this.btnPrint.Enabled = false;
                }
                else
                {
                    this.btnDelete.Enabled = true;
                    this.btnPrint.Enabled = true;
                    this.btnEdit.Enabled = true;
                }
            }
            else
            {
                if (this.grdCompletedJobs.Rows.Count == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearch.Text, "", false) != 0)
                    this.nosearch2.Visible = true;
                else
                    this.nosearch2.Visible = false;
                if (this.grdCompletedJobs.Rows.Count == 0)
                {
                    this.btnEdit.Enabled = false;
                    this.btnDelete.Enabled = false;
                    this.btnPrint.Enabled = false;
                }
                else
                {
                    this.btnDelete.Enabled = true;
                    this.btnPrint.Enabled = true;
                    this.btnEdit.Enabled = true;
                }
            }
        }

        private void lnkagain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.txtSearch.Text = "";
            this.CheckList();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            this.txtSearch.Text = "";
            this.CheckList();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmPrint frmPrint = this.TabControl1.SelectedIndex != 0 ? new frmPrint(1, RuntimeHelpers.GetObjectValue(this.grdCompletedJobs.SelectedRows[0].Cells[0].Value), false) : new frmPrint(1, RuntimeHelpers.GetObjectValue(this.grdPendingJobs.SelectedRows[0].Cells[0].Value), false);
            int num = (int)frmPrint.ShowDialog((IWin32Window)this);
            frmPrint.Dispose();
        }

        private void lblnosearch_Click(object sender, EventArgs e)
        {
            this.txtSearch.Focus();
        }

        private void grdPendingJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void grdPendingJobs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnEdit_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs)e);
        }

        private void grdCompletedJobs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnEdit_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs)e);
        }

        public frmJobList()
        {
            this.Load += new EventHandler(this.frmTaskList_Load);
            this.dboJob = new Reytec.JobCard.DAL.JobCard(ConnectionInfo.GlobalConnection);
            this.filter = Reytec.JobCard.DAL.JobCard.CompletedListType.Today;
            this.InitializeComponent();
            this.GetPendingJobs();
            this.CheckList();
        }

        public void DeleteJob()
        {
            ;
            if (MessageBox.Show($"This Job Card will be permanently deleted. Are you sure you want to do this?", "Delete job card", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
                return;
            if (this.TabControl1.SelectedIndex == 0)
            {
                this.dboJob.Delete(RuntimeHelpers.GetObjectValue(this.grdPendingJobs.SelectedRows[0].Cells[0].Value));
                this.GetPendingJobs();
            }
            else
            {
                this.dboJob.Delete(RuntimeHelpers.GetObjectValue(this.grdCompletedJobs.SelectedRows[0].Cells[0].Value));
                this.GetCompletedJobs(this.filter);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(SystemUserGeneric.isUserAdmin(JobFunctions.LoggedUserID, ConnectionInfo.GlobalConnection), (object)false, false))
            {
                frmPassword frmPassword = new frmPassword();
                if (frmPassword.ValidateAdministrator(JobFunctions.LoggedUserID))
                {
                    if (frmPassword.isCanceled)
                        return;
                    this.DeleteJob();
                }
                else
                {
                    if (frmPassword.isCanceled)
                        return;
                    MessageBox.Show($"Invalid password!", "Authentication failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                this.DeleteJob();
        }
    }
}
