// Decompiled with JetBrains decompiler
// Type: Reytec.GUI.Controls.DataLookupWindow.LookupForm
// Assembly: ReytecDataLookupWindow, Version=1.0.3386.36143, Culture=neutral, PublicKeyToken=null
// MVID: E8FA6B8F-937A-43C2-80C5-9B0FB7B8E776
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\ReytecDataLookupWindow.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Reytec.GUI.Controls.DataLookupWindow
{
  [DesignerGenerated]
  public class LookupForm : Form
  {
    private IContainer components;
    [AccessedThroughProperty("lt")]
    private ListView _lt;
    [AccessedThroughProperty("btnCancel")]
    private SoftButton _btnCancel;
    [AccessedThroughProperty("btnSubmit")]
    private SoftButton _btnSubmit;
    [AccessedThroughProperty("TableLayoutPanel1")]
    private TableLayoutPanel _TableLayoutPanel1;
    [AccessedThroughProperty("TableLayoutPanel2")]
    private TableLayoutPanel _TableLayoutPanel2;
    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;
    [AccessedThroughProperty("Panel2")]
    private Panel _Panel2;
    [AccessedThroughProperty("txtSearch")]
    private TextBox _txtSearch;
    [AccessedThroughProperty("lblnosearch")]
    private Label _lblnosearch;
    [AccessedThroughProperty("btnclear")]
    private SoftButton _btnclear;
    [AccessedThroughProperty("Panel3")]
    private Panel _Panel3;
    [AccessedThroughProperty("nosearch")]
    private Panel _nosearch;
    [AccessedThroughProperty("lnkagain")]
    private LinkLabel _lnkagain;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("grd")]
    private DataGridView _grd;
    private Collection _ValueCollection;
    private const string delm = "|:::|";
    private Collection _SourceFields;
    private Collection _HideFields;
    private DataTable _ds;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (LookupForm));
      this.lt = new ListView();
      this.TableLayoutPanel1 = new TableLayoutPanel();
      this.TableLayoutPanel2 = new TableLayoutPanel();
      this.Panel1 = new Panel();
      this.btnCancel = new SoftButton();
      this.btnSubmit = new SoftButton();
      this.Panel2 = new Panel();
      this.btnclear = new SoftButton();
      this.lblnosearch = new Label();
      this.txtSearch = new TextBox();
      this.Panel3 = new Panel();
      this.nosearch = new Panel();
      this.Label1 = new Label();
      this.lnkagain = new LinkLabel();
      this.grd = new DataGridView();
      this.TableLayoutPanel1.SuspendLayout();
      this.TableLayoutPanel2.SuspendLayout();
      this.Panel1.SuspendLayout();
      this.Panel2.SuspendLayout();
      this.Panel3.SuspendLayout();
      this.nosearch.SuspendLayout();
      ((ISupportInitialize) this.grd).BeginInit();
      this.SuspendLayout();
      this.lt.FullRowSelect = true;
      ListView lt1 = this.lt;
      Point point1 = new Point(514, 351);
      Point point2 = point1;
      lt1.Location = point2;
      ListView lt2 = this.lt;
      Padding padding1 = new Padding(0);
      Padding padding2 = padding1;
      lt2.Margin = padding2;
      this.lt.MultiSelect = false;
      this.lt.Name = "lt";
      ListView lt3 = this.lt;
      Size size1 = new Size(40, 31);
      Size size2 = size1;
      lt3.Size = size2;
      this.lt.TabIndex = 2;
      this.lt.UseCompatibleStateImageBehavior = false;
      this.lt.View = View.Details;
      this.lt.Visible = false;
      this.TableLayoutPanel1.ColumnCount = 1;
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
      this.TableLayoutPanel1.Controls.Add((Control) this.TableLayoutPanel2, 0, 0);
      this.TableLayoutPanel1.Controls.Add((Control) this.Panel3, 0, 1);
      this.TableLayoutPanel1.Dock = DockStyle.Fill;
      TableLayoutPanel tableLayoutPanel1_1 = this.TableLayoutPanel1;
      point1 = new Point(0, 0);
      Point point3 = point1;
      tableLayoutPanel1_1.Location = point3;
      this.TableLayoutPanel1.Name = "TableLayoutPanel1";
      this.TableLayoutPanel1.RowCount = 2;
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
      TableLayoutPanel tableLayoutPanel1_2 = this.TableLayoutPanel1;
      size1 = new Size(688, 444);
      Size size3 = size1;
      tableLayoutPanel1_2.Size = size3;
      this.TableLayoutPanel1.TabIndex = 4;
      this.TableLayoutPanel2.BackgroundImage = (Image) componentResourceManager.GetObject("TableLayoutPanel2.BackgroundImage");
      this.TableLayoutPanel2.ColumnCount = 2;
      this.TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
      this.TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
      this.TableLayoutPanel2.Controls.Add((Control) this.Panel1, 1, 0);
      this.TableLayoutPanel2.Controls.Add((Control) this.Panel2, 0, 0);
      this.TableLayoutPanel2.Dock = DockStyle.Fill;
      TableLayoutPanel tableLayoutPanel2_1 = this.TableLayoutPanel2;
      point1 = new Point(0, 0);
      Point point4 = point1;
      tableLayoutPanel2_1.Location = point4;
      TableLayoutPanel tableLayoutPanel2_2 = this.TableLayoutPanel2;
      padding1 = new Padding(0);
      Padding padding3 = padding1;
      tableLayoutPanel2_2.Margin = padding3;
      this.TableLayoutPanel2.Name = "TableLayoutPanel2";
      this.TableLayoutPanel2.RowCount = 1;
      this.TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
      TableLayoutPanel tableLayoutPanel2_3 = this.TableLayoutPanel2;
      size1 = new Size(688, 35);
      Size size4 = size1;
      tableLayoutPanel2_3.Size = size4;
      this.TableLayoutPanel2.TabIndex = 4;
      this.Panel1.BackColor = Color.Transparent;
      this.Panel1.Controls.Add((Control) this.btnCancel);
      this.Panel1.Controls.Add((Control) this.btnSubmit);
      this.Panel1.Dock = DockStyle.Right;
      Panel panel1_1 = this.Panel1;
      point1 = new Point(529, 3);
      Point point5 = point1;
      panel1_1.Location = point5;
      this.Panel1.Name = "Panel1";
      Panel panel1_2 = this.Panel1;
      size1 = new Size(156, 29);
      Size size5 = size1;
      panel1_2.Size = size5;
      this.Panel1.TabIndex = 2;
      this.btnCancel.AutoValidate = AutoValidate.EnableAllowFocusChange;
      this.btnCancel.BackColor = Color.Transparent;
      this.btnCancel.BaseColor = Color.FromArgb(33, 124, 180);
      this.btnCancel.ButtonColor = Color.FromArgb(23, 87, 125);
      this.btnCancel.ButtonStyle = SoftButton.Style.Flat;
      this.btnCancel.ButtonText = "Cancel";
      this.btnCancel.CornerRadius = 3;
      this.btnCancel.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnCancel.Glow2Color = Color.FromArgb(209, 242, 250);
      this.btnCancel.GlowColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.btnCancel.HighlightColor = Color.FromArgb(192, 222, 254);
      this.btnCancel.Image = (Image) componentResourceManager.GetObject("btnCancel.Image");
      SoftButton btnCancel1 = this.btnCancel;
      size1 = new Size(16, 16);
      Size size6 = size1;
      btnCancel1.ImageSize = size6;
      SoftButton btnCancel2 = this.btnCancel;
      point1 = new Point(84, 0);
      Point point6 = point1;
      btnCancel2.Location = point6;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.ShadowColor = Color.Black;
      SoftButton btnCancel3 = this.btnCancel;
      size1 = new Size(72, 30);
      Size size7 = size1;
      btnCancel3.Size = size7;
      this.btnCancel.TabIndex = 14;
      this.btnCancel.TextAlign = ContentAlignment.MiddleRight;
      this.btnSubmit.AutoValidate = AutoValidate.EnableAllowFocusChange;
      this.btnSubmit.BackColor = Color.Transparent;
      this.btnSubmit.BaseColor = Color.FromArgb(33, 124, 180);
      this.btnSubmit.ButtonColor = Color.FromArgb(23, 87, 125);
      this.btnSubmit.ButtonStyle = SoftButton.Style.Flat;
      this.btnSubmit.ButtonText = "Accept";
      this.btnSubmit.CornerRadius = 3;
      this.btnSubmit.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSubmit.Glow2Color = Color.FromArgb(209, 242, 250);
      this.btnSubmit.GlowColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.btnSubmit.HighlightColor = Color.FromArgb(192, 222, 254);
      this.btnSubmit.Image = (Image) componentResourceManager.GetObject("btnSubmit.Image");
      SoftButton btnSubmit1 = this.btnSubmit;
      size1 = new Size(16, 16);
      Size size8 = size1;
      btnSubmit1.ImageSize = size8;
      SoftButton btnSubmit2 = this.btnSubmit;
      point1 = new Point(3, 0);
      Point point7 = point1;
      btnSubmit2.Location = point7;
      this.btnSubmit.Name = "btnSubmit";
      this.btnSubmit.ShadowColor = Color.Black;
      SoftButton btnSubmit3 = this.btnSubmit;
      size1 = new Size(75, 30);
      Size size9 = size1;
      btnSubmit3.Size = size9;
      this.btnSubmit.TabIndex = 13;
      this.btnSubmit.TextAlign = ContentAlignment.MiddleRight;
      this.Panel2.BackColor = Color.Transparent;
      this.Panel2.Controls.Add((Control) this.btnclear);
      this.Panel2.Controls.Add((Control) this.lblnosearch);
      this.Panel2.Controls.Add((Control) this.txtSearch);
      this.Panel2.Dock = DockStyle.Fill;
      Panel panel2_1 = this.Panel2;
      point1 = new Point(3, 3);
      Point point8 = point1;
      panel2_1.Location = point8;
      this.Panel2.Name = "Panel2";
      Panel panel2_2 = this.Panel2;
      size1 = new Size(520, 29);
      Size size10 = size1;
      panel2_2.Size = size10;
      this.Panel2.TabIndex = 3;
      this.btnclear.AutoValidate = AutoValidate.EnableAllowFocusChange;
      this.btnclear.BackColor = Color.Transparent;
      this.btnclear.BaseColor = Color.FromArgb(33, 124, 180);
      this.btnclear.ButtonColor = Color.FromArgb(23, 87, 125);
      this.btnclear.ButtonStyle = SoftButton.Style.Flat;
      this.btnclear.ButtonText = "Clear";
      this.btnclear.CornerRadius = 3;
      this.btnclear.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnclear.Glow2Color = Color.FromArgb(209, 242, 250);
      this.btnclear.GlowColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.btnclear.HighlightColor = Color.FromArgb(192, 222, 254);
      this.btnclear.Image = (Image) componentResourceManager.GetObject("btnclear.Image");
      SoftButton btnclear1 = this.btnclear;
      size1 = new Size(16, 16);
      Size size11 = size1;
      btnclear1.ImageSize = size11;
      SoftButton btnclear2 = this.btnclear;
      point1 = new Point(366, 0);
      Point point9 = point1;
      btnclear2.Location = point9;
      this.btnclear.Name = "btnclear";
      this.btnclear.ShadowColor = Color.Black;
      SoftButton btnclear3 = this.btnclear;
      size1 = new Size(61, 30);
      Size size12 = size1;
      btnclear3.Size = size12;
      this.btnclear.TabIndex = 14;
      this.btnclear.TextAlign = ContentAlignment.MiddleRight;
      this.lblnosearch.AutoSize = true;
      this.lblnosearch.BackColor = Color.White;
      this.lblnosearch.Cursor = Cursors.IBeam;
      this.lblnosearch.Font = new Font("Segoe UI", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblnosearch.ForeColor = SystemColors.ControlText;
      Label lblnosearch1 = this.lblnosearch;
      point1 = new Point(13, 6);
      Point point10 = point1;
      lblnosearch1.Location = point10;
      Label lblnosearch2 = this.lblnosearch;
      padding1 = new Padding(0);
      Padding padding4 = padding1;
      lblnosearch2.Margin = padding4;
      this.lblnosearch.Name = "lblnosearch";
      Label lblnosearch3 = this.lblnosearch;
      size1 = new Size(117, 15);
      Size size13 = size1;
      lblnosearch3.Size = size13;
      this.lblnosearch.TabIndex = 3;
      this.lblnosearch.Text = "Type search text here";
      this.lblnosearch.Visible = false;
      TextBox txtSearch1 = this.txtSearch;
      point1 = new Point(6, 4);
      Point point11 = point1;
      txtSearch1.Location = point11;
      this.txtSearch.Name = "txtSearch";
      TextBox txtSearch2 = this.txtSearch;
      size1 = new Size(354, 21);
      Size size14 = size1;
      txtSearch2.Size = size14;
      this.txtSearch.TabIndex = 2;
      this.Panel3.Controls.Add((Control) this.nosearch);
      this.Panel3.Controls.Add((Control) this.grd);
      this.Panel3.Dock = DockStyle.Fill;
      Panel panel3_1 = this.Panel3;
      point1 = new Point(3, 38);
      Point point12 = point1;
      panel3_1.Location = point12;
      this.Panel3.Name = "Panel3";
      Panel panel3_2 = this.Panel3;
      size1 = new Size(682, 403);
      Size size15 = size1;
      panel3_2.Size = size15;
      this.Panel3.TabIndex = 5;
      this.nosearch.BackColor = SystemColors.Window;
      this.nosearch.Controls.Add((Control) this.Label1);
      this.nosearch.Controls.Add((Control) this.lnkagain);
      Panel nosearch1 = this.nosearch;
      point1 = new Point(9, 39);
      Point point13 = point1;
      nosearch1.Location = point13;
      this.nosearch.Name = "nosearch";
      Panel nosearch2 = this.nosearch;
      size1 = new Size(293, 21);
      Size size16 = size1;
      nosearch2.Size = size16;
      this.nosearch.TabIndex = 4;
      this.nosearch.Visible = false;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Segoe UI", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      Label label1_1 = this.Label1;
      point1 = new Point(3, 0);
      Point point14 = point1;
      label1_1.Location = point14;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(172, 15);
      Size size17 = size1;
      label1_2.Size = size17;
      this.Label1.TabIndex = 6;
      this.Label1.Text = "Your search returned no results.";
      this.lnkagain.AutoSize = true;
      this.lnkagain.Font = new Font("Segoe UI", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lnkagain.LinkColor = Color.SteelBlue;
      LinkLabel lnkagain1 = this.lnkagain;
      point1 = new Point(175, 0);
      Point point15 = point1;
      lnkagain1.Location = point15;
      this.lnkagain.Name = "lnkagain";
      LinkLabel lnkagain2 = this.lnkagain;
      size1 = new Size(114, 15);
      Size size18 = size1;
      lnkagain2.Size = size18;
      this.lnkagain.TabIndex = 5;
      this.lnkagain.TabStop = true;
      this.lnkagain.Text = "Try searching again.";
      this.grd.AllowUserToAddRows = false;
      this.grd.AllowUserToDeleteRows = false;
      this.grd.AllowUserToOrderColumns = true;
      this.grd.AllowUserToResizeRows = false;
      this.grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.grd.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
      this.grd.BackgroundColor = SystemColors.Window;
      this.grd.BorderStyle = BorderStyle.Fixed3D;
      this.grd.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
      this.grd.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
      this.grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grd.Dock = DockStyle.Fill;
      this.grd.EditMode = DataGridViewEditMode.EditProgrammatically;
      this.grd.GridColor = SystemColors.ActiveBorder;
      DataGridView grd1 = this.grd;
      point1 = new Point(0, 0);
      Point point16 = point1;
      grd1.Location = point16;
      this.grd.MultiSelect = false;
      this.grd.Name = "grd";
      this.grd.ReadOnly = true;
      this.grd.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
      this.grd.RowHeadersVisible = false;
      this.grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      DataGridView grd2 = this.grd;
      size1 = new Size(682, 403);
      Size size19 = size1;
      grd2.Size = size19;
      this.grd.StandardTab = true;
      this.grd.TabIndex = 5;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(688, 444);
      this.ClientSize = size1;
      this.ControlBox = false;
      this.Controls.Add((Control) this.TableLayoutPanel1);
      this.Controls.Add((Control) this.lt);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      size1 = new Size(606, 406);
      this.MinimumSize = size1;
      this.Name = nameof (LookupForm);
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = nameof (LookupForm);
      this.TableLayoutPanel1.ResumeLayout(false);
      this.TableLayoutPanel2.ResumeLayout(false);
      this.Panel1.ResumeLayout(false);
      this.Panel2.ResumeLayout(false);
      this.Panel2.PerformLayout();
      this.Panel3.ResumeLayout(false);
      this.nosearch.ResumeLayout(false);
      this.nosearch.PerformLayout();
      ((ISupportInitialize) this.grd).EndInit();
      this.ResumeLayout(false);
    }

    internal virtual ListView lt
    {
      [DebuggerNonUserCode] get
      {
        return this._lt;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lt = value;
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

    internal virtual SoftButton btnSubmit
    {
      [DebuggerNonUserCode] get
      {
        return this._btnSubmit;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnSubmit_Click);
        if (this._btnSubmit != null)
          this._btnSubmit.Click -= eventHandler;
        this._btnSubmit = value;
        if (this._btnSubmit == null)
          return;
        this._btnSubmit.Click += eventHandler;
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
        this._TableLayoutPanel1 = value;
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

    internal virtual TextBox txtSearch
    {
      [DebuggerNonUserCode] get
      {
        return this._txtSearch;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtSearch_TextChanged);
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSearch_KeyDown);
        if (this._txtSearch != null)
        {
          this._txtSearch.TextChanged -= eventHandler;
          this._txtSearch.KeyDown -= keyEventHandler;
        }
        this._txtSearch = value;
        if (this._txtSearch == null)
          return;
        this._txtSearch.TextChanged += eventHandler;
        this._txtSearch.KeyDown += keyEventHandler;
      }
    }

    internal virtual Label lblnosearch
    {
      [DebuggerNonUserCode] get
      {
        return this._lblnosearch;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
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

    internal virtual SoftButton btnclear
    {
      [DebuggerNonUserCode] get
      {
        return this._btnclear;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnclear_Click);
        if (this._btnclear != null)
          this._btnclear.Click -= eventHandler;
        this._btnclear = value;
        if (this._btnclear == null)
          return;
        this._btnclear.Click += eventHandler;
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

    internal virtual Panel nosearch
    {
      [DebuggerNonUserCode] get
      {
        return this._nosearch;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._nosearch = value;
      }
    }

    internal virtual LinkLabel lnkagain
    {
      [DebuggerNonUserCode] get
      {
        return this._lnkagain;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler1 = new LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
        LinkLabelLinkClickedEventHandler clickedEventHandler2 = new LinkLabelLinkClickedEventHandler(this.btnclear_Click);
        if (this._lnkagain != null)
        {
          this._lnkagain.LinkClicked -= clickedEventHandler1;
          this._lnkagain.LinkClicked -= clickedEventHandler2;
        }
        this._lnkagain = value;
        if (this._lnkagain == null)
          return;
        this._lnkagain.LinkClicked += clickedEventHandler1;
        this._lnkagain.LinkClicked += clickedEventHandler2;
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

    internal virtual DataGridView grd
    {
      [DebuggerNonUserCode] get
      {
        return this._grd;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.grd_KeyDown);
        DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.grd_CellDoubleClick);
        DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.grd_CellContentClick);
        if (this._grd != null)
        {
          this._grd.KeyDown -= keyEventHandler;
          this._grd.CellDoubleClick -= cellEventHandler1;
          this._grd.CellContentClick -= cellEventHandler2;
        }
        this._grd = value;
        if (this._grd == null)
          return;
        this._grd.KeyDown += keyEventHandler;
        this._grd.CellDoubleClick += cellEventHandler1;
        this._grd.CellContentClick += cellEventHandler2;
      }
    }

    public event LookupForm.NewCompanyEventHandler NewCompany;

    public event LookupForm.ValueSubmittedEventHandler ValueSubmitted;

    public Collection ValueCollection
    {
      set
      {
        this._ValueCollection = value;
      }
    }

    private void LookupForm_Activated(object sender, EventArgs e)
    {
      this.btnSubmit.Focus();
      this.txtSearch.Focus();
    }

    public static void GroupColumns(ListView lst, int col)
    {
      lst.Groups.Clear();
      int num1 = checked (lst.Items.Count - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        lst.Groups.Add(lst.Items[index1].SubItems[col].Text, lst.Items[index1].SubItems[col].Text);
        checked { ++index1; }
      }
      if (col <= 0)
        return;
      int num2 = checked (lst.Items.Count - 1);
      int index2 = 0;
      while (index2 <= num2)
      {
        lst.Items[index2].Group = lst.Groups[lst.Items[index2].SubItems[col].Text];
        checked { ++index2; }
      }
    }

    private void LoadList(DataTable fromTable, string ColNames = null)
    {
      this.grd.DataSource = (object) fromTable;
      string str = "";
      int count1 = this._SourceFields.Count;
      int index1 = 1;
      while (index1 <= count1)
      {
        str = "";
        object objectValue = RuntimeHelpers.GetObjectValue(this._SourceFields[index1]);
        NewLateBinding.LateSetComplex(NewLateBinding.LateGet((object) this.grd.Columns, (System.Type) null, "Item", new object[1]
        {
          RuntimeHelpers.GetObjectValue(objectValue)
        }, (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Tag", new object[1]
        {
          RuntimeHelpers.GetObjectValue(objectValue)
        }, (string[]) null, (System.Type[]) null, false, true);
        checked { ++index1; }
      }
      int count2 = this._HideFields.Count;
      int index2 = 1;
      while (index2 <= count2)
      {
        NewLateBinding.LateSetComplex(NewLateBinding.LateGet((object) this.grd.Columns, (System.Type) null, "Item", new object[1]
        {
          RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(this._HideFields[index2]))
        }, (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Visible", new object[1]
        {
          (object) false
        }, (string[]) null, (System.Type[]) null, false, true);
        checked { ++index2; }
      }
      this.lblnosearch.Visible = true;
    }

    public void CreateLookupListview(
      ListView CurrentListView,
      DataTable fromTable,
      string ColNames = null)
    {
      CurrentListView.Columns.Clear();
      CurrentListView.Items.Clear();
      string str1 = "";
      string[] strArray = Strings.Split(ColNames, ",", -1, CompareMethod.Binary);
      int num1 = checked (fromTable.Columns.Count - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        if (ColNames == null)
          CurrentListView.Columns.Add(fromTable.Columns[index1].ColumnName);
        else
          CurrentListView.Columns.Add(strArray[index1]);
        int count = this._SourceFields.Count;
        int index2 = 1;
        while (index2 <= count)
        {
          str1 = "";
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet((object) null, typeof (Strings), "UCase", new object[1]
          {
            RuntimeHelpers.GetObjectValue(this._SourceFields[index2])
          }, (string[]) null, (System.Type[]) null, (bool[]) null), (object) Strings.UCase(CurrentListView.Columns[index1].Text), false))
          {
            string str2 = Conversions.ToString(this._SourceFields[index2]);
            CurrentListView.Columns[index1].Tag = (object) str2;
            break;
          }
          checked { ++index2; }
        }
        checked { ++index1; }
      }
      int num2 = checked (CurrentListView.Columns.Count - 1);
      int index3 = 0;
      while (index3 <= num2)
      {
        int num3 = checked (fromTable.Rows.Count - 1);
        int index2 = 0;
        while (index2 <= num3)
        {
          str1 = "";
          System.Type Type = typeof (Strings);
          object[] objArray1 = new object[1];
          object[] objArray2 = objArray1;
          DataRow row = fromTable.Rows[index2];
          DataRow dataRow = row;
          int index4 = index3;
          int index5 = index4;
          object objectValue = RuntimeHelpers.GetObjectValue(dataRow[index5]);
          objArray2[0] = objectValue;
          object[] objArray3 = objArray1;
          object[] Arguments = objArray3;
          bool[] flagArray = new bool[1]{ true };
          bool[] CopyBack = flagArray;
          object Left = NewLateBinding.LateGet((object) null, Type, "UCase", Arguments, (string[]) null, (System.Type[]) null, CopyBack);
          if (flagArray[0])
            row[index4] = RuntimeHelpers.GetObjectValue(objArray3[0]);
          string str2 = Strings.UCase(CurrentListView.Columns[index3].Text);
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) str2, false))
          {
            string str3 = Conversions.ToString(fromTable.Rows[index2][index3]);
            CurrentListView.Columns[index3].Tag = (object) str3;
            break;
          }
          checked { ++index2; }
        }
        checked { ++index3; }
      }
      long num4 = (long) checked (fromTable.Rows.Count - 1);
      long num5 = 0;
      while (num5 <= num4)
      {
        int num3 = 0;
        ListView.ListViewItemCollection items = CurrentListView.Items;
        object[] objArray1 = new object[1];
        object[] objArray2 = objArray1;
        DataRow row1 = fromTable.Rows[checked ((int) num5)];
        DataRow dataRow1 = row1;
        int index2 = num3;
        int index4 = index2;
        object objectValue1 = RuntimeHelpers.GetObjectValue(dataRow1[index4]);
        objArray2[0] = objectValue1;
        object[] objArray3 = objArray1;
        object[] Arguments1 = objArray3;
        bool[] flagArray1 = new bool[1]{ true };
        bool[] CopyBack1 = flagArray1;
        NewLateBinding.LateCall((object) items, (System.Type) null, "Add", Arguments1, (string[]) null, (System.Type[]) null, CopyBack1, true);
        if (flagArray1[0])
          row1[index2] = RuntimeHelpers.GetObjectValue(objArray3[0]);
        int num6 = checked (fromTable.Columns.Count - 1);
        int num7 = 1;
        while (num7 <= num6)
        {
          ListViewItem.ListViewSubItemCollection subItems = CurrentListView.Items[checked (CurrentListView.Items.Count - 1)].SubItems;
          object[] objArray4 = new object[1];
          object[] objArray5 = objArray4;
          DataRow row2 = fromTable.Rows[checked ((int) num5)];
          DataRow dataRow2 = row2;
          int index5 = num7;
          int index6 = index5;
          object objectValue2 = RuntimeHelpers.GetObjectValue(dataRow2[index6]);
          objArray5[0] = objectValue2;
          object[] objArray6 = objArray4;
          object[] Arguments2 = objArray6;
          bool[] flagArray2 = new bool[1]{ true };
          bool[] CopyBack2 = flagArray2;
          NewLateBinding.LateCall((object) subItems, (System.Type) null, "Add", Arguments2, (string[]) null, (System.Type[]) null, CopyBack2, true);
          if (flagArray2[0])
            row2[index5] = RuntimeHelpers.GetObjectValue(objArray6[0]);
          checked { ++num7; }
        }
        checked { ++num5; }
      }
      int num8 = checked (CurrentListView.Columns.Count - 1);
      int index7 = 0;
      while (index7 <= num8)
      {
        CurrentListView.Columns[index7].Width = -2;
        checked { ++index7; }
      }
    }

    public static void CreateListview(
      ListView CurrentListView,
      DataTable fromTable,
      string ColNames = null)
    {
      CurrentListView.Columns.Clear();
      CurrentListView.Items.Clear();
      string str1 = "";
      string[] strArray = Strings.Split(ColNames, ",", -1, CompareMethod.Binary);
      int num1 = checked (fromTable.Columns.Count - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        if (ColNames == null)
          CurrentListView.Columns.Add(fromTable.Columns[index1].ColumnName);
        else
          CurrentListView.Columns.Add(strArray[index1]);
        checked { ++index1; }
      }
      int num2 = checked (CurrentListView.Columns.Count - 1);
      int index2 = 0;
      while (index2 <= num2)
      {
        int num3 = checked (fromTable.Rows.Count - 1);
        int index3 = 0;
        while (index3 <= num3)
        {
          str1 = "";
          System.Type Type = typeof (Strings);
          object[] objArray1 = new object[1];
          object[] objArray2 = objArray1;
          DataRow row = fromTable.Rows[index3];
          DataRow dataRow = row;
          int index4 = index2;
          int index5 = index4;
          object objectValue = RuntimeHelpers.GetObjectValue(dataRow[index5]);
          objArray2[0] = objectValue;
          object[] objArray3 = objArray1;
          object[] Arguments = objArray3;
          bool[] flagArray = new bool[1]{ true };
          bool[] CopyBack = flagArray;
          object Left = NewLateBinding.LateGet((object) null, Type, "UCase", Arguments, (string[]) null, (System.Type[]) null, CopyBack);
          if (flagArray[0])
            row[index4] = RuntimeHelpers.GetObjectValue(objArray3[0]);
          string str2 = Strings.UCase(CurrentListView.Columns[index2].Text);
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) str2, false))
          {
            string str3 = Conversions.ToString(fromTable.Rows[index3][index2]);
            CurrentListView.Columns[index2].Tag = (object) str3;
            break;
          }
          checked { ++index3; }
        }
        checked { ++index2; }
      }
      long num4 = (long) checked (fromTable.Rows.Count - 1);
      long num5 = 0;
      while (num5 <= num4)
      {
        int num3 = 0;
        ListView.ListViewItemCollection items = CurrentListView.Items;
        object[] objArray1 = new object[1];
        object[] objArray2 = objArray1;
        DataRow row1 = fromTable.Rows[checked ((int) num5)];
        DataRow dataRow1 = row1;
        int index3 = num3;
        int index4 = index3;
        object objectValue1 = RuntimeHelpers.GetObjectValue(dataRow1[index4]);
        objArray2[0] = objectValue1;
        object[] objArray3 = objArray1;
        object[] Arguments1 = objArray3;
        bool[] flagArray1 = new bool[1]{ true };
        bool[] CopyBack1 = flagArray1;
        NewLateBinding.LateCall((object) items, (System.Type) null, "Add", Arguments1, (string[]) null, (System.Type[]) null, CopyBack1, true);
        if (flagArray1[0])
          row1[index3] = RuntimeHelpers.GetObjectValue(objArray3[0]);
        int num6 = checked (fromTable.Columns.Count - 1);
        int num7 = 1;
        while (num7 <= num6)
        {
          ListViewItem.ListViewSubItemCollection subItems = CurrentListView.Items[checked (CurrentListView.Items.Count - 1)].SubItems;
          object[] objArray4 = new object[1];
          object[] objArray5 = objArray4;
          DataRow row2 = fromTable.Rows[checked ((int) num5)];
          DataRow dataRow2 = row2;
          int index5 = num7;
          int index6 = index5;
          object objectValue2 = RuntimeHelpers.GetObjectValue(dataRow2[index6]);
          objArray5[0] = objectValue2;
          object[] objArray6 = objArray4;
          object[] Arguments2 = objArray6;
          bool[] flagArray2 = new bool[1]{ true };
          bool[] CopyBack2 = flagArray2;
          NewLateBinding.LateCall((object) subItems, (System.Type) null, "Add", Arguments2, (string[]) null, (System.Type[]) null, CopyBack2, true);
          if (flagArray2[0])
            row2[index5] = RuntimeHelpers.GetObjectValue(objArray6[0]);
          checked { ++num7; }
        }
        checked { ++num5; }
      }
      int num8 = checked (CurrentListView.Columns.Count - 1);
      int index7 = 0;
      while (index7 <= num8)
      {
        CurrentListView.Columns[index7].Width = -2;
        checked { ++index7; }
      }
    }

    public LookupForm(
      DataTable ds,
      Collection SourceFields,
      Collection HiddenFields,
      string ColNames = null)
    {
      this.Load += new EventHandler(this.LookupForm_Load);
      this.Activated += new EventHandler(this.LookupForm_Activated);
      this._SourceFields = new Collection();
      this._HideFields = new Collection();
      this.InitializeComponent();
      this._SourceFields = SourceFields;
      this._ds = ds;
      this._HideFields = HiddenFields;
      this.LoadList(ds, ColNames);
    }

    private void txtSearch_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Return)
        this.SetSelected();
      if (!(e.KeyCode == Keys.Up | e.KeyCode == Keys.Down))
        return;
      this.grd.Focus();
    }

    public void SetSelected()
    {
      if (!this.btnSubmit.Enabled)
        return;
      string str = "";
      int num = checked (this.grd.Columns.Count - 1);
      int index = 0;
      while (index <= num)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.grd.Columns[index].Tag, (object) "", false))
        {
          str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) str, this.grd.SelectedRows[0].Cells[index].Value));
          if (index != checked (this.grd.Columns.Count - 1))
            str += "|:::|";
        }
        checked { ++index; }
      }
      ValueSubmission e = new ValueSubmission(new Collection()
      {
        {
          (object) Strings.Mid(str, 1, checked (Strings.Len(str) - Strings.Len("|:::|"))),
          (string) null,
          (object) null,
          (object) null
        }
      });
      LookupForm.ValueSubmittedEventHandler valueSubmittedEvent = this.ValueSubmittedEvent;
      if (valueSubmittedEvent != null)
        valueSubmittedEvent((object) this, e);
      this.Close();
    }

    private void btnSubmit_Click(object sender, EventArgs e)
    {
      this.SetSelected();
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearch.Text, "", false) != 0)
      {
        this.lblnosearch.Visible = false;
        DataView dataView = new DataView(this._ds);
        dataView.RowFilter = this.DoSearch(dataView.Table, this.txtSearch.Text);
        this.grd.DataSource = (object) dataView;
      }
      else
      {
        this.lblnosearch.Visible = true;
        this.LoadList(this._ds, (string) null);
      }
      if (this.grd.Rows.Count == 0)
      {
        this.nosearch.Visible = true;
        this.btnSubmit.Enabled = false;
      }
      else
      {
        this.nosearch.Visible = false;
        this.btnSubmit.Enabled = true;
      }
    }

    public string DoSearch(DataTable tbl, string s)
    {
      string str = "";
      int num = checked (tbl.Columns.Count - 1);
      int index = 0;
      while (index <= num)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tbl.Columns[index].DataType.ToString(), "System.String", false) == 0)
        {
          str = str + "[" + tbl.Columns[index].ColumnName + "] like '%" + s + "%' ";
          if (index != checked (tbl.Columns.Count - 1))
            str += " OR ";
        }
        checked { ++index; }
      }
      return str;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnclear_Click(object sender, EventArgs e)
    {
      this.txtSearch.Text = "";
      this.nosearch.Visible = false;
      this.txtSearch.Focus();
    }

    private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
    }

    private void lstsearch_ItemActivate(object sender, EventArgs e)
    {
      this.SetSelected();
    }

    private void lstsearch_ItemSelectionChanged(
      object sender,
      ListViewItemSelectionChangedEventArgs e)
    {
    }

    private void lstsearch_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void LookupForm_Load(object sender, EventArgs e)
    {
    }

    private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void lblnosearch_Click(object sender, EventArgs e)
    {
      this.txtSearch.Focus();
    }

    private void grd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      this.SetSelected();
    }

    private void grd_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Up | e.KeyCode != Keys.Down)
        this.grd.Focus();
      if (e.KeyCode != Keys.Return)
        return;
      this.SetSelected();
    }

    public delegate void NewCompanyEventHandler();

    public delegate void ValueSubmittedEventHandler(object sender, ValueSubmission e);
        public event ValueSubmittedEventHandler ValueSubmittedEvent;
    }
}
