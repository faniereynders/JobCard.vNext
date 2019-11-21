// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.Core.frmCustomerDetail
// Assembly: JobCard, Version=1.0.0.2, Culture=neutral, PublicKeyToken=null
// MVID: 355A629F-A2FA-4599-879B-59162A296DD0
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCard.exe

using Microsoft.VisualBasic;
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
    public class frmCustomerDetail : Form
    {
        private IContainer components;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("txtAccountNr")]
        private TextBox _txtAccountNr;
        [AccessedThroughProperty("cmbCustomerType")]
        private ComboBox _cmbCustomerType;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("txtName")]
        private TextBox _txtName;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("txtResidential")]
        private TextBox _txtResidential;
        [AccessedThroughProperty("txtPostal")]
        private TextBox _txtPostal;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("txtTel1")]
        private TextBox _txtTel1;
        [AccessedThroughProperty("Label6")]
        private Label _Label6;
        [AccessedThroughProperty("Label7")]
        private Label _Label7;
        [AccessedThroughProperty("txtTel2")]
        private TextBox _txtTel2;
        [AccessedThroughProperty("Label8")]
        private Label _Label8;
        [AccessedThroughProperty("Label9")]
        private Label _Label9;
        [AccessedThroughProperty("txtCell1")]
        private TextBox _txtCell1;
        [AccessedThroughProperty("txtFax")]
        private TextBox _txtFax;
        [AccessedThroughProperty("Panel1")]
        private Panel _Panel1;
        [AccessedThroughProperty("Layout")]
        private TableLayoutPanel _Layout;
        [AccessedThroughProperty("Panel2")]
        private Panel _Panel2;
        [AccessedThroughProperty("pnlPrivate")]
        private Panel _pnlPrivate;
        [AccessedThroughProperty("txtClientID")]
        private TextBox _txtClientID;
        [AccessedThroughProperty("Label11")]
        private Label _Label11;
        [AccessedThroughProperty("pnlCompany")]
        private Panel _pnlCompany;
        [AccessedThroughProperty("txtRegNr")]
        private TextBox _txtRegNr;
        [AccessedThroughProperty("Label12")]
        private Label _Label12;
        [AccessedThroughProperty("Label13")]
        private Label _Label13;
        [AccessedThroughProperty("txtVATNr")]
        private TextBox _txtVATNr;
        [AccessedThroughProperty("txtDir4")]
        private TextBox _txtDir4;
        [AccessedThroughProperty("Label20")]
        private Label _Label20;
        [AccessedThroughProperty("Label21")]
        private Label _Label21;
        [AccessedThroughProperty("txtDirID4")]
        private TextBox _txtDirID4;
        [AccessedThroughProperty("txtDir3")]
        private TextBox _txtDir3;
        [AccessedThroughProperty("Label18")]
        private Label _Label18;
        [AccessedThroughProperty("Label19")]
        private Label _Label19;
        [AccessedThroughProperty("txtDirID3")]
        private TextBox _txtDirID3;
        [AccessedThroughProperty("txtDir2")]
        private TextBox _txtDir2;
        [AccessedThroughProperty("Label16")]
        private Label _Label16;
        [AccessedThroughProperty("Label17")]
        private Label _Label17;
        [AccessedThroughProperty("txtDirID2")]
        private TextBox _txtDirID2;
        [AccessedThroughProperty("txtDir1")]
        private TextBox _txtDir1;
        [AccessedThroughProperty("Label14")]
        private Label _Label14;
        [AccessedThroughProperty("Label15")]
        private Label _Label15;
        [AccessedThroughProperty("txtDirID1")]
        private TextBox _txtDirID1;
        [AccessedThroughProperty("txtManagerName")]
        private TextBox _txtManagerName;
        [AccessedThroughProperty("Label10")]
        private Label _Label10;
        [AccessedThroughProperty("txtEmail")]
        private TextBox _txtEmail;
        [AccessedThroughProperty("Label22")]
        private Label _Label22;
        [AccessedThroughProperty("btnSave")]
        private SoftButton _btnSave;
        [AccessedThroughProperty("btnCancel")]
        private SoftButton _btnCancel;
        [AccessedThroughProperty("Panel3")]
        private Panel _Panel3;
        [AccessedThroughProperty("Label24")]
        private Label _Label24;
        [AccessedThroughProperty("Label23")]
        private Label _Label23;
        [AccessedThroughProperty("Label25")]
        private Label _Label25;
        [AccessedThroughProperty("Label26")]
        private Label _Label26;
        [AccessedThroughProperty("Label31")]
        private Label _Label31;
        [AccessedThroughProperty("Label30")]
        private Label _Label30;
        [AccessedThroughProperty("Label29")]
        private Label _Label29;
        [AccessedThroughProperty("Label28")]
        private Label _Label28;
        [AccessedThroughProperty("Label27")]
        private Label _Label27;
        private Customer dboCustomer;
        private int _CustomerID;
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmCustomerDetail));
            this.Label1 = new Label();
            this.txtAccountNr = new TextBox();
            this.cmbCustomerType = new ComboBox();
            this.Label2 = new Label();
            this.Label3 = new Label();
            this.txtName = new TextBox();
            this.Label4 = new Label();
            this.txtResidential = new TextBox();
            this.txtPostal = new TextBox();
            this.Label5 = new Label();
            this.txtTel1 = new TextBox();
            this.Label6 = new Label();
            this.Label7 = new Label();
            this.txtTel2 = new TextBox();
            this.Label8 = new Label();
            this.Label9 = new Label();
            this.txtCell1 = new TextBox();
            this.txtFax = new TextBox();
            this.Panel1 = new Panel();
            this.Panel3 = new Panel();
            this.btnCancel = new SoftButton();
            this.btnSave = new SoftButton();
            this.txtEmail = new TextBox();
            this.Label22 = new Label();
            this.Layout = new TableLayoutPanel();
            this.Panel2 = new Panel();
            this.pnlPrivate = new Panel();
            this.txtClientID = new TextBox();
            this.Label11 = new Label();
            this.pnlCompany = new Panel();
            this.txtManagerName = new TextBox();
            this.Label10 = new Label();
            this.txtDir4 = new TextBox();
            this.Label20 = new Label();
            this.Label21 = new Label();
            this.txtDirID4 = new TextBox();
            this.txtDir3 = new TextBox();
            this.Label18 = new Label();
            this.Label19 = new Label();
            this.txtDirID3 = new TextBox();
            this.txtDir2 = new TextBox();
            this.Label16 = new Label();
            this.Label17 = new Label();
            this.txtDirID2 = new TextBox();
            this.txtDir1 = new TextBox();
            this.Label14 = new Label();
            this.Label15 = new Label();
            this.txtDirID1 = new TextBox();
            this.txtRegNr = new TextBox();
            this.Label12 = new Label();
            this.Label13 = new Label();
            this.txtVATNr = new TextBox();
            this.Label23 = new Label();
            this.Label24 = new Label();
            this.Label25 = new Label();
            this.Label26 = new Label();
            this.Label27 = new Label();
            this.Label28 = new Label();
            this.Label29 = new Label();
            this.Label30 = new Label();
            this.Label31 = new Label();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Layout.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.pnlPrivate.SuspendLayout();
            this.pnlCompany.SuspendLayout();
            this.SuspendLayout();
            this.Label1.AutoSize = true;
            Label label1_1 = this.Label1;
            Point point1 = new Point(-3, 9);
            Point point2 = point1;
            label1_1.Location = point2;
            this.Label1.Name = "Label1";
            Label label1_2 = this.Label1;
            Size size1 = new Size(82, 13);
            Size size2 = size1;
            label1_2.Size = size2;
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Customer type:";
            TextBox txtAccountNr1 = this.txtAccountNr;
            point1 = new Point(405, 6);
            Point point3 = point1;
            txtAccountNr1.Location = point3;
            this.txtAccountNr.Name = "txtAccountNr";
            TextBox txtAccountNr2 = this.txtAccountNr;
            size1 = new Size(181, 21);
            Size size3 = size1;
            txtAccountNr2.Size = size3;
            this.txtAccountNr.TabIndex = 2;
            this.cmbCustomerType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCustomerType.FormattingEnabled = true;
            this.cmbCustomerType.Items.AddRange(new object[2]
            {
        (object) "Private",
        (object) "Company"
            });
            ComboBox cmbCustomerType1 = this.cmbCustomerType;
            point1 = new Point(99, 6);
            Point point4 = point1;
            cmbCustomerType1.Location = point4;
            this.cmbCustomerType.Name = "cmbCustomerType";
            ComboBox cmbCustomerType2 = this.cmbCustomerType;
            size1 = new Size(165, 21);
            Size size4 = size1;
            cmbCustomerType2.Size = size4;
            this.cmbCustomerType.TabIndex = 1;
            this.Label2.AutoSize = true;
            Label label2_1 = this.Label2;
            point1 = new Point(287, 9);
            Point point5 = point1;
            label2_1.Location = point5;
            this.Label2.Name = "Label2";
            Label label2_2 = this.Label2;
            size1 = new Size(89, 13);
            Size size5 = size1;
            label2_2.Size = size5;
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Account number:";
            this.Label3.AutoSize = true;
            Label label3_1 = this.Label3;
            point1 = new Point(-3, 36);
            Point point6 = point1;
            label3_1.Location = point6;
            this.Label3.Name = "Label3";
            Label label3_2 = this.Label3;
            size1 = new Size(86, 13);
            Size size6 = size1;
            label3_2.Size = size6;
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Customer name:";
            TextBox txtName1 = this.txtName;
            point1 = new Point(99, 33);
            Point point7 = point1;
            txtName1.Location = point7;
            this.txtName.Name = "txtName";
            TextBox txtName2 = this.txtName;
            size1 = new Size(487, 21);
            Size size7 = size1;
            txtName2.Size = size7;
            this.txtName.TabIndex = 3;
            this.Label4.AutoSize = true;
            this.Label4.ForeColor = Color.Black;
            Label label4_1 = this.Label4;
            point1 = new Point(-3, 3);
            Point point8 = point1;
            label4_1.Location = point8;
            this.Label4.Name = "Label4";
            Label label4_2 = this.Label4;
            size1 = new Size(82, 13);
            Size size8 = size1;
            label4_2.Size = size8;
            this.Label4.TabIndex = 44;
            this.Label4.Text = "Postal Address:";
            TextBox txtResidential1 = this.txtResidential;
            point1 = new Point(405, 0);
            Point point9 = point1;
            txtResidential1.Location = point9;
            this.txtResidential.MaxLength = 100;
            this.txtResidential.Multiline = true;
            this.txtResidential.Name = "txtResidential";
            this.txtResidential.ScrollBars = ScrollBars.Vertical;
            TextBox txtResidential2 = this.txtResidential;
            size1 = new Size(181, 85);
            Size size9 = size1;
            txtResidential2.Size = size9;
            this.txtResidential.TabIndex = 19;
            TextBox txtPostal1 = this.txtPostal;
            point1 = new Point(99, 0);
            Point point10 = point1;
            txtPostal1.Location = point10;
            this.txtPostal.MaxLength = 100;
            this.txtPostal.Multiline = true;
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.ScrollBars = ScrollBars.Vertical;
            TextBox txtPostal2 = this.txtPostal;
            size1 = new Size(165, 85);
            Size size10 = size1;
            txtPostal2.Size = size10;
            this.txtPostal.TabIndex = 18;
            this.Label5.AutoSize = true;
            this.Label5.ForeColor = Color.Black;
            Label label5_1 = this.Label5;
            point1 = new Point(287, 3);
            Point point11 = point1;
            label5_1.Location = point11;
            this.Label5.Name = "Label5";
            Label label5_2 = this.Label5;
            size1 = new Size(105, 13);
            Size size11 = size1;
            label5_2.Size = size11;
            this.Label5.TabIndex = 45;
            this.Label5.Text = "Residential Address:";
            TextBox txtTel1_1 = this.txtTel1;
            point1 = new Point(99, 91);
            Point point12 = point1;
            txtTel1_1.Location = point12;
            this.txtTel1.MaxLength = 20;
            this.txtTel1.Name = "txtTel1";
            TextBox txtTel1_2 = this.txtTel1;
            size1 = new Size(165, 21);
            Size size12 = size1;
            txtTel1_2.Size = size12;
            this.txtTel1.TabIndex = 20;
            this.Label6.AutoSize = true;
            this.Label6.ForeColor = Color.Black;
            Label label6_1 = this.Label6;
            point1 = new Point(-3, 121);
            Point point13 = point1;
            label6_1.Location = point13;
            this.Label6.Name = "Label6";
            Label label6_2 = this.Label6;
            size1 = new Size(70, 13);
            Size size13 = size1;
            label6_2.Size = size13;
            this.Label6.TabIndex = 58;
            this.Label6.Text = "Telephone 2:";
            this.Label7.AutoSize = true;
            this.Label7.ForeColor = Color.Black;
            Label label7_1 = this.Label7;
            point1 = new Point(-3, 94);
            Point point14 = point1;
            label7_1.Location = point14;
            this.Label7.Name = "Label7";
            Label label7_2 = this.Label7;
            size1 = new Size(70, 13);
            Size size14 = size1;
            label7_2.Size = size14;
            this.Label7.TabIndex = 57;
            this.Label7.Text = "Telephone 1:";
            TextBox txtTel2_1 = this.txtTel2;
            point1 = new Point(99, 118);
            Point point15 = point1;
            txtTel2_1.Location = point15;
            this.txtTel2.MaxLength = 20;
            this.txtTel2.Name = "txtTel2";
            TextBox txtTel2_2 = this.txtTel2;
            size1 = new Size(165, 21);
            Size size15 = size1;
            txtTel2_2.Size = size15;
            this.txtTel2.TabIndex = 22;
            this.Label8.AutoSize = true;
            this.Label8.ForeColor = Color.Black;
            Label label8_1 = this.Label8;
            point1 = new Point(287, 94);
            Point point16 = point1;
            label8_1.Location = point16;
            this.Label8.Name = "Label8";
            Label label8_2 = this.Label8;
            size1 = new Size(37, 13);
            Size size16 = size1;
            label8_2.Size = size16;
            this.Label8.TabIndex = 60;
            this.Label8.Text = "Cell 1:";
            this.Label9.AutoSize = true;
            this.Label9.ForeColor = Color.Black;
            Label label9_1 = this.Label9;
            point1 = new Point(287, 121);
            Point point17 = point1;
            label9_1.Location = point17;
            this.Label9.Name = "Label9";
            Label label9_2 = this.Label9;
            size1 = new Size(29, 13);
            Size size17 = size1;
            label9_2.Size = size17;
            this.Label9.TabIndex = 59;
            this.Label9.Text = "Fax:";
            TextBox txtCell1_1 = this.txtCell1;
            point1 = new Point(405, 91);
            Point point18 = point1;
            txtCell1_1.Location = point18;
            this.txtCell1.MaxLength = 20;
            this.txtCell1.Name = "txtCell1";
            TextBox txtCell1_2 = this.txtCell1;
            size1 = new Size(181, 21);
            Size size18 = size1;
            txtCell1_2.Size = size18;
            this.txtCell1.TabIndex = 21;
            TextBox txtFax1 = this.txtFax;
            point1 = new Point(405, 118);
            Point point19 = point1;
            txtFax1.Location = point19;
            this.txtFax.MaxLength = 20;
            this.txtFax.Name = "txtFax";
            TextBox txtFax2 = this.txtFax;
            size1 = new Size(181, 21);
            Size size19 = size1;
            txtFax2.Size = size19;
            this.txtFax.TabIndex = 24;
            this.Panel1.Controls.Add((Control)this.Label31);
            this.Panel1.Controls.Add((Control)this.Label30);
            this.Panel1.Controls.Add((Control)this.Label29);
            this.Panel1.Controls.Add((Control)this.Panel3);
            this.Panel1.Controls.Add((Control)this.txtEmail);
            this.Panel1.Controls.Add((Control)this.Label22);
            this.Panel1.Controls.Add((Control)this.txtPostal);
            this.Panel1.Controls.Add((Control)this.txtTel1);
            this.Panel1.Controls.Add((Control)this.Label5);
            this.Panel1.Controls.Add((Control)this.Label6);
            this.Panel1.Controls.Add((Control)this.txtResidential);
            this.Panel1.Controls.Add((Control)this.Label7);
            this.Panel1.Controls.Add((Control)this.Label4);
            this.Panel1.Controls.Add((Control)this.txtTel2);
            this.Panel1.Controls.Add((Control)this.txtFax);
            this.Panel1.Controls.Add((Control)this.Label8);
            this.Panel1.Controls.Add((Control)this.txtCell1);
            this.Panel1.Controls.Add((Control)this.Label9);
            this.Panel1.Dock = DockStyle.Fill;
            Panel panel1_1 = this.Panel1;
            point1 = new Point(8, 280);
            Point point20 = point1;
            panel1_1.Location = point20;
            this.Panel1.Name = "Panel1";
            Panel panel1_2 = this.Panel1;
            size1 = new Size(612, 210);
            Size size20 = size1;
            panel1_2.Size = size20;
            this.Panel1.TabIndex = 0;
            this.Panel3.Controls.Add((Control)this.btnCancel);
            this.Panel3.Controls.Add((Control)this.btnSave);
            this.Panel3.Dock = DockStyle.Bottom;
            Panel panel3_1 = this.Panel3;
            point1 = new Point(0, 172);
            Point point21 = point1;
            panel3_1.Location = point21;
            this.Panel3.Name = "Panel3";
            Panel panel3_2 = this.Panel3;
            size1 = new Size(612, 38);
            Size size21 = size1;
            panel3_2.Size = size21;
            this.Panel3.TabIndex = 101;
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
            Size size22 = size1;
            btnCancel1.ImageSize = size22;
            SoftButton btnCancel2 = this.btnCancel;
            point1 = new Point(510, 3);
            Point point22 = point1;
            btnCancel2.Location = point22;
            this.btnCancel.Name = "btnCancel";
            SoftButton btnCancel3 = this.btnCancel;
            size1 = new Size(76, 30);
            Size size23 = size1;
            btnCancel3.Size = size23;
            this.btnCancel.TabIndex = 65;
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
            this.btnSave.Image = (Image)componentResourceManager.GetObject("btnSave.Image");
            SoftButton btnSave1 = this.btnSave;
            size1 = new Size(16, 16);
            Size size24 = size1;
            btnSave1.ImageSize = size24;
            SoftButton btnSave2 = this.btnSave;
            point1 = new Point(437, 3);
            Point point23 = point1;
            btnSave2.Location = point23;
            this.btnSave.Name = "btnSave";
            SoftButton btnSave3 = this.btnSave;
            size1 = new Size(67, 30);
            Size size25 = size1;
            btnSave3.Size = size25;
            this.btnSave.TabIndex = 64;
            this.btnSave.TextAlign = ContentAlignment.MiddleRight;
            TextBox txtEmail1 = this.txtEmail;
            point1 = new Point(99, 145);
            Point point24 = point1;
            txtEmail1.Location = point24;
            this.txtEmail.MaxLength = 20;
            this.txtEmail.Name = "txtEmail";
            TextBox txtEmail2 = this.txtEmail;
            size1 = new Size(165, 21);
            Size size26 = size1;
            txtEmail2.Size = size26;
            this.txtEmail.TabIndex = 25;
            this.Label22.AutoSize = true;
            this.Label22.ForeColor = Color.Black;
            Label label22_1 = this.Label22;
            point1 = new Point(-3, 148);
            Point point25 = point1;
            label22_1.Location = point25;
            this.Label22.Name = "Label22";
            Label label22_2 = this.Label22;
            size1 = new Size(35, 13);
            Size size27 = size1;
            label22_2.Size = size27;
            this.Label22.TabIndex = 62;
            this.Label22.Text = "E-Mail";
            this.Layout.ColumnCount = 1;
            this.Layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.Layout.Controls.Add((Control)this.Panel2, 0, 0);
            this.Layout.Controls.Add((Control)this.Panel1, 0, 3);
            this.Layout.Controls.Add((Control)this.pnlPrivate, 0, 1);
            this.Layout.Controls.Add((Control)this.pnlCompany, 0, 2);
            this.Layout.Dock = DockStyle.Fill;
            TableLayoutPanel layout1 = this.Layout;
            point1 = new Point(0, 0);
            Point point26 = point1;
            layout1.Location = point26;
            this.Layout.Name = "Layout";
            this.Layout.Padding = new Padding(5);
            this.Layout.RowCount = 4;
            this.Layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 65f));
            this.Layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35f));
            this.Layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 172f));
            this.Layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 187f));
            this.Layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
            TableLayoutPanel layout2 = this.Layout;
            size1 = new Size(628, 498);
            Size size28 = size1;
            layout2.Size = size28;
            this.Layout.TabIndex = 63;
            this.Panel2.Controls.Add((Control)this.Label24);
            this.Panel2.Controls.Add((Control)this.Label23);
            this.Panel2.Controls.Add((Control)this.Label1);
            this.Panel2.Controls.Add((Control)this.txtAccountNr);
            this.Panel2.Controls.Add((Control)this.Label3);
            this.Panel2.Controls.Add((Control)this.cmbCustomerType);
            this.Panel2.Controls.Add((Control)this.txtName);
            this.Panel2.Controls.Add((Control)this.Label2);
            this.Panel2.Dock = DockStyle.Fill;
            Panel panel2_1 = this.Panel2;
            point1 = new Point(8, 8);
            Point point27 = point1;
            panel2_1.Location = point27;
            this.Panel2.Name = "Panel2";
            Panel panel2_2 = this.Panel2;
            size1 = new Size(612, 59);
            Size size29 = size1;
            panel2_2.Size = size29;
            this.Panel2.TabIndex = 64;
            this.pnlPrivate.Controls.Add((Control)this.Label25);
            this.pnlPrivate.Controls.Add((Control)this.txtClientID);
            this.pnlPrivate.Controls.Add((Control)this.Label11);
            this.pnlPrivate.Dock = DockStyle.Fill;
            Panel pnlPrivate1 = this.pnlPrivate;
            point1 = new Point(8, 73);
            Point point28 = point1;
            pnlPrivate1.Location = point28;
            this.pnlPrivate.Name = "pnlPrivate";
            Panel pnlPrivate2 = this.pnlPrivate;
            size1 = new Size(612, 29);
            Size size30 = size1;
            pnlPrivate2.Size = size30;
            this.pnlPrivate.TabIndex = 65;
            TextBox txtClientId1 = this.txtClientID;
            point1 = new Point(99, 3);
            Point point29 = point1;
            txtClientId1.Location = point29;
            this.txtClientID.Name = "txtClientID";
            TextBox txtClientId2 = this.txtClientID;
            size1 = new Size(165, 21);
            Size size31 = size1;
            txtClientId2.Size = size31;
            this.txtClientID.TabIndex = 4;
            this.Label11.AutoSize = true;
            Label label11_1 = this.Label11;
            point1 = new Point(-3, 6);
            Point point30 = point1;
            label11_1.Location = point30;
            this.Label11.Name = "Label11";
            Label label11_2 = this.Label11;
            size1 = new Size(92, 13);
            Size size32 = size1;
            label11_2.Size = size32;
            this.Label11.TabIndex = 0;
            this.Label11.Text = "Client ID Number:";
            this.pnlCompany.Controls.Add((Control)this.Label28);
            this.pnlCompany.Controls.Add((Control)this.Label27);
            this.pnlCompany.Controls.Add((Control)this.Label26);
            this.pnlCompany.Controls.Add((Control)this.txtManagerName);
            this.pnlCompany.Controls.Add((Control)this.Label10);
            this.pnlCompany.Controls.Add((Control)this.txtDir4);
            this.pnlCompany.Controls.Add((Control)this.Label20);
            this.pnlCompany.Controls.Add((Control)this.Label21);
            this.pnlCompany.Controls.Add((Control)this.txtDirID4);
            this.pnlCompany.Controls.Add((Control)this.txtDir3);
            this.pnlCompany.Controls.Add((Control)this.Label18);
            this.pnlCompany.Controls.Add((Control)this.Label19);
            this.pnlCompany.Controls.Add((Control)this.txtDirID3);
            this.pnlCompany.Controls.Add((Control)this.txtDir2);
            this.pnlCompany.Controls.Add((Control)this.Label16);
            this.pnlCompany.Controls.Add((Control)this.Label17);
            this.pnlCompany.Controls.Add((Control)this.txtDirID2);
            this.pnlCompany.Controls.Add((Control)this.txtDir1);
            this.pnlCompany.Controls.Add((Control)this.Label14);
            this.pnlCompany.Controls.Add((Control)this.Label15);
            this.pnlCompany.Controls.Add((Control)this.txtDirID1);
            this.pnlCompany.Controls.Add((Control)this.txtRegNr);
            this.pnlCompany.Controls.Add((Control)this.Label12);
            this.pnlCompany.Controls.Add((Control)this.Label13);
            this.pnlCompany.Controls.Add((Control)this.txtVATNr);
            this.pnlCompany.Dock = DockStyle.Fill;
            Panel pnlCompany1 = this.pnlCompany;
            point1 = new Point(8, 108);
            Point point31 = point1;
            pnlCompany1.Location = point31;
            this.pnlCompany.Name = "pnlCompany";
            Panel pnlCompany2 = this.pnlCompany;
            size1 = new Size(612, 166);
            Size size33 = size1;
            pnlCompany2.Size = size33;
            this.pnlCompany.TabIndex = 66;
            TextBox txtManagerName1 = this.txtManagerName;
            point1 = new Point(99, 138);
            Point point32 = point1;
            txtManagerName1.Location = point32;
            this.txtManagerName.MaxLength = 50;
            this.txtManagerName.Name = "txtManagerName";
            TextBox txtManagerName2 = this.txtManagerName;
            size1 = new Size(487, 21);
            Size size34 = size1;
            txtManagerName2.Size = size34;
            this.txtManagerName.TabIndex = 15;
            this.Label10.AutoSize = true;
            this.Label10.ForeColor = Color.Black;
            Label label10_1 = this.Label10;
            point1 = new Point(-3, 141);
            Point point33 = point1;
            label10_1.Location = point33;
            this.Label10.Name = "Label10";
            Label label10_2 = this.Label10;
            size1 = new Size(82, 13);
            Size size35 = size1;
            label10_2.Size = size35;
            this.Label10.TabIndex = 77;
            this.Label10.Text = "Manager name:";
            TextBox txtDir4_1 = this.txtDir4;
            point1 = new Point(99, 111);
            Point point34 = point1;
            txtDir4_1.Location = point34;
            this.txtDir4.MaxLength = 50;
            this.txtDir4.Name = "txtDir4";
            TextBox txtDir4_2 = this.txtDir4;
            size1 = new Size(165, 21);
            Size size36 = size1;
            txtDir4_2.Size = size36;
            this.txtDir4.TabIndex = 13;
            this.Label20.AutoSize = true;
            this.Label20.ForeColor = Color.Black;
            Label label20_1 = this.Label20;
            point1 = new Point(287, 114);
            Point point35 = point1;
            label20_1.Location = point35;
            this.Label20.Name = "Label20";
            Label label20_2 = this.Label20;
            size1 = new Size(112, 13);
            Size size37 = size1;
            label20_2.Size = size37;
            this.Label20.TabIndex = 75;
            this.Label20.Text = "Director 4 ID Number:";
            this.Label21.AutoSize = true;
            this.Label21.ForeColor = Color.Black;
            Label label21_1 = this.Label21;
            point1 = new Point(-3, 114);
            Point point36 = point1;
            label21_1.Location = point36;
            this.Label21.Name = "Label21";
            Label label21_2 = this.Label21;
            size1 = new Size(88, 13);
            Size size38 = size1;
            label21_2.Size = size38;
            this.Label21.TabIndex = 74;
            this.Label21.Text = "Director 4 Name:";
            TextBox txtDirId4_1 = this.txtDirID4;
            point1 = new Point(405, 111);
            Point point37 = point1;
            txtDirId4_1.Location = point37;
            this.txtDirID4.MaxLength = 50;
            this.txtDirID4.Name = "txtDirID4";
            TextBox txtDirId4_2 = this.txtDirID4;
            size1 = new Size(181, 21);
            Size size39 = size1;
            txtDirId4_2.Size = size39;
            this.txtDirID4.TabIndex = 14;
            TextBox txtDir3_1 = this.txtDir3;
            point1 = new Point(99, 84);
            Point point38 = point1;
            txtDir3_1.Location = point38;
            this.txtDir3.MaxLength = 50;
            this.txtDir3.Name = "txtDir3";
            TextBox txtDir3_2 = this.txtDir3;
            size1 = new Size(165, 21);
            Size size40 = size1;
            txtDir3_2.Size = size40;
            this.txtDir3.TabIndex = 11;
            this.Label18.AutoSize = true;
            this.Label18.ForeColor = Color.Black;
            Label label18_1 = this.Label18;
            point1 = new Point(287, 87);
            Point point39 = point1;
            label18_1.Location = point39;
            this.Label18.Name = "Label18";
            Label label18_2 = this.Label18;
            size1 = new Size(112, 13);
            Size size41 = size1;
            label18_2.Size = size41;
            this.Label18.TabIndex = 71;
            this.Label18.Text = "Director 3 ID Number:";
            this.Label19.AutoSize = true;
            this.Label19.ForeColor = Color.Black;
            Label label19_1 = this.Label19;
            point1 = new Point(-3, 87);
            Point point40 = point1;
            label19_1.Location = point40;
            this.Label19.Name = "Label19";
            Label label19_2 = this.Label19;
            size1 = new Size(88, 13);
            Size size42 = size1;
            label19_2.Size = size42;
            this.Label19.TabIndex = 70;
            this.Label19.Text = "Director 3 Name:";
            TextBox txtDirId3_1 = this.txtDirID3;
            point1 = new Point(405, 84);
            Point point41 = point1;
            txtDirId3_1.Location = point41;
            this.txtDirID3.MaxLength = 50;
            this.txtDirID3.Name = "txtDirID3";
            TextBox txtDirId3_2 = this.txtDirID3;
            size1 = new Size(181, 21);
            Size size43 = size1;
            txtDirId3_2.Size = size43;
            this.txtDirID3.TabIndex = 12;
            TextBox txtDir2_1 = this.txtDir2;
            point1 = new Point(99, 57);
            Point point42 = point1;
            txtDir2_1.Location = point42;
            this.txtDir2.MaxLength = 50;
            this.txtDir2.Name = "txtDir2";
            TextBox txtDir2_2 = this.txtDir2;
            size1 = new Size(165, 21);
            Size size44 = size1;
            txtDir2_2.Size = size44;
            this.txtDir2.TabIndex = 9;
            this.Label16.AutoSize = true;
            this.Label16.ForeColor = Color.Black;
            Label label16_1 = this.Label16;
            point1 = new Point(287, 60);
            Point point43 = point1;
            label16_1.Location = point43;
            this.Label16.Name = "Label16";
            Label label16_2 = this.Label16;
            size1 = new Size(112, 13);
            Size size45 = size1;
            label16_2.Size = size45;
            this.Label16.TabIndex = 67;
            this.Label16.Text = "Director 2 ID Number:";
            this.Label17.AutoSize = true;
            this.Label17.ForeColor = Color.Black;
            Label label17_1 = this.Label17;
            point1 = new Point(-3, 60);
            Point point44 = point1;
            label17_1.Location = point44;
            this.Label17.Name = "Label17";
            Label label17_2 = this.Label17;
            size1 = new Size(88, 13);
            Size size46 = size1;
            label17_2.Size = size46;
            this.Label17.TabIndex = 66;
            this.Label17.Text = "Director 2 Name:";
            TextBox txtDirId2_1 = this.txtDirID2;
            point1 = new Point(405, 57);
            Point point45 = point1;
            txtDirId2_1.Location = point45;
            this.txtDirID2.MaxLength = 50;
            this.txtDirID2.Name = "txtDirID2";
            TextBox txtDirId2_2 = this.txtDirID2;
            size1 = new Size(181, 21);
            Size size47 = size1;
            txtDirId2_2.Size = size47;
            this.txtDirID2.TabIndex = 10;
            TextBox txtDir1_1 = this.txtDir1;
            point1 = new Point(99, 30);
            Point point46 = point1;
            txtDir1_1.Location = point46;
            this.txtDir1.MaxLength = 50;
            this.txtDir1.Name = "txtDir1";
            TextBox txtDir1_2 = this.txtDir1;
            size1 = new Size(165, 21);
            Size size48 = size1;
            txtDir1_2.Size = size48;
            this.txtDir1.TabIndex = 7;
            this.Label14.AutoSize = true;
            this.Label14.ForeColor = Color.Black;
            Label label14_1 = this.Label14;
            point1 = new Point(287, 33);
            Point point47 = point1;
            label14_1.Location = point47;
            this.Label14.Name = "Label14";
            Label label14_2 = this.Label14;
            size1 = new Size(112, 13);
            Size size49 = size1;
            label14_2.Size = size49;
            this.Label14.TabIndex = 63;
            this.Label14.Text = "Director 1 ID Number:";
            this.Label15.AutoSize = true;
            this.Label15.ForeColor = Color.Black;
            Label label15_1 = this.Label15;
            point1 = new Point(-3, 33);
            Point point48 = point1;
            label15_1.Location = point48;
            this.Label15.Name = "Label15";
            Label label15_2 = this.Label15;
            size1 = new Size(88, 13);
            Size size50 = size1;
            label15_2.Size = size50;
            this.Label15.TabIndex = 62;
            this.Label15.Text = "Director 1 Name:";
            TextBox txtDirId1_1 = this.txtDirID1;
            point1 = new Point(405, 30);
            Point point49 = point1;
            txtDirId1_1.Location = point49;
            this.txtDirID1.MaxLength = 50;
            this.txtDirID1.Name = "txtDirID1";
            TextBox txtDirId1_2 = this.txtDirID1;
            size1 = new Size(181, 21);
            Size size51 = size1;
            txtDirId1_2.Size = size51;
            this.txtDirID1.TabIndex = 8;
            TextBox txtRegNr1 = this.txtRegNr;
            point1 = new Point(99, 3);
            Point point50 = point1;
            txtRegNr1.Location = point50;
            this.txtRegNr.MaxLength = 50;
            this.txtRegNr.Name = "txtRegNr";
            TextBox txtRegNr2 = this.txtRegNr;
            size1 = new Size(165, 21);
            Size size52 = size1;
            txtRegNr2.Size = size52;
            this.txtRegNr.TabIndex = 5;
            this.Label12.AutoSize = true;
            this.Label12.ForeColor = Color.Black;
            Label label12_1 = this.Label12;
            point1 = new Point(287, 6);
            Point point51 = point1;
            label12_1.Location = point51;
            this.Label12.Name = "Label12";
            Label label12_2 = this.Label12;
            size1 = new Size(105, 13);
            Size size53 = size1;
            label12_2.Size = size53;
            this.Label12.TabIndex = 59;
            this.Label12.Text = "VAT Registration Nr:";
            this.Label13.AutoSize = true;
            this.Label13.ForeColor = Color.Black;
            Label label13_1 = this.Label13;
            point1 = new Point(-3, 6);
            Point point52 = point1;
            label13_1.Location = point52;
            this.Label13.Name = "Label13";
            Label label13_2 = this.Label13;
            size1 = new Size(83, 13);
            Size size54 = size1;
            label13_2.Size = size54;
            this.Label13.TabIndex = 58;
            this.Label13.Text = "Registration Nr:";
            TextBox txtVatNr1 = this.txtVATNr;
            point1 = new Point(405, 3);
            Point point53 = point1;
            txtVatNr1.Location = point53;
            this.txtVATNr.MaxLength = 50;
            this.txtVATNr.Name = "txtVATNr";
            TextBox txtVatNr2 = this.txtVATNr;
            size1 = new Size(181, 21);
            Size size55 = size1;
            txtVatNr2.Size = size55;
            this.txtVATNr.TabIndex = 6;
            this.Label23.AutoSize = true;
            this.Label23.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label23.ForeColor = Color.Red;
            Label label23_1 = this.Label23;
            point1 = new Point(265, 6);
            Point point54 = point1;
            label23_1.Location = point54;
            this.Label23.Name = "Label23";
            Label label23_2 = this.Label23;
            size1 = new Size(16, 16);
            Size size56 = size1;
            label23_2.Size = size56;
            this.Label23.TabIndex = 62;
            this.Label23.Text = "*";
            this.Label24.AutoSize = true;
            this.Label24.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label24.ForeColor = Color.Red;
            Label label24_1 = this.Label24;
            point1 = new Point(592, 33);
            Point point55 = point1;
            label24_1.Location = point55;
            this.Label24.Name = "Label24";
            Label label24_2 = this.Label24;
            size1 = new Size(16, 16);
            Size size57 = size1;
            label24_2.Size = size57;
            this.Label24.TabIndex = 63;
            this.Label24.Text = "*";
            this.Label25.AutoSize = true;
            this.Label25.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label25.ForeColor = Color.Red;
            Label label25_1 = this.Label25;
            point1 = new Point(265, 3);
            Point point56 = point1;
            label25_1.Location = point56;
            this.Label25.Name = "Label25";
            Label label25_2 = this.Label25;
            size1 = new Size(16, 16);
            Size size58 = size1;
            label25_2.Size = size58;
            this.Label25.TabIndex = 62;
            this.Label25.Text = "*";
            this.Label26.AutoSize = true;
            this.Label26.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label26.ForeColor = Color.Red;
            Label label26_1 = this.Label26;
            point1 = new Point(265, 3);
            Point point57 = point1;
            label26_1.Location = point57;
            this.Label26.Name = "Label26";
            Label label26_2 = this.Label26;
            size1 = new Size(16, 16);
            Size size59 = size1;
            label26_2.Size = size59;
            this.Label26.TabIndex = 78;
            this.Label26.Text = "*";
            this.Label27.AutoSize = true;
            this.Label27.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label27.ForeColor = Color.Red;
            Label label27_1 = this.Label27;
            point1 = new Point(265, 30);
            Point point58 = point1;
            label27_1.Location = point58;
            this.Label27.Name = "Label27";
            Label label27_2 = this.Label27;
            size1 = new Size(16, 16);
            Size size60 = size1;
            label27_2.Size = size60;
            this.Label27.TabIndex = 79;
            this.Label27.Text = "*";
            this.Label28.AutoSize = true;
            this.Label28.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label28.ForeColor = Color.Red;
            Label label28_1 = this.Label28;
            point1 = new Point(592, 27);
            Point point59 = point1;
            label28_1.Location = point59;
            this.Label28.Name = "Label28";
            Label label28_2 = this.Label28;
            size1 = new Size(16, 16);
            Size size61 = size1;
            label28_2.Size = size61;
            this.Label28.TabIndex = 80;
            this.Label28.Text = "*";
            this.Label29.AutoSize = true;
            this.Label29.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label29.ForeColor = Color.Red;
            Label label29_1 = this.Label29;
            point1 = new Point(265, 0);
            Point point60 = point1;
            label29_1.Location = point60;
            this.Label29.Name = "Label29";
            Label label29_2 = this.Label29;
            size1 = new Size(16, 16);
            Size size62 = size1;
            label29_2.Size = size62;
            this.Label29.TabIndex = 102;
            this.Label29.Text = "*";
            this.Label30.AutoSize = true;
            this.Label30.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label30.ForeColor = Color.Red;
            Label label30_1 = this.Label30;
            point1 = new Point(592, -3);
            Point point61 = point1;
            label30_1.Location = point61;
            this.Label30.Name = "Label30";
            Label label30_2 = this.Label30;
            size1 = new Size(16, 16);
            Size size63 = size1;
            label30_2.Size = size63;
            this.Label30.TabIndex = 103;
            this.Label30.Text = "*";
            this.Label31.AutoSize = true;
            this.Label31.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label31.ForeColor = Color.Red;
            Label label31_1 = this.Label31;
            point1 = new Point(265, 91);
            Point point62 = point1;
            label31_1.Location = point62;
            this.Label31.Name = "Label31";
            Label label31_2 = this.Label31;
            size1 = new Size(16, 16);
            Size size64 = size1;
            label31_2.Size = size64;
            this.Label31.TabIndex = 104;
            this.Label31.Text = "*";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            size1 = new Size(628, 498);
            this.ClientSize = size1;
            this.Controls.Add((Control)this.Layout);
            this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = nameof(frmCustomerDetail);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Customer Detail";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Layout.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.pnlPrivate.ResumeLayout(false);
            this.pnlPrivate.PerformLayout();
            this.pnlCompany.ResumeLayout(false);
            this.pnlCompany.PerformLayout();
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

        internal virtual TextBox txtAccountNr
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtAccountNr;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtAccountNr != null)
                    this._txtAccountNr.TextChanged -= eventHandler;
                this._txtAccountNr = value;
                if (this._txtAccountNr == null)
                    return;
                this._txtAccountNr.TextChanged += eventHandler;
            }
        }

        internal virtual ComboBox cmbCustomerType
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cmbCustomerType;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler1 = new EventHandler(this.cmbCustomerType_SelectedIndexChanged);
                EventHandler eventHandler2 = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._cmbCustomerType != null)
                {
                    this._cmbCustomerType.SelectedIndexChanged -= eventHandler1;
                    this._cmbCustomerType.SelectedIndexChanged -= eventHandler2;
                }
                this._cmbCustomerType = value;
                if (this._cmbCustomerType == null)
                    return;
                this._cmbCustomerType.SelectedIndexChanged += eventHandler1;
                this._cmbCustomerType.SelectedIndexChanged += eventHandler2;
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

        internal virtual TextBox txtName
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtName;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtName != null)
                    this._txtName.TextChanged -= eventHandler;
                this._txtName = value;
                if (this._txtName == null)
                    return;
                this._txtName.TextChanged += eventHandler;
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

        internal virtual TextBox txtResidential
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtResidential;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtResidential != null)
                    this._txtResidential.TextChanged -= eventHandler;
                this._txtResidential = value;
                if (this._txtResidential == null)
                    return;
                this._txtResidential.TextChanged += eventHandler;
            }
        }

        internal virtual TextBox txtPostal
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtPostal;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtPostal != null)
                    this._txtPostal.TextChanged -= eventHandler;
                this._txtPostal = value;
                if (this._txtPostal == null)
                    return;
                this._txtPostal.TextChanged += eventHandler;
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

        internal virtual TextBox txtTel1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtTel1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtTel1 != null)
                    this._txtTel1.TextChanged -= eventHandler;
                this._txtTel1 = value;
                if (this._txtTel1 == null)
                    return;
                this._txtTel1.TextChanged += eventHandler;
            }
        }

        internal virtual Label Label6
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

        internal virtual Label Label7
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

        internal virtual TextBox txtTel2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtTel2;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtTel2 != null)
                    this._txtTel2.TextChanged -= eventHandler;
                this._txtTel2 = value;
                if (this._txtTel2 == null)
                    return;
                this._txtTel2.TextChanged += eventHandler;
            }
        }

        internal virtual Label Label8
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

        internal virtual Label Label9
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

        internal virtual TextBox txtCell1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtCell1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtCell1 != null)
                    this._txtCell1.TextChanged -= eventHandler;
                this._txtCell1 = value;
                if (this._txtCell1 == null)
                    return;
                this._txtCell1.TextChanged += eventHandler;
            }
        }

        internal virtual TextBox txtFax
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtFax;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtFax != null)
                    this._txtFax.TextChanged -= eventHandler;
                this._txtFax = value;
                if (this._txtFax == null)
                    return;
                this._txtFax.TextChanged += eventHandler;
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

        internal virtual TableLayoutPanel Layout
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Layout;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Layout = value;
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

        internal virtual Panel pnlPrivate
        {
            [DebuggerNonUserCode]
            get
            {
                return this._pnlPrivate;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pnlPrivate = value;
            }
        }

        internal virtual TextBox txtClientID
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtClientID;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtClientID != null)
                    this._txtClientID.TextChanged -= eventHandler;
                this._txtClientID = value;
                if (this._txtClientID == null)
                    return;
                this._txtClientID.TextChanged += eventHandler;
            }
        }

        internal virtual Label Label11
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

        internal virtual Panel pnlCompany
        {
            [DebuggerNonUserCode]
            get
            {
                return this._pnlCompany;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pnlCompany = value;
            }
        }

        internal virtual TextBox txtRegNr
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtRegNr;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtRegNr != null)
                    this._txtRegNr.TextChanged -= eventHandler;
                this._txtRegNr = value;
                if (this._txtRegNr == null)
                    return;
                this._txtRegNr.TextChanged += eventHandler;
            }
        }

        internal virtual Label Label12
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

        internal virtual Label Label13
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

        internal virtual TextBox txtVATNr
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtVATNr;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtVATNr != null)
                    this._txtVATNr.TextChanged -= eventHandler;
                this._txtVATNr = value;
                if (this._txtVATNr == null)
                    return;
                this._txtVATNr.TextChanged += eventHandler;
            }
        }

        internal virtual TextBox txtDir4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtDir4;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtDir4 != null)
                    this._txtDir4.TextChanged -= eventHandler;
                this._txtDir4 = value;
                if (this._txtDir4 == null)
                    return;
                this._txtDir4.TextChanged += eventHandler;
            }
        }

        internal virtual Label Label20
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label20;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label20 = value;
            }
        }

        internal virtual Label Label21
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label21;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label21 = value;
            }
        }

        internal virtual TextBox txtDirID4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtDirID4;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtDirID4 != null)
                    this._txtDirID4.TextChanged -= eventHandler;
                this._txtDirID4 = value;
                if (this._txtDirID4 == null)
                    return;
                this._txtDirID4.TextChanged += eventHandler;
            }
        }

        internal virtual TextBox txtDir3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtDir3;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtDir3 != null)
                    this._txtDir3.TextChanged -= eventHandler;
                this._txtDir3 = value;
                if (this._txtDir3 == null)
                    return;
                this._txtDir3.TextChanged += eventHandler;
            }
        }

        internal virtual Label Label18
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

        internal virtual Label Label19
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

        internal virtual TextBox txtDirID3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtDirID3;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtDirID3 != null)
                    this._txtDirID3.TextChanged -= eventHandler;
                this._txtDirID3 = value;
                if (this._txtDirID3 == null)
                    return;
                this._txtDirID3.TextChanged += eventHandler;
            }
        }

        internal virtual TextBox txtDir2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtDir2;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtDir2 != null)
                    this._txtDir2.TextChanged -= eventHandler;
                this._txtDir2 = value;
                if (this._txtDir2 == null)
                    return;
                this._txtDir2.TextChanged += eventHandler;
            }
        }

        internal virtual Label Label16
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

        internal virtual Label Label17
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

        internal virtual TextBox txtDirID2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtDirID2;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtDirID2 != null)
                    this._txtDirID2.TextChanged -= eventHandler;
                this._txtDirID2 = value;
                if (this._txtDirID2 == null)
                    return;
                this._txtDirID2.TextChanged += eventHandler;
            }
        }

        internal virtual TextBox txtDir1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtDir1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtDir1 != null)
                    this._txtDir1.TextChanged -= eventHandler;
                this._txtDir1 = value;
                if (this._txtDir1 == null)
                    return;
                this._txtDir1.TextChanged += eventHandler;
            }
        }

        internal virtual Label Label14
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

        internal virtual Label Label15
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label15;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label15 = value;
            }
        }

        internal virtual TextBox txtDirID1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtDirID1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtDirID1 != null)
                    this._txtDirID1.TextChanged -= eventHandler;
                this._txtDirID1 = value;
                if (this._txtDirID1 == null)
                    return;
                this._txtDirID1.TextChanged += eventHandler;
            }
        }

        internal virtual TextBox txtManagerName
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtManagerName;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtManagerName = value;
            }
        }

        internal virtual Label Label10
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

        internal virtual TextBox txtEmail
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtEmail;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.SetDirty());
                if (this._txtEmail != null)
                    this._txtEmail.TextChanged -= eventHandler;
                this._txtEmail = value;
                if (this._txtEmail == null)
                    return;
                this._txtEmail.TextChanged += eventHandler;
            }
        }

        internal virtual Label Label22
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label22;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label22 = value;
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

        internal virtual Label Label24
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label24;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label24 = value;
            }
        }

        internal virtual Label Label23
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label23;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label23 = value;
            }
        }

        internal virtual Label Label25
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

        internal virtual Label Label26
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label26;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label26 = value;
            }
        }

        internal virtual Label Label31
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label31;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label31 = value;
            }
        }

        internal virtual Label Label30
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label30;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label30 = value;
            }
        }

        internal virtual Label Label29
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label29;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label29 = value;
            }
        }

        internal virtual Label Label28
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label28;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label28 = value;
            }
        }

        internal virtual Label Label27
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label27;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label27 = value;
            }
        }

        private void frmCustomerDetail_Activated(object sender, EventArgs e)
        {
            this.cmbCustomerType.Focus();
        }

        private void frmCustomerDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.saved)
                return;

            switch (MessageBox.Show("Do you want to save your changes?", "Save changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information))
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    this.btnSave.Focus();
                    if (this.SaveInfo())
                        break;
                    e.Cancel = true;
                    break;
            }
        }

        private void CustomerDetail_Load(object sender, EventArgs e)
        {
        }

        public void GetDetails()
        {
            Customer dboCustomer = this.dboCustomer;
            dboCustomer.GetOne((object)this._CustomerID);
            this.cmbCustomerType.SelectedIndex = Conversions.ToInteger(Interaction.IIf(Conversions.ToBoolean(dboCustomer.isCompany), (object)1, (object)0));
            this.txtAccountNr.Text = Conversions.ToString(dboCustomer.AccountNumber);
            this.txtName.Text = Conversions.ToString(dboCustomer.Name);
            this.txtClientID.Text = Conversions.ToString(dboCustomer.PrivateIDNumber);
            this.txtRegNr.Text = Conversions.ToString(dboCustomer.RegistrationNr);
            this.txtVATNr.Text = Conversions.ToString(dboCustomer.VATNr);
            this.txtDirID1.Text = Conversions.ToString(dboCustomer.Director1ID);
            this.txtDirID2.Text = Conversions.ToString(dboCustomer.Director2ID);
            this.txtDirID3.Text = Conversions.ToString(dboCustomer.Director3ID);
            this.txtDirID4.Text = Conversions.ToString(dboCustomer.Director4ID);
            this.txtDir1.Text = Conversions.ToString(dboCustomer.Director1Name);
            this.txtDir2.Text = Conversions.ToString(dboCustomer.Director2Name);
            this.txtDir3.Text = Conversions.ToString(dboCustomer.Director3Name);
            this.txtDir4.Text = Conversions.ToString(dboCustomer.Director4Name);
            this.txtPostal.Text = Conversions.ToString(dboCustomer.PostalAddress);
            this.txtResidential.Text = Conversions.ToString(dboCustomer.ResidentialAddress);
            this.txtTel1.Text = Conversions.ToString(dboCustomer.Tel1);
            this.txtTel2.Text = Conversions.ToString(dboCustomer.Tel2);
            this.txtCell1.Text = Conversions.ToString(dboCustomer.Cell);
            this.txtEmail.Text = Conversions.ToString(dboCustomer.CustomerEmail);
            this.txtFax.Text = Conversions.ToString(dboCustomer.Fax);
            this.txtManagerName.Text = Conversions.ToString(dboCustomer.ManagerName);
            this.saved = true;
        }

        public frmCustomerDetail(int CustomerID = -1)
        {
            this.Activated += new EventHandler(this.frmCustomerDetail_Activated);
            this.FormClosing += new FormClosingEventHandler(this.frmCustomerDetail_FormClosing);
            this.Load += new EventHandler(this.CustomerDetail_Load);
            this.dboCustomer = new Customer(ConnectionInfo.GlobalConnection);
            this._CustomerID = -1;
            this.saved = true;
            this.InitializeComponent();
            if (CustomerID != -1)
            {
                this._CustomerID = CustomerID;
                this.Text = "Edit Customer";
                this.GetDetails();
            }
            else
            {
                this.cmbCustomerType.SelectedIndex = 0;
                this.Text = "New Customer";
            }
        }

        private void cmbCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbCustomerType.SelectedIndex == 0)
            {
                this.Layout.RowStyles[1].Height = 30f;
                this.Layout.RowStyles[2].Height = 0.0f;
                this.pnlCompany.Visible = false;
                this.pnlPrivate.Visible = true;
            }
            else
            {
                this.Layout.RowStyles[2].Height = 166f;
                this.Layout.RowStyles[1].Height = 0.0f;
                this.pnlCompany.Visible = true;
                this.pnlPrivate.Visible = false;
            }
        }

        public void SetDirty()
        {
            this.saved = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Validated()
        {
            bool flag = true;
            if (Operators.CompareString(this.txtName.Text, "", false) == 0)
            {
                General.ShowValidationMessage("Please enter a customer name", (Control)this.txtName);
                return false;
            }
            if (this.cmbCustomerType.SelectedIndex == 0)
            {
                if (Operators.CompareString(this.txtClientID.Text, "", false) == 0)
                {
                    General.ShowValidationMessage("Please enter a customer ID Number", (Control)this.txtClientID);
                    return false;
                }
                if (this.txtClientID.Text.Length != 13 | !Versioned.IsNumeric((object)this.txtClientID.Text))
                {
                    General.ShowValidationMessage("The customer ID number must be 13 numeric characters!", (Control)this.txtClientID);
                    return false;
                }
            }
            else
            {
                if (Operators.CompareString(this.txtRegNr.Text, "", false) == 0)
                {
                    General.ShowValidationMessage("Please enter the customer company registration number", (Control)this.txtRegNr);
                    return false;
                }
                if (Operators.CompareString(this.txtDir1.Text, "", false) == 0)
                {
                    General.ShowValidationMessage("Please enter atleast one director name", (Control)this.txtDir1);
                    return false;
                }
                if (Operators.CompareString(this.txtDirID1.Text, "", false) == 0)
                {
                    General.ShowValidationMessage("Please enter atleast one director ID number", (Control)this.txtRegNr);
                    return false;
                }
                if (this.txtDirID1.Text.Length != 13 | !Versioned.IsNumeric((object)this.txtDirID1.Text))
                {
                    General.ShowValidationMessage("The director ID number must be 13 numeric characters!", (Control)this.txtDirID1);
                    return false;
                }
            }
            if (Operators.CompareString(this.txtPostal.Text, "", false) == 0)
            {
                General.ShowValidationMessage("Please enter the customer postal address", (Control)this.txtPostal);
                return false;
            }
            if (Operators.CompareString(this.txtResidential.Text, "", false) == 0)
            {
                General.ShowValidationMessage("Please enter the customer residential address", (Control)this.txtResidential);
                return false;
            }
            if (Operators.CompareString(this.txtTel1.Text, "", false) != 0)
                return flag;
            General.ShowValidationMessage("Please enter the customer telephone number", (Control)this.txtTel1);
            return false;
        }

        public bool SaveInfo()
        {
            if (!this.Validated())
                return false;
            Customer dboCustomer = this.dboCustomer;
            if (this._CustomerID == -1 & dboCustomer.AlreadyExists(this.txtAccountNr.Text))
            {
                MessageBox.Show($"Customer already exists! Please choose a different Account number.", "User Already Exsts", MessageBoxButtons.OK, MessageBoxIcon.Error);

                bool flag = true;
                return flag;
            }
            dboCustomer.isCompany = (object)this.cmbCustomerType.SelectedIndex;
            dboCustomer.AccountNumber = (object)this.txtAccountNr.Text;
            dboCustomer.Name = (object)this.txtName.Text;
            dboCustomer.PrivateIDNumber = (object)this.txtClientID.Text;
            dboCustomer.RegistrationNr = (object)this.txtRegNr.Text;
            dboCustomer.VATNr = (object)this.txtVATNr.Text;
            dboCustomer.Director1ID = (object)this.txtDirID1.Text;
            dboCustomer.Director2ID = (object)this.txtDirID2.Text;
            dboCustomer.Director3ID = (object)this.txtDirID3.Text;
            dboCustomer.Director4ID = (object)this.txtDirID4.Text;
            dboCustomer.Director1Name = (object)this.txtDir1.Text;
            dboCustomer.Director2Name = (object)this.txtDir2.Text;
            dboCustomer.Director3Name = (object)this.txtDir3.Text;
            dboCustomer.Director4Name = (object)this.txtDir4.Text;
            dboCustomer.PostalAddress = (object)this.txtPostal.Text;
            dboCustomer.ResidentialAddress = (object)this.txtResidential.Text;
            dboCustomer.Tel1 = (object)this.txtTel1.Text;
            dboCustomer.Tel2 = (object)this.txtTel2.Text;
            dboCustomer.Cell = (object)this.txtCell1.Text;
            dboCustomer.CustomerEmail = (object)this.txtEmail.Text;
            dboCustomer.Fax = (object)this.txtFax.Text;
            dboCustomer.ManagerName = (object)this.txtManagerName.Text;
            this.saved = true;
            if (this._CustomerID != -1)
                return dboCustomer.Update((object)this._CustomerID);
            return dboCustomer.Add();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.SaveInfo())
                return;
            MessageBox.Show($"Customer successfully saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
