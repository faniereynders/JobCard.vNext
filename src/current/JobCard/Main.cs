// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.Core.Main
// Assembly: JobCard, Version=1.0.0.2, Culture=neutral, PublicKeyToken=null
// MVID: 355A629F-A2FA-4599-879B-59162A296DD0
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCard.exe

using JobCard;
using JobCard.Security;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Client;
using Microsoft.Identity.Client.Extensibility;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Protocols;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Reytec.Data.Engine;
using Reytec.GUI.Controls;
using Reytec.GUI.Controls.DataLookupWindow;
using Reytec.JobCard.DAL;
using Reytec.JobCard.Functions.GUITransformation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reytec.JobCard.Core
{
    [DesignerGenerated]
    public class Main : Form
    {
        private IContainer components;
        [AccessedThroughProperty("ToolTip")]
        private ToolTip _ToolTip;
        [AccessedThroughProperty("StatusStrip")]
        private StatusStrip _StatusStrip;
        [AccessedThroughProperty("BottomToolStripPanel")]
        private ToolStripPanel _BottomToolStripPanel;
        [AccessedThroughProperty("TopToolStripPanel")]
        private ToolStripPanel _TopToolStripPanel;
        [AccessedThroughProperty("RightToolStripPanel")]
        private ToolStripPanel _RightToolStripPanel;
        [AccessedThroughProperty("LeftToolStripPanel")]
        private ToolStripPanel _LeftToolStripPanel;
        [AccessedThroughProperty("ContentPanel")]
        private ToolStripContentPanel _ContentPanel;
        [AccessedThroughProperty("pnlMenu")]
        private Panel _pnlMenu;
        [AccessedThroughProperty("Panel2")]
        private Panel _Panel2;
        [AccessedThroughProperty("stlblCompanyName")]
        private ToolStripStatusLabel _stlblCompanyName;
        [AccessedThroughProperty("pnlBody")]
        private Panel _pnlBody;
        [AccessedThroughProperty("lblTitle")]
        private Label _lblTitle;
        [AccessedThroughProperty("ln")]
        private PictureBox _ln;
        [AccessedThroughProperty("ImageList1")]
        private ImageList _ImageList1;
        [AccessedThroughProperty("btndetails")]
        private SoftButton _btndetails;
        [AccessedThroughProperty("VistaButton3")]
        private SoftButton _VistaButton3;
        [AccessedThroughProperty("VistaButton1")]
        private SoftButton _VistaButton1;
        [AccessedThroughProperty("VistaButton2")]
        private SoftButton _VistaButton2;
        [AccessedThroughProperty("btnOpenCo")]
        private SoftButton _btnOpenCo;
        [AccessedThroughProperty("btnNewCo")]
        private SoftButton _btnNewCo;
        [AccessedThroughProperty("btnMyInfo")]
        private SoftButton _btnMyInfo;
        [AccessedThroughProperty("VistaButton4")]
        private SoftButton _VistaButton4;
        [AccessedThroughProperty("VistaButton5")]
        private SoftButton _VistaButton5;
        [AccessedThroughProperty("VistaButton8")]
        private SoftButton _VistaButton8;
        [AccessedThroughProperty("lblUser")]
        private Label _lblUser;
        [AccessedThroughProperty("btnSign")]
        private SoftButton _btnSign;
        [AccessedThroughProperty("lblCompanyName")]
        private Label _lblCompanyName;
        private MdiClient ClientControl;
        private string ServerName;
        private string DatabaseName;
        private string CompanyFileName;
        private SystemUser general;
        private DataAccess sql;
        private bool SignIn;
        private string commandfile;
        [AccessedThroughProperty("frmCompanyConnect")]
        private frmConnection _frmCompanyConnect;
        private readonly IServiceProvider serviceProvider;

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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Main));
            this.StatusStrip = new StatusStrip();
            this.stlblCompanyName = new ToolStripStatusLabel();
            this.ToolTip = new ToolTip(this.components);
            this.BottomToolStripPanel = new ToolStripPanel();
            this.TopToolStripPanel = new ToolStripPanel();
            this.RightToolStripPanel = new ToolStripPanel();
            this.LeftToolStripPanel = new ToolStripPanel();
            this.ContentPanel = new ToolStripContentPanel();
            this.Panel2 = new Panel();
            this.ln = new PictureBox();
            this.lblTitle = new Label();
            this.pnlBody = new Panel();
            this.ImageList1 = new ImageList(this.components);
            this.pnlMenu = new Panel();
            this.lblUser = new Label();
            this.lblCompanyName = new Label();
            this.btnSign = new SoftButton();
            this.btnMyInfo = new SoftButton();
            this.VistaButton4 = new SoftButton();
            this.VistaButton5 = new SoftButton();
            this.VistaButton8 = new SoftButton();
            this.btndetails = new SoftButton();
            this.VistaButton3 = new SoftButton();
            this.VistaButton1 = new SoftButton();
            this.VistaButton2 = new SoftButton();
            this.btnOpenCo = new SoftButton();
            this.btnNewCo = new SoftButton();
            this.StatusStrip.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((ISupportInitialize)this.ln).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            this.StatusStrip.Items.AddRange(new ToolStripItem[1]
            {
        (ToolStripItem) this.stlblCompanyName
            });
            StatusStrip statusStrip1 = this.StatusStrip;
            Point point1 = new Point(0, 590);
            Point point2 = point1;
            statusStrip1.Location = point2;
            this.StatusStrip.Name = "StatusStrip";
            StatusStrip statusStrip2 = this.StatusStrip;
            Size size1 = new Size(792, 22);
            Size size2 = size1;
            statusStrip2.Size = size2;
            this.StatusStrip.TabIndex = 7;
            this.StatusStrip.Text = "StatusStrip";
            //this.stlblCompanyName.Image = (Image) Reytec.JobCard.Core.My.Resources.Resources.HomeHS;
            this.stlblCompanyName.Name = "stlblCompanyName";
            ToolStripStatusLabel stlblCompanyName = this.stlblCompanyName;
            size1 = new Size(95, 17);
            Size size3 = size1;
            stlblCompanyName.Size = size3;
            this.stlblCompanyName.Text = "CompanyName";
            ToolStripPanel bottomToolStripPanel1 = this.BottomToolStripPanel;
            point1 = new Point(0, 0);
            Point point3 = point1;
            bottomToolStripPanel1.Location = point3;
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = Orientation.Horizontal;
            ToolStripPanel bottomToolStripPanel2 = this.BottomToolStripPanel;
            Padding padding1 = new Padding(3, 0, 0, 0);
            Padding padding2 = padding1;
            bottomToolStripPanel2.RowMargin = padding2;
            ToolStripPanel bottomToolStripPanel3 = this.BottomToolStripPanel;
            size1 = new Size(0, 0);
            Size size4 = size1;
            bottomToolStripPanel3.Size = size4;
            this.TopToolStripPanel.BackColor = SystemColors.ActiveCaptionText;
            ToolStripPanel topToolStripPanel1 = this.TopToolStripPanel;
            point1 = new Point(0, 0);
            Point point4 = point1;
            topToolStripPanel1.Location = point4;
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = Orientation.Horizontal;
            ToolStripPanel topToolStripPanel2 = this.TopToolStripPanel;
            padding1 = new Padding(3, 0, 0, 0);
            Padding padding3 = padding1;
            topToolStripPanel2.RowMargin = padding3;
            ToolStripPanel topToolStripPanel3 = this.TopToolStripPanel;
            size1 = new Size(0, 0);
            Size size5 = size1;
            topToolStripPanel3.Size = size5;
            ToolStripPanel rightToolStripPanel1 = this.RightToolStripPanel;
            point1 = new Point(0, 0);
            Point point5 = point1;
            rightToolStripPanel1.Location = point5;
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = Orientation.Horizontal;
            ToolStripPanel rightToolStripPanel2 = this.RightToolStripPanel;
            padding1 = new Padding(3, 0, 0, 0);
            Padding padding4 = padding1;
            rightToolStripPanel2.RowMargin = padding4;
            ToolStripPanel rightToolStripPanel3 = this.RightToolStripPanel;
            size1 = new Size(0, 0);
            Size size6 = size1;
            rightToolStripPanel3.Size = size6;
            ToolStripPanel leftToolStripPanel1 = this.LeftToolStripPanel;
            point1 = new Point(0, 0);
            Point point6 = point1;
            leftToolStripPanel1.Location = point6;
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = Orientation.Horizontal;
            ToolStripPanel leftToolStripPanel2 = this.LeftToolStripPanel;
            padding1 = new Padding(3, 0, 0, 0);
            Padding padding5 = padding1;
            leftToolStripPanel2.RowMargin = padding5;
            ToolStripPanel leftToolStripPanel3 = this.LeftToolStripPanel;
            size1 = new Size(0, 0);
            Size size7 = size1;
            leftToolStripPanel3.Size = size7;
            this.ContentPanel.BackColor = SystemColors.ActiveCaptionText;
            ToolStripContentPanel contentPanel = this.ContentPanel;
            size1 = new Size(632, 406);
            Size size8 = size1;
            contentPanel.Size = size8;
            this.Panel2.BackColor = Color.SteelBlue;
            this.Panel2.Controls.Add((Control)this.ln);
            this.Panel2.Controls.Add((Control)this.lblTitle);
            this.Panel2.Dock = DockStyle.Top;
            Panel panel2_1 = this.Panel2;
            point1 = new Point(0, 80);
            Point point7 = point1;
            panel2_1.Location = point7;
            this.Panel2.Name = "Panel2";
            Panel panel2_2 = this.Panel2;
            size1 = new Size(792, 36);
            Size size9 = size1;
            panel2_2.Size = size9;
            this.Panel2.TabIndex = 24;
            // this.ln.Image = (Image) Reytec.JobCard.Core.My.Resources.Resources.hline;
            PictureBox ln1 = this.ln;
            point1 = new Point(3, 33);
            Point point8 = point1;
            ln1.Location = point8;
            this.ln.Name = "ln";
            PictureBox ln2 = this.ln;
            size1 = new Size(583, 10);
            Size size10 = size1;
            ln2.Size = size10;
            this.ln.TabIndex = 23;
            this.ln.TabStop = false;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = Color.Transparent;
            this.lblTitle.Font = new Font("Segoe UI", 14.25f, FontStyle.Italic, GraphicsUnit.Point, (byte)0);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.ImageAlign = ContentAlignment.MiddleRight;
            Label lblTitle1 = this.lblTitle;
            point1 = new Point(3, -1);
            Point point9 = point1;
            lblTitle1.Location = point9;
            this.lblTitle.Name = "lblTitle";
            Label lblTitle2 = this.lblTitle;
            size1 = new Size(0, 28);
            Size size11 = size1;
            lblTitle2.Size = size11;
            this.lblTitle.TabIndex = 22;
            this.lblTitle.TextAlign = ContentAlignment.MiddleRight;
            this.lblTitle.UseCompatibleTextRendering = true;
            this.pnlBody.BackColor = Color.SteelBlue;
            this.pnlBody.Dock = DockStyle.Fill;
            Panel pnlBody1 = this.pnlBody;
            point1 = new Point(0, 116);
            Point point10 = point1;
            pnlBody1.Location = point10;
            this.pnlBody.Name = "pnlBody";
            Panel pnlBody2 = this.pnlBody;
            size1 = new Size(792, 474);
            Size size12 = size1;
            pnlBody2.Size = size12;
            this.pnlBody.TabIndex = 26;
            this.ImageList1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream");
            this.ImageList1.TransparentColor = Color.Fuchsia;
            this.ImageList1.Images.SetKeyName(0, "OK.bmp");
            this.ImageList1.Images.SetKeyName(1, "Critical.bmp");
            this.pnlMenu.BackColor = Color.SteelBlue;
            //this.pnlMenu.BackgroundImage = (Image) Reytec.JobCard.Core.My.Resources.Resources.topback;
            this.pnlMenu.BackgroundImageLayout = ImageLayout.Stretch;
            this.pnlMenu.Controls.Add((Control)this.lblUser);
            this.pnlMenu.Controls.Add((Control)this.btnSign);
            this.pnlMenu.Controls.Add((Control)this.lblCompanyName);
            this.pnlMenu.Controls.Add((Control)this.btnMyInfo);
            this.pnlMenu.Controls.Add((Control)this.VistaButton4);
            this.pnlMenu.Controls.Add((Control)this.VistaButton5);
            this.pnlMenu.Controls.Add((Control)this.VistaButton8);
            this.pnlMenu.Dock = DockStyle.Top;
            Panel pnlMenu1 = this.pnlMenu;
            point1 = new Point(0, 0);
            Point point11 = point1;
            pnlMenu1.Location = point11;
            this.pnlMenu.Name = "pnlMenu";
            Panel pnlMenu2 = this.pnlMenu;
            size1 = new Size(792, 80);
            Size size13 = size1;
            pnlMenu2.Size = size13;
            this.pnlMenu.TabIndex = 23;
            this.lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.lblUser.BackColor = Color.Transparent;
            this.lblUser.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblUser.ForeColor = Color.White;
            Label lblUser1 = this.lblUser;
            point1 = new Point(350, 45);
            Point point12 = point1;
            lblUser1.Location = point12;
            this.lblUser.Name = "lblUser";
            Label lblUser2 = this.lblUser;
            size1 = new Size(344, 34);
            Size size14 = size1;
            lblUser2.Size = size14;
            this.lblUser.TabIndex = 24;
            this.lblUser.TextAlign = ContentAlignment.MiddleRight;
            this.lblCompanyName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.lblCompanyName.BackColor = Color.Transparent;
            this.lblCompanyName.Font = new Font("Segoe UI", 14.25f, FontStyle.Italic, GraphicsUnit.Point, (byte)0);
            this.lblCompanyName.ForeColor = Color.White;
            this.lblCompanyName.ImageAlign = ContentAlignment.MiddleRight;
            Label lblCompanyName1 = this.lblCompanyName;
            point1 = new Point(326, 9);
            Point point13 = point1;
            lblCompanyName1.Location = point13;
            this.lblCompanyName.Name = "lblCompanyName";
            Label lblCompanyName2 = this.lblCompanyName;
            size1 = new Size(454, 31);
            Size size15 = size1;
            lblCompanyName2.Size = size15;
            this.lblCompanyName.TabIndex = 23;
            this.lblCompanyName.TextAlign = ContentAlignment.MiddleRight;
            this.lblCompanyName.UseCompatibleTextRendering = true;
            this.lblCompanyName.UseMnemonic = false;
            this.btnSign.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnSign.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnSign.BackColor = Color.Transparent;
            this.btnSign.BaseColor = Color.FromArgb(33, 124, 180);
            this.btnSign.ButtonColor = Color.FromArgb(23, 87, 125);
            this.btnSign.ButtonStyle = SoftButton.Style.Flat;
            this.btnSign.ButtonText = "Sign Out";
            this.btnSign.CornerRadius = 3;
            this.btnSign.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnSign.Glow2Color = Color.FromArgb(209, 242, 250);
            this.btnSign.GlowColor = Color.FromArgb(192, (int)byte.MaxValue, (int)byte.MaxValue);
            this.btnSign.HighlightColor = Color.FromArgb(192, 222, 254);
            this.btnSign.Image = (Image)componentResourceManager.GetObject("btnSign.Image");
            SoftButton btnSign1 = this.btnSign;
            size1 = new Size(16, 16);
            Size size16 = size1;
            btnSign1.ImageSize = size16;
            SoftButton btnSign2 = this.btnSign;
            point1 = new Point(700, 43);
            Point point14 = point1;
            btnSign2.Location = point14;
            this.btnSign.Name = "btnSign";
            this.btnSign.ShadowColor = Color.Black;
            SoftButton btnSign3 = this.btnSign;
            size1 = new Size(80, 34);
            Size size17 = size1;
            btnSign3.Size = size17;
            this.btnSign.TabIndex = 22;
            this.btnSign.TextAlign = ContentAlignment.MiddleRight;
            this.btnMyInfo.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnMyInfo.BackColor = Color.Transparent;
            this.btnMyInfo.BaseColor = Color.FromArgb(33, 124, 180);
            this.btnMyInfo.ButtonColor = Color.FromArgb(23, 87, 125);
            this.btnMyInfo.ButtonStyle = SoftButton.Style.Flat;
            this.btnMyInfo.ButtonText = "My Information";
            this.btnMyInfo.CornerRadius = 5;
            this.btnMyInfo.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btnMyInfo.Glow2Color = Color.FromArgb(209, 242, 250);
            this.btnMyInfo.GlowColor = Color.FromArgb(192, (int)byte.MaxValue, (int)byte.MaxValue);
            this.btnMyInfo.HighlightColor = Color.FromArgb(192, 222, 254);
            // this.btnMyInfo.Image = (Image) Reytec.JobCard.Core.My.Resources.Resources.warehouse;
            this.btnMyInfo.ImageAlign = ContentAlignment.TopCenter;
            SoftButton btnMyInfo1 = this.btnMyInfo;
            size1 = new Size(32, 32);
            Size size18 = size1;
            btnMyInfo1.ImageSize = size18;
            SoftButton btnMyInfo2 = this.btnMyInfo;
            point1 = new Point(9, 0);
            Point point15 = point1;
            btnMyInfo2.Location = point15;
            SoftButton btnMyInfo3 = this.btnMyInfo;
            padding1 = new Padding(0);
            Padding padding6 = padding1;
            btnMyInfo3.Margin = padding6;
            this.btnMyInfo.Name = "btnMyInfo";
            this.btnMyInfo.ShadowColor = Color.Black;
            SoftButton btnMyInfo4 = this.btnMyInfo;
            size1 = new Size(81, 79);
            Size size19 = size1;
            btnMyInfo4.Size = size19;
            this.btnMyInfo.TabIndex = 13;
            this.btnMyInfo.TextAlign = ContentAlignment.BottomCenter;
            this.VistaButton4.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.VistaButton4.BackColor = Color.Transparent;
            this.VistaButton4.BaseColor = Color.FromArgb(33, 124, 180);
            this.VistaButton4.ButtonColor = Color.FromArgb(23, 87, 125);
            this.VistaButton4.ButtonStyle = SoftButton.Style.Flat;
            this.VistaButton4.ButtonText = "My Customers";
            this.VistaButton4.CornerRadius = 5;
            this.VistaButton4.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.VistaButton4.Glow2Color = Color.FromArgb(209, 242, 250);
            this.VistaButton4.GlowColor = Color.FromArgb(192, (int)byte.MaxValue, (int)byte.MaxValue);
            this.VistaButton4.HighlightColor = Color.FromArgb(192, 222, 254);
            this.VistaButton4.Image = (Image)componentResourceManager.GetObject("VistaButton4.Image");
            this.VistaButton4.ImageAlign = ContentAlignment.TopCenter;
            SoftButton vistaButton4_1 = this.VistaButton4;
            size1 = new Size(32, 32);
            Size size20 = size1;
            vistaButton4_1.ImageSize = size20;
            SoftButton vistaButton4_2 = this.VistaButton4;
            point1 = new Point(90, 0);
            Point point16 = point1;
            vistaButton4_2.Location = point16;
            SoftButton vistaButton4_3 = this.VistaButton4;
            padding1 = new Padding(0);
            Padding padding7 = padding1;
            vistaButton4_3.Margin = padding7;
            this.VistaButton4.Name = "VistaButton4";
            this.VistaButton4.ShadowColor = Color.Black;
            SoftButton vistaButton4_4 = this.VistaButton4;
            size1 = new Size(75, 79);
            Size size21 = size1;
            vistaButton4_4.Size = size21;
            this.VistaButton4.TabIndex = 14;
            this.VistaButton4.TextAlign = ContentAlignment.BottomCenter;
            this.VistaButton5.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.VistaButton5.BackColor = Color.Transparent;
            this.VistaButton5.BaseColor = Color.FromArgb(33, 124, 180);
            this.VistaButton5.ButtonColor = Color.FromArgb(23, 87, 125);
            this.VistaButton5.ButtonStyle = SoftButton.Style.Flat;
            this.VistaButton5.ButtonText = "Manage Job Cards";
            this.VistaButton5.CornerRadius = 5;
            this.VistaButton5.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.VistaButton5.Glow2Color = Color.FromArgb(209, 242, 250);
            this.VistaButton5.GlowColor = Color.FromArgb(192, (int)byte.MaxValue, (int)byte.MaxValue);
            this.VistaButton5.HighlightColor = Color.FromArgb(192, 222, 254);
            // this.VistaButton5.Image = (Image) Reytec.JobCard.Core.My.Resources.Resources.job;
            this.VistaButton5.ImageAlign = ContentAlignment.TopCenter;
            SoftButton vistaButton5_1 = this.VistaButton5;
            size1 = new Size(26, 32);
            Size size22 = size1;
            vistaButton5_1.ImageSize = size22;
            SoftButton vistaButton5_2 = this.VistaButton5;
            point1 = new Point(165, 0);
            Point point17 = point1;
            vistaButton5_2.Location = point17;
            SoftButton vistaButton5_3 = this.VistaButton5;
            padding1 = new Padding(0);
            Padding padding8 = padding1;
            vistaButton5_3.Margin = padding8;
            this.VistaButton5.Name = "VistaButton5";
            this.VistaButton5.ShadowColor = Color.Black;
            SoftButton vistaButton5_4 = this.VistaButton5;
            size1 = new Size(71, 79);
            Size size23 = size1;
            vistaButton5_4.Size = size23;
            this.VistaButton5.TabIndex = 15;
            this.VistaButton5.TextAlign = ContentAlignment.BottomCenter;
            this.VistaButton8.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.VistaButton8.BackColor = Color.Transparent;
            this.VistaButton8.BaseColor = Color.FromArgb(33, 124, 180);
            this.VistaButton8.ButtonColor = Color.FromArgb(23, 87, 125);
            this.VistaButton8.ButtonStyle = SoftButton.Style.Flat;
            this.VistaButton8.ButtonText = "Backup & Restore";
            this.VistaButton8.CornerRadius = 5;
            this.VistaButton8.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.VistaButton8.Glow2Color = Color.FromArgb(209, 242, 250);
            this.VistaButton8.GlowColor = Color.FromArgb(192, (int)byte.MaxValue, (int)byte.MaxValue);
            this.VistaButton8.HighlightColor = Color.FromArgb(192, 222, 254);
            this.VistaButton8.Image = (Image)componentResourceManager.GetObject("VistaButton8.Image");
            this.VistaButton8.ImageAlign = ContentAlignment.TopCenter;
            SoftButton vistaButton8_1 = this.VistaButton8;
            size1 = new Size(32, 32);
            Size size24 = size1;
            vistaButton8_1.ImageSize = size24;
            SoftButton vistaButton8_2 = this.VistaButton8;
            point1 = new Point(236, 0);
            Point point18 = point1;
            vistaButton8_2.Location = point18;
            SoftButton vistaButton8_3 = this.VistaButton8;
            padding1 = new Padding(0);
            Padding padding9 = padding1;
            vistaButton8_3.Margin = padding9;
            this.VistaButton8.Name = "VistaButton8";
            this.VistaButton8.ShadowColor = Color.Black;
            SoftButton vistaButton8_4 = this.VistaButton8;
            size1 = new Size(71, 79);
            Size size25 = size1;
            vistaButton8_4.Size = size25;
            this.VistaButton8.TabIndex = 18;
            this.VistaButton8.TextAlign = ContentAlignment.BottomCenter;
            this.btndetails.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btndetails.BackColor = Color.Transparent;
            this.btndetails.BaseColor = Color.FromArgb(33, 124, 180);
            this.btndetails.ButtonColor = Color.FromArgb(23, 87, 125);
            this.btndetails.ButtonStyle = SoftButton.Style.Flat;
            this.btndetails.ButtonText = "Details...";
            this.btndetails.CornerRadius = 3;
            this.btndetails.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.btndetails.GlowColor = Color.FromArgb((int)byte.MaxValue, 216, 158);
            this.btndetails.HighlightColor = Color.FromArgb(192, 222, 254);
            this.btndetails.Image = (Image)componentResourceManager.GetObject("btndetails.Image");
            SoftButton btndetails1 = this.btndetails;
            size1 = new Size(16, 16);
            Size size26 = size1;
            btndetails1.ImageSize = size26;
            SoftButton btndetails2 = this.btndetails;
            point1 = new Point(250, 3);
            Point point19 = point1;
            btndetails2.Location = point19;
            this.btndetails.Name = "btndetails";
            this.btndetails.ShadowColor = Color.Black;
            SoftButton btndetails3 = this.btndetails;
            size1 = new Size(82, 30);
            Size size27 = size1;
            btndetails3.Size = size27;
            this.btndetails.TabIndex = 41;
            this.btndetails.TextAlign = ContentAlignment.MiddleRight;
            this.VistaButton3.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.VistaButton3.BackColor = Color.Transparent;
            this.VistaButton3.BaseColor = Color.FromArgb(33, 124, 180);
            this.VistaButton3.ButtonColor = Color.FromArgb(23, 87, 125);
            this.VistaButton3.ButtonStyle = SoftButton.Style.Flat;
            this.VistaButton3.ButtonText = "Help";
            this.VistaButton3.CornerRadius = 3;
            this.VistaButton3.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.VistaButton3.GlowColor = Color.FromArgb((int)byte.MaxValue, 216, 158);
            this.VistaButton3.HighlightColor = Color.FromArgb(192, 222, 254);
            this.VistaButton3.Image = (Image)componentResourceManager.GetObject("VistaButton3.Image");
            SoftButton vistaButton3_1 = this.VistaButton3;
            size1 = new Size(16, 16);
            Size size28 = size1;
            vistaButton3_1.ImageSize = size28;
            SoftButton vistaButton3_2 = this.VistaButton3;
            point1 = new Point(564, 3);
            Point point20 = point1;
            vistaButton3_2.Location = point20;
            this.VistaButton3.Name = "VistaButton3";
            this.VistaButton3.ShadowColor = Color.Black;
            SoftButton vistaButton3_3 = this.VistaButton3;
            size1 = new Size(65, 29);
            Size size29 = size1;
            vistaButton3_3.Size = size29;
            this.VistaButton3.TabIndex = 40;
            this.VistaButton3.TextAlign = ContentAlignment.MiddleRight;
            this.VistaButton1.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.VistaButton1.BackColor = Color.Transparent;
            this.VistaButton1.BaseColor = Color.FromArgb(33, 124, 180);
            this.VistaButton1.ButtonColor = Color.FromArgb(23, 87, 125);
            this.VistaButton1.ButtonStyle = SoftButton.Style.Flat;
            this.VistaButton1.ButtonText = "Delete";
            this.VistaButton1.CornerRadius = 3;
            this.VistaButton1.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.VistaButton1.GlowColor = Color.FromArgb((int)byte.MaxValue, 216, 158);
            this.VistaButton1.HighlightColor = Color.FromArgb(192, 222, 254);
            this.VistaButton1.Image = (Image)componentResourceManager.GetObject("VistaButton1.Image");
            SoftButton vistaButton1_1 = this.VistaButton1;
            size1 = new Size(16, 16);
            Size size30 = size1;
            vistaButton1_1.ImageSize = size30;
            SoftButton vistaButton1_2 = this.VistaButton1;
            point1 = new Point(338, 3);
            Point point21 = point1;
            vistaButton1_2.Location = point21;
            this.VistaButton1.Name = "VistaButton1";
            this.VistaButton1.ShadowColor = Color.Black;
            SoftButton vistaButton1_3 = this.VistaButton1;
            size1 = new Size(73, 30);
            Size size31 = size1;
            vistaButton1_3.Size = size31;
            this.VistaButton1.TabIndex = 38;
            this.VistaButton1.TextAlign = ContentAlignment.MiddleRight;
            this.VistaButton2.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.VistaButton2.BackColor = Color.Transparent;
            this.VistaButton2.BaseColor = Color.FromArgb(33, 124, 180);
            this.VistaButton2.ButtonColor = Color.FromArgb(23, 87, 125);
            this.VistaButton2.ButtonStyle = SoftButton.Style.Flat;
            this.VistaButton2.ButtonText = "Back-up & Restore...";
            this.VistaButton2.CornerRadius = 3;
            this.VistaButton2.Enabled = false;
            this.VistaButton2.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.VistaButton2.GlowColor = Color.FromArgb((int)byte.MaxValue, 216, 158);
            this.VistaButton2.HighlightColor = Color.FromArgb(192, 222, 254);
            this.VistaButton2.Image = (Image)componentResourceManager.GetObject("VistaButton2.Image");
            SoftButton vistaButton2_1 = this.VistaButton2;
            size1 = new Size(16, 16);
            Size size32 = size1;
            vistaButton2_1.ImageSize = size32;
            SoftButton vistaButton2_2 = this.VistaButton2;
            point1 = new Point(413, 3);
            Point point22 = point1;
            vistaButton2_2.Location = point22;
            this.VistaButton2.Name = "VistaButton2";
            this.VistaButton2.ShadowColor = Color.Black;
            SoftButton vistaButton2_3 = this.VistaButton2;
            size1 = new Size(145, 29);
            Size size33 = size1;
            vistaButton2_3.Size = size33;
            this.VistaButton2.TabIndex = 39;
            this.VistaButton2.TextAlign = ContentAlignment.MiddleRight;
            this.btnOpenCo.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.btnOpenCo.BackColor = Color.Transparent;
            this.btnOpenCo.BaseColor = Color.FromArgb(33, 124, 180);
            this.btnOpenCo.ButtonColor = Color.FromArgb(23, 87, 125);
            this.btnOpenCo.ButtonStyle = SoftButton.Style.Flat;
            this.btnOpenCo.ButtonText = "Connect";
            this.btnOpenCo.CornerRadius = 3;
            this.btnOpenCo.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.btnOpenCo.GlowColor = Color.FromArgb((int)byte.MaxValue, 216, 158);
            this.btnOpenCo.HighlightColor = Color.FromArgb(192, 222, 254);
            this.btnOpenCo.Image = (Image)componentResourceManager.GetObject("btnOpenCo.Image");
            SoftButton btnOpenCo1 = this.btnOpenCo;
            size1 = new Size(16, 16);
            Size size34 = size1;
            btnOpenCo1.ImageSize = size34;
            SoftButton btnOpenCo2 = this.btnOpenCo;
            point1 = new Point(160, 3);
            Point point23 = point1;
            btnOpenCo2.Location = point23;
            this.btnOpenCo.Name = "btnOpenCo";
            this.btnOpenCo.ShadowColor = Color.Black;
            SoftButton btnOpenCo3 = this.btnOpenCo;
            size1 = new Size(84, 30);
            Size size35 = size1;
            btnOpenCo3.Size = size35;
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
            this.btnNewCo.GlowColor = Color.FromArgb((int)byte.MaxValue, 216, 158);
            this.btnNewCo.HighlightColor = Color.FromArgb(192, 222, 254);
            this.btnNewCo.Image = (Image)componentResourceManager.GetObject("btnNewCo.Image");
            SoftButton btnNewCo1 = this.btnNewCo;
            size1 = new Size(16, 16);
            Size size36 = size1;
            btnNewCo1.ImageSize = size36;
            SoftButton btnNewCo2 = this.btnNewCo;
            point1 = new Point(7, 3);
            Point point24 = point1;
            btnNewCo2.Location = point24;
            SoftButton btnNewCo3 = this.btnNewCo;
            padding1 = new Padding(0);
            Padding padding10 = padding1;
            btnNewCo3.Margin = padding10;
            this.btnNewCo.Name = "btnNewCo";
            this.btnNewCo.ShadowColor = Color.Black;
            SoftButton btnNewCo4 = this.btnNewCo;
            size1 = new Size(150, 30);
            Size size37 = size1;
            btnNewCo4.Size = size37;
            this.btnNewCo.TabIndex = 13;
            this.btnNewCo.TextAlign = ContentAlignment.MiddleRight;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.ButtonFace;
            size1 = new Size(792, 612);
            this.ClientSize = size1;
            this.Controls.Add((Control)this.pnlBody);
            this.Controls.Add((Control)this.Panel2);
            this.Controls.Add((Control)this.pnlMenu);
            this.Controls.Add((Control)this.StatusStrip);
            this.IsMdiContainer = true;
            size1 = new Size(800, 600);
            this.MinimumSize = size1;
            this.Name = nameof(Main);
            this.Text = "Reytec JobCard";
            this.WindowState = FormWindowState.Maximized;
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((ISupportInitialize)this.ln).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        internal virtual ToolTip ToolTip
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ToolTip;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ToolTip = value;
            }
        }

        internal virtual StatusStrip StatusStrip
        {
            [DebuggerNonUserCode]
            get
            {
                return this._StatusStrip;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._StatusStrip = value;
            }
        }

        internal virtual ToolStripPanel BottomToolStripPanel
        {
            [DebuggerNonUserCode]
            get
            {
                return this._BottomToolStripPanel;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._BottomToolStripPanel = value;
            }
        }

        internal virtual ToolStripPanel TopToolStripPanel
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TopToolStripPanel;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.ToolStripContainer1_TopToolStripPanel_Click);
                if (this._TopToolStripPanel != null)
                    this._TopToolStripPanel.Click -= eventHandler;
                this._TopToolStripPanel = value;
                if (this._TopToolStripPanel == null)
                    return;
                this._TopToolStripPanel.Click += eventHandler;
            }
        }

        internal virtual ToolStripPanel RightToolStripPanel
        {
            [DebuggerNonUserCode]
            get
            {
                return this._RightToolStripPanel;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._RightToolStripPanel = value;
            }
        }

        internal virtual ToolStripPanel LeftToolStripPanel
        {
            [DebuggerNonUserCode]
            get
            {
                return this._LeftToolStripPanel;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._LeftToolStripPanel = value;
            }
        }

        internal virtual ToolStripContentPanel ContentPanel
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ContentPanel;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.ToolStripContainer1_ContentPanel_Load);
                if (this._ContentPanel != null)
                    this._ContentPanel.Load -= eventHandler;
                this._ContentPanel = value;
                if (this._ContentPanel == null)
                    return;
                this._ContentPanel.Load += eventHandler;
            }
        }

        internal virtual Panel pnlMenu
        {
            [DebuggerNonUserCode]
            get
            {
                return this._pnlMenu;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pnlMenu = value;
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

        internal virtual ToolStripStatusLabel stlblCompanyName
        {
            [DebuggerNonUserCode]
            get
            {
                return this._stlblCompanyName;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._stlblCompanyName = value;
            }
        }

        internal virtual Panel pnlBody
        {
            [DebuggerNonUserCode]
            get
            {
                return this._pnlBody;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                PaintEventHandler paintEventHandler = new PaintEventHandler(this.pnlBody_Paint);
                if (this._pnlBody != null)
                    this._pnlBody.Paint -= paintEventHandler;
                this._pnlBody = value;
                if (this._pnlBody == null)
                    return;
                this._pnlBody.Paint += paintEventHandler;
            }
        }

        internal virtual Label lblTitle
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblTitle;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblTitle = value;
            }
        }

        internal virtual PictureBox ln
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ln;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ln = value;
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

        internal virtual SoftButton btndetails
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btndetails;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._btndetails = value;
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

        internal virtual SoftButton VistaButton1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._VistaButton1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._VistaButton1 = value;
            }
        }

        internal virtual SoftButton VistaButton2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._VistaButton2;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._VistaButton2 = value;
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
                this._btnOpenCo = value;
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
                this._btnNewCo = value;
            }
        }

        internal virtual SoftButton btnMyInfo
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnMyInfo;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnMyInfo_Click);
                if (this._btnMyInfo != null)
                    this._btnMyInfo.Click -= eventHandler;
                this._btnMyInfo = value;
                if (this._btnMyInfo == null)
                    return;
                this._btnMyInfo.Click += eventHandler;
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

        internal virtual SoftButton VistaButton5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._VistaButton5;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.VistaButton5_Click);
                if (this._VistaButton5 != null)
                    this._VistaButton5.Click -= eventHandler;
                this._VistaButton5 = value;
                if (this._VistaButton5 == null)
                    return;
                this._VistaButton5.Click += eventHandler;
            }
        }

        internal virtual SoftButton VistaButton8
        {
            [DebuggerNonUserCode]
            get
            {
                return this._VistaButton8;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.VistaButton8_Click);
                if (this._VistaButton8 != null)
                    this._VistaButton8.Click -= eventHandler;
                this._VistaButton8 = value;
                if (this._VistaButton8 == null)
                    return;
                this._VistaButton8.Click += eventHandler;
            }
        }

        internal virtual Label lblUser
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblUser;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblUser = value;
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
                EventHandler eventHandler = new EventHandler(this.btnSign_Click_1);
                if (this._btnSign != null)
                    this._btnSign.Click -= eventHandler;
                this._btnSign = value;
                if (this._btnSign == null)
                    return;
                this._btnSign.Click += eventHandler;
            }
        }

        internal virtual Label lblCompanyName
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblCompanyName;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblCompanyName = value;
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
                // frmConnection.CompanyNameChangedEventHandler changedEventHandler = new frmConnection.CompanyNameChangedEventHandler(this.CompanyNameChanged);
                //if (this._frmCompanyConnect != null)
                //    this._frmCompanyConnect.CompanyNameChanged -= changedEventHandler;
                this._frmCompanyConnect = value;
                //if (this._frmCompanyConnect == null)
                //    return;
                //  this._frmCompanyConnect.CompanyNameChanged += changedEventHandler;
            }
        }

        public event Main.ShowConnectEventHandler ShowConnect;

        public void OpenCompany_Old(string filename)
        {
            this.ReadFromFile(filename);
            ConnectionInfo.ConnectionFile = filename;
            ConnectionInfo.RefreshConnection();
            this.sql = new DataAccess(ConnectionInfo.GlobalConnection);
            frmLogin frmLogin = new frmLogin();
            frmLogin.LoginSuccessfull += new frmLogin.LoginSuccessfullEventHandler(this.SignInSuccess);
            int num = (int)frmLogin.ShowDialog(this);
        }

        public async Task OpenCompany(string filename)
        {
            this.ReadFromFile(filename);
            ConnectionInfo.ConnectionFile = filename;
            ConnectionInfo.RefreshConnection();
            this.sql = new DataAccess(ConnectionInfo.GlobalConnection);


            var authenticationResult = await LoginWithAzureAD();

            var client = new HttpClient();
            var header = authenticationResult.CreateAuthorizationHeader();
            client.DefaultRequestHeaders.Add("Authorization", header);
            var response = await client.GetAsync("https://graph.microsoft.com/v1.0/me");
            var content = await response.Content.ReadAsStringAsync();

            MessageBox.Show(content);

            //frmLogin frmLogin = new frmLogin();
            //frmLogin.LoginSuccessfull += new frmLogin.LoginSuccessfullEventHandler(this.SignInSuccess);
            //int num = (int)frmLogin.ShowDialog(this);
        }




        private static async Task<SecurityToken> validateJwtTokenAsync(string token)
        {
            const string TENANT = "1830360c-5d89-409b-8fa4-27204b64c85e";
            const string AUDIENCE = "00000003-0000-0000-c000-000000000000";
            const string CLIENT_ID = "8898135d-4300-4ef2-b007-c62d827a2743";
            // Build URL based on your AAD-TenantId
            string stsDiscoveryEndpoint = "https://login.microsoftonline.com/common/v2.0/.well-known/openid-configuration";
            var handler = new JwtSecurityTokenHandler();
            ConfigurationManager<OpenIdConnectConfiguration> configManager = new ConfigurationManager<OpenIdConnectConfiguration>(stsDiscoveryEndpoint, new OpenIdConnectConfigurationRetriever());
            OpenIdConnectConfiguration config = configManager.GetConfigurationAsync().Result;

            try
            {






                TokenValidationParameters validationParameters = new TokenValidationParameters
                {
                    ValidIssuers = new[] { $"https://login.microsoftonline.com/{TENANT}/v2.0" },
                    ValidAudiences = new[] { CLIENT_ID, "https://graph.windows.net" },
                    ValidateAudience = false,
                    ValidateIssuer = true,
                    IssuerSigningKeys = config.SigningKeys,
                    ValidateLifetime = true
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                SecurityToken validatedToken = null;






                tokenHandler.ValidateToken(token, validationParameters, out validatedToken);
                return validatedToken;
            }
            catch (SecurityTokenInvalidSignatureException ex)
            {
                throw;
            }
            catch (SecurityTokenValidationException)
            {
                throw;
            }
            //return validatedToken;
        }

        private async Task<AuthenticationResult> LoginWithAzureAD()
        {
            var clientId = "8898135d-4300-4ef2-b007-c62d827a2743";
            var tenant = "organizations";
            var scopes = new string[] { "user.read", "GroupMember.Read.All" };

            var clientApp = PublicClientApplicationBuilder.Create(clientId)
                .WithRedirectUri("http://localhost:5000/auth")
                .WithAuthority(AzureCloudInstance.AzurePublic, tenant)
                .Build();

            TokenCacheHelper.EnableSerialization(clientApp.UserTokenCache);

            IdentityModelEventSource.ShowPII = true;

            var result = default(AuthenticationResult);
            var accounts = await clientApp.GetAccountsAsync();
            try
            {
                result = await clientApp.AcquireTokenSilent(scopes, accounts.FirstOrDefault())
                       .ExecuteAsync();
            }
            catch (MsalUiRequiredException ex)
            {
                var builder = clientApp.AcquireTokenInteractive(scopes)
                                       .WithPrompt(Prompt.SelectAccount)
                                       .WithCustomWebUi(new AzureLoginCustomWebUi());

                result = await builder.ExecuteAsync();
            }

            return result;
        }



















        public void ChangeState()
        {
            if (this.SignIn)
            {
                this.lblCompanyName.Text = this.sql.GetScalar("select companyname from companyinfo where companyid=1");
                this.stlblCompanyName.Image = this.ImageList1.Images[0];
                this.stlblCompanyName.Text = "Connected to " + this.lblCompanyName.Text;
                this.pnlMenu.Enabled = true;
                this.lblUser.Text = JobFunctions.LoggedUser;
            }
            else
            {
                this.lblCompanyName.Text = "";
                this.stlblCompanyName.Text = "Not connected";
                this.stlblCompanyName.Image = this.ImageList1.Images[1];
                this.pnlMenu.Enabled = false;
                this.lblUser.Text = "";
            }
        }

        public void SignInSuccess()
        {
            this.pnlBody.Controls.Clear();
            this.SignIn = true;
            this.ChangeState();
        }

        public void SignOut()
        {
            this.SignIn = false;
            this.ChangeState();
            var frmConnection = serviceProvider.GetService<frmConnection>();
            // frmConnection.CompanyNameChanged += new frmConnection.CompanyNameChangedEventHandler(this.CompanyNameChanged);
            JobFunctions.ShowBodyForm(this.pnlBody, (Form)frmConnection, this.lblTitle);
        }

        public void ReadFromFile(string filename)
        {
            try
            {
                string[] strArray1 = new string[1];
                string[] strArray2 = Strings.Split(File.ReadAllText(filename), "\r\n", -1, CompareMethod.Binary);
                this.CompanyFileName = strArray2[0];
                this.ServerName = strArray2[1];
                this.DatabaseName = strArray2[2];
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
            }
        }

        private void CompanyNameChanged(object sender, CompanyNameChangeEventArgs e)
        {
            this.OpenCompany(e.NewValue);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.lblTitle.Text = "Welcome";
            this.ChangeState();
            this.frmCompanyConnect = serviceProvider.GetService<frmConnection>();
            this.frmCompanyConnect.CompanyNameChanged += new frmConnection.CompanyNameChangedEventHandler(this.CompanyNameChanged);
            //TODO: cmd args
            //if (MyProject.Application.CommandLineArgs.Count > 0)
            //{
            //    this.commandfile = MyProject.Application.CommandLineArgs[0];
            //    if (Operators.CompareString(this.commandfile, "", false) != 0)
            //    {
            //        this.OpenCompany(this.commandfile);
            //        if (this.SignIn)
            //            return;
            //        this.SignOut();
            //        return;
            //    }
            //}
            this.ReadFromFile(Application.StartupPath + "\\Default.jcc");
            if (Operators.CompareString(this.CompanyFileName, "", false) != 0)
            {
                this.OpenCompany(Application.StartupPath + "\\" + this.DatabaseName + ".jcc");
                if (this.SignIn)
                    return;
                this.SignOut();
            }
            else
                this.SignOut();
        }

        public void ActivateLogin()
        {
            JobFunctions.ShowForm((Form)new frmLogin());
        }

        private void ToolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {
        }

        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void MenuStrip_MouseEnter(object sender, EventArgs e)
        {
        }

        private void ToolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {
        }

        private void Main_Resize(object sender, EventArgs e)
        {
        }

        private void b_Click(object sender, EventArgs e)
        {
        }

        private void b_Load(object sender, EventArgs e)
        {
        }

        private void b_ValueSubmitted(object sender, ValueSubmission e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void lblCompanyName_Click(object sender, EventArgs e)
        {
        }

        private void lblCompanyName_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
        }

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnMyInfo_Click(object sender, EventArgs e)
        {
            if (Operators.ConditionalCompareObjectEqual(SystemUserGeneric.isUserAdmin(JobFunctions.LoggedUserID, ConnectionInfo.GlobalConnection), (object)false, false))
            {
                frmPassword frmPassword = new frmPassword();
                if (frmPassword.ValidateAdministrator(JobFunctions.LoggedUserID))
                {
                    if (frmPassword.isCanceled)
                        return;
                    JobFunctions.ShowForm((Form)new frmCompanyInfo((Form)this, false));
                }
                else
                {
                    if (frmPassword.isCanceled)
                        return;
                    MessageBox.Show("Invalid password!", "Authentication failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                JobFunctions.ShowForm((Form)new frmCompanyInfo((Form)this, false));
        }

        private void progress_AvailableChanged(object sender, EventArgs e)
        {
        }

        private void progress_Click(object sender, EventArgs e)
        {
        }

        private void VistaButton4_Click(object sender, EventArgs e)
        {
            JobFunctions.ShowBodyForm(this.pnlBody, (Form)new frmCustomerList(), this.lblTitle);
        }

        private void VistaButton5_Click(object sender, EventArgs e)
        {
            JobFunctions.ShowBodyForm(this.pnlBody, (Form)new frmJobList(), this.lblTitle);
        }

        private void VistaButton8_Click(object sender, EventArgs e)
        {
            if (Operators.ConditionalCompareObjectEqual(SystemUserGeneric.isUserAdmin(JobFunctions.LoggedUserID, ConnectionInfo.GlobalConnection), (object)false, false))
            {
                frmPassword frmPassword = new frmPassword();
                if (frmPassword.ValidateAdministrator(JobFunctions.LoggedUserID))
                {
                    if (frmPassword.isCanceled)
                        return;
                    this.doBackup();
                }
                else
                {
                    if (frmPassword.isCanceled)
                        return;
                    MessageBox.Show("Invalid password!", "Authentication failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                this.doBackup();
        }

        public void doBackup()
        {
            frmBackup frmBackup = new frmBackup();
            frmBackup.ShowDialog();
        }

        public Main(IServiceProvider serviceProvider)
        {
            this.Load += new EventHandler(this.Main_Load);
            this.Resize += new EventHandler(this.Main_Resize);
            this.general = new SystemUser(ConnectionInfo.GlobalConnection);
            this.SignIn = false;
            this.commandfile = "";
            this.InitializeComponent();
            // this.
            this.serviceProvider = serviceProvider;
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            //  throw new NotImplementedException();
        }

        private void btnSign_Click_1(object sender, EventArgs e)
        {
            this.SignOut();
        }

        public delegate void ShowConnectEventHandler();
    }
}
