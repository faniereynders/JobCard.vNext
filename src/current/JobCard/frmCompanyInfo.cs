// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.Core.frmCompanyInfo
// Assembly: JobCard, Version=1.0.0.2, Culture=neutral, PublicKeyToken=null
// MVID: 355A629F-A2FA-4599-879B-59162A296DD0
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCard.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Reytec.Data.Attributes;
using Reytec.Data.Connection;
using Reytec.Data.Engine;
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
  public class frmCompanyInfo : Form
  {
    private IContainer components;
    [AccessedThroughProperty("dlg")]
    private OpenFileDialog _dlg;
    [AccessedThroughProperty("Panel3")]
    private Panel _Panel3;
    [AccessedThroughProperty("btnSave")]
    private SoftButton _btnSave;
    [AccessedThroughProperty("btnCancel")]
    private SoftButton _btnCancel;
    [AccessedThroughProperty("img")]
    private Button _img;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("txtCompanyName")]
    private TextBox _txtCompanyName;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label12")]
    private Label _Label12;
    [AccessedThroughProperty("Label7")]
    private Label _Label7;
    [AccessedThroughProperty("txtPostal")]
    private TextBox _txtPostal;
    [AccessedThroughProperty("txtCell1")]
    private TextBox _txtCell1;
    [AccessedThroughProperty("txtJobPrefix")]
    private TextBox _txtJobPrefix;
    [AccessedThroughProperty("txtFax")]
    private TextBox _txtFax;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("Label8")]
    private Label _Label8;
    [AccessedThroughProperty("Label11")]
    private Label _Label11;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("txtResidential")]
    private TextBox _txtResidential;
    [AccessedThroughProperty("txtCell2")]
    private TextBox _txtCell2;
    [AccessedThroughProperty("txtVATNr")]
    private TextBox _txtVATNr;
    [AccessedThroughProperty("txtTel2")]
    private TextBox _txtTel2;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("Label10")]
    private Label _Label10;
    [AccessedThroughProperty("Label9")]
    private Label _Label9;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("txtTel1")]
    private TextBox _txtTel1;
    [AccessedThroughProperty("txtRegNr")]
    private TextBox _txtRegNr;
    [AccessedThroughProperty("Label13")]
    private Label _Label13;
    [AccessedThroughProperty("Label14")]
    private Label _Label14;
    [AccessedThroughProperty("Label15")]
    private Label _Label15;
    [AccessedThroughProperty("Label16")]
    private Label _Label16;
    [AccessedThroughProperty("Label17")]
    private Label _Label17;
    [AccessedThroughProperty("TabControl1")]
    private TabControl _TabControl1;
    [AccessedThroughProperty("tbUsers")]
    private TabPage _tbUsers;
    [AccessedThroughProperty("lstUsers")]
    private ListView _lstUsers;
    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;
    [AccessedThroughProperty("btnEditUser")]
    private SoftButton _btnEditUser;
    [AccessedThroughProperty("btnAddUser")]
    private SoftButton _btnAddUser;
    [AccessedThroughProperty("btnDelUser")]
    private SoftButton _btnDelUser;
    [AccessedThroughProperty("ImageList1")]
    private ImageList _ImageList1;
    [AccessedThroughProperty("ImageList2")]
    private ImageList _ImageList2;
    [AccessedThroughProperty("Panel2")]
    private Panel _Panel2;
    [AccessedThroughProperty("TableLayoutPanel2")]
    private TableLayoutPanel _TableLayoutPanel2;
    [AccessedThroughProperty("TableLayoutPanel1")]
    private TableLayoutPanel _TableLayoutPanel1;
    [AccessedThroughProperty("tbCompanyInfo")]
    private TabPage _tbCompanyInfo;
    [AccessedThroughProperty("txttradings")]
    private TextBox _txttradings;
    [AccessedThroughProperty("Label18")]
    private Label _Label18;
    [AccessedThroughProperty("Label19")]
    private Label _Label19;
    [AccessedThroughProperty("txtbranchname")]
    private TextBox _txtbranchname;
    [AccessedThroughProperty("Label20")]
    private Label _Label20;
    [AccessedThroughProperty("Label21")]
    private Label _Label21;
    [AccessedThroughProperty("txtnumber")]
    private TextBox _txtnumber;
    private JobCardCompany dboCompany;
    private bool isNewCompanyFlag;
    private Form _parentForm;
    private DataAccess sql;
    private string imgpath;
    private bool changes;
    public bool newFlag;

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
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCompanyInfo));
      this.dlg = new OpenFileDialog();
      this.Label1 = new Label();
      this.txtCompanyName = new TextBox();
      this.Label2 = new Label();
      this.Label12 = new Label();
      this.Label7 = new Label();
      this.txtPostal = new TextBox();
      this.txtCell1 = new TextBox();
      this.txtJobPrefix = new TextBox();
      this.txtFax = new TextBox();
      this.Label3 = new Label();
      this.Label8 = new Label();
      this.Label11 = new Label();
      this.Label6 = new Label();
      this.txtResidential = new TextBox();
      this.txtCell2 = new TextBox();
      this.txtVATNr = new TextBox();
      this.txtTel2 = new TextBox();
      this.Label4 = new Label();
      this.Label10 = new Label();
      this.Label9 = new Label();
      this.Label5 = new Label();
      this.txtTel1 = new TextBox();
      this.txtRegNr = new TextBox();
      this.Label13 = new Label();
      this.Label14 = new Label();
      this.Label15 = new Label();
      this.Label16 = new Label();
      this.Label17 = new Label();
      this.TabControl1 = new TabControl();
      this.tbCompanyInfo = new TabPage();
      this.Label20 = new Label();
      this.Label21 = new Label();
      this.txtnumber = new TextBox();
      this.txttradings = new TextBox();
      this.Label18 = new Label();
      this.Label19 = new Label();
      this.txtbranchname = new TextBox();
      this.img = new Button();
      this.tbUsers = new TabPage();
      this.TableLayoutPanel2 = new TableLayoutPanel();
      this.Panel1 = new Panel();
      this.btnDelUser = new SoftButton();
      this.btnEditUser = new SoftButton();
      this.btnAddUser = new SoftButton();
      this.lstUsers = new ListView();
      this.ImageList1 = new ImageList(this.components);
      this.ImageList2 = new ImageList(this.components);
      this.Panel3 = new Panel();
      this.btnCancel = new SoftButton();
      this.btnSave = new SoftButton();
      this.Panel2 = new Panel();
      this.TableLayoutPanel1 = new TableLayoutPanel();
      this.TabControl1.SuspendLayout();
      this.tbCompanyInfo.SuspendLayout();
      this.tbUsers.SuspendLayout();
      this.TableLayoutPanel2.SuspendLayout();
      this.Panel1.SuspendLayout();
      this.Panel3.SuspendLayout();
      this.Panel2.SuspendLayout();
      this.TableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      this.dlg.DefaultExt = "*.jpg";
      this.dlg.Filter = "Bitmap Files|*.bmp|Jpeg Format|*.jpg|GIF Format|*.gif|Png Format|*.png";
      this.dlg.Title = "Add Company Logo";
      this.Label1.AutoSize = true;
      this.Label1.ForeColor = Color.Black;
      Label label1_1 = this.Label1;
      Point point1 = new Point(6, 115);
      Point point2 = point1;
      label1_1.Location = point2;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      Size size1 = new Size(85, 13);
      Size size2 = size1;
      label1_2.Size = size2;
      this.Label1.TabIndex = 37;
      this.Label1.Text = "Company name:";
      TextBox txtCompanyName1 = this.txtCompanyName;
      point1 = new Point(108, 112);
      Point point3 = point1;
      txtCompanyName1.Location = point3;
      this.txtCompanyName.MaxLength = 50;
      this.txtCompanyName.Name = "txtCompanyName";
      TextBox txtCompanyName2 = this.txtCompanyName;
      size1 = new Size(480, 21);
      Size size3 = size1;
      txtCompanyName2.Size = size3;
      this.txtCompanyName.TabIndex = 2;
      this.Label2.AutoSize = true;
      this.Label2.ForeColor = Color.Black;
      Label label2_1 = this.Label2;
      point1 = new Point(6, 196);
      Point point4 = point1;
      label2_1.Location = point4;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(81, 13);
      Size size4 = size1;
      label2_2.Size = size4;
      this.Label2.TabIndex = 39;
      this.Label2.Text = "Postal address:";
      this.Label12.AutoSize = true;
      this.Label12.ForeColor = Color.Black;
      Label label12_1 = this.Label12;
      point1 = new Point(7, 10);
      Point point5 = point1;
      label12_1.Location = point5;
      this.Label12.Name = "Label12";
      Label label12_2 = this.Label12;
      size1 = new Size(34, 13);
      Size size5 = size1;
      label12_2.Size = size5;
      this.Label12.TabIndex = 59;
      this.Label12.Text = "Logo:";
      this.Label7.AutoSize = true;
      this.Label7.ForeColor = Color.Black;
      Label label7_1 = this.Label7;
      point1 = new Point(296, 287);
      Point point6 = point1;
      label7_1.Location = point6;
      this.Label7.Name = "Label7";
      Label label7_2 = this.Label7;
      size1 = new Size(37, 13);
      Size size6 = size1;
      label7_2.Size = size6;
      this.Label7.TabIndex = 49;
      this.Label7.Text = "Cell 1:";
      TextBox txtPostal1 = this.txtPostal;
      point1 = new Point(108, 193);
      Point point7 = point1;
      txtPostal1.Location = point7;
      this.txtPostal.MaxLength = 100;
      this.txtPostal.Multiline = true;
      this.txtPostal.Name = "txtPostal";
      this.txtPostal.ScrollBars = ScrollBars.Vertical;
      TextBox txtPostal2 = this.txtPostal;
      size1 = new Size(165, 85);
      Size size7 = size1;
      txtPostal2.Size = size7;
      this.txtPostal.TabIndex = 5;
      TextBox txtCell1_1 = this.txtCell1;
      point1 = new Point(407, 284);
      Point point8 = point1;
      txtCell1_1.Location = point8;
      this.txtCell1.MaxLength = 20;
      this.txtCell1.Name = "txtCell1";
      TextBox txtCell1_2 = this.txtCell1;
      size1 = new Size(181, 21);
      Size size8 = size1;
      txtCell1_2.Size = size8;
      this.txtCell1.TabIndex = 8;
      TextBox txtJobPrefix1 = this.txtJobPrefix;
      point1 = new Point(108, 365);
      Point point9 = point1;
      txtJobPrefix1.Location = point9;
      this.txtJobPrefix.MaxLength = 10;
      this.txtJobPrefix.Name = "txtJobPrefix";
      TextBox txtJobPrefix2 = this.txtJobPrefix;
      size1 = new Size(57, 21);
      Size size9 = size1;
      txtJobPrefix2.Size = size9;
      this.txtJobPrefix.TabIndex = 12;
      TextBox txtFax1 = this.txtFax;
      point1 = new Point(108, 338);
      Point point10 = point1;
      txtFax1.Location = point10;
      this.txtFax.MaxLength = 20;
      this.txtFax.Name = "txtFax";
      TextBox txtFax2 = this.txtFax;
      size1 = new Size(165, 21);
      Size size10 = size1;
      txtFax2.Size = size10;
      this.txtFax.TabIndex = 11;
      this.Label3.AutoSize = true;
      this.Label3.ForeColor = Color.Black;
      Label label3_1 = this.Label3;
      point1 = new Point(296, 196);
      Point point11 = point1;
      label3_1.Location = point11;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(104, 13);
      Size size11 = size1;
      label3_2.Size = size11;
      this.Label3.TabIndex = 41;
      this.Label3.Text = "Residential address:";
      this.Label8.AutoSize = true;
      this.Label8.ForeColor = Color.Black;
      Label label8_1 = this.Label8;
      point1 = new Point(296, 314);
      Point point12 = point1;
      label8_1.Location = point12;
      this.Label8.Name = "Label8";
      Label label8_2 = this.Label8;
      size1 = new Size(37, 13);
      Size size12 = size1;
      label8_2.Size = size12;
      this.Label8.TabIndex = 51;
      this.Label8.Text = "Cell 2:";
      this.Label11.AutoSize = true;
      this.Label11.ForeColor = Color.Black;
      Label label11_1 = this.Label11;
      point1 = new Point(7, 368);
      Point point13 = point1;
      label11_1.Location = point13;
      this.Label11.Name = "Label11";
      Label label11_2 = this.Label11;
      size1 = new Size(83, 13);
      Size size13 = size1;
      label11_2.Size = size13;
      this.Label11.TabIndex = 57;
      this.Label11.Text = "Job card prefix:";
      this.Label6.AutoSize = true;
      this.Label6.ForeColor = Color.Black;
      Label label6_1 = this.Label6;
      point1 = new Point(6, 341);
      Point point14 = point1;
      label6_1.Location = point14;
      this.Label6.Name = "Label6";
      Label label6_2 = this.Label6;
      size1 = new Size(29, 13);
      Size size14 = size1;
      label6_2.Size = size14;
      this.Label6.TabIndex = 47;
      this.Label6.Text = "Fax:";
      TextBox txtResidential1 = this.txtResidential;
      point1 = new Point(407, 193);
      Point point15 = point1;
      txtResidential1.Location = point15;
      this.txtResidential.MaxLength = 100;
      this.txtResidential.Multiline = true;
      this.txtResidential.Name = "txtResidential";
      this.txtResidential.ScrollBars = ScrollBars.Vertical;
      TextBox txtResidential2 = this.txtResidential;
      size1 = new Size(181, 85);
      Size size15 = size1;
      txtResidential2.Size = size15;
      this.txtResidential.TabIndex = 6;
      TextBox txtCell2_1 = this.txtCell2;
      point1 = new Point(407, 311);
      Point point16 = point1;
      txtCell2_1.Location = point16;
      this.txtCell2.MaxLength = 20;
      this.txtCell2.Name = "txtCell2";
      TextBox txtCell2_2 = this.txtCell2;
      size1 = new Size(181, 21);
      Size size16 = size1;
      txtCell2_2.Size = size16;
      this.txtCell2.TabIndex = 10;
      TextBox txtVatNr1 = this.txtVATNr;
      point1 = new Point(407, 166);
      Point point17 = point1;
      txtVatNr1.Location = point17;
      this.txtVATNr.MaxLength = 50;
      this.txtVATNr.Name = "txtVATNr";
      TextBox txtVatNr2 = this.txtVATNr;
      size1 = new Size(181, 21);
      Size size17 = size1;
      txtVatNr2.Size = size17;
      this.txtVATNr.TabIndex = 4;
      TextBox txtTel2_1 = this.txtTel2;
      point1 = new Point(108, 311);
      Point point18 = point1;
      txtTel2_1.Location = point18;
      this.txtTel2.MaxLength = 20;
      this.txtTel2.Name = "txtTel2";
      TextBox txtTel2_2 = this.txtTel2;
      size1 = new Size(165, 21);
      Size size18 = size1;
      txtTel2_2.Size = size18;
      this.txtTel2.TabIndex = 9;
      this.Label4.AutoSize = true;
      this.Label4.ForeColor = Color.Black;
      Label label4_1 = this.Label4;
      point1 = new Point(6, 287);
      Point point19 = point1;
      label4_1.Location = point19;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(70, 13);
      Size size19 = size1;
      label4_2.Size = size19;
      this.Label4.TabIndex = 43;
      this.Label4.Text = "Telephone 1:";
      this.Label10.AutoSize = true;
      this.Label10.ForeColor = Color.Black;
      Label label10_1 = this.Label10;
      point1 = new Point(6, 169);
      Point point20 = point1;
      label10_1.Location = point20;
      this.Label10.Name = "Label10";
      Label label10_2 = this.Label10;
      size1 = new Size(82, 13);
      Size size20 = size1;
      label10_2.Size = size20;
      this.Label10.TabIndex = 53;
      this.Label10.Text = "Registration nr:";
      this.Label9.AutoSize = true;
      this.Label9.ForeColor = Color.Black;
      Label label9_1 = this.Label9;
      point1 = new Point(296, 169);
      Point point21 = point1;
      label9_1.Location = point21;
      this.Label9.Name = "Label9";
      Label label9_2 = this.Label9;
      size1 = new Size(101, 13);
      Size size21 = size1;
      label9_2.Size = size21;
      this.Label9.TabIndex = 55;
      this.Label9.Text = "VAT registration nr:";
      this.Label5.AutoSize = true;
      this.Label5.ForeColor = Color.Black;
      Label label5_1 = this.Label5;
      point1 = new Point(6, 314);
      Point point22 = point1;
      label5_1.Location = point22;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(70, 13);
      Size size22 = size1;
      label5_2.Size = size22;
      this.Label5.TabIndex = 45;
      this.Label5.Text = "Telephone 2:";
      TextBox txtTel1_1 = this.txtTel1;
      point1 = new Point(108, 284);
      Point point23 = point1;
      txtTel1_1.Location = point23;
      this.txtTel1.MaxLength = 20;
      this.txtTel1.Name = "txtTel1";
      TextBox txtTel1_2 = this.txtTel1;
      size1 = new Size(165, 21);
      Size size23 = size1;
      txtTel1_2.Size = size23;
      this.txtTel1.TabIndex = 7;
      TextBox txtRegNr1 = this.txtRegNr;
      point1 = new Point(108, 166);
      Point point24 = point1;
      txtRegNr1.Location = point24;
      this.txtRegNr.MaxLength = 50;
      this.txtRegNr.Name = "txtRegNr";
      TextBox txtRegNr2 = this.txtRegNr;
      size1 = new Size(165, 21);
      Size size24 = size1;
      txtRegNr2.Size = size24;
      this.txtRegNr.TabIndex = 3;
      this.Label13.AutoSize = true;
      this.Label13.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label13.ForeColor = Color.Red;
      Label label13_1 = this.Label13;
      point1 = new Point(590, 112);
      Point point25 = point1;
      label13_1.Location = point25;
      this.Label13.Name = "Label13";
      Label label13_2 = this.Label13;
      size1 = new Size(16, 16);
      Size size25 = size1;
      label13_2.Size = size25;
      this.Label13.TabIndex = 60;
      this.Label13.Text = "*";
      this.Label14.AutoSize = true;
      this.Label14.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label14.ForeColor = Color.Red;
      Label label14_1 = this.Label14;
      point1 = new Point(274, 193);
      Point point26 = point1;
      label14_1.Location = point26;
      this.Label14.Name = "Label14";
      Label label14_2 = this.Label14;
      size1 = new Size(16, 16);
      Size size26 = size1;
      label14_2.Size = size26;
      this.Label14.TabIndex = 61;
      this.Label14.Text = "*";
      this.Label15.AutoSize = true;
      this.Label15.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label15.ForeColor = Color.Red;
      Label label15_1 = this.Label15;
      point1 = new Point(590, 166);
      Point point27 = point1;
      label15_1.Location = point27;
      this.Label15.Name = "Label15";
      Label label15_2 = this.Label15;
      size1 = new Size(16, 16);
      Size size27 = size1;
      label15_2.Size = size27;
      this.Label15.TabIndex = 62;
      this.Label15.Text = "*";
      this.Label16.AutoSize = true;
      this.Label16.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label16.ForeColor = Color.Red;
      Label label16_1 = this.Label16;
      point1 = new Point(274, 285);
      Point point28 = point1;
      label16_1.Location = point28;
      this.Label16.Name = "Label16";
      Label label16_2 = this.Label16;
      size1 = new Size(16, 16);
      Size size28 = size1;
      label16_2.Size = size28;
      this.Label16.TabIndex = 63;
      this.Label16.Text = "*";
      this.Label17.AutoSize = true;
      this.Label17.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label17.ForeColor = Color.Red;
      Label label17_1 = this.Label17;
      point1 = new Point(171, 365);
      Point point29 = point1;
      label17_1.Location = point29;
      this.Label17.Name = "Label17";
      Label label17_2 = this.Label17;
      size1 = new Size(16, 16);
      Size size29 = size1;
      label17_2.Size = size29;
      this.Label17.TabIndex = 64;
      this.Label17.Text = "*";
      this.TabControl1.Controls.Add((Control) this.tbCompanyInfo);
      this.TabControl1.Controls.Add((Control) this.tbUsers);
      this.TabControl1.Dock = DockStyle.Fill;
      TabControl tabControl1_1 = this.TabControl1;
      point1 = new Point(6, 6);
      Point point30 = point1;
      tabControl1_1.Location = point30;
      TabControl tabControl1_2 = this.TabControl1;
      Padding padding1 = new Padding(6);
      Padding padding2 = padding1;
      tabControl1_2.Margin = padding2;
      this.TabControl1.Name = "TabControl1";
      this.TabControl1.SelectedIndex = 0;
      TabControl tabControl1_3 = this.TabControl1;
      size1 = new Size(619, 424);
      Size size30 = size1;
      tabControl1_3.Size = size30;
      this.TabControl1.TabIndex = 65;
      this.tbCompanyInfo.Controls.Add((Control) this.Label20);
      this.tbCompanyInfo.Controls.Add((Control) this.Label21);
      this.tbCompanyInfo.Controls.Add((Control) this.txtnumber);
      this.tbCompanyInfo.Controls.Add((Control) this.txttradings);
      this.tbCompanyInfo.Controls.Add((Control) this.Label18);
      this.tbCompanyInfo.Controls.Add((Control) this.Label19);
      this.tbCompanyInfo.Controls.Add((Control) this.txtbranchname);
      this.tbCompanyInfo.Controls.Add((Control) this.img);
      this.tbCompanyInfo.Controls.Add((Control) this.Label15);
      this.tbCompanyInfo.Controls.Add((Control) this.Label17);
      this.tbCompanyInfo.Controls.Add((Control) this.Label13);
      this.tbCompanyInfo.Controls.Add((Control) this.txtRegNr);
      this.tbCompanyInfo.Controls.Add((Control) this.Label16);
      this.tbCompanyInfo.Controls.Add((Control) this.txtTel1);
      this.tbCompanyInfo.Controls.Add((Control) this.Label5);
      this.tbCompanyInfo.Controls.Add((Control) this.Label14);
      this.tbCompanyInfo.Controls.Add((Control) this.Label9);
      this.tbCompanyInfo.Controls.Add((Control) this.Label10);
      this.tbCompanyInfo.Controls.Add((Control) this.Label4);
      this.tbCompanyInfo.Controls.Add((Control) this.Label1);
      this.tbCompanyInfo.Controls.Add((Control) this.txtTel2);
      this.tbCompanyInfo.Controls.Add((Control) this.txtCompanyName);
      this.tbCompanyInfo.Controls.Add((Control) this.txtVATNr);
      this.tbCompanyInfo.Controls.Add((Control) this.Label2);
      this.tbCompanyInfo.Controls.Add((Control) this.txtCell2);
      this.tbCompanyInfo.Controls.Add((Control) this.Label12);
      this.tbCompanyInfo.Controls.Add((Control) this.txtResidential);
      this.tbCompanyInfo.Controls.Add((Control) this.Label7);
      this.tbCompanyInfo.Controls.Add((Control) this.Label6);
      this.tbCompanyInfo.Controls.Add((Control) this.txtPostal);
      this.tbCompanyInfo.Controls.Add((Control) this.Label11);
      this.tbCompanyInfo.Controls.Add((Control) this.txtCell1);
      this.tbCompanyInfo.Controls.Add((Control) this.Label8);
      this.tbCompanyInfo.Controls.Add((Control) this.txtJobPrefix);
      this.tbCompanyInfo.Controls.Add((Control) this.Label3);
      this.tbCompanyInfo.Controls.Add((Control) this.txtFax);
      TabPage tbCompanyInfo1 = this.tbCompanyInfo;
      point1 = new Point(4, 22);
      Point point31 = point1;
      tbCompanyInfo1.Location = point31;
      this.tbCompanyInfo.Name = "tbCompanyInfo";
      TabPage tbCompanyInfo2 = this.tbCompanyInfo;
      padding1 = new Padding(3);
      Padding padding3 = padding1;
      tbCompanyInfo2.Padding = padding3;
      TabPage tbCompanyInfo3 = this.tbCompanyInfo;
      size1 = new Size(611, 398);
      Size size31 = size1;
      tbCompanyInfo3.Size = size31;
      this.tbCompanyInfo.TabIndex = 0;
      this.tbCompanyInfo.Text = "General";
      this.tbCompanyInfo.UseVisualStyleBackColor = true;
      this.Label20.AutoSize = true;
      this.Label20.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label20.ForeColor = Color.Red;
      Label label20_1 = this.Label20;
      point1 = new Point(508, 366);
      Point point32 = point1;
      label20_1.Location = point32;
      this.Label20.Name = "Label20";
      Label label20_2 = this.Label20;
      size1 = new Size(16, 16);
      Size size32 = size1;
      label20_2.Size = size32;
      this.Label20.TabIndex = 71;
      this.Label20.Text = "*";
      this.Label21.AutoSize = true;
      this.Label21.ForeColor = Color.Black;
      Label label21_1 = this.Label21;
      point1 = new Point(296, 368);
      Point point33 = point1;
      label21_1.Location = point33;
      this.Label21.Name = "Label21";
      Label label21_2 = this.Label21;
      size1 = new Size(100, 13);
      Size size33 = size1;
      label21_2.Size = size33;
      this.Label21.TabIndex = 70;
      this.Label21.Text = "Next sequence nr.:";
      TextBox txtnumber1 = this.txtnumber;
      point1 = new Point(407, 365);
      Point point34 = point1;
      txtnumber1.Location = point34;
      this.txtnumber.MaxLength = 10;
      this.txtnumber.Name = "txtnumber";
      TextBox txtnumber2 = this.txtnumber;
      size1 = new Size(95, 21);
      Size size34 = size1;
      txtnumber2.Size = size34;
      this.txtnumber.TabIndex = 69;
      TextBox txttradings1 = this.txttradings;
      point1 = new Point(108, 139);
      Point point35 = point1;
      txttradings1.Location = point35;
      this.txttradings.MaxLength = 50;
      this.txttradings.Name = "txttradings";
      TextBox txttradings2 = this.txttradings;
      size1 = new Size(165, 21);
      Size size35 = size1;
      txttradings2.Size = size35;
      this.txttradings.TabIndex = 65;
      this.Label18.AutoSize = true;
      this.Label18.ForeColor = Color.Black;
      Label label18_1 = this.Label18;
      point1 = new Point(296, 142);
      Point point36 = point1;
      label18_1.Location = point36;
      this.Label18.Name = "Label18";
      Label label18_2 = this.Label18;
      size1 = new Size(73, 13);
      Size size36 = size1;
      label18_2.Size = size36;
      this.Label18.TabIndex = 68;
      this.Label18.Text = "Branch name:";
      this.Label19.AutoSize = true;
      this.Label19.ForeColor = Color.Black;
      Label label19_1 = this.Label19;
      point1 = new Point(6, 142);
      Point point37 = point1;
      label19_1.Location = point37;
      this.Label19.Name = "Label19";
      Label label19_2 = this.Label19;
      size1 = new Size(61, 13);
      Size size37 = size1;
      label19_2.Size = size37;
      this.Label19.TabIndex = 67;
      this.Label19.Text = "Trading as:";
      TextBox txtbranchname1 = this.txtbranchname;
      point1 = new Point(407, 139);
      Point point38 = point1;
      txtbranchname1.Location = point38;
      this.txtbranchname.MaxLength = 50;
      this.txtbranchname.Name = "txtbranchname";
      TextBox txtbranchname2 = this.txtbranchname;
      size1 = new Size(181, 21);
      Size size38 = size1;
      txtbranchname2.Size = size38;
      this.txtbranchname.TabIndex = 66;
      this.img.BackColor = Color.White;
      this.img.BackgroundImageLayout = ImageLayout.Center;
      this.img.Cursor = Cursors.Hand;
      this.img.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
      this.img.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
      this.img.FlatAppearance.MouseOverBackColor = SystemColors.Info;
      this.img.FlatStyle = FlatStyle.Flat;
      this.img.ForeColor = Color.DimGray;
      //this.img.Image = (Image) Reytec.JobCard.Core.My.Resources.Resources.generic_picture;
      this.img.ImageAlign = ContentAlignment.TopCenter;
      Button img1 = this.img;
      point1 = new Point(108, 6);
      Point point39 = point1;
      img1.Location = point39;
      this.img.Name = "img";
      Button img2 = this.img;
      size1 = new Size(480, 100);
      Size size39 = size1;
      img2.Size = size39;
      this.img.TabIndex = 1;
      this.img.TabStop = false;
      this.img.Text = "Click here to add your logo (480 x 100 pixels)";
      this.img.TextAlign = ContentAlignment.BottomCenter;
      this.img.UseCompatibleTextRendering = true;
      this.img.UseVisualStyleBackColor = true;
      this.tbUsers.Controls.Add((Control) this.TableLayoutPanel2);
      TabPage tbUsers1 = this.tbUsers;
      point1 = new Point(4, 22);
      Point point40 = point1;
      tbUsers1.Location = point40;
      this.tbUsers.Name = "tbUsers";
      TabPage tbUsers2 = this.tbUsers;
      padding1 = new Padding(3);
      Padding padding4 = padding1;
      tbUsers2.Padding = padding4;
      TabPage tbUsers3 = this.tbUsers;
      size1 = new Size(611, 398);
      Size size40 = size1;
      tbUsers3.Size = size40;
      this.tbUsers.TabIndex = 1;
      this.tbUsers.Text = "Users";
      this.tbUsers.UseVisualStyleBackColor = true;
      this.TableLayoutPanel2.ColumnCount = 1;
      this.TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
      this.TableLayoutPanel2.Controls.Add((Control) this.Panel1, 0, 0);
      this.TableLayoutPanel2.Controls.Add((Control) this.lstUsers, 0, 1);
      this.TableLayoutPanel2.Dock = DockStyle.Fill;
      TableLayoutPanel tableLayoutPanel2_1 = this.TableLayoutPanel2;
      point1 = new Point(3, 3);
      Point point41 = point1;
      tableLayoutPanel2_1.Location = point41;
      this.TableLayoutPanel2.Name = "TableLayoutPanel2";
      this.TableLayoutPanel2.RowCount = 2;
      this.TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35f));
      this.TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
      TableLayoutPanel tableLayoutPanel2_2 = this.TableLayoutPanel2;
      size1 = new Size(605, 392);
      Size size41 = size1;
      tableLayoutPanel2_2.Size = size41;
      this.TableLayoutPanel2.TabIndex = 5;
      this.Panel1.BackColor = Color.Transparent;
      this.Panel1.Controls.Add((Control) this.btnDelUser);
      this.Panel1.Controls.Add((Control) this.btnEditUser);
      this.Panel1.Controls.Add((Control) this.btnAddUser);
      this.Panel1.Dock = DockStyle.Top;
      Panel panel1_1 = this.Panel1;
      point1 = new Point(0, 0);
      Point point42 = point1;
      panel1_1.Location = point42;
      Panel panel1_2 = this.Panel1;
      padding1 = new Padding(0);
      Padding padding5 = padding1;
      panel1_2.Margin = padding5;
      this.Panel1.Name = "Panel1";
      Panel panel1_3 = this.Panel1;
      size1 = new Size(605, 35);
      Size size42 = size1;
      panel1_3.Size = size42;
      this.Panel1.TabIndex = 4;
      this.btnDelUser.AutoValidate = AutoValidate.EnableAllowFocusChange;
      this.btnDelUser.BackColor = Color.Transparent;
      this.btnDelUser.BaseColor = SystemColors.ButtonFace;
      this.btnDelUser.ButtonColor = SystemColors.ButtonShadow;
      this.btnDelUser.ButtonText = "Delete";
      this.btnDelUser.CornerRadius = 3;
      this.btnDelUser.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnDelUser.ForeColor = SystemColors.ControlText;
      this.btnDelUser.Glow2Color = Color.White;
      this.btnDelUser.GlowColor = SystemColors.Info;
      this.btnDelUser.HighlightColor = SystemColors.ControlLightLight;
      //this.btnDelUser.Image = (Image) Reytec.JobCard.Core.My.Resources.Resources.delete;
      SoftButton btnDelUser1 = this.btnDelUser;
      size1 = new Size(16, 16);
      Size size43 = size1;
      btnDelUser1.ImageSize = size43;
      SoftButton btnDelUser2 = this.btnDelUser;
      point1 = new Point(136, 3);
      Point point43 = point1;
      btnDelUser2.Location = point43;
      this.btnDelUser.Name = "btnDelUser";
      SoftButton btnDelUser3 = this.btnDelUser;
      size1 = new Size(69, 30);
      Size size44 = size1;
      btnDelUser3.Size = size44;
      this.btnDelUser.TabIndex = 15;
      this.btnDelUser.TextAlign = ContentAlignment.MiddleRight;
      this.btnEditUser.AutoValidate = AutoValidate.EnableAllowFocusChange;
      this.btnEditUser.BackColor = Color.Transparent;
      this.btnEditUser.BaseColor = SystemColors.ButtonFace;
      this.btnEditUser.ButtonColor = SystemColors.ButtonShadow;
      this.btnEditUser.ButtonText = "Edit";
      this.btnEditUser.CornerRadius = 3;
      this.btnEditUser.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnEditUser.ForeColor = SystemColors.ControlText;
      this.btnEditUser.Glow2Color = Color.White;
      this.btnEditUser.GlowColor = SystemColors.Info;
      this.btnEditUser.HighlightColor = SystemColors.ControlLightLight;
      this.btnEditUser.Image = (Image) componentResourceManager.GetObject("btnEditUser.Image");
      SoftButton btnEditUser1 = this.btnEditUser;
      size1 = new Size(16, 16);
      Size size45 = size1;
      btnEditUser1.ImageSize = size45;
      SoftButton btnEditUser2 = this.btnEditUser;
      point1 = new Point(70, 2);
      Point point44 = point1;
      btnEditUser2.Location = point44;
      this.btnEditUser.Name = "btnEditUser";
      SoftButton btnEditUser3 = this.btnEditUser;
      size1 = new Size(60, 30);
      Size size46 = size1;
      btnEditUser3.Size = size46;
      this.btnEditUser.TabIndex = 14;
      this.btnEditUser.TextAlign = ContentAlignment.MiddleRight;
      this.btnAddUser.AutoValidate = AutoValidate.EnableAllowFocusChange;
      this.btnAddUser.BackColor = Color.Transparent;
      this.btnAddUser.BaseColor = SystemColors.ButtonFace;
      this.btnAddUser.ButtonColor = SystemColors.ButtonShadow;
      this.btnAddUser.ButtonText = "Add";
      this.btnAddUser.CornerRadius = 3;
      this.btnAddUser.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnAddUser.ForeColor = SystemColors.ControlText;
      this.btnAddUser.Glow2Color = Color.White;
      this.btnAddUser.GlowColor = SystemColors.Info;
      this.btnAddUser.HighlightColor = SystemColors.ControlLightLight;
      //this.btnAddUser.Image = (Image) Reytec.JobCard.Core.My.Resources.Resources.NewCardHS;
      SoftButton btnAddUser1 = this.btnAddUser;
      size1 = new Size(16, 16);
      Size size47 = size1;
      btnAddUser1.ImageSize = size47;
      SoftButton btnAddUser2 = this.btnAddUser;
      point1 = new Point(3, 2);
      Point point45 = point1;
      btnAddUser2.Location = point45;
      this.btnAddUser.Name = "btnAddUser";
      SoftButton btnAddUser3 = this.btnAddUser;
      size1 = new Size(61, 30);
      Size size48 = size1;
      btnAddUser3.Size = size48;
      this.btnAddUser.TabIndex = 13;
      this.btnAddUser.TextAlign = ContentAlignment.MiddleRight;
      this.lstUsers.Dock = DockStyle.Fill;
      this.lstUsers.FullRowSelect = true;
      this.lstUsers.LargeImageList = this.ImageList1;
      ListView lstUsers1 = this.lstUsers;
      point1 = new Point(3, 38);
      Point point46 = point1;
      lstUsers1.Location = point46;
      this.lstUsers.MultiSelect = false;
      this.lstUsers.Name = "lstUsers";
      ListView lstUsers2 = this.lstUsers;
      size1 = new Size(599, 351);
      Size size49 = size1;
      lstUsers2.Size = size49;
      this.lstUsers.TabIndex = 0;
      ListView lstUsers3 = this.lstUsers;
      size1 = new Size(180, 56);
      Size size50 = size1;
      lstUsers3.TileSize = size50;
      this.lstUsers.UseCompatibleStateImageBehavior = false;
      this.lstUsers.View = View.Tile;
      this.ImageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageList1.ImageStream");
      this.ImageList1.TransparentColor = Color.Transparent;
      this.ImageList1.Images.SetKeyName(0, "adminlocked.png");
      this.ImageList1.Images.SetKeyName(1, "admin.png");
      this.ImageList1.Images.SetKeyName(2, "user.png");
      this.ImageList2.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageList2.ImageStream");
      this.ImageList2.TransparentColor = Color.Transparent;
      this.ImageList2.Images.SetKeyName(0, "blank.png");
      this.ImageList2.Images.SetKeyName(1, "ProtectFormHS.png");
      this.Panel3.BackColor = Color.Transparent;
      this.Panel3.Controls.Add((Control) this.btnCancel);
      this.Panel3.Controls.Add((Control) this.btnSave);
      this.Panel3.Dock = DockStyle.Right;
      Panel panel3_1 = this.Panel3;
      point1 = new Point(469, 436);
      Point point47 = point1;
      panel3_1.Location = point47;
      Panel panel3_2 = this.Panel3;
      padding1 = new Padding(0);
      Padding padding6 = padding1;
      panel3_2.Margin = padding6;
      this.Panel3.Name = "Panel3";
      Panel panel3_3 = this.Panel3;
      size1 = new Size(162, 40);
      Size size51 = size1;
      panel3_3.Size = size51;
      this.Panel3.TabIndex = 3;
      this.btnCancel.AutoValidate = AutoValidate.EnableAllowFocusChange;
      this.btnCancel.BackColor = Color.Transparent;
      this.btnCancel.BaseColor = SystemColors.ButtonFace;
      this.btnCancel.ButtonColor = SystemColors.ButtonShadow;
      this.btnCancel.ButtonText = "Cancel";
      this.btnCancel.CornerRadius = 3;
      this.btnCancel.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnCancel.ForeColor = SystemColors.ControlText;
      this.btnCancel.Glow2Color = Color.White;
      this.btnCancel.GlowColor = SystemColors.Info;
      this.btnCancel.HighlightColor = SystemColors.ControlLightLight;
      this.btnCancel.Image = (Image) componentResourceManager.GetObject("btnCancel.Image");
      SoftButton btnCancel1 = this.btnCancel;
      size1 = new Size(16, 16);
      Size size52 = size1;
      btnCancel1.ImageSize = size52;
      SoftButton btnCancel2 = this.btnCancel;
      point1 = new Point(80, 2);
      Point point48 = point1;
      btnCancel2.Location = point48;
      this.btnCancel.Name = "btnCancel";
      SoftButton btnCancel3 = this.btnCancel;
      size1 = new Size(76, 30);
      Size size53 = size1;
      btnCancel3.Size = size53;
      this.btnCancel.TabIndex = 14;
      this.btnCancel.TextAlign = ContentAlignment.MiddleRight;
      this.btnSave.AutoValidate = AutoValidate.EnableAllowFocusChange;
      this.btnSave.BackColor = Color.Transparent;
      this.btnSave.BaseColor = SystemColors.ButtonFace;
      this.btnSave.ButtonColor = SystemColors.ButtonShadow;
      this.btnSave.ButtonText = "Save";
      this.btnSave.CornerRadius = 3;
      this.btnSave.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSave.ForeColor = SystemColors.ControlText;
      this.btnSave.Glow2Color = Color.White;
      this.btnSave.GlowColor = SystemColors.Info;
      this.btnSave.HighlightColor = SystemColors.ControlLightLight;
      this.btnSave.Image = (Image) componentResourceManager.GetObject("btnSave.Image");
      SoftButton btnSave1 = this.btnSave;
      size1 = new Size(16, 16);
      Size size54 = size1;
      btnSave1.ImageSize = size54;
      SoftButton btnSave2 = this.btnSave;
      point1 = new Point(7, 2);
      Point point49 = point1;
      btnSave2.Location = point49;
      this.btnSave.Name = "btnSave";
      SoftButton btnSave3 = this.btnSave;
      size1 = new Size(67, 30);
      Size size55 = size1;
      btnSave3.Size = size55;
      this.btnSave.TabIndex = 13;
      this.btnSave.TextAlign = ContentAlignment.MiddleRight;
      this.Panel2.Controls.Add((Control) this.TableLayoutPanel1);
      this.Panel2.Dock = DockStyle.Fill;
      Panel panel2_1 = this.Panel2;
      point1 = new Point(0, 0);
      Point point50 = point1;
      panel2_1.Location = point50;
      this.Panel2.Name = "Panel2";
      Panel panel2_2 = this.Panel2;
      padding1 = new Padding(3);
      Padding padding7 = padding1;
      panel2_2.Padding = padding7;
      Panel panel2_3 = this.Panel2;
      size1 = new Size(637, 482);
      Size size56 = size1;
      panel2_3.Size = size56;
      this.Panel2.TabIndex = 66;
      this.TableLayoutPanel1.ColumnCount = 1;
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
      this.TableLayoutPanel1.Controls.Add((Control) this.TabControl1, 0, 0);
      this.TableLayoutPanel1.Controls.Add((Control) this.Panel3, 0, 1);
      this.TableLayoutPanel1.Dock = DockStyle.Fill;
      TableLayoutPanel tableLayoutPanel1_1 = this.TableLayoutPanel1;
      point1 = new Point(3, 3);
      Point point51 = point1;
      tableLayoutPanel1_1.Location = point51;
      this.TableLayoutPanel1.Name = "TableLayoutPanel1";
      this.TableLayoutPanel1.RowCount = 2;
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40f));
      TableLayoutPanel tableLayoutPanel1_2 = this.TableLayoutPanel1;
      size1 = new Size(631, 476);
      Size size57 = size1;
      tableLayoutPanel1_2.Size = size57;
      this.TableLayoutPanel1.TabIndex = 66;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ButtonFace;
      size1 = new Size(637, 482);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Panel2);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.White;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (frmCompanyInfo);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "My Company Information";
      this.TabControl1.ResumeLayout(false);
      this.tbCompanyInfo.ResumeLayout(false);
      this.tbCompanyInfo.PerformLayout();
      this.tbUsers.ResumeLayout(false);
      this.TableLayoutPanel2.ResumeLayout(false);
      this.Panel1.ResumeLayout(false);
      this.Panel3.ResumeLayout(false);
      this.Panel2.ResumeLayout(false);
      this.TableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    internal virtual OpenFileDialog dlg
    {
      [DebuggerNonUserCode] get
      {
        return this._dlg;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._dlg = value;
      }
    }

    internal virtual Panel Panel3
    {
      [DebuggerNonUserCode] get
      {
        return this._Panel3;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Panel3 = value;
      }
    }

    internal virtual SoftButton btnSave
    {
      [DebuggerNonUserCode] get
      {
        return this._btnSave;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
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
      [DebuggerNonUserCode] get
      {
        return this._btnCancel;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
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

    internal virtual Button img
    {
      [DebuggerNonUserCode] get
      {
        return this._img;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.img_Click);
        if (this._img != null)
          this._img.Click -= eventHandler;
        this._img = value;
        if (this._img == null)
          return;
        this._img.Click += eventHandler;
      }
    }

    internal virtual Label Label1
    {
      [DebuggerNonUserCode] get
      {
        return this._Label1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label1 = value;
      }
    }

    internal virtual TextBox txtCompanyName
    {
      [DebuggerNonUserCode] get
      {
        return this._txtCompanyName;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.hasChanged);
        EventHandler eventHandler2 = (EventHandler) ((a0, a1) => this.hasChanged());
        if (this._txtCompanyName != null)
        {
          this._txtCompanyName.TextChanged -= eventHandler1;
          this._txtCompanyName.TextChanged -= eventHandler2;
        }
        this._txtCompanyName = value;
        if (this._txtCompanyName == null)
          return;
        this._txtCompanyName.TextChanged += eventHandler1;
        this._txtCompanyName.TextChanged += eventHandler2;
      }
    }

    internal virtual Label Label2
    {
      [DebuggerNonUserCode] get
      {
        return this._Label2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label2 = value;
      }
    }

    internal virtual Label Label12
    {
      [DebuggerNonUserCode] get
      {
        return this._Label12;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label12 = value;
      }
    }

    internal virtual Label Label7
    {
      [DebuggerNonUserCode] get
      {
        return this._Label7;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label7 = value;
      }
    }

    internal virtual TextBox txtPostal
    {
      [DebuggerNonUserCode] get
      {
        return this._txtPostal;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.hasChanged);
        if (this._txtPostal != null)
          this._txtPostal.TextChanged -= eventHandler;
        this._txtPostal = value;
        if (this._txtPostal == null)
          return;
        this._txtPostal.TextChanged += eventHandler;
      }
    }

    internal virtual TextBox txtCell1
    {
      [DebuggerNonUserCode] get
      {
        return this._txtCell1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.hasChanged);
        if (this._txtCell1 != null)
          this._txtCell1.TextChanged -= eventHandler;
        this._txtCell1 = value;
        if (this._txtCell1 == null)
          return;
        this._txtCell1.TextChanged += eventHandler;
      }
    }

    internal virtual TextBox txtJobPrefix
    {
      [DebuggerNonUserCode] get
      {
        return this._txtJobPrefix;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.hasChanged);
        if (this._txtJobPrefix != null)
          this._txtJobPrefix.TextChanged -= eventHandler;
        this._txtJobPrefix = value;
        if (this._txtJobPrefix == null)
          return;
        this._txtJobPrefix.TextChanged += eventHandler;
      }
    }

    internal virtual TextBox txtFax
    {
      [DebuggerNonUserCode] get
      {
        return this._txtFax;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.hasChanged);
        if (this._txtFax != null)
          this._txtFax.TextChanged -= eventHandler;
        this._txtFax = value;
        if (this._txtFax == null)
          return;
        this._txtFax.TextChanged += eventHandler;
      }
    }

    internal virtual Label Label3
    {
      [DebuggerNonUserCode] get
      {
        return this._Label3;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label3 = value;
      }
    }

    internal virtual Label Label8
    {
      [DebuggerNonUserCode] get
      {
        return this._Label8;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label8 = value;
      }
    }

    internal virtual Label Label11
    {
      [DebuggerNonUserCode] get
      {
        return this._Label11;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label11 = value;
      }
    }

    internal virtual Label Label6
    {
      [DebuggerNonUserCode] get
      {
        return this._Label6;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label6 = value;
      }
    }

    internal virtual TextBox txtResidential
    {
      [DebuggerNonUserCode] get
      {
        return this._txtResidential;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.hasChanged);
        if (this._txtResidential != null)
          this._txtResidential.TextChanged -= eventHandler;
        this._txtResidential = value;
        if (this._txtResidential == null)
          return;
        this._txtResidential.TextChanged += eventHandler;
      }
    }

    internal virtual TextBox txtCell2
    {
      [DebuggerNonUserCode] get
      {
        return this._txtCell2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.hasChanged);
        if (this._txtCell2 != null)
          this._txtCell2.TextChanged -= eventHandler;
        this._txtCell2 = value;
        if (this._txtCell2 == null)
          return;
        this._txtCell2.TextChanged += eventHandler;
      }
    }

    internal virtual TextBox txtVATNr
    {
      [DebuggerNonUserCode] get
      {
        return this._txtVATNr;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.hasChanged);
        if (this._txtVATNr != null)
          this._txtVATNr.TextChanged -= eventHandler;
        this._txtVATNr = value;
        if (this._txtVATNr == null)
          return;
        this._txtVATNr.TextChanged += eventHandler;
      }
    }

    internal virtual TextBox txtTel2
    {
      [DebuggerNonUserCode] get
      {
        return this._txtTel2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.hasChanged);
        if (this._txtTel2 != null)
          this._txtTel2.TextChanged -= eventHandler;
        this._txtTel2 = value;
        if (this._txtTel2 == null)
          return;
        this._txtTel2.TextChanged += eventHandler;
      }
    }

    internal virtual Label Label4
    {
      [DebuggerNonUserCode] get
      {
        return this._Label4;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label4 = value;
      }
    }

    internal virtual Label Label10
    {
      [DebuggerNonUserCode] get
      {
        return this._Label10;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label10 = value;
      }
    }

    internal virtual Label Label9
    {
      [DebuggerNonUserCode] get
      {
        return this._Label9;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label9 = value;
      }
    }

    internal virtual Label Label5
    {
      [DebuggerNonUserCode] get
      {
        return this._Label5;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label5 = value;
      }
    }

    internal virtual TextBox txtTel1
    {
      [DebuggerNonUserCode] get
      {
        return this._txtTel1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.hasChanged);
        if (this._txtTel1 != null)
          this._txtTel1.TextChanged -= eventHandler;
        this._txtTel1 = value;
        if (this._txtTel1 == null)
          return;
        this._txtTel1.TextChanged += eventHandler;
      }
    }

    internal virtual TextBox txtRegNr
    {
      [DebuggerNonUserCode] get
      {
        return this._txtRegNr;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.hasChanged);
        EventHandler eventHandler2 = (EventHandler) ((a0, a1) => this.hasChanged());
        if (this._txtRegNr != null)
        {
          this._txtRegNr.TextChanged -= eventHandler1;
          this._txtRegNr.TextChanged -= eventHandler2;
        }
        this._txtRegNr = value;
        if (this._txtRegNr == null)
          return;
        this._txtRegNr.TextChanged += eventHandler1;
        this._txtRegNr.TextChanged += eventHandler2;
      }
    }

    internal virtual Label Label13
    {
      [DebuggerNonUserCode] get
      {
        return this._Label13;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label13 = value;
      }
    }

    internal virtual Label Label14
    {
      [DebuggerNonUserCode] get
      {
        return this._Label14;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label14 = value;
      }
    }

    internal virtual Label Label15
    {
      [DebuggerNonUserCode] get
      {
        return this._Label15;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label15 = value;
      }
    }

    internal virtual Label Label16
    {
      [DebuggerNonUserCode] get
      {
        return this._Label16;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label16 = value;
      }
    }

    internal virtual Label Label17
    {
      [DebuggerNonUserCode] get
      {
        return this._Label17;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label17 = value;
      }
    }

    internal virtual TabControl TabControl1
    {
      [DebuggerNonUserCode] get
      {
        return this._TabControl1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TabControl1 = value;
      }
    }

    internal virtual TabPage tbUsers
    {
      [DebuggerNonUserCode] get
      {
        return this._tbUsers;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._tbUsers = value;
      }
    }

    internal virtual ListView lstUsers
    {
      [DebuggerNonUserCode] get
      {
        return this._lstUsers;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.btnEditUser_Click);
        EventHandler eventHandler2 = new EventHandler(this.lstUsers_SelectedIndexChanged);
        ListViewItemSelectionChangedEventHandler changedEventHandler = new ListViewItemSelectionChangedEventHandler(this.lstUsers_ItemSelectionChanged);
        if (this._lstUsers != null)
        {
          this._lstUsers.ItemActivate -= eventHandler1;
          this._lstUsers.SelectedIndexChanged -= eventHandler2;
          this._lstUsers.ItemSelectionChanged -= changedEventHandler;
        }
        this._lstUsers = value;
        if (this._lstUsers == null)
          return;
        this._lstUsers.ItemActivate += eventHandler1;
        this._lstUsers.SelectedIndexChanged += eventHandler2;
        this._lstUsers.ItemSelectionChanged += changedEventHandler;
      }
    }

    internal virtual Panel Panel1
    {
      [DebuggerNonUserCode] get
      {
        return this._Panel1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Panel1 = value;
      }
    }

    internal virtual SoftButton btnEditUser
    {
      [DebuggerNonUserCode] get
      {
        return this._btnEditUser;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnEditUser_Click);
        if (this._btnEditUser != null)
          this._btnEditUser.Click -= eventHandler;
        this._btnEditUser = value;
        if (this._btnEditUser == null)
          return;
        this._btnEditUser.Click += eventHandler;
      }
    }

    internal virtual SoftButton btnAddUser
    {
      [DebuggerNonUserCode] get
      {
        return this._btnAddUser;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnAddUser_Click);
        if (this._btnAddUser != null)
          this._btnAddUser.Click -= eventHandler;
        this._btnAddUser = value;
        if (this._btnAddUser == null)
          return;
        this._btnAddUser.Click += eventHandler;
      }
    }

    internal virtual SoftButton btnDelUser
    {
      [DebuggerNonUserCode] get
      {
        return this._btnDelUser;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnDelUser_Click);
        if (this._btnDelUser != null)
          this._btnDelUser.Click -= eventHandler;
        this._btnDelUser = value;
        if (this._btnDelUser == null)
          return;
        this._btnDelUser.Click += eventHandler;
      }
    }

    internal virtual ImageList ImageList1
    {
      [DebuggerNonUserCode] get
      {
        return this._ImageList1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ImageList1 = value;
      }
    }

    internal virtual ImageList ImageList2
    {
      [DebuggerNonUserCode] get
      {
        return this._ImageList2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ImageList2 = value;
      }
    }

    internal virtual Panel Panel2
    {
      [DebuggerNonUserCode] get
      {
        return this._Panel2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Panel2 = value;
      }
    }

    internal virtual TableLayoutPanel TableLayoutPanel2
    {
      [DebuggerNonUserCode] get
      {
        return this._TableLayoutPanel2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TableLayoutPanel2 = value;
      }
    }

    internal virtual TableLayoutPanel TableLayoutPanel1
    {
      [DebuggerNonUserCode] get
      {
        return this._TableLayoutPanel1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        PaintEventHandler paintEventHandler = new PaintEventHandler(this.TableLayoutPanel1_Paint);
        if (this._TableLayoutPanel1 != null)
          this._TableLayoutPanel1.Paint -= paintEventHandler;
        this._TableLayoutPanel1 = value;
        if (this._TableLayoutPanel1 == null)
          return;
        this._TableLayoutPanel1.Paint += paintEventHandler;
      }
    }

    internal virtual TabPage tbCompanyInfo
    {
      [DebuggerNonUserCode] get
      {
        return this._tbCompanyInfo;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._tbCompanyInfo = value;
      }
    }

    internal virtual TextBox txttradings
    {
      [DebuggerNonUserCode] get
      {
        return this._txttradings;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.hasChanged);
        if (this._txttradings != null)
          this._txttradings.TextChanged -= eventHandler;
        this._txttradings = value;
        if (this._txttradings == null)
          return;
        this._txttradings.TextChanged += eventHandler;
      }
    }

    internal virtual Label Label18
    {
      [DebuggerNonUserCode] get
      {
        return this._Label18;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label18 = value;
      }
    }

    internal virtual Label Label19
    {
      [DebuggerNonUserCode] get
      {
        return this._Label19;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label19 = value;
      }
    }

    internal virtual TextBox txtbranchname
    {
      [DebuggerNonUserCode] get
      {
        return this._txtbranchname;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.hasChanged);
        if (this._txtbranchname != null)
          this._txtbranchname.TextChanged -= eventHandler;
        this._txtbranchname = value;
        if (this._txtbranchname == null)
          return;
        this._txtbranchname.TextChanged += eventHandler;
      }
    }

    internal virtual Label Label20
    {
      [DebuggerNonUserCode] get
      {
        return this._Label20;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label20 = value;
      }
    }

    internal virtual Label Label21
    {
      [DebuggerNonUserCode] get
      {
        return this._Label21;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label21 = value;
      }
    }

    internal virtual TextBox txtnumber
    {
      [DebuggerNonUserCode] get
      {
        return this._txtnumber;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtnumber_TextChanged);
        if (this._txtnumber != null)
          this._txtnumber.TextChanged -= eventHandler;
        this._txtnumber = value;
        if (this._txtnumber == null)
          return;
        this._txtnumber.TextChanged += eventHandler;
      }
    }

    public event frmCompanyInfo.NewCompanyEventHandler NewCompany;

    private void img_Click(object sender, EventArgs e)
    {
      int num = (int) this.dlg.ShowDialog();
      try
      {
        this.img.BackgroundImage = Image.FromFile(this.dlg.FileName);
        if (this.img.BackgroundImage != null)
        {
          this.img.Text = "";
          this.img.Image = (Image) null;
        }
        this.imgpath = this.dlg.FileName;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.dlg.Dispose();
    }

    public void SaveLogo()
    {
      this.dboCompany.SaveLogo(this.imgpath);
    }

    public bool SaveInfo()
    {
      JobCardCompany dboCompany = this.dboCompany;
      if (this.newFlag)
        ConnectionInfo.RefreshConnection();
      dboCompany.CompanyName = (object) this.txtCompanyName.Text;
      dboCompany.TradingAs = (object) this.txttradings.Text;
      dboCompany.BranchName = (object) this.txtbranchname.Text;
      dboCompany.PostalAddress = (object) this.txtPostal.Text;
      dboCompany.ResidentialAddress = (object) this.txtResidential.Text;
      dboCompany.Tel1 = (object) this.txtTel1.Text;
      dboCompany.Tel2 = (object) this.txtTel2.Text;
      dboCompany.Cell1 = (object) this.txtCell1.Text;
      dboCompany.Cell2 = (object) this.txtCell2.Text;
      dboCompany.Fax = (object) this.txtFax.Text;
      dboCompany.VATNr = (object) this.txtVATNr.Text;
      dboCompany.RegistrationNr = (object) this.txtRegNr.Text;
      dboCompany.JobCardNrPrefix = (object) this.txtJobPrefix.Text;
      dboCompany.NextNumber = (object) this.txtnumber.Text;
      this.changes = false;
      return Conversions.ToBoolean(dboCompany.SaveInfo());
    }

    public void LoadUsers()
    {
      DataTable dataTable = new DataTable();
      this.lstUsers.Clear();
      this.lstUsers.Columns.Add("User");
      this.lstUsers.Columns.Add("Type");
      this.lstUsers.Columns.Add("Description");
      DataTable all = new SystemUser(ConnectionInfo.GlobalConnection).GetAll();
      int num = checked (all.Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        ListViewItem listViewItem = new ListViewItem();
        ListViewItem.ListViewSubItem listViewSubItem1 = new ListViewItem.ListViewSubItem();
        ListViewItem.ListViewSubItem listViewSubItem2 = new ListViewItem.ListViewSubItem();
        ListViewItem.ListViewSubItem listViewSubItem3 = new ListViewItem.ListViewSubItem();
        listViewSubItem2.ForeColor = Color.Gray;
        listViewSubItem3.ForeColor = Color.Gray;
        if (index == 0)
        {
          listViewItem.Text = "Default Account";
          listViewItem.ImageIndex = 0;
          listViewSubItem1.Text = "Administrators";
          listViewSubItem2.Text = "System Administrator";
          listViewSubItem3.Text = "Full Access";
        }
        else
        {
          listViewItem.Text = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(all.Rows[index]["User name"], (object) " "), all.Rows[index]["User Surname"]));
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(all.Rows[index]["isAdmin"], (object) true, false))
          {
            listViewItem.ImageIndex = 1;
            listViewSubItem1.Text = "Administrators";
            listViewSubItem2.Text = "Administrator";
            listViewSubItem3.Text = "Full Access";
          }
          else
          {
            listViewItem.ImageIndex = 2;
            listViewSubItem1.Text = "Users";
            listViewSubItem2.Text = "Normal User";
            listViewSubItem3.Text = "Limited Access";
          }
        }
        listViewItem.Tag = RuntimeHelpers.GetObjectValue(all.Rows[index]["SystemUserID"]);
        listViewItem.SubItems.Add(listViewSubItem2);
        listViewItem.SubItems.Add(listViewSubItem3);
        listViewItem.SubItems.Add(listViewSubItem1);
        this.lstUsers.Items.Add(listViewItem);
        checked { ++index; }
      }
      JobFunctions.GroupColumns(this.lstUsers, 3);
      this.lstUsers.Items[0].Selected = true;
    }

    public void LoadInfo()
    {
      JobCardCompany dboCompany = this.dboCompany;
      dboCompany.GetInfo();
      this.txtCompanyName.Text = Conversions.ToString(dboCompany.CompanyName);
      this.txttradings.Text = Conversions.ToString(dboCompany.TradingAs);
      this.txtbranchname.Text = Conversions.ToString(dboCompany.BranchName);
      this.txtPostal.Text = Conversions.ToString(dboCompany.PostalAddress);
      this.txtResidential.Text = Conversions.ToString(dboCompany.ResidentialAddress);
      this.txtTel1.Text = Conversions.ToString(dboCompany.Tel1);
      this.txtTel2.Text = Conversions.ToString(dboCompany.Tel2);
      this.txtCell1.Text = Conversions.ToString(dboCompany.Cell1);
      this.txtCell2.Text = Conversions.ToString(dboCompany.Cell2);
      this.txtFax.Text = Conversions.ToString(dboCompany.Fax);
      this.txtVATNr.Text = Conversions.ToString(dboCompany.VATNr);
      this.txtRegNr.Text = Conversions.ToString(dboCompany.RegistrationNr);
      this.txtJobPrefix.Text = Conversions.ToString(dboCompany.JobCardNrPrefix);
      this.txtnumber.Text = Conversions.ToString(dboCompany.NextNumber);
      this.img.BackgroundImage = dboCompany.LogoFromField((TableField) dboCompany.Logo);
      this.img.Text = "";
      this.img.Image = (Image) null;
      this.changes = false;
      this.LoadUsers();
    }

    public bool SaveAction()
    {
      if (!this.Validated())
        return false;
      if (this.newFlag)
        this.CreateNewCompany();
      this.changes = false;
      if (!this.SaveInfo())
        return false;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.imgpath, "", false) != 0)
        this.SaveLogo();
      if (this.newFlag)
      {
        frmCompanyInfo.NewCompanyEventHandler newCompanyEvent = this.NewCompanyEvent;
        if (newCompanyEvent != null)
          newCompanyEvent();
      }
      return true;
    }

        private void NewCompanyEvent()
        {
            throw new NotImplementedException();
        }

        private void btnSave_Click(object sender, EventArgs e)
    {
      if (!this.SaveAction())
        return;
      this.Close();
    }

    public bool Validated()
    {
      bool flag = true;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCompanyName.Text, "", false) == 0)
      {
        General.ShowValidationMessage("Please enter your company name", (Control) this.txtCompanyName);
        return false;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtVATNr.Text, "", false) == 0)
      {
        General.ShowValidationMessage("Please enter the company's VAT number", (Control) this.txtVATNr);
        return false;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPostal.Text, "", false) == 0)
      {
        General.ShowValidationMessage("Please enter the company postal address", (Control) this.txtPostal);
        return false;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtTel1.Text, "", false) == 0)
      {
        General.ShowValidationMessage("Please enter the company telephone 1", (Control) this.txtTel1);
        return false;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtJobPrefix.Text, "", false) == 0)
      {
        General.ShowValidationMessage("Please enter a job card prefix", (Control) this.txtJobPrefix);
        return false;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtnumber.Text, "", false) == 0)
      {
        General.ShowValidationMessage("Please enter a job card sequence", (Control) this.txtnumber);
        return false;
      }
      if (Versioned.IsNumeric((object) this.txtnumber.Text))
        return flag;
      General.ShowValidationMessage("Only numeric values accepted for job card sequence", (Control) this.txtnumber);
      return false;
    }

    public frmCompanyInfo(Form parentForm, bool newFlag = false)
    {
      this.FormClosing += new FormClosingEventHandler(this.frmCompanyInfo_FormClosing);
      this.Load += new EventHandler(this.frmCompanyInfo_Load);
      this.dboCompany = new JobCardCompany(ConnectionInfo.GlobalConnection);
      this.isNewCompanyFlag = false;
      this.imgpath = "";
      this.changes = false;
      this.newFlag = false;
      this.InitializeComponent();
      this.isNewCompany = newFlag;
      this._parentForm = parentForm;
      if (this.isNewCompanyFlag)
        return;
      this.sql = new DataAccess(ConnectionInfo.GlobalConnection);
      this.txtnumber.Text = Conversions.ToString(1);
    }

    public bool isNewCompany
    {
      set
      {
        this.isNewCompanyFlag = value;
      }
    }

    public bool hasChanged()
    {
      this.changes = true;
      bool flag = default(bool);
      return flag;
    }

    private void frmCompanyInfo_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (!this.changes)
        return;
      switch (MessageBox.Show("Do you want to save your changes?", "Changes", MessageBoxButtons.YesNoCancel))
      {
        case DialogResult.Cancel:
          e.Cancel = true;
          break;
        case DialogResult.Yes:
          this.SaveAction();
          break;
      }
    }

    public object StripSpaces(string s)
    {
      return (object) Strings.Replace(s, " ", "", 1, -1, CompareMethod.Binary);
    }

    public void CreateNewCompany()
    {
      JobCardCompany dboCompany = this.dboCompany;
      dboCompany.ServerName = Environment.MachineName;
      dboCompany.DatabaseName = Conversions.ToString(this.StripSpaces(this.txtCompanyName.Text));
      dboCompany.CompanyName = (object) this.txtCompanyName.Text;
      dboCompany.CreateNew();
      ConnectionInfo.ConnectionFile = Application.StartupPath + "\\" + dboCompany.DatabaseName + ".jcc";
      DataConnection DALConnection = new DataConnection(ConnectionInfo.GetServerName(), ConnectionInfo.GetDatabaseName(), DataConnection.ProviderType.SQL);
      dboCompany.ChangeConnection(DALConnection);
    }

    private void frmCompanyInfo_Load(object sender, EventArgs e)
    {
      if (this.newFlag)
      {
        this.Text = "Create new Company";
        this.TabControl1.TabPages.Remove(this.tbUsers);
        this.txtnumber.Enabled = true;
        this.txtnumber.Text = Conversions.ToString(1);
      }
      else
      {
        this.LoadInfo();
        this.Text = "Update my company";
        this.txtnumber.Enabled = false;
      }
      this.EnableButtons(false);
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.changes = false;
      this.Close();
    }

    public void EnableButtons(bool setting)
    {
      this.btnEditUser.Enabled = setting;
      this.btnDelUser.Enabled = setting;
    }

    private void lstUsers_ItemSelectionChanged(
      object sender,
      ListViewItemSelectionChangedEventArgs e)
    {
      if (e.IsSelected)
      {
        this.EnableButtons(true);
        if (e.Item.ImageIndex == 0)
          this.btnDelUser.Enabled = false;
        else
          this.btnDelUser.Enabled = true;
      }
      else
        this.EnableButtons(false);
    }

    private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void btnEditUser_Click(object sender, EventArgs e)
    {
      frmUserDetail frmUserDetail = new frmUserDetail(Conversions.ToInteger(this.lstUsers.SelectedItems[0].Tag));
      frmUserDetail.UserChanged += new frmUserDetail.UserChangedEventHandler(this.LoadUsers);
      int num = (int) frmUserDetail.ShowDialog();
      frmUserDetail.Dispose();
    }

    private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void btnAddUser_Click(object sender, EventArgs e)
    {
      frmUserDetail frmUserDetail = new frmUserDetail(-1);
      frmUserDetail.UserChanged += new frmUserDetail.UserChangedEventHandler(this.LoadUsers);
      int num = (int) frmUserDetail.ShowDialog();
      frmUserDetail.Dispose();
    }

    private void btnDelUser_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Are you sure you want to delete this user?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation ) != DialogResult.Yes)
        return;
      new SystemUser(ConnectionInfo.GlobalConnection).Delete(RuntimeHelpers.GetObjectValue(this.lstUsers.SelectedItems[0].Tag));
      this.LoadUsers();
    }

    private void hasChanged(object sender, EventArgs e)
    {
      this.changes = true;
    }

    private void txtnumber_TextChanged(object sender, EventArgs e)
    {
    }

    public delegate void NewCompanyEventHandler();
  }
}
