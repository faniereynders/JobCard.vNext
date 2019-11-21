// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.Core.frmPrint
// Assembly: JobCard, Version=1.0.0.2, Culture=neutral, PublicKeyToken=null
// MVID: 355A629F-A2FA-4599-879B-59162A296DD0
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCard.exe

using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Export.Pdf;
using DataDynamics.ActiveReports.Viewer;
using Microsoft.Office.Interop.Outlook;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Reytec.GUI.Controls;
using Reytec.JobCard.DAL;
using Reytec.JobCard.Reports;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Reytec.JobCard.Core
{
    [DesignerGenerated]
    public class frmPrint : Form
    {
        private IContainer components;
        [AccessedThroughProperty("TableLayoutPanel1")]
        private TableLayoutPanel _TableLayoutPanel1;
        [AccessedThroughProperty("v")]
        private DataDynamics.ActiveReports.Viewer.Viewer _v;
        [AccessedThroughProperty("Panel3")]
        private Panel _Panel3;
        [AccessedThroughProperty("btnEmail")]
        private SoftButton _btnEmail;
        [AccessedThroughProperty("btnPrint")]
        private SoftButton _btnPrint;
        [AccessedThroughProperty("btnExport")]
        private SoftButton _btnExport;
        [AccessedThroughProperty("dlgSave")]
        private SaveFileDialog _dlgSave;
        private object _parms;
        private Reytec.JobCard.DAL.JobCard dboJobCard;

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
            this.btnExport = new SoftButton();
            this.btnEmail = new SoftButton();
            this.btnPrint = new SoftButton();
            this.v = new DataDynamics.ActiveReports.Viewer.Viewer();
            this.dlgSave = new SaveFileDialog();
            this.TableLayoutPanel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.TableLayoutPanel1.Controls.Add((Control)this.Panel3, 0, 0);
            this.TableLayoutPanel1.Controls.Add((Control)this.v, 0, 1);
            this.TableLayoutPanel1.Dock = DockStyle.Fill;
            TableLayoutPanel tableLayoutPanel1_1 = this.TableLayoutPanel1;
            Point point1 = new Point(0, 0);
            Point point2 = point1;
            tableLayoutPanel1_1.Location = point2;
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 2;
            this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35f));
            this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
            TableLayoutPanel tableLayoutPanel1_2 = this.TableLayoutPanel1;
            Size size1 = new Size(628, 474);
            Size size2 = size1;
            tableLayoutPanel1_2.Size = size2;
            this.TableLayoutPanel1.TabIndex = 6;
            this.Panel3.BackColor = Color.Transparent;
            //this.Panel3.BackgroundImage = (System.Drawing.Image) Reytec.JobCard.Core.My.Resources.Resources.toolbackt;
            this.Panel3.Controls.Add((Control)this.btnExport);
            this.Panel3.Controls.Add((Control)this.btnEmail);
            this.Panel3.Controls.Add((Control)this.btnPrint);
            this.Panel3.Dock = DockStyle.Top;
            Panel panel3_1 = this.Panel3;
            point1 = new Point(0, 0);
            Point point3 = point1;
            panel3_1.Location = point3;
            Panel panel3_2 = this.Panel3;
            System.Windows.Forms.Padding padding1 = new System.Windows.Forms.Padding(0);
            System.Windows.Forms.Padding padding2 = padding1;
            panel3_2.Margin = padding2;
            this.Panel3.Name = "Panel3";
            Panel panel3_3 = this.Panel3;
            size1 = new Size(628, 35);
            Size size3 = size1;
            panel3_3.Size = size3;
            this.Panel3.TabIndex = 5;
            this.btnExport.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnExport.BackColor = Color.Transparent;
            this.btnExport.BaseColor = Color.FromArgb(33, 124, 180);
            this.btnExport.ButtonColor = Color.FromArgb(23, 87, 125);
            this.btnExport.ButtonStyle = SoftButton.Style.Flat;
            this.btnExport.ButtonText = "Export...";
            this.btnExport.CornerRadius = 3;
            this.btnExport.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnExport.Glow2Color = Color.FromArgb(209, 242, 250);
            this.btnExport.GlowColor = Color.FromArgb(192, (int)byte.MaxValue, (int)byte.MaxValue);
            this.btnExport.HighlightColor = Color.FromArgb(192, 222, 254);
            // this.btnExport.Image = (System.Drawing.Image) Reytec.JobCard.Core.My.Resources.Resources.DoubleRightArrowHS;
            SoftButton btnExport1 = this.btnExport;
            size1 = new Size(16, 16);
            Size size4 = size1;
            btnExport1.ImageSize = size4;
            SoftButton btnExport2 = this.btnExport;
            point1 = new Point(145, 3);
            Point point4 = point1;
            btnExport2.Location = point4;
            SoftButton btnExport3 = this.btnExport;
            padding1 = new System.Windows.Forms.Padding(0);
            System.Windows.Forms.Padding padding3 = padding1;
            btnExport3.Margin = padding3;
            this.btnExport.Name = "btnExport";
            this.btnExport.ShadowColor = Color.Black;
            SoftButton btnExport4 = this.btnExport;
            size1 = new Size(80, 30);
            Size size5 = size1;
            btnExport4.Size = size5;
            this.btnExport.TabIndex = 43;
            this.btnExport.TabStop = false;
            this.btnExport.TextAlign = ContentAlignment.MiddleRight;
            this.btnEmail.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnEmail.BackColor = Color.Transparent;
            this.btnEmail.BaseColor = Color.FromArgb(33, 124, 180);
            this.btnEmail.ButtonColor = Color.FromArgb(23, 87, 125);
            this.btnEmail.ButtonStyle = SoftButton.Style.Flat;
            this.btnEmail.ButtonText = "E-Mail";
            this.btnEmail.CornerRadius = 3;
            this.btnEmail.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnEmail.Glow2Color = Color.FromArgb(209, 242, 250);
            this.btnEmail.GlowColor = Color.FromArgb(192, (int)byte.MaxValue, (int)byte.MaxValue);
            this.btnEmail.HighlightColor = Color.FromArgb(192, 222, 254);
            //this.btnEmail.Image = (System.Drawing.Image) Reytec.JobCard.Core.My.Resources.Resources.EnvelopeHS;
            SoftButton btnEmail1 = this.btnEmail;
            size1 = new Size(16, 16);
            Size size6 = size1;
            btnEmail1.ImageSize = size6;
            SoftButton btnEmail2 = this.btnEmail;
            point1 = new Point(71, 3);
            Point point5 = point1;
            btnEmail2.Location = point5;
            SoftButton btnEmail3 = this.btnEmail;
            padding1 = new System.Windows.Forms.Padding(0);
            System.Windows.Forms.Padding padding4 = padding1;
            btnEmail3.Margin = padding4;
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.ShadowColor = Color.Black;
            SoftButton btnEmail4 = this.btnEmail;
            size1 = new Size(74, 30);
            Size size7 = size1;
            btnEmail4.Size = size7;
            this.btnEmail.TabIndex = 42;
            this.btnEmail.TabStop = false;
            this.btnEmail.TextAlign = ContentAlignment.MiddleRight;
            this.btnPrint.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnPrint.BackColor = Color.Transparent;
            this.btnPrint.BaseColor = Color.FromArgb(33, 124, 180);
            this.btnPrint.ButtonColor = Color.FromArgb(23, 87, 125);
            this.btnPrint.ButtonStyle = SoftButton.Style.Flat;
            this.btnPrint.ButtonText = "Print";
            this.btnPrint.CornerRadius = 3;
            this.btnPrint.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnPrint.Glow2Color = Color.FromArgb(209, 242, 250);
            this.btnPrint.GlowColor = Color.FromArgb(192, (int)byte.MaxValue, (int)byte.MaxValue);
            this.btnPrint.HighlightColor = Color.FromArgb(192, 222, 254);
            // this.btnPrint.Image = (System.Drawing.Image) Reytec.JobCard.Core.My.Resources.Resources.PrintHS2;
            SoftButton btnPrint1 = this.btnPrint;
            size1 = new Size(16, 16);
            Size size8 = size1;
            btnPrint1.ImageSize = size8;
            SoftButton btnPrint2 = this.btnPrint;
            point1 = new Point(7, 3);
            Point point6 = point1;
            btnPrint2.Location = point6;
            SoftButton btnPrint3 = this.btnPrint;
            padding1 = new System.Windows.Forms.Padding(0);
            System.Windows.Forms.Padding padding5 = padding1;
            btnPrint3.Margin = padding5;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShadowColor = Color.Black;
            SoftButton btnPrint4 = this.btnPrint;
            size1 = new Size(64, 30);
            Size size9 = size1;
            btnPrint4.Size = size9;
            this.btnPrint.TabIndex = 13;
            this.btnPrint.TabStop = false;
            this.btnPrint.TextAlign = ContentAlignment.MiddleRight;
            this.v.BackColor = SystemColors.Control;
            this.v.Dock = DockStyle.Fill;
            this.v.Document = new DataDynamics.ActiveReports.Document.Document("ARNet Document");
            DataDynamics.ActiveReports.Viewer.Viewer v1 = this.v;
            point1 = new Point(3, 38);
            Point point7 = point1;
            v1.Location = point7;
            this.v.Name = "v";
            this.v.ReportViewer.CurrentPage = 0;
            this.v.ReportViewer.MultiplePageCols = 3;
            this.v.ReportViewer.MultiplePageRows = 2;
            this.v.ReportViewer.ViewType = ViewType.Normal;
            DataDynamics.ActiveReports.Viewer.Viewer v2 = this.v;
            size1 = new Size(622, 433);
            Size size10 = size1;
            v2.Size = size10;
            this.v.TabIndex = 6;
            this.v.TableOfContents.Text = "Table Of Contents";
            this.v.TableOfContents.Width = 200;
            this.v.TabTitleLength = 35;
            this.v.Toolbar.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.v.Toolbar.Wrappable = false;
            this.dlgSave.Filter = "Acrobat PDF|*.pdf";
            this.dlgSave.Title = "Export Report";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            size1 = new Size(628, 474);
            this.ClientSize = size1;
            this.Controls.Add((Control)this.TableLayoutPanel1);
            this.Name = nameof(frmPrint);
            this.Text = "Print Preview";
            this.WindowState = FormWindowState.Maximized;
            this.TableLayoutPanel1.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.ResumeLayout(false);
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

        internal virtual DataDynamics.ActiveReports.Viewer.Viewer v
        {
            [DebuggerNonUserCode]
            get
            {
                return this._v;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._v = value;
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

        internal virtual SoftButton btnEmail
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnEmail;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnEdit_Click);
                if (this._btnEmail != null)
                    this._btnEmail.Click -= eventHandler;
                this._btnEmail = value;
                if (this._btnEmail == null)
                    return;
                this._btnEmail.Click += eventHandler;
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
                EventHandler eventHandler = new EventHandler(this.btnNew_Click);
                if (this._btnPrint != null)
                    this._btnPrint.Click -= eventHandler;
                this._btnPrint = value;
                if (this._btnPrint == null)
                    return;
                this._btnPrint.Click += eventHandler;
            }
        }

        internal virtual SoftButton btnExport
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnExport;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnExport_Click);
                if (this._btnExport != null)
                    this._btnExport.Click -= eventHandler;
                this._btnExport = value;
                if (this._btnExport == null)
                    return;
                this._btnExport.Click += eventHandler;
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
                EventHandler eventHandler = new EventHandler(this.dlgSave_Disposed);
                CancelEventHandler cancelEventHandler = new CancelEventHandler(this.dlgSave_FileOk);
                if (this._dlgSave != null)
                {
                    this._dlgSave.Disposed -= eventHandler;
                    this._dlgSave.FileOk -= cancelEventHandler;
                }
                this._dlgSave = value;
                if (this._dlgSave == null)
                    return;
                this._dlgSave.Disposed += eventHandler;
                this._dlgSave.FileOk += cancelEventHandler;
            }
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.v.Document.Print(true, true, true);
        }

        public frmPrint(int ReportId, object parms = null, bool LoadFromImage = false)
        {
            this.Load += new EventHandler(this.frmPrint_Load);
            this.InitializeComponent();
            ActiveReport3 activeReport3 = (ActiveReport3)null;
            this._parms = RuntimeHelpers.GetObjectValue(parms);
            if (ReportId == 1)
            {
                this.dboJobCard = new Reytec.JobCard.DAL.JobCard(ConnectionInfo.GlobalConnection);
                this.dboJobCard.GetOne(RuntimeHelpers.GetObjectValue(parms));
                if (Conversions.ToBoolean(this.dboJobCard.JobCompleted))
                {
                    this.v.Document.Load((Stream)this.dboJobCard.GetCompletedImage());
                    return;
                }
                activeReport3 = (ActiveReport3)new rptJobCard((object)ConnectionInfo.GlobalConnection);
                activeReport3.Parameters["pJobID"].Value = Conversions.ToString(parms);
            }
            activeReport3.Run();
            this.v.Document = activeReport3.Document;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            JobCardCompany jobCardCompany = new JobCardCompany(ConnectionInfo.GlobalConnection);
            Customer customer = new Customer(ConnectionInfo.GlobalConnection);
            customer.GetOne(RuntimeHelpers.GetObjectValue(this.dboJobCard.CustomerID));
            jobCardCompany.GetInfo();
            string str = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(System.Windows.Forms.Application.StartupPath + "\\JobCard "), this.dboJobCard.JobNr), (object)".pdf"));
            new PdfExport().Export(this.v.Document, str);
            _MailItem mailItem = (_MailItem)((_Application)new ApplicationClass()).CreateItem(OlItemType.olMailItem);
            mailItem.Attachments.Add((object)str, (object)Missing.Value, (object)Missing.Value, (object)"FILE");
            mailItem.BodyFormat = OlBodyFormat.olFormatHTML;
            mailItem.Subject = Conversions.ToString(Operators.ConcatenateObject((object)"Job Card from ", jobCardCompany.CompanyName));
            mailItem.To = Conversions.ToString(customer.CustomerEmail);
            mailItem.Body = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Please se attached for Job Card ", this.dboJobCard.JobNr), (object)"\r\n"), (object)"\r\n"), (object)"Regards,"), (object)"\r\n"), jobCardCompany.CompanyName), (object)"\r\n"), jobCardCompany.BranchName));
            mailItem.Display((object)Missing.Value);
            File.Delete(str);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            this.dlgSave.FileName = Conversions.ToString(this.dboJobCard.JobNr);
            int num = (int)this.dlgSave.ShowDialog();
        }

        private void dlgSave_Disposed(object sender, EventArgs e)
        {
        }

        private void dlgSave_FileOk(object sender, CancelEventArgs e)
        {
            if (e.Cancel)
                return;
            new PdfExport().Export(this.v.Document, this.dlgSave.FileName);
            MessageBox.Show($"Exported successfully", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
