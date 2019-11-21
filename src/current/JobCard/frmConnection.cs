// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.Core.frmConnection
// Assembly: JobCard, Version=1.0.0.2, Culture=neutral, PublicKeyToken=null
// MVID: 355A629F-A2FA-4599-879B-59162A296DD0
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCard.exe

using Jobcard.Core;
using Jobcard.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Reytec.GUI.Controls;
using Reytec.JobCard.DAL;
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
    public class frmConnection : Form
    {
        private IContainer components;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("lstCompanies")]
        private ListView _lstCompanies;
        [AccessedThroughProperty("ImageList1")]
        private ImageList _ImageList1;
        [AccessedThroughProperty("chkAuto")]
        private CheckBox _chkAuto;
        [AccessedThroughProperty("btnOpenCo")]
        private SoftButton _btnOpenCo;
        [AccessedThroughProperty("btnNewCo")]
        private SoftButton _btnNewCo;
        [AccessedThroughProperty("Panel3")]
        private Panel _Panel3;
        [AccessedThroughProperty("btnDelete")]
        private SoftButton _btnDelete;
        [AccessedThroughProperty("VistaButton3")]
        private SoftButton _VistaButton3;
        [AccessedThroughProperty("VistaButton4")]
        private SoftButton _VistaButton4;
        [AccessedThroughProperty("Panel1")]
        private Panel _Panel1;
        [AccessedThroughProperty("TableLayoutPanel1")]
        private TableLayoutPanel _TableLayoutPanel1;
        [AccessedThroughProperty("TableLayoutPanel2")]
        private TableLayoutPanel _TableLayoutPanel2;
        [AccessedThroughProperty("Panel4")]
        private Panel _Panel4;
        [AccessedThroughProperty("Panel2")]
        private Panel _Panel2;
        [AccessedThroughProperty("Panel5")]
        private Panel _Panel5;
        [AccessedThroughProperty("ContextMenuStrip1")]
        private ContextMenuStrip _ContextMenuStrip1;
        [AccessedThroughProperty("RtytryryrytToolStripMenuItem")]
        private ToolStripMenuItem _RtytryryrytToolStripMenuItem;
        [AccessedThroughProperty("DeleteToolStripMenuItem")]
        private ToolStripMenuItem _DeleteToolStripMenuItem;
        [AccessedThroughProperty("btnAddCompanyShortcut")]
        private SoftButton _btnAddCompanyShortcut;
        [AccessedThroughProperty("SoftButton1")]
        private SoftButton _SoftButton1;
        [AccessedThroughProperty("dlgOpen")]
        private OpenFileDialog _dlgOpen;
        [AccessedThroughProperty("dlgSave")]
        private SaveFileDialog _dlgSave;
        private string CompanyFilename;
        private string ServerName;
        private string DatabaseName;
        private JobCardCompany companyDataHelper;
        private readonly ICompanyConnectionRepository companyConnectionRepository;

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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmConnection));
            this.Label1 = new Label();
            this.companyListView = new ListView();
            this.ContextMenuStrip1 = new ContextMenuStrip(this.components);
            this.ImageList1 = new ImageList(this.components);
            this.chkAuto = new CheckBox();
            this.TableLayoutPanel1 = new TableLayoutPanel();
            this.TableLayoutPanel2 = new TableLayoutPanel();
            this.Panel4 = new Panel();
            this.VistaButton4 = new SoftButton();
            this.Panel2 = new Panel();
            this.Panel5 = new Panel();
            this.Panel3 = new Panel();
            this.SoftButton1 = new SoftButton();
            this.btnAddCompanyShortcut = new SoftButton();
            this.Panel1 = new Panel();
            this.VistaButton3 = new SoftButton();
            this.btnDelete = new SoftButton();
            this.btnOpenCo = new SoftButton();
            this.btnNewCo = new SoftButton();
            this.RtytryryrytToolStripMenuItem = new ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new ToolStripMenuItem();
            this.dlgOpen = new OpenFileDialog();
            this.dlgSave = new SaveFileDialog();
            this.TableLayoutPanel1.SuspendLayout();
            this.TableLayoutPanel2.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            this.Label1.AutoSize = true;
            Label label1_1 = this.Label1;
            Point point1 = new Point(-1, 0);
            Point point2 = point1;
            label1_1.Location = point2;
            this.Label1.Name = "Label1";
            Label label1_2 = this.Label1;
            Size size1 = new Size(442, 13);
            Size size2 = size1;
            label1_2.Size = size2;
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Here are the companies availabe to you. Select a company and click 'Connect' to work in it:";
            this.companyListView.Activation = ItemActivation.OneClick;
            this.companyListView.ContextMenuStrip = this.ContextMenuStrip1;
            this.companyListView.Dock = DockStyle.Fill;
            this.companyListView.HideSelection = false;
            this.companyListView.LargeImageList = this.ImageList1;
            ListView lstCompanies1 = this.companyListView;
            point1 = new Point(0, 0);
            Point point3 = point1;
            lstCompanies1.Location = point3;
            this.companyListView.MultiSelect = false;
            this.companyListView.Name = "lstCompanies";
            ListView lstCompanies2 = this.companyListView;
            size1 = new Size(665, 427);
            Size size3 = size1;
            lstCompanies2.Size = size3;
            this.companyListView.TabIndex = 4;
            ListView lstCompanies3 = this.companyListView;
            size1 = new Size(200, 56);
            Size size4 = size1;
            lstCompanies3.TileSize = size4;
            this.companyListView.UseCompatibleStateImageBehavior = false;
            this.companyListView.View = View.Tile;
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            ContextMenuStrip contextMenuStrip1 = this.ContextMenuStrip1;
            size1 = new Size(61, 4);
            Size size5 = size1;
            contextMenuStrip1.Size = size5;
            this.ImageList1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream");
            this.ImageList1.TransparentColor = Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "warehouse.png");
            this.ImageList1.Images.SetKeyName(1, "warehousedefault.png");
            this.chkAuto.AutoSize = true;
            CheckBox chkAuto1 = this.chkAuto;
            point1 = new Point(0, 16);
            Point point4 = point1;
            chkAuto1.Location = point4;
            this.chkAuto.Name = "chkAuto";
            CheckBox chkAuto2 = this.chkAuto;
            size1 = new Size(349, 17);
            Size size6 = size1;
            chkAuto2.Size = size6;
            this.chkAuto.TabIndex = 7;
            this.chkAuto.Text = "Automatically open the selected company when I start the program";
            this.chkAuto.UseVisualStyleBackColor = true;
            this.TableLayoutPanel1.BackColor = SystemColors.Control;
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.TableLayoutPanel1.Controls.Add((Control)this.TableLayoutPanel2, 0, 0);
            this.TableLayoutPanel1.Controls.Add((Control)this.Panel5, 0, 1);
            this.TableLayoutPanel1.Dock = DockStyle.Fill;
            TableLayoutPanel tableLayoutPanel1_1 = this.TableLayoutPanel1;
            point1 = new Point(0, 35);
            Point point5 = point1;
            tableLayoutPanel1_1.Location = point5;
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 2;
            this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43f));
            this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            TableLayoutPanel tableLayoutPanel1_2 = this.TableLayoutPanel1;
            size1 = new Size(671, 476);
            Size size7 = size1;
            tableLayoutPanel1_2.Size = size7;
            this.TableLayoutPanel1.TabIndex = 15;
            this.TableLayoutPanel2.ColumnCount = 2;
            this.TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84.66165f));
            this.TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.33835f));
            this.TableLayoutPanel2.Controls.Add((Control)this.Panel4, 1, 0);
            this.TableLayoutPanel2.Controls.Add((Control)this.Panel2, 0, 0);
            this.TableLayoutPanel2.Dock = DockStyle.Fill;
            TableLayoutPanel tableLayoutPanel2_1 = this.TableLayoutPanel2;
            point1 = new Point(3, 3);
            Point point6 = point1;
            tableLayoutPanel2_1.Location = point6;
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 1;
            this.TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
            TableLayoutPanel tableLayoutPanel2_2 = this.TableLayoutPanel2;
            size1 = new Size(665, 37);
            Size size8 = size1;
            tableLayoutPanel2_2.Size = size8;
            this.TableLayoutPanel2.TabIndex = 5;
            this.Panel4.Controls.Add((Control)this.VistaButton4);
            this.Panel4.Dock = DockStyle.Right;
            Panel panel4_1 = this.Panel4;
            point1 = new Point(565, 3);
            Point point7 = point1;
            panel4_1.Location = point7;
            this.Panel4.Name = "Panel4";
            Panel panel4_2 = this.Panel4;
            size1 = new Size(97, 31);
            Size size9 = size1;
            panel4_2.Size = size9;
            this.Panel4.TabIndex = 16;
            this.VistaButton4.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.VistaButton4.BackColor = Color.Transparent;
            this.VistaButton4.BaseColor = SystemColors.ButtonFace;
            this.VistaButton4.ButtonColor = SystemColors.ButtonShadow;
            this.VistaButton4.ButtonText = "Refresh";
            this.VistaButton4.CornerRadius = 3;
            this.VistaButton4.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.VistaButton4.ForeColor = SystemColors.ControlText;
            this.VistaButton4.Glow2Color = Color.White;
            this.VistaButton4.GlowColor = SystemColors.Info;
            this.VistaButton4.HighlightColor = SystemColors.ControlLightLight;
            this.VistaButton4.Image = (Image)componentResourceManager.GetObject("VistaButton4.Image");
            SoftButton vistaButton4_1 = this.VistaButton4;
            size1 = new Size(16, 16);
            Size size10 = size1;
            vistaButton4_1.ImageSize = size10;
            SoftButton vistaButton4_2 = this.VistaButton4;
            point1 = new Point(18, 0);
            Point point8 = point1;
            vistaButton4_2.Location = point8;
            SoftButton vistaButton4_3 = this.VistaButton4;
            Padding padding1 = new Padding(0);
            Padding padding2 = padding1;
            vistaButton4_3.Margin = padding2;
            this.VistaButton4.Name = "VistaButton4";
            SoftButton vistaButton4_4 = this.VistaButton4;
            size1 = new Size(79, 30);
            Size size11 = size1;
            vistaButton4_4.Size = size11;
            this.VistaButton4.TabIndex = 14;
            this.VistaButton4.TextAlign = ContentAlignment.MiddleRight;
            this.Panel2.Controls.Add((Control)this.Label1);
            this.Panel2.Controls.Add((Control)this.chkAuto);
            this.Panel2.Dock = DockStyle.Fill;
            Panel panel2_1 = this.Panel2;
            point1 = new Point(3, 3);
            Point point9 = point1;
            panel2_1.Location = point9;
            this.Panel2.Name = "Panel2";
            Panel panel2_2 = this.Panel2;
            size1 = new Size(556, 31);
            Size size12 = size1;
            panel2_2.Size = size12;
            this.Panel2.TabIndex = 0;
            this.Panel5.Controls.Add((Control)this.companyListView);
            this.Panel5.Dock = DockStyle.Fill;
            Panel panel5_1 = this.Panel5;
            point1 = new Point(3, 46);
            Point point10 = point1;
            panel5_1.Location = point10;
            this.Panel5.Name = "Panel5";
            Panel panel5_2 = this.Panel5;
            size1 = new Size(665, 427);
            Size size13 = size1;
            panel5_2.Size = size13;
            this.Panel5.TabIndex = 6;
            this.Panel3.BackColor = Color.Transparent;
            //this.Panel3.BackgroundImage = (Image) Reytec.JobCard.Core.My.Resources.Resources.toolbackt;
            this.Panel3.Controls.Add((Control)this.SoftButton1);
            this.Panel3.Controls.Add((Control)this.btnAddCompanyShortcut);
            this.Panel3.Controls.Add((Control)this.Panel1);
            this.Panel3.Controls.Add((Control)this.btnDelete);
            this.Panel3.Controls.Add((Control)this.btnOpenCo);
            this.Panel3.Controls.Add((Control)this.btnNewCo);
            this.Panel3.Dock = DockStyle.Top;
            Panel panel3_1 = this.Panel3;
            point1 = new Point(0, 0);
            Point point11 = point1;
            panel3_1.Location = point11;
            Panel panel3_2 = this.Panel3;
            padding1 = new Padding(0);
            Padding padding3 = padding1;
            panel3_2.Margin = padding3;
            this.Panel3.Name = "Panel3";
            Panel panel3_3 = this.Panel3;
            size1 = new Size(671, 35);
            Size size14 = size1;
            panel3_3.Size = size14;
            this.Panel3.TabIndex = 3;
            this.SoftButton1.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.SoftButton1.BackColor = Color.Transparent;
            this.SoftButton1.BaseColor = Color.FromArgb(33, 124, 180);
            this.SoftButton1.ButtonColor = Color.FromArgb(23, 87, 125);
            this.SoftButton1.ButtonStyle = SoftButton.Style.Flat;
            this.SoftButton1.ButtonText = "Export...";
            this.SoftButton1.CornerRadius = 3;
            this.SoftButton1.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.SoftButton1.Glow2Color = Color.FromArgb(209, 242, 250);
            this.SoftButton1.GlowColor = Color.FromArgb(192, (int)byte.MaxValue, (int)byte.MaxValue);
            this.SoftButton1.HighlightColor = Color.FromArgb(192, 222, 254);
            //this.SoftButton1.Image = (Image) Reytec.JobCard.Core.My.Resources.Resources.DoubleRightArrowHS1;
            SoftButton softButton1_1 = this.SoftButton1;
            size1 = new Size(16, 16);
            Size size15 = size1;
            softButton1_1.ImageSize = size15;
            SoftButton softButton1_2 = this.SoftButton1;
            point1 = new Point(433, 3);
            Point point12 = point1;
            softButton1_2.Location = point12;
            SoftButton softButton1_3 = this.SoftButton1;
            padding1 = new Padding(0);
            Padding padding4 = padding1;
            softButton1_3.Margin = padding4;
            this.SoftButton1.Name = "SoftButton1";
            this.SoftButton1.ShadowColor = Color.Black;
            SoftButton softButton1_4 = this.SoftButton1;
            size1 = new Size(81, 30);
            Size size16 = size1;
            softButton1_4.Size = size16;
            this.SoftButton1.TabIndex = 43;
            this.SoftButton1.TextAlign = ContentAlignment.MiddleRight;
            this.btnAddCompanyShortcut.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnAddCompanyShortcut.BackColor = Color.Transparent;
            this.btnAddCompanyShortcut.BaseColor = Color.FromArgb(33, 124, 180);
            this.btnAddCompanyShortcut.ButtonColor = Color.FromArgb(23, 87, 125);
            this.btnAddCompanyShortcut.ButtonStyle = SoftButton.Style.Flat;
            this.btnAddCompanyShortcut.ButtonText = "Add Shortcut";
            this.btnAddCompanyShortcut.CornerRadius = 3;
            this.btnAddCompanyShortcut.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnAddCompanyShortcut.Glow2Color = Color.FromArgb(209, 242, 250);
            this.btnAddCompanyShortcut.GlowColor = Color.FromArgb(192, (int)byte.MaxValue, (int)byte.MaxValue);
            this.btnAddCompanyShortcut.HighlightColor = Color.FromArgb(192, 222, 254);
            // this.btnAddCompanyShortcut.Image = (Image) Reytec.JobCard.Core.My.Resources.Resources.Annotation_New1;
            SoftButton addCompanyShortcut1 = this.btnAddCompanyShortcut;
            size1 = new Size(16, 16);
            Size size17 = size1;
            addCompanyShortcut1.ImageSize = size17;
            SoftButton addCompanyShortcut2 = this.btnAddCompanyShortcut;
            point1 = new Point(157, 3);
            Point point13 = point1;
            addCompanyShortcut2.Location = point13;
            SoftButton addCompanyShortcut3 = this.btnAddCompanyShortcut;
            padding1 = new Padding(0);
            Padding padding5 = padding1;
            addCompanyShortcut3.Margin = padding5;
            this.btnAddCompanyShortcut.Name = "btnAddCompanyShortcut";
            this.btnAddCompanyShortcut.ShadowColor = Color.Black;
            SoftButton addCompanyShortcut4 = this.btnAddCompanyShortcut;
            size1 = new Size(107, 30);
            Size size18 = size1;
            addCompanyShortcut4.Size = size18;
            this.btnAddCompanyShortcut.TabIndex = 42;
            this.btnAddCompanyShortcut.TextAlign = ContentAlignment.MiddleRight;
            this.Panel1.Controls.Add((Control)this.VistaButton3);
            this.Panel1.Dock = DockStyle.Right;
            Panel panel1_1 = this.Panel1;
            point1 = new Point(590, 0);
            Point point14 = point1;
            panel1_1.Location = point14;
            this.Panel1.Name = "Panel1";
            Panel panel1_2 = this.Panel1;
            size1 = new Size(81, 35);
            Size size19 = size1;
            panel1_2.Size = size19;
            this.Panel1.TabIndex = 41;
            this.VistaButton3.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.VistaButton3.BackColor = Color.Transparent;
            this.VistaButton3.BaseColor = Color.FromArgb(33, 124, 180);
            this.VistaButton3.ButtonColor = Color.FromArgb(23, 87, 125);
            this.VistaButton3.ButtonStyle = SoftButton.Style.Flat;
            this.VistaButton3.ButtonText = "Help";
            this.VistaButton3.CornerRadius = 3;
            this.VistaButton3.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.VistaButton3.Glow2Color = Color.FromArgb(209, 242, 250);
            this.VistaButton3.GlowColor = Color.FromArgb(192, (int)byte.MaxValue, (int)byte.MaxValue);
            this.VistaButton3.HighlightColor = Color.FromArgb(192, 222, 254);
            this.VistaButton3.Image = (Image)componentResourceManager.GetObject("VistaButton3.Image");
            SoftButton vistaButton3_1 = this.VistaButton3;
            size1 = new Size(16, 16);
            Size size20 = size1;
            vistaButton3_1.ImageSize = size20;
            SoftButton vistaButton3_2 = this.VistaButton3;
            point1 = new Point(10, 3);
            Point point15 = point1;
            vistaButton3_2.Location = point15;
            this.VistaButton3.Name = "VistaButton3";
            this.VistaButton3.ShadowColor = Color.Black;
            SoftButton vistaButton3_3 = this.VistaButton3;
            size1 = new Size(65, 29);
            Size size21 = size1;
            vistaButton3_3.Size = size21;
            this.VistaButton3.TabIndex = 40;
            this.VistaButton3.TextAlign = ContentAlignment.MiddleRight;
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
            this.btnDelete.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
            SoftButton btnDelete1 = this.btnDelete;
            size1 = new Size(16, 16);
            Size size22 = size1;
            btnDelete1.ImageSize = size22;
            SoftButton btnDelete2 = this.btnDelete;
            point1 = new Point(357, 3);
            Point point16 = point1;
            btnDelete2.Location = point16;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowColor = Color.Black;
            SoftButton btnDelete3 = this.btnDelete;
            size1 = new Size(73, 30);
            Size size23 = size1;
            btnDelete3.Size = size23;
            this.btnDelete.TabIndex = 38;
            this.btnDelete.TextAlign = ContentAlignment.MiddleRight;
            this.btnOpenCo.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnOpenCo.BackColor = Color.Transparent;
            this.btnOpenCo.BaseColor = Color.FromArgb(33, 124, 180);
            this.btnOpenCo.ButtonColor = Color.FromArgb(23, 87, 125);
            this.btnOpenCo.ButtonStyle = SoftButton.Style.Flat;
            this.btnOpenCo.ButtonText = "Connect";
            this.btnOpenCo.CornerRadius = 3;
            this.btnOpenCo.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.btnOpenCo.Glow2Color = Color.FromArgb(209, 242, 250);
            this.btnOpenCo.GlowColor = Color.FromArgb(192, (int)byte.MaxValue, (int)byte.MaxValue);
            this.btnOpenCo.HighlightColor = Color.FromArgb(192, 222, 254);
            this.btnOpenCo.Image = (Image)componentResourceManager.GetObject("btnOpenCo.Image");
            SoftButton btnOpenCo1 = this.btnOpenCo;
            size1 = new Size(16, 16);
            Size size24 = size1;
            btnOpenCo1.ImageSize = size24;
            SoftButton btnOpenCo2 = this.btnOpenCo;
            point1 = new Point(267, 3);
            Point point17 = point1;
            btnOpenCo2.Location = point17;
            this.btnOpenCo.Name = "btnOpenCo";
            this.btnOpenCo.ShadowColor = Color.Black;
            SoftButton btnOpenCo3 = this.btnOpenCo;
            size1 = new Size(84, 30);
            Size size25 = size1;
            btnOpenCo3.Size = size25;
            this.btnOpenCo.TabIndex = 14;
            this.btnOpenCo.TextAlign = ContentAlignment.MiddleRight;
            this.btnNewCo.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnNewCo.BackColor = Color.Transparent;
            this.btnNewCo.BaseColor = Color.FromArgb(33, 124, 180);
            this.btnNewCo.ButtonColor = Color.FromArgb(23, 87, 125);
            this.btnNewCo.ButtonStyle = SoftButton.Style.Flat;
            this.btnNewCo.ButtonText = "Create new Company";
            this.btnNewCo.CornerRadius = 3;
            this.btnNewCo.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnNewCo.Glow2Color = Color.FromArgb(209, 242, 250);
            this.btnNewCo.GlowColor = Color.FromArgb(192, (int)byte.MaxValue, (int)byte.MaxValue);
            this.btnNewCo.HighlightColor = Color.FromArgb(192, 222, 254);
            // this.btnNewCo.Image = (Image) Reytec.JobCard.Core.My.Resources.Resources.warehousenew;
            SoftButton btnNewCo1 = this.btnNewCo;
            size1 = new Size(16, 16);
            Size size26 = size1;
            btnNewCo1.ImageSize = size26;
            SoftButton btnNewCo2 = this.btnNewCo;
            point1 = new Point(7, 3);
            Point point18 = point1;
            btnNewCo2.Location = point18;
            SoftButton btnNewCo3 = this.btnNewCo;
            padding1 = new Padding(0);
            Padding padding6 = padding1;
            btnNewCo3.Margin = padding6;
            this.btnNewCo.Name = "btnNewCo";
            this.btnNewCo.ShadowColor = Color.Black;
            SoftButton btnNewCo4 = this.btnNewCo;
            size1 = new Size(150, 30);
            Size size27 = size1;
            btnNewCo4.Size = size27;
            this.btnNewCo.TabIndex = 13;
            this.btnNewCo.TextAlign = ContentAlignment.MiddleRight;
            this.RtytryryrytToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("RtytryryrytToolStripMenuItem.Image");
            this.RtytryryrytToolStripMenuItem.Name = "RtytryryrytToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem1 = this.RtytryryrytToolStripMenuItem;
            size1 = new Size(152, 22);
            Size size28 = size1;
            toolStripMenuItem1.Size = size28;
            this.RtytryryrytToolStripMenuItem.Text = "Connect";
            this.DeleteToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("DeleteToolStripMenuItem.Image");
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem2 = this.DeleteToolStripMenuItem;
            size1 = new Size(152, 22);
            Size size29 = size1;
            toolStripMenuItem2.Size = size29;
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.dlgOpen.Filter = "Reytec JobCard Company File|*.jcc";
            this.dlgOpen.Title = "Add Company Shortcut";
            this.dlgSave.Filter = "Reytec JobCard Company File|*.jcc";
            this.dlgSave.Title = "Export Company Shortcut";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            size1 = new Size(671, 511);
            this.ClientSize = size1;
            this.Controls.Add((Control)this.TableLayoutPanel1);
            this.Controls.Add((Control)this.Panel3);
            this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = nameof(frmConnection);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Manage Companies";
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel2.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel5.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
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

        internal virtual ListView companyListView
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lstCompanies;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.lstCompanies_SelectedIndexChanged);
                ListViewItemSelectionChangedEventHandler changedEventHandler = new ListViewItemSelectionChangedEventHandler(this.lstCompanies_ItemSelectionChanged);
                if (this._lstCompanies != null)
                {
                    this._lstCompanies.SelectedIndexChanged -= eventHandler;
                    this._lstCompanies.ItemSelectionChanged -= changedEventHandler;
                }
                this._lstCompanies = value;
                if (this._lstCompanies == null)
                    return;
                this._lstCompanies.SelectedIndexChanged += eventHandler;
                this._lstCompanies.ItemSelectionChanged += changedEventHandler;
            }
        }

        internal virtual ImageList ImageList1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ImageList1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ImageList1 = value;
            }
        }

        internal virtual CheckBox chkAuto
        {
            [DebuggerNonUserCode]
            get
            {
                return this._chkAuto;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.chkAuto_CheckedChanged);
                if (this._chkAuto != null)
                    this._chkAuto.CheckedChanged -= eventHandler;
                this._chkAuto = value;
                if (this._chkAuto == null)
                    return;
                this._chkAuto.CheckedChanged += eventHandler;
            }
        }

        internal virtual SoftButton btnOpenCo
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnOpenCo;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnOpenCo_Click);
                if (this._btnOpenCo != null)
                    this._btnOpenCo.Click -= eventHandler;
                this._btnOpenCo = value;
                if (this._btnOpenCo == null)
                    return;
                this._btnOpenCo.Click += eventHandler;
            }
        }

        internal virtual SoftButton btnNewCo
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnNewCo;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnNewCo_Click);
                if (this._btnNewCo != null)
                    this._btnNewCo.Click -= eventHandler;
                this._btnNewCo = value;
                if (this._btnNewCo == null)
                    return;
                this._btnNewCo.Click += eventHandler;
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

        internal virtual SoftButton VistaButton3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._VistaButton3;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._VistaButton3 = value;
            }
        }

        internal virtual SoftButton VistaButton4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._VistaButton4;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.VistaButton4_Click);
                if (this._VistaButton4 != null)
                    this._VistaButton4.Click -= eventHandler;
                this._VistaButton4 = value;
                if (this._VistaButton4 == null)
                    return;
                this._VistaButton4.Click += eventHandler;
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

        internal virtual ContextMenuStrip ContextMenuStrip1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ContextMenuStrip1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ContextMenuStrip1 = value;
            }
        }

        internal virtual ToolStripMenuItem RtytryryrytToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._RtytryryrytToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._RtytryryrytToolStripMenuItem = value;
            }
        }

        internal virtual ToolStripMenuItem DeleteToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DeleteToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DeleteToolStripMenuItem = value;
            }
        }

        internal virtual SoftButton btnAddCompanyShortcut
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnAddCompanyShortcut;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnAddCompanyShortcut_Click);
                if (this._btnAddCompanyShortcut != null)
                    this._btnAddCompanyShortcut.Click -= eventHandler;
                this._btnAddCompanyShortcut = value;
                if (this._btnAddCompanyShortcut == null)
                    return;
                this._btnAddCompanyShortcut.Click += eventHandler;
            }
        }

        internal virtual SoftButton SoftButton1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._SoftButton1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.SoftButton1_Click);
                if (this._SoftButton1 != null)
                    this._SoftButton1.Click -= eventHandler;
                this._SoftButton1 = value;
                if (this._SoftButton1 == null)
                    return;
                this._SoftButton1.Click += eventHandler;
            }
        }

        internal virtual OpenFileDialog dlgOpen
        {
            [DebuggerNonUserCode]
            get
            {
                return this._dlgOpen;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                CancelEventHandler cancelEventHandler = new CancelEventHandler(this.dlgOpen_FileOk);
                if (this._dlgOpen != null)
                    this._dlgOpen.FileOk -= cancelEventHandler;
                this._dlgOpen = value;
                if (this._dlgOpen == null)
                    return;
                this._dlgOpen.FileOk += cancelEventHandler;
            }
        }

        internal virtual SaveFileDialog dlgSave
        {
            [DebuggerNonUserCode]
            get
            {
                return this._dlgSave;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                CancelEventHandler cancelEventHandler = new CancelEventHandler(this.dlgSave_FileOk);
                if (this._dlgSave != null)
                    this._dlgSave.FileOk -= cancelEventHandler;
                this._dlgSave = value;
                if (this._dlgSave == null)
                    return;
                this._dlgSave.FileOk += cancelEventHandler;
            }
        }

        public event frmConnection.CompanyNameChangedEventHandler CompanyNameChanged;

        public event frmConnection.ShowLoginEventHandler ShowLogin;

        public event frmConnection.NewCompanyEventHandler NewCompany;

        public void ReadFromFile(string filename)
        {
            try
            {
                string[] strArray1 = new string[1];
                string[] strArray2 = Strings.Split(File.ReadAllText(filename), "\r\n", -1, CompareMethod.Binary);
                this.CompanyFilename = strArray2[0];
                this.ServerName = strArray2[1];
                this.DatabaseName = strArray2[2];
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
            }
        }

        private void frmConnection_Load(object sender, EventArgs e)
        {
            this.LoadCompanyList();
        }

        public void LoadCompanyList()
        {
            this.companyDataHelper.ListCompanies(this.companyListView);
            if (this.companyListView.Items.Count > 0)
            {
                this.companyListView.Items[0].Selected = true;
                this.btnDelete.Enabled = true;
                this.btnOpenCo.Enabled = true;
            }
            else
            {
                this.btnDelete.Enabled = false;
                this.btnOpenCo.Enabled = false;
            }
        }

        private void lstCompanies_ItemSelectionChanged(
          object sender,
          ListViewItemSelectionChangedEventArgs e)
        {
            this.chkAuto.Checked = e.Item.ImageIndex == 1;
            ConnectionInfo.ConnectionFile = e.Item.SubItems[2].Text;
        }

        private void chkAuto_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnNewCo_Click(object sender, EventArgs e)
        {
            frmCompanyInfo frmCompanyInfo = new frmCompanyInfo((Form)this, true);
            frmCompanyInfo.NewCompany += new frmCompanyInfo.NewCompanyEventHandler(this.LoadCompanyList);
            frmCompanyInfo.newFlag = true;
            int num = (int)frmCompanyInfo.ShowDialog();
            frmCompanyInfo.Dispose();
        }

        private void btndetails_Click(object sender, EventArgs e)
        {
            ConnectionInfo.ConnectionFile = this.companyListView.SelectedItems[0].SubItems[2].Text;
            ConnectionInfo.RefreshConnection();
            int num = (int)new frmCompanyInfo(this, false).ShowDialog();
        }

        private void VistaButton4_Click(object sender, EventArgs e)
        {
            this.LoadCompanyList();
        }

        private void btnOpenCo_Click(object sender, EventArgs e)
        {
            var connection = this.companyListView.SelectedItems[0].Tag as CompanyConnection;
           
            //todo: this.companyDataHelper.AutoOpenCompany(this.chkAuto.Checked);
            ConnectionInfo.ConnectionFile = connection.FileName;
            CompanyNameChangeEventArgs e1 = new CompanyNameChangeEventArgs(ConnectionInfo.ConnectionFile);
            frmConnection.CompanyNameChangedEventHandler nameChangedEvent = this.CompanyNameChanged;
            if (nameChangedEvent == null)
                return;
            nameChangedEvent((object)this, e1);
        }

        public frmConnection(JobCardCompany companyDataHelper)
        {
            this.Load += new EventHandler(this.frmConnection_Load);
            this.companyDataHelper = companyDataHelper;
            this.InitializeComponent();
           
        }

        public void DeleteACompany(string FileName)
        {
            this.companyDataHelper.FileName = FileName;
            this.companyDataHelper.DeleteCompany();
            this.LoadCompanyList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show($"Are you sure you want to permanently delete this company?", "Delete Company", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            this.companyDataHelper.FileName = this.companyListView.SelectedItems[0].SubItems[2].Text;
            string adminPassword = this.companyDataHelper.GetAdminPassword();
            frmPassword frmPassword = new frmPassword();
            while (true)
            {
                int num1 = (int)frmPassword.ShowDialog();
                if (!frmPassword.isCanceled)
                {
                    if (Operators.CompareString(adminPassword, frmPassword.txtpass.Text, false) != 0)
                    {
                        MessageBox.Show($"The password is incorrect! Please try again.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        break;
                }
                else
                    goto label_6;
            }
            this.DeleteACompany(this.companyListView.SelectedItems[0].SubItems[2].Text);
            label_6:
            frmPassword.Dispose();
        }

        private void lstCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnAddCompanyShortcut_Click(object sender, EventArgs e)
        {
            int num = (int)this.dlgOpen.ShowDialog();
        }

        private void SoftButton1_Click(object sender, EventArgs e)
        {
            int num = (int)this.dlgSave.ShowDialog();
        }

        private void dlgOpen_FileOk(object sender, CancelEventArgs e)
        {
            if (e.Cancel)
                return;
            File.Copy(this.dlgOpen.FileName, Application.StartupPath + "\\" + Microsoft.VisualBasic.FileIO.FileSystem.GetName(this.dlgOpen.FileName), true);
            this.LoadCompanyList();
        }

        private void dlgSave_FileOk(object sender, CancelEventArgs e)
        {
            if (e.Cancel)
                return;
            File.Copy(this.companyListView.SelectedItems[0].SubItems[2].Text, this.dlgSave.FileName, true);
        }

        public delegate void CompanyNameChangedEventHandler(object sender, CompanyNameChangeEventArgs e);

        public delegate void ShowLoginEventHandler();

        public delegate void NewCompanyEventHandler(
          object sender,
          frmConnection.NewCompanyEventHandler e);
    }
}
