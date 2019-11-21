// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.Core.frmCustomerList
// Assembly: JobCard, Version=1.0.0.2, Culture=neutral, PublicKeyToken=null
// MVID: 355A629F-A2FA-4599-879B-59162A296DD0
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCard.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Reytec.GUI.Controls;
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
    public class frmCustomerList : Form
    {
        private IContainer components;
        [AccessedThroughProperty("Panel3")]
        private Panel _Panel3;
        [AccessedThroughProperty("Panel1")]
        private Panel _Panel1;
        [AccessedThroughProperty("btnNew")]
        private SoftButton _btnNew;
        [AccessedThroughProperty("TableLayoutPanel1")]
        private TableLayoutPanel _TableLayoutPanel1;
        [AccessedThroughProperty("Panel5")]
        private Panel _Panel5;
        [AccessedThroughProperty("btnDelete")]
        private SoftButton _btnDelete;
        [AccessedThroughProperty("btnEdit")]
        private SoftButton _btnEdit;
        [AccessedThroughProperty("txtSearch")]
        private TextBox _txtSearch;
        [AccessedThroughProperty("btnReset")]
        private SoftButton _btnReset;
        [AccessedThroughProperty("AccountNumberDataGridViewTextBoxColumn")]
        private DataGridViewTextBoxColumn _AccountNumberDataGridViewTextBoxColumn;
        [AccessedThroughProperty("NameDataGridViewTextBoxColumn")]
        private DataGridViewTextBoxColumn _NameDataGridViewTextBoxColumn;
        [AccessedThroughProperty("Tel1DataGridViewTextBoxColumn")]
        private DataGridViewTextBoxColumn _Tel1DataGridViewTextBoxColumn;
        [AccessedThroughProperty("CustomerEmailDataGridViewTextBoxColumn")]
        private DataGridViewTextBoxColumn _CustomerEmailDataGridViewTextBoxColumn;
        [AccessedThroughProperty("CellDataGridViewTextBoxColumn")]
        private DataGridViewTextBoxColumn _CellDataGridViewTextBoxColumn;
        [AccessedThroughProperty("DataGridViewTextBoxColumn6")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn6;
        [AccessedThroughProperty("DataGridViewTextBoxColumn7")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn7;
        [AccessedThroughProperty("DataGridViewTextBoxColumn8")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn8;
        [AccessedThroughProperty("DataGridViewTextBoxColumn9")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn9;
        [AccessedThroughProperty("DataGridViewTextBoxColumn10")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn10;
        [AccessedThroughProperty("DataGridViewTextBoxColumn11")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn11;
        [AccessedThroughProperty("DataGridViewTextBoxColumn12")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn12;
        [AccessedThroughProperty("DataGridViewTextBoxColumn13")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn13;
        [AccessedThroughProperty("DataGridViewTextBoxColumn14")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn14;
        [AccessedThroughProperty("DataGridViewTextBoxColumn15")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn15;
        [AccessedThroughProperty("DataGridViewTextBoxColumn16")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn16;
        [AccessedThroughProperty("DataGridViewTextBoxColumn17")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn17;
        [AccessedThroughProperty("DataGridViewTextBoxColumn18")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn18;
        [AccessedThroughProperty("DataGridViewTextBoxColumn19")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn19;
        [AccessedThroughProperty("DataGridViewTextBoxColumn20")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn20;
        [AccessedThroughProperty("DataGridViewTextBoxColumn21")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn21;
        [AccessedThroughProperty("DataGridViewTextBoxColumn22")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn22;
        [AccessedThroughProperty("DataGridViewTextBoxColumn23")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn23;
        [AccessedThroughProperty("grdCustomers")]
        private DataGridView _grdCustomers;
        [AccessedThroughProperty("grdImg")]
        private ImageList _grdImg;
        [AccessedThroughProperty("nosearch")]
        private Panel _nosearch;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("lnkagain")]
        private LinkLabel _lnkagain;
        [AccessedThroughProperty("lblnosearch")]
        private Label _lblnosearch;
        [AccessedThroughProperty("Column1")]
        private DataGridViewImageColumn _Column1;
        private Customer dboCustomers;
        private Font sf;
        private Font nf;
        private const string sTxt = "Type search text here";

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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmCustomerList));
            this.TableLayoutPanel1 = new TableLayoutPanel();
            this.Panel5 = new Panel();
            this.nosearch = new Panel();
            this.Label1 = new Label();
            this.lnkagain = new LinkLabel();
            this.grdCustomers = new DataGridView();
            this.Panel3 = new Panel();
            this.btnReset = new SoftButton();
            this.btnDelete = new SoftButton();
            this.btnEdit = new SoftButton();
            this.Panel1 = new Panel();
            this.lblnosearch = new Label();
            this.txtSearch = new TextBox();
            this.btnNew = new SoftButton();
            this.grdImg = new ImageList(this.components);
            this.DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn19 = new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn20 = new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn21 = new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn22 = new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn23 = new DataGridViewTextBoxColumn();
            this.Column1 = new DataGridViewImageColumn();
            this.TableLayoutPanel1.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.nosearch.SuspendLayout();
            ((ISupportInitialize)this.grdCustomers).BeginInit();
            this.Panel3.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            this.TableLayoutPanel1.BackColor = SystemColors.Control;
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.TableLayoutPanel1.Controls.Add((Control)this.Panel5, 0, 0);
            this.TableLayoutPanel1.Dock = DockStyle.Fill;
            TableLayoutPanel tableLayoutPanel1_1 = this.TableLayoutPanel1;
            Point point1 = new Point(0, 35);
            Point point2 = point1;
            tableLayoutPanel1_1.Location = point2;
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 462f));
            TableLayoutPanel tableLayoutPanel1_2 = this.TableLayoutPanel1;
            Size size1 = new Size(667, 462);
            Size size2 = size1;
            tableLayoutPanel1_2.Size = size2;
            this.TableLayoutPanel1.TabIndex = 16;
            this.Panel5.Controls.Add((Control)this.nosearch);
            this.Panel5.Controls.Add((Control)this.grdCustomers);
            this.Panel5.Dock = DockStyle.Fill;
            Panel panel5_1 = this.Panel5;
            point1 = new Point(3, 3);
            Point point3 = point1;
            panel5_1.Location = point3;
            this.Panel5.Name = "Panel5";
            Panel panel5_2 = this.Panel5;
            size1 = new Size(661, 456);
            Size size3 = size1;
            panel5_2.Size = size3;
            this.Panel5.TabIndex = 6;
            this.nosearch.BackColor = SystemColors.Window;
            this.nosearch.Controls.Add((Control)this.Label1);
            this.nosearch.Controls.Add((Control)this.lnkagain);
            Panel nosearch1 = this.nosearch;
            point1 = new Point(9, 45);
            Point point4 = point1;
            nosearch1.Location = point4;
            this.nosearch.Name = "nosearch";
            Panel nosearch2 = this.nosearch;
            size1 = new Size(293, 21);
            Size size4 = size1;
            nosearch2.Size = size4;
            this.nosearch.TabIndex = 5;
            this.nosearch.Visible = false;
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("Segoe UI", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte)0);
            Label label1_1 = this.Label1;
            point1 = new Point(3, 0);
            Point point5 = point1;
            label1_1.Location = point5;
            this.Label1.Name = "Label1";
            Label label1_2 = this.Label1;
            size1 = new Size(172, 15);
            Size size5 = size1;
            label1_2.Size = size5;
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Your search returned no results.";
            this.lnkagain.AutoSize = true;
            this.lnkagain.Font = new Font("Segoe UI", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte)0);
            this.lnkagain.LinkColor = Color.SteelBlue;
            LinkLabel lnkagain1 = this.lnkagain;
            point1 = new Point(175, 0);
            Point point6 = point1;
            lnkagain1.Location = point6;
            this.lnkagain.Name = "lnkagain";
            LinkLabel lnkagain2 = this.lnkagain;
            size1 = new Size(114, 15);
            Size size6 = size1;
            lnkagain2.Size = size6;
            this.lnkagain.TabIndex = 5;
            this.lnkagain.TabStop = true;
            this.lnkagain.Text = "Try searching again.";
            this.grdCustomers.AllowUserToAddRows = false;
            this.grdCustomers.AllowUserToDeleteRows = false;
            this.grdCustomers.AllowUserToOrderColumns = true;
            this.grdCustomers.AllowUserToResizeRows = false;
            this.grdCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCustomers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.grdCustomers.BackgroundColor = SystemColors.Window;
            this.grdCustomers.BorderStyle = BorderStyle.Fixed3D;
            this.grdCustomers.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            this.grdCustomers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.grdCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomers.Columns.AddRange((DataGridViewColumn)this.Column1);
            this.grdCustomers.Dock = DockStyle.Fill;
            this.grdCustomers.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.grdCustomers.GridColor = SystemColors.ActiveBorder;
            DataGridView grdCustomers1 = this.grdCustomers;
            point1 = new Point(0, 0);
            Point point7 = point1;
            grdCustomers1.Location = point7;
            this.grdCustomers.MultiSelect = false;
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.ReadOnly = true;
            this.grdCustomers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.grdCustomers.RowHeadersVisible = false;
            this.grdCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView grdCustomers2 = this.grdCustomers;
            size1 = new Size(661, 456);
            Size size7 = size1;
            grdCustomers2.Size = size7;
            this.grdCustomers.StandardTab = true;
            this.grdCustomers.TabIndex = 3;
            this.Panel3.BackColor = Color.Transparent;
            // this.Panel3.BackgroundImage = (Image) Reytec.JobCard.Core.My.Resources.Resources.toolbackt;
            this.Panel3.Controls.Add((Control)this.btnReset);
            this.Panel3.Controls.Add((Control)this.btnDelete);
            this.Panel3.Controls.Add((Control)this.btnEdit);
            this.Panel3.Controls.Add((Control)this.Panel1);
            this.Panel3.Controls.Add((Control)this.btnNew);
            this.Panel3.Dock = DockStyle.Top;
            Panel panel3_1 = this.Panel3;
            point1 = new Point(0, 0);
            Point point8 = point1;
            panel3_1.Location = point8;
            Panel panel3_2 = this.Panel3;
            Padding padding1 = new Padding(0);
            Padding padding2 = padding1;
            panel3_2.Margin = padding2;
            this.Panel3.Name = "Panel3";
            Panel panel3_3 = this.Panel3;
            size1 = new Size(667, 35);
            Size size8 = size1;
            panel3_3.Size = size8;
            this.Panel3.TabIndex = 4;
            this.btnReset.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnReset.BackColor = Color.Transparent;
            this.btnReset.BaseColor = Color.FromArgb(33, 124, 180);
            this.btnReset.ButtonColor = Color.FromArgb(23, 87, 125);
            this.btnReset.ButtonStyle = SoftButton.Style.Flat;
            this.btnReset.ButtonText = "Show All";
            this.btnReset.CornerRadius = 3;
            this.btnReset.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnReset.Glow2Color = Color.FromArgb(209, 242, 250);
            this.btnReset.GlowColor = Color.FromArgb(192, (int)byte.MaxValue, (int)byte.MaxValue);
            this.btnReset.HighlightColor = Color.FromArgb(192, 222, 254);
            // this.btnReset.Image = (Image) Reytec.JobCard.Core.My.Resources.Resources.ActualSizeHS;
            SoftButton btnReset1 = this.btnReset;
            size1 = new Size(16, 16);
            Size size9 = size1;
            btnReset1.ImageSize = size9;
            SoftButton btnReset2 = this.btnReset;
            point1 = new Point(262, 3);
            Point point9 = point1;
            btnReset2.Location = point9;
            SoftButton btnReset3 = this.btnReset;
            padding1 = new Padding(0);
            Padding padding3 = padding1;
            btnReset3.Margin = padding3;
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowColor = Color.Black;
            SoftButton btnReset4 = this.btnReset;
            size1 = new Size(86, 30);
            Size size10 = size1;
            btnReset4.Size = size10;
            this.btnReset.TabIndex = 44;
            this.btnReset.TextAlign = ContentAlignment.MiddleRight;
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
            Size size11 = size1;
            btnDelete1.ImageSize = size11;
            SoftButton btnDelete2 = this.btnDelete;
            point1 = new Point(188, 3);
            Point point10 = point1;
            btnDelete2.Location = point10;
            SoftButton btnDelete3 = this.btnDelete;
            padding1 = new Padding(0);
            Padding padding4 = padding1;
            btnDelete3.Margin = padding4;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowColor = Color.Black;
            SoftButton btnDelete4 = this.btnDelete;
            size1 = new Size(74, 30);
            Size size12 = size1;
            btnDelete4.Size = size12;
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
            Size size13 = size1;
            btnEdit1.ImageSize = size13;
            SoftButton btnEdit2 = this.btnEdit;
            point1 = new Point(126, 3);
            Point point11 = point1;
            btnEdit2.Location = point11;
            SoftButton btnEdit3 = this.btnEdit;
            padding1 = new Padding(0);
            Padding padding5 = padding1;
            btnEdit3.Margin = padding5;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowColor = Color.Black;
            SoftButton btnEdit4 = this.btnEdit;
            size1 = new Size(62, 30);
            Size size14 = size1;
            btnEdit4.Size = size14;
            this.btnEdit.TabIndex = 42;
            this.btnEdit.TextAlign = ContentAlignment.MiddleRight;
            this.Panel1.Controls.Add((Control)this.lblnosearch);
            this.Panel1.Controls.Add((Control)this.txtSearch);
            this.Panel1.Dock = DockStyle.Right;
            Panel panel1_1 = this.Panel1;
            point1 = new Point(437, 0);
            Point point12 = point1;
            panel1_1.Location = point12;
            this.Panel1.Name = "Panel1";
            Panel panel1_2 = this.Panel1;
            size1 = new Size(230, 35);
            Size size15 = size1;
            panel1_2.Size = size15;
            this.Panel1.TabIndex = 41;
            this.lblnosearch.AutoSize = true;
            this.lblnosearch.BackColor = Color.White;
            this.lblnosearch.Cursor = Cursors.IBeam;
            this.lblnosearch.Font = new Font("Segoe UI", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte)0);
            this.lblnosearch.ForeColor = SystemColors.ControlText;
            Label lblnosearch1 = this.lblnosearch;
            point1 = new Point(9, 11);
            Point point13 = point1;
            lblnosearch1.Location = point13;
            Label lblnosearch2 = this.lblnosearch;
            padding1 = new Padding(0);
            Padding padding6 = padding1;
            lblnosearch2.Margin = padding6;
            this.lblnosearch.Name = "lblnosearch";
            Label lblnosearch3 = this.lblnosearch;
            size1 = new Size(117, 15);
            Size size16 = size1;
            lblnosearch3.Size = size16;
            this.lblnosearch.TabIndex = 4;
            this.lblnosearch.Text = "Type search text here";
            TextBox txtSearch1 = this.txtSearch;
            point1 = new Point(3, 9);
            Point point14 = point1;
            txtSearch1.Location = point14;
            this.txtSearch.Name = "txtSearch";
            TextBox txtSearch2 = this.txtSearch;
            size1 = new Size(224, 21);
            Size size17 = size1;
            txtSearch2.Size = size17;
            this.txtSearch.TabIndex = 0;
            this.btnNew.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnNew.BackColor = Color.Transparent;
            this.btnNew.BaseColor = Color.FromArgb(33, 124, 180);
            this.btnNew.ButtonColor = Color.FromArgb(23, 87, 125);
            this.btnNew.ButtonStyle = SoftButton.Style.Flat;
            this.btnNew.ButtonText = "New Customer";
            this.btnNew.CornerRadius = 3;
            this.btnNew.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnNew.Glow2Color = Color.FromArgb(209, 242, 250);
            this.btnNew.GlowColor = Color.FromArgb(192, (int)byte.MaxValue, (int)byte.MaxValue);
            this.btnNew.HighlightColor = Color.FromArgb(192, 222, 254);
            // this.btnNew.Image = (Image) Reytec.JobCard.Core.My.Resources.Resources.VistaUsers;
            SoftButton btnNew1 = this.btnNew;
            size1 = new Size(16, 16);
            Size size18 = size1;
            btnNew1.ImageSize = size18;
            SoftButton btnNew2 = this.btnNew;
            point1 = new Point(7, 3);
            Point point15 = point1;
            btnNew2.Location = point15;
            SoftButton btnNew3 = this.btnNew;
            padding1 = new Padding(0);
            Padding padding7 = padding1;
            btnNew3.Margin = padding7;
            this.btnNew.Name = "btnNew";
            this.btnNew.ShadowColor = Color.Black;
            SoftButton btnNew4 = this.btnNew;
            size1 = new Size(119, 30);
            Size size19 = size1;
            btnNew4.Size = size19;
            this.btnNew.TabIndex = 13;
            this.btnNew.TextAlign = ContentAlignment.MiddleRight;
            this.grdImg.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("grdImg.ImageStream");
            this.grdImg.TransparentColor = Color.Transparent;
            this.grdImg.Images.SetKeyName(0, "users.ico");
            this.grdImg.Images.SetKeyName(1, "user.ico");
            this.DataGridViewTextBoxColumn6.DataPropertyName = "ResidentialAddress";
            this.DataGridViewTextBoxColumn6.HeaderText = "ResidentialAddress";
            this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            this.DataGridViewTextBoxColumn6.Width = 29;
            this.DataGridViewTextBoxColumn7.DataPropertyName = "Tel1";
            this.DataGridViewTextBoxColumn7.HeaderText = "Tel1";
            this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            this.DataGridViewTextBoxColumn7.Width = 28;
            this.DataGridViewTextBoxColumn8.DataPropertyName = "Tel2";
            this.DataGridViewTextBoxColumn8.HeaderText = "Tel2";
            this.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
            this.DataGridViewTextBoxColumn8.Width = 29;
            this.DataGridViewTextBoxColumn9.DataPropertyName = "Cell";
            this.DataGridViewTextBoxColumn9.HeaderText = "Cell";
            this.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9";
            this.DataGridViewTextBoxColumn9.Width = 28;
            this.DataGridViewTextBoxColumn10.DataPropertyName = "Fax";
            this.DataGridViewTextBoxColumn10.HeaderText = "Fax";
            this.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10";
            this.DataGridViewTextBoxColumn10.Width = 29;
            this.DataGridViewTextBoxColumn11.DataPropertyName = "CustomerEmail";
            this.DataGridViewTextBoxColumn11.HeaderText = "CustomerEmail";
            this.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11";
            this.DataGridViewTextBoxColumn11.Width = 29;
            this.DataGridViewTextBoxColumn12.DataPropertyName = "VATNr";
            this.DataGridViewTextBoxColumn12.HeaderText = "VATNr";
            this.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12";
            this.DataGridViewTextBoxColumn12.Width = 28;
            this.DataGridViewTextBoxColumn13.DataPropertyName = "RegistrationNr";
            this.DataGridViewTextBoxColumn13.HeaderText = "RegistrationNr";
            this.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13";
            this.DataGridViewTextBoxColumn13.Width = 29;
            this.DataGridViewTextBoxColumn14.DataPropertyName = "Director1Name";
            this.DataGridViewTextBoxColumn14.HeaderText = "Director1Name";
            this.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14";
            this.DataGridViewTextBoxColumn14.Width = 29;
            this.DataGridViewTextBoxColumn15.DataPropertyName = "Director2Name";
            this.DataGridViewTextBoxColumn15.HeaderText = "Director2Name";
            this.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15";
            this.DataGridViewTextBoxColumn15.Width = 28;
            this.DataGridViewTextBoxColumn16.DataPropertyName = "Director3Name";
            this.DataGridViewTextBoxColumn16.HeaderText = "Director3Name";
            this.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16";
            this.DataGridViewTextBoxColumn16.Width = 29;
            this.DataGridViewTextBoxColumn17.DataPropertyName = "Director4Name";
            this.DataGridViewTextBoxColumn17.HeaderText = "Director4Name";
            this.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17";
            this.DataGridViewTextBoxColumn17.Width = 28;
            this.DataGridViewTextBoxColumn18.DataPropertyName = "Director1ID";
            this.DataGridViewTextBoxColumn18.HeaderText = "Director1ID";
            this.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18";
            this.DataGridViewTextBoxColumn18.Width = 29;
            this.DataGridViewTextBoxColumn19.DataPropertyName = "Director2ID";
            this.DataGridViewTextBoxColumn19.HeaderText = "Director2ID";
            this.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19";
            this.DataGridViewTextBoxColumn19.Width = 29;
            this.DataGridViewTextBoxColumn20.DataPropertyName = "Director3ID";
            this.DataGridViewTextBoxColumn20.HeaderText = "Director3ID";
            this.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20";
            this.DataGridViewTextBoxColumn20.Width = 28;
            this.DataGridViewTextBoxColumn21.DataPropertyName = "Director4ID";
            this.DataGridViewTextBoxColumn21.HeaderText = "Director4ID";
            this.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21";
            this.DataGridViewTextBoxColumn21.Width = 29;
            this.DataGridViewTextBoxColumn22.DataPropertyName = "ManagerName";
            this.DataGridViewTextBoxColumn22.HeaderText = "ManagerName";
            this.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22";
            this.DataGridViewTextBoxColumn22.Width = 28;
            this.DataGridViewTextBoxColumn23.DataPropertyName = "PrivateIDNumber";
            this.DataGridViewTextBoxColumn23.HeaderText = "PrivateIDNumber";
            this.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23";
            this.DataGridViewTextBoxColumn23.Width = 29;
            this.Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = DataGridViewTriState.True;
            this.Column1.SortMode = DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 20;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            size1 = new Size(667, 497);
            this.ClientSize = size1;
            this.Controls.Add((Control)this.TableLayoutPanel1);
            this.Controls.Add((Control)this.Panel3);
            this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Name = nameof(frmCustomerList);
            this.Text = "My Customers";
            this.TableLayoutPanel1.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            this.nosearch.ResumeLayout(false);
            this.nosearch.PerformLayout();
            ((ISupportInitialize)this.grdCustomers).EndInit();
            this.Panel3.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
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
                EventHandler eventHandler1 = new EventHandler(this.txtSearch_LostFocus);
                EventHandler eventHandler2 = new EventHandler(this.txtSearch_TextChanged);
                if (this._txtSearch != null)
                {
                    this._txtSearch.LostFocus -= eventHandler1;
                    this._txtSearch.TextChanged -= eventHandler2;
                }
                this._txtSearch = value;
                if (this._txtSearch == null)
                    return;
                this._txtSearch.LostFocus += eventHandler1;
                this._txtSearch.TextChanged += eventHandler2;
            }
        }

        internal virtual SoftButton btnReset
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnReset;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnReset_Click);
                if (this._btnReset != null)
                    this._btnReset.Click -= eventHandler;
                this._btnReset = value;
                if (this._btnReset == null)
                    return;
                this._btnReset.Click += eventHandler;
            }
        }

        internal virtual DataGridViewTextBoxColumn AccountNumberDataGridViewTextBoxColumn
        {
            [DebuggerNonUserCode]
            get
            {
                return this._AccountNumberDataGridViewTextBoxColumn;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._AccountNumberDataGridViewTextBoxColumn = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn NameDataGridViewTextBoxColumn
        {
            [DebuggerNonUserCode]
            get
            {
                return this._NameDataGridViewTextBoxColumn;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._NameDataGridViewTextBoxColumn = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn Tel1DataGridViewTextBoxColumn
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Tel1DataGridViewTextBoxColumn;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Tel1DataGridViewTextBoxColumn = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn CustomerEmailDataGridViewTextBoxColumn
        {
            [DebuggerNonUserCode]
            get
            {
                return this._CustomerEmailDataGridViewTextBoxColumn;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._CustomerEmailDataGridViewTextBoxColumn = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn CellDataGridViewTextBoxColumn
        {
            [DebuggerNonUserCode]
            get
            {
                return this._CellDataGridViewTextBoxColumn;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._CellDataGridViewTextBoxColumn = value;
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

        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn9
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DataGridViewTextBoxColumn9;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn9 = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn10
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DataGridViewTextBoxColumn10;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn10 = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn11
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DataGridViewTextBoxColumn11;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn11 = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn12
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DataGridViewTextBoxColumn12;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn12 = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn13
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DataGridViewTextBoxColumn13;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn13 = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn14
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DataGridViewTextBoxColumn14;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn14 = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn15
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DataGridViewTextBoxColumn15;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn15 = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn16
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DataGridViewTextBoxColumn16;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn16 = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn17
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DataGridViewTextBoxColumn17;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn17 = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn18
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DataGridViewTextBoxColumn18;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn18 = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn19
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DataGridViewTextBoxColumn19;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn19 = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn20
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DataGridViewTextBoxColumn20;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn20 = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn21
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DataGridViewTextBoxColumn21;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn21 = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn22
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DataGridViewTextBoxColumn22;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn22 = value;
            }
        }

        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn23
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DataGridViewTextBoxColumn23;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn23 = value;
            }
        }

        internal virtual DataGridView grdCustomers
        {
            [DebuggerNonUserCode]
            get
            {
                return this._grdCustomers;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                DataGridViewCellMouseEventHandler mouseEventHandler = new DataGridViewCellMouseEventHandler(this.grdCustomers_ColumnHeaderMouseClick);
                DataGridViewCellValueEventHandler valueEventHandler1 = new DataGridViewCellValueEventHandler(this.grdCustomers_CellValuePushed);
                DataGridViewCellValueEventHandler valueEventHandler2 = new DataGridViewCellValueEventHandler(this.grdCustomers_CellValueNeeded);
                DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.grdCustomers_CellValueChanged);
                DataGridViewCellFormattingEventHandler formattingEventHandler = new DataGridViewCellFormattingEventHandler(this.grdCustomers_CellFormatting);
                DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.grdCustomers_CellDoubleClick);
                DataGridViewCellEventHandler cellEventHandler3 = new DataGridViewCellEventHandler(this.grdCustomers_CellContentClick_1);
                DataGridViewCellCancelEventHandler cancelEventHandler = new DataGridViewCellCancelEventHandler(this.grdCustomers_RowValidating);
                DataGridViewCellEventHandler cellEventHandler4 = new DataGridViewCellEventHandler(this.grdCustomers_RowValidated);
                DataGridViewRowsAddedEventHandler addedEventHandler = new DataGridViewRowsAddedEventHandler(this.grdCustomers_RowsAdded);
                DataGridViewRowPostPaintEventHandler paintEventHandler = new DataGridViewRowPostPaintEventHandler(this.grdCustomers_RowPostPaint);
                if (this._grdCustomers != null)
                {
                    this._grdCustomers.ColumnHeaderMouseClick -= mouseEventHandler;
                    this._grdCustomers.CellValuePushed -= valueEventHandler1;
                    this._grdCustomers.CellValueNeeded -= valueEventHandler2;
                    this._grdCustomers.CellValueChanged -= cellEventHandler1;
                    this._grdCustomers.CellFormatting -= formattingEventHandler;
                    this._grdCustomers.CellDoubleClick -= cellEventHandler2;
                    this._grdCustomers.CellContentClick -= cellEventHandler3;
                    this._grdCustomers.RowValidating -= cancelEventHandler;
                    this._grdCustomers.RowValidated -= cellEventHandler4;
                    this._grdCustomers.RowsAdded -= addedEventHandler;
                    this._grdCustomers.RowPostPaint -= paintEventHandler;
                }
                this._grdCustomers = value;
                if (this._grdCustomers == null)
                    return;
                this._grdCustomers.ColumnHeaderMouseClick += mouseEventHandler;
                this._grdCustomers.CellValuePushed += valueEventHandler1;
                this._grdCustomers.CellValueNeeded += valueEventHandler2;
                this._grdCustomers.CellValueChanged += cellEventHandler1;
                this._grdCustomers.CellFormatting += formattingEventHandler;
                this._grdCustomers.CellDoubleClick += cellEventHandler2;
                this._grdCustomers.CellContentClick += cellEventHandler3;
                this._grdCustomers.RowValidating += cancelEventHandler;
                this._grdCustomers.RowValidated += cellEventHandler4;
                this._grdCustomers.RowsAdded += addedEventHandler;
                this._grdCustomers.RowPostPaint += paintEventHandler;
            }
        }

        internal virtual ImageList grdImg
        {
            [DebuggerNonUserCode]
            get
            {
                return this._grdImg;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._grdImg = value;
            }
        }

        internal virtual Panel nosearch
        {
            [DebuggerNonUserCode]
            get
            {
                return this._nosearch;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._nosearch = value;
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

        internal virtual DataGridViewImageColumn Column1
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.editCustomer();
        }

        public void editCustomer()
        {
            int num = (int)new frmCustomerDetail(Conversions.ToInteger(this.grdCustomers.SelectedRows[0].Cells[1].Value)).ShowDialog((IWin32Window)this);
            this.LoadList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int num = (int)new frmCustomerDetail(-1).ShowDialog((IWin32Window)this);
            this.LoadList();
        }

        public void LoadList()
        {
            this.txtSearch.Text = "";
            this.nosearch.Visible = false;
            this.grdCustomers.DataSource = (object)this.dboCustomers.GetList();
            this.grdCustomers.Columns[1].Visible = false;
            this.grdCustomers.Columns[2].Visible = false;
        }

        private void frmCustomerList_Load(object sender, EventArgs e)
        {
        }

        private void lstCustomers_ColumnClick(object sender, ColumnClickEventArgs e)
        {
        }

        private void lstCustomers_GotFocus(object sender, EventArgs e)
        {
        }

        private void lstCustomers_ItemActivate(object sender, EventArgs e)
        {
            this.editCustomer();
        }

        private void lstCustomers_ItemSelectionChanged(
          object sender,
          ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                this.btnDelete.Enabled = true;
                this.btnEdit.Enabled = true;
            }
            else
            {
                this.btnDelete.Enabled = false;
                this.btnEdit.Enabled = false;
            }
        }

        private void lstCustomers_LostFocus(object sender, EventArgs e)
        {
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtSearch_LostFocus(object sender, EventArgs e)
        {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearch.Text, "", false) == 0)
                this.lblnosearch.Visible = true;
            else
                this.lblnosearch.Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearch.Text, "", false) != 0)
            {
                DataView dataView = new DataView(this.dboCustomers.GetList());
                dataView.RowFilter = JobFunctions.DoSearch(dataView.Table, this.txtSearch.Text);
                this.grdCustomers.DataSource = (object)dataView;
                this.lblnosearch.Visible = false;
            }
            else
            {
                this.lblnosearch.Visible = true;
                this.LoadList();
            }
            if (this.grdCustomers.Rows.Count == 0)
            {
                this.nosearch.Visible = true;
                this.btnEdit.Enabled = false;
                this.btnDelete.Enabled = false;
            }
            else
            {
                this.nosearch.Visible = false;
                this.btnEdit.Enabled = true;
                this.btnDelete.Enabled = true;
            }
        }

        public void DeleteCustomer()
        {
            ;
            if (MessageBox.Show($"Are you sure you want to delete this customer?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
                return;
            SystemUser systemUser = new SystemUser(ConnectionInfo.GlobalConnection);
            this.dboCustomers.Delete(RuntimeHelpers.GetObjectValue(this.grdCustomers.SelectedRows[0].Cells[1].Value));
            this.LoadList();
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
                    this.DeleteCustomer();
                }
                else
                {
                    if (frmPassword.isCanceled)
                        return;
                    MessageBox.Show($"Invalid password!", "Authentication failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
                this.DeleteCustomer();
        }

        private void lstsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.LoadList();
        }

        private void lstSearch_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void grdCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void grdCustomers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void grdCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.editCustomer();
        }

        private void grdCustomers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex != 0)
                return;
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.grdCustomers.Rows[e.RowIndex].Cells[2].Value, (object)true, false))
                e.Value = (object)this.grdImg.Images[0];
            else
                e.Value = (object)this.grdImg.Images[1];
        }

        private void grdCustomers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void grdCustomers_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
        }

        private void grdCustomers_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
        }

        private void grdCustomers_ColumnHeaderMouseClick(
          object sender,
          DataGridViewCellMouseEventArgs e)
        {
        }

        private void grdCustomers_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
        }

        private void grdCustomers_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
        }

        private void grdCustomers_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void grdCustomers_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
        }

        private void lblnosearch_Click(object sender, EventArgs e)
        {
            this.txtSearch.Focus();
        }

        private void lnkagain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.LoadList();
        }

        public frmCustomerList()
        {
            this.Load += new EventHandler(this.frmCustomerList_Load);
            this.dboCustomers = new Customer(ConnectionInfo.GlobalConnection);
            this.sf = new Font("Segoe UI", 9f, FontStyle.Italic);
            this.nf = new Font("Segoe UI", 9f, FontStyle.Regular);
            this.InitializeComponent();
            this.LoadList();
            if (this.grdCustomers.Rows.Count == 0)
            {
                this.btnEdit.Enabled = false;
                this.btnDelete.Enabled = false;
            }
            else
            {
                this.btnEdit.Enabled = true;
                this.btnDelete.Enabled = true;
            }
        }
    }
}
