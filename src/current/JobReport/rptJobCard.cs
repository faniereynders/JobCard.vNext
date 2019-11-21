// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.Reports.rptJobCard
// Assembly: JobReport, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9AB96827-84A0-4A46-B10A-10D430717D98
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobReport.dll

using DataDynamics.ActiveReports;
using DDCssLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Reytec.Data.Attributes;
using Reytec.Data.Connection;
using Reytec.JobCard.DAL;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Reytec.JobCard.Reports
{
  [DesignerGenerated]
  public class rptJobCard : ActiveReport3
  {
    [AccessedThroughProperty("Detail1")]
    private Detail _Detail1;
    [AccessedThroughProperty("lblCompleted")]
    private DataDynamics.ActiveReports.Label _lblCompleted;
    [AccessedThroughProperty("Shape6")]
    private Shape _Shape6;
    [AccessedThroughProperty("Shape2")]
    private Shape _Shape2;
    [AccessedThroughProperty("Shape3")]
    private Shape _Shape3;
    [AccessedThroughProperty("Label1")]
    private DataDynamics.ActiveReports.Label _Label1;
    [AccessedThroughProperty("TextBox8")]
    private DataDynamics.ActiveReports.TextBox _TextBox8;
    [AccessedThroughProperty("TextBox9")]
    private DataDynamics.ActiveReports.TextBox _TextBox9;
    [AccessedThroughProperty("Label3")]
    private DataDynamics.ActiveReports.Label _Label3;
    [AccessedThroughProperty("Line1")]
    private Line _Line1;
    [AccessedThroughProperty("Line2")]
    private Line _Line2;
    [AccessedThroughProperty("Label4")]
    private DataDynamics.ActiveReports.Label _Label4;
    [AccessedThroughProperty("Label5")]
    private DataDynamics.ActiveReports.Label _Label5;
    [AccessedThroughProperty("TextBox10")]
    private DataDynamics.ActiveReports.TextBox _TextBox10;
    [AccessedThroughProperty("TextBox11")]
    private DataDynamics.ActiveReports.TextBox _TextBox11;
    [AccessedThroughProperty("Label6")]
    private DataDynamics.ActiveReports.Label _Label6;
    [AccessedThroughProperty("Label7")]
    private DataDynamics.ActiveReports.Label _Label7;
    [AccessedThroughProperty("TextBox12")]
    private DataDynamics.ActiveReports.TextBox _TextBox12;
    [AccessedThroughProperty("Label8")]
    private DataDynamics.ActiveReports.Label _Label8;
    [AccessedThroughProperty("TextBox13")]
    private DataDynamics.ActiveReports.TextBox _TextBox13;
    [AccessedThroughProperty("Label9")]
    private DataDynamics.ActiveReports.Label _Label9;
    [AccessedThroughProperty("TextBox7")]
    private DataDynamics.ActiveReports.TextBox _TextBox7;
    [AccessedThroughProperty("TextBox14")]
    private DataDynamics.ActiveReports.TextBox _TextBox14;
    [AccessedThroughProperty("Label10")]
    private DataDynamics.ActiveReports.Label _Label10;
    [AccessedThroughProperty("Label11")]
    private DataDynamics.ActiveReports.Label _Label11;
    [AccessedThroughProperty("TextBox15")]
    private DataDynamics.ActiveReports.TextBox _TextBox15;
    [AccessedThroughProperty("TextBox16")]
    private DataDynamics.ActiveReports.TextBox _TextBox16;
    [AccessedThroughProperty("Label12")]
    private DataDynamics.ActiveReports.Label _Label12;
    [AccessedThroughProperty("TextBox17")]
    private DataDynamics.ActiveReports.TextBox _TextBox17;
    [AccessedThroughProperty("Label13")]
    private DataDynamics.ActiveReports.Label _Label13;
    [AccessedThroughProperty("TextBox18")]
    private DataDynamics.ActiveReports.TextBox _TextBox18;
    [AccessedThroughProperty("Label14")]
    private DataDynamics.ActiveReports.Label _Label14;
    [AccessedThroughProperty("Line3")]
    private Line _Line3;
    [AccessedThroughProperty("Line4")]
    private Line _Line4;
    [AccessedThroughProperty("Line5")]
    private Line _Line5;
    [AccessedThroughProperty("Line6")]
    private Line _Line6;
    [AccessedThroughProperty("Line7")]
    private Line _Line7;
    [AccessedThroughProperty("Shape4")]
    private Shape _Shape4;
    [AccessedThroughProperty("Label15")]
    private DataDynamics.ActiveReports.Label _Label15;
    [AccessedThroughProperty("Label16")]
    private DataDynamics.ActiveReports.Label _Label16;
    [AccessedThroughProperty("TextBox19")]
    private DataDynamics.ActiveReports.TextBox _TextBox19;
    [AccessedThroughProperty("Line8")]
    private Line _Line8;
    [AccessedThroughProperty("Line9")]
    private Line _Line9;
    [AccessedThroughProperty("Label17")]
    private DataDynamics.ActiveReports.Label _Label17;
    [AccessedThroughProperty("TextBox20")]
    private DataDynamics.ActiveReports.TextBox _TextBox20;
    [AccessedThroughProperty("TextBox21")]
    private DataDynamics.ActiveReports.TextBox _TextBox21;
    [AccessedThroughProperty("Label18")]
    private DataDynamics.ActiveReports.Label _Label18;
    [AccessedThroughProperty("Shape5")]
    private Shape _Shape5;
    [AccessedThroughProperty("Label19")]
    private DataDynamics.ActiveReports.Label _Label19;
    [AccessedThroughProperty("Label20")]
    private DataDynamics.ActiveReports.Label _Label20;
    [AccessedThroughProperty("TextBox22")]
    private DataDynamics.ActiveReports.TextBox _TextBox22;
    [AccessedThroughProperty("Line10")]
    private Line _Line10;
    [AccessedThroughProperty("Label21")]
    private DataDynamics.ActiveReports.Label _Label21;
    [AccessedThroughProperty("TextBox23")]
    private DataDynamics.ActiveReports.TextBox _TextBox23;
    [AccessedThroughProperty("Label22")]
    private DataDynamics.ActiveReports.Label _Label22;
    [AccessedThroughProperty("TextBox24")]
    private DataDynamics.ActiveReports.TextBox _TextBox24;
    [AccessedThroughProperty("Label24")]
    private DataDynamics.ActiveReports.Label _Label24;
    [AccessedThroughProperty("TextBox26")]
    private DataDynamics.ActiveReports.TextBox _TextBox26;
    [AccessedThroughProperty("Line11")]
    private Line _Line11;
    [AccessedThroughProperty("Label23")]
    private DataDynamics.ActiveReports.Label _Label23;
    [AccessedThroughProperty("Label25")]
    private DataDynamics.ActiveReports.Label _Label25;
    [AccessedThroughProperty("Label26")]
    private DataDynamics.ActiveReports.Label _Label26;
    [AccessedThroughProperty("Label27")]
    private DataDynamics.ActiveReports.Label _Label27;
    [AccessedThroughProperty("Line13")]
    private Line _Line13;
    [AccessedThroughProperty("Line14")]
    private Line _Line14;
    [AccessedThroughProperty("Label28")]
    private DataDynamics.ActiveReports.Label _Label28;
    [AccessedThroughProperty("Label29")]
    private DataDynamics.ActiveReports.Label _Label29;
    [AccessedThroughProperty("Label30")]
    private DataDynamics.ActiveReports.Label _Label30;
    [AccessedThroughProperty("Label31")]
    private DataDynamics.ActiveReports.Label _Label31;
    [AccessedThroughProperty("Line16")]
    private Line _Line16;
    [AccessedThroughProperty("Line17")]
    private Line _Line17;
    [AccessedThroughProperty("Line12")]
    private Line _Line12;
    [AccessedThroughProperty("Label32")]
    private DataDynamics.ActiveReports.Label _Label32;
    [AccessedThroughProperty("TextBox25")]
    private DataDynamics.ActiveReports.TextBox _TextBox25;
    [AccessedThroughProperty("TextBox27")]
    private DataDynamics.ActiveReports.TextBox _TextBox27;
    [AccessedThroughProperty("TextBox28")]
    private DataDynamics.ActiveReports.TextBox _TextBox28;
    [AccessedThroughProperty("TextBox29")]
    private DataDynamics.ActiveReports.TextBox _TextBox29;
    [AccessedThroughProperty("TextBox30")]
    private DataDynamics.ActiveReports.TextBox _TextBox30;
    [AccessedThroughProperty("TextBox31")]
    private DataDynamics.ActiveReports.TextBox _TextBox31;
    [AccessedThroughProperty("TextBox32")]
    private DataDynamics.ActiveReports.TextBox _TextBox32;
    [AccessedThroughProperty("Line15")]
    private Line _Line15;
    [AccessedThroughProperty("Label33")]
    private DataDynamics.ActiveReports.Label _Label33;
    [AccessedThroughProperty("TextBox33")]
    private DataDynamics.ActiveReports.TextBox _TextBox33;
    [AccessedThroughProperty("Label34")]
    private DataDynamics.ActiveReports.Label _Label34;
    [AccessedThroughProperty("TextBox34")]
    private DataDynamics.ActiveReports.TextBox _TextBox34;
    [AccessedThroughProperty("TextBox35")]
    private DataDynamics.ActiveReports.TextBox _TextBox35;
    [AccessedThroughProperty("Label35")]
    private DataDynamics.ActiveReports.Label _Label35;
    [AccessedThroughProperty("Line18")]
    private Line _Line18;
    [AccessedThroughProperty("Line19")]
    private Line _Line19;
    [AccessedThroughProperty("Label36")]
    private DataDynamics.ActiveReports.Label _Label36;
    [AccessedThroughProperty("TextBox36")]
    private DataDynamics.ActiveReports.TextBox _TextBox36;
    [AccessedThroughProperty("Label37")]
    private DataDynamics.ActiveReports.Label _Label37;
    [AccessedThroughProperty("TextBox37")]
    private DataDynamics.ActiveReports.TextBox _TextBox37;
    [AccessedThroughProperty("Line20")]
    private Line _Line20;
    [AccessedThroughProperty("Label38")]
    private DataDynamics.ActiveReports.Label _Label38;
    [AccessedThroughProperty("Label39")]
    private DataDynamics.ActiveReports.Label _Label39;
    [AccessedThroughProperty("Line21")]
    private Line _Line21;
    [AccessedThroughProperty("Line22")]
    private Line _Line22;
    [AccessedThroughProperty("Label40")]
    private DataDynamics.ActiveReports.Label _Label40;
    [AccessedThroughProperty("Label41")]
    private DataDynamics.ActiveReports.Label _Label41;
    [AccessedThroughProperty("Line23")]
    private Line _Line23;
    [AccessedThroughProperty("Label42")]
    private DataDynamics.ActiveReports.Label _Label42;
    [AccessedThroughProperty("txtNotes")]
    private DataDynamics.ActiveReports.TextBox _txtNotes;
    [AccessedThroughProperty("PageHeader1")]
    private PageHeader _PageHeader1;
    [AccessedThroughProperty("Shape1")]
    private Shape _Shape1;
    [AccessedThroughProperty("imgLogo")]
    private Picture _imgLogo;
    [AccessedThroughProperty("TextBox2")]
    private DataDynamics.ActiveReports.TextBox _TextBox2;
    [AccessedThroughProperty("Label2")]
    private DataDynamics.ActiveReports.Label _Label2;
    [AccessedThroughProperty("TextBox1")]
    private DataDynamics.ActiveReports.TextBox _TextBox1;
    [AccessedThroughProperty("TextBox3")]
    private DataDynamics.ActiveReports.TextBox _TextBox3;
    [AccessedThroughProperty("TextBox4")]
    private DataDynamics.ActiveReports.TextBox _TextBox4;
    [AccessedThroughProperty("TextBox5")]
    private DataDynamics.ActiveReports.TextBox _TextBox5;
    [AccessedThroughProperty("TextBox6")]
    private DataDynamics.ActiveReports.TextBox _TextBox6;
    [AccessedThroughProperty("PageFooter1")]
    private PageFooter _PageFooter1;
    [AccessedThroughProperty("pJobID")]
    private Parameter _pJobID;
    private JobCardCompany dboCompany;
    private Reytec.JobCard.DAL.JobCard dboJob;
    private Customer dboCustomer;
    private int _JobID;
    private int _CustomerID;

    protected override void Dispose(bool disposing)
    {
      int num = disposing ? 1 : 0;
      base.Dispose(disposing);
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptJobCard));
      this.Detail1 = new Detail();
      this.PageHeader1 = new PageHeader();
      this.PageFooter1 = new PageFooter();
      this.Shape1 = new Shape();
      this.imgLogo = new Picture();
      this.TextBox2 = new DataDynamics.ActiveReports.TextBox();
      this.Label2 = new DataDynamics.ActiveReports.Label();
      this.TextBox1 = new DataDynamics.ActiveReports.TextBox();
      this.TextBox3 = new DataDynamics.ActiveReports.TextBox();
      this.TextBox4 = new DataDynamics.ActiveReports.TextBox();
      this.TextBox5 = new DataDynamics.ActiveReports.TextBox();
      this.TextBox6 = new DataDynamics.ActiveReports.TextBox();
      this.lblCompleted = new DataDynamics.ActiveReports.Label();
      this.Shape6 = new Shape();
      this.Shape2 = new Shape();
      this.Shape3 = new Shape();
      this.Label1 = new DataDynamics.ActiveReports.Label();
      this.TextBox8 = new DataDynamics.ActiveReports.TextBox();
      this.TextBox9 = new DataDynamics.ActiveReports.TextBox();
      this.Label3 = new DataDynamics.ActiveReports.Label();
      this.Line1 = new Line();
      this.Line2 = new Line();
      this.Label4 = new DataDynamics.ActiveReports.Label();
      this.Label5 = new DataDynamics.ActiveReports.Label();
      this.TextBox10 = new DataDynamics.ActiveReports.TextBox();
      this.TextBox11 = new DataDynamics.ActiveReports.TextBox();
      this.Label6 = new DataDynamics.ActiveReports.Label();
      this.Label7 = new DataDynamics.ActiveReports.Label();
      this.TextBox12 = new DataDynamics.ActiveReports.TextBox();
      this.Label8 = new DataDynamics.ActiveReports.Label();
      this.TextBox13 = new DataDynamics.ActiveReports.TextBox();
      this.Label9 = new DataDynamics.ActiveReports.Label();
      this.TextBox7 = new DataDynamics.ActiveReports.TextBox();
      this.TextBox14 = new DataDynamics.ActiveReports.TextBox();
      this.Label10 = new DataDynamics.ActiveReports.Label();
      this.Label11 = new DataDynamics.ActiveReports.Label();
      this.TextBox15 = new DataDynamics.ActiveReports.TextBox();
      this.TextBox16 = new DataDynamics.ActiveReports.TextBox();
      this.Label12 = new DataDynamics.ActiveReports.Label();
      this.TextBox17 = new DataDynamics.ActiveReports.TextBox();
      this.Label13 = new DataDynamics.ActiveReports.Label();
      this.TextBox18 = new DataDynamics.ActiveReports.TextBox();
      this.Label14 = new DataDynamics.ActiveReports.Label();
      this.Line3 = new Line();
      this.Line4 = new Line();
      this.Line5 = new Line();
      this.Line6 = new Line();
      this.Line7 = new Line();
      this.Shape4 = new Shape();
      this.Label15 = new DataDynamics.ActiveReports.Label();
      this.Label16 = new DataDynamics.ActiveReports.Label();
      this.TextBox19 = new DataDynamics.ActiveReports.TextBox();
      this.Line8 = new Line();
      this.Line9 = new Line();
      this.Label17 = new DataDynamics.ActiveReports.Label();
      this.TextBox20 = new DataDynamics.ActiveReports.TextBox();
      this.TextBox21 = new DataDynamics.ActiveReports.TextBox();
      this.Label18 = new DataDynamics.ActiveReports.Label();
      this.Shape5 = new Shape();
      this.Label19 = new DataDynamics.ActiveReports.Label();
      this.Label20 = new DataDynamics.ActiveReports.Label();
      this.TextBox22 = new DataDynamics.ActiveReports.TextBox();
      this.Line10 = new Line();
      this.Label21 = new DataDynamics.ActiveReports.Label();
      this.TextBox23 = new DataDynamics.ActiveReports.TextBox();
      this.Label22 = new DataDynamics.ActiveReports.Label();
      this.TextBox24 = new DataDynamics.ActiveReports.TextBox();
      this.Label24 = new DataDynamics.ActiveReports.Label();
      this.TextBox26 = new DataDynamics.ActiveReports.TextBox();
      this.Line11 = new Line();
      this.Label23 = new DataDynamics.ActiveReports.Label();
      this.Label25 = new DataDynamics.ActiveReports.Label();
      this.Label26 = new DataDynamics.ActiveReports.Label();
      this.Label27 = new DataDynamics.ActiveReports.Label();
      this.Line13 = new Line();
      this.Line14 = new Line();
      this.Label28 = new DataDynamics.ActiveReports.Label();
      this.Label29 = new DataDynamics.ActiveReports.Label();
      this.Label30 = new DataDynamics.ActiveReports.Label();
      this.Label31 = new DataDynamics.ActiveReports.Label();
      this.Line16 = new Line();
      this.Line17 = new Line();
      this.Line12 = new Line();
      this.Label32 = new DataDynamics.ActiveReports.Label();
      this.TextBox25 = new DataDynamics.ActiveReports.TextBox();
      this.TextBox27 = new DataDynamics.ActiveReports.TextBox();
      this.TextBox28 = new DataDynamics.ActiveReports.TextBox();
      this.TextBox29 = new DataDynamics.ActiveReports.TextBox();
      this.TextBox30 = new DataDynamics.ActiveReports.TextBox();
      this.TextBox31 = new DataDynamics.ActiveReports.TextBox();
      this.TextBox32 = new DataDynamics.ActiveReports.TextBox();
      this.Line15 = new Line();
      this.Label33 = new DataDynamics.ActiveReports.Label();
      this.TextBox33 = new DataDynamics.ActiveReports.TextBox();
      this.Label34 = new DataDynamics.ActiveReports.Label();
      this.TextBox34 = new DataDynamics.ActiveReports.TextBox();
      this.TextBox35 = new DataDynamics.ActiveReports.TextBox();
      this.Label35 = new DataDynamics.ActiveReports.Label();
      this.Line18 = new Line();
      this.Line19 = new Line();
      this.Label36 = new DataDynamics.ActiveReports.Label();
      this.TextBox36 = new DataDynamics.ActiveReports.TextBox();
      this.Label37 = new DataDynamics.ActiveReports.Label();
      this.TextBox37 = new DataDynamics.ActiveReports.TextBox();
      this.Line20 = new Line();
      this.Label38 = new DataDynamics.ActiveReports.Label();
      this.Label39 = new DataDynamics.ActiveReports.Label();
      this.Line21 = new Line();
      this.Line22 = new Line();
      this.Label40 = new DataDynamics.ActiveReports.Label();
      this.Label41 = new DataDynamics.ActiveReports.Label();
      this.Line23 = new Line();
      this.Label42 = new DataDynamics.ActiveReports.Label();
      this.txtNotes = new DataDynamics.ActiveReports.TextBox();
      this.pJobID = new Parameter();
      ((ISupportInitialize) this.imgLogo).BeginInit();
      this.TextBox2.BeginInit();
      this.Label2.BeginInit();
      this.TextBox1.BeginInit();
      this.TextBox3.BeginInit();
      this.TextBox4.BeginInit();
      this.TextBox5.BeginInit();
      this.TextBox6.BeginInit();
      this.lblCompleted.BeginInit();
      this.Label1.BeginInit();
      this.TextBox8.BeginInit();
      this.TextBox9.BeginInit();
      this.Label3.BeginInit();
      this.Label4.BeginInit();
      this.Label5.BeginInit();
      this.TextBox10.BeginInit();
      this.TextBox11.BeginInit();
      this.Label6.BeginInit();
      this.Label7.BeginInit();
      this.TextBox12.BeginInit();
      this.Label8.BeginInit();
      this.TextBox13.BeginInit();
      this.Label9.BeginInit();
      this.TextBox7.BeginInit();
      this.TextBox14.BeginInit();
      this.Label10.BeginInit();
      this.Label11.BeginInit();
      this.TextBox15.BeginInit();
      this.TextBox16.BeginInit();
      this.Label12.BeginInit();
      this.TextBox17.BeginInit();
      this.Label13.BeginInit();
      this.TextBox18.BeginInit();
      this.Label14.BeginInit();
      this.Label15.BeginInit();
      this.Label16.BeginInit();
      this.TextBox19.BeginInit();
      this.Label17.BeginInit();
      this.TextBox20.BeginInit();
      this.TextBox21.BeginInit();
      this.Label18.BeginInit();
      this.Label19.BeginInit();
      this.Label20.BeginInit();
      this.TextBox22.BeginInit();
      this.Label21.BeginInit();
      this.TextBox23.BeginInit();
      this.Label22.BeginInit();
      this.TextBox24.BeginInit();
      this.Label24.BeginInit();
      this.TextBox26.BeginInit();
      this.Label23.BeginInit();
      this.Label25.BeginInit();
      this.Label26.BeginInit();
      this.Label27.BeginInit();
      this.Label28.BeginInit();
      this.Label29.BeginInit();
      this.Label30.BeginInit();
      this.Label31.BeginInit();
      this.Label32.BeginInit();
      this.TextBox25.BeginInit();
      this.TextBox27.BeginInit();
      this.TextBox28.BeginInit();
      this.TextBox29.BeginInit();
      this.TextBox30.BeginInit();
      this.TextBox31.BeginInit();
      this.TextBox32.BeginInit();
      this.Label33.BeginInit();
      this.TextBox33.BeginInit();
      this.Label34.BeginInit();
      this.TextBox34.BeginInit();
      this.TextBox35.BeginInit();
      this.Label35.BeginInit();
      this.Label36.BeginInit();
      this.TextBox36.BeginInit();
      this.Label37.BeginInit();
      this.TextBox37.BeginInit();
      this.Label38.BeginInit();
      this.Label39.BeginInit();
      this.Label40.BeginInit();
      this.Label41.BeginInit();
      this.Label42.BeginInit();
      this.txtNotes.BeginInit();
      this.BeginInit();
      this.Detail1.ColumnSpacing = 0.0f;
      this.Detail1.Controls.AddRange(new ARControl[102]
      {
        (ARControl) this.lblCompleted,
        (ARControl) this.Shape6,
        (ARControl) this.Shape2,
        (ARControl) this.Shape3,
        (ARControl) this.Label1,
        (ARControl) this.TextBox8,
        (ARControl) this.TextBox9,
        (ARControl) this.Label3,
        (ARControl) this.Line1,
        (ARControl) this.Line2,
        (ARControl) this.Label4,
        (ARControl) this.Label5,
        (ARControl) this.TextBox10,
        (ARControl) this.TextBox11,
        (ARControl) this.Label6,
        (ARControl) this.Label7,
        (ARControl) this.TextBox12,
        (ARControl) this.Label8,
        (ARControl) this.TextBox13,
        (ARControl) this.Label9,
        (ARControl) this.TextBox7,
        (ARControl) this.TextBox14,
        (ARControl) this.Label10,
        (ARControl) this.Label11,
        (ARControl) this.TextBox15,
        (ARControl) this.TextBox16,
        (ARControl) this.Label12,
        (ARControl) this.TextBox17,
        (ARControl) this.Label13,
        (ARControl) this.TextBox18,
        (ARControl) this.Label14,
        (ARControl) this.Line3,
        (ARControl) this.Line4,
        (ARControl) this.Line5,
        (ARControl) this.Line6,
        (ARControl) this.Line7,
        (ARControl) this.Shape4,
        (ARControl) this.Label15,
        (ARControl) this.Label16,
        (ARControl) this.TextBox19,
        (ARControl) this.Line8,
        (ARControl) this.Line9,
        (ARControl) this.Label17,
        (ARControl) this.TextBox20,
        (ARControl) this.TextBox21,
        (ARControl) this.Label18,
        (ARControl) this.Shape5,
        (ARControl) this.Label19,
        (ARControl) this.Label20,
        (ARControl) this.TextBox22,
        (ARControl) this.Line10,
        (ARControl) this.Label21,
        (ARControl) this.TextBox23,
        (ARControl) this.Label22,
        (ARControl) this.TextBox24,
        (ARControl) this.Label24,
        (ARControl) this.TextBox26,
        (ARControl) this.Line11,
        (ARControl) this.Label23,
        (ARControl) this.Label25,
        (ARControl) this.Label26,
        (ARControl) this.Label27,
        (ARControl) this.Line13,
        (ARControl) this.Line14,
        (ARControl) this.Label28,
        (ARControl) this.Label29,
        (ARControl) this.Label30,
        (ARControl) this.Label31,
        (ARControl) this.Line16,
        (ARControl) this.Line17,
        (ARControl) this.Line12,
        (ARControl) this.Label32,
        (ARControl) this.TextBox25,
        (ARControl) this.TextBox27,
        (ARControl) this.TextBox28,
        (ARControl) this.TextBox29,
        (ARControl) this.TextBox30,
        (ARControl) this.TextBox31,
        (ARControl) this.TextBox32,
        (ARControl) this.Line15,
        (ARControl) this.Label33,
        (ARControl) this.TextBox33,
        (ARControl) this.Label34,
        (ARControl) this.TextBox34,
        (ARControl) this.TextBox35,
        (ARControl) this.Label35,
        (ARControl) this.Line18,
        (ARControl) this.Line19,
        (ARControl) this.Label36,
        (ARControl) this.TextBox36,
        (ARControl) this.Label37,
        (ARControl) this.TextBox37,
        (ARControl) this.Line20,
        (ARControl) this.Label38,
        (ARControl) this.Label39,
        (ARControl) this.Line21,
        (ARControl) this.Line22,
        (ARControl) this.Label40,
        (ARControl) this.Label41,
        (ARControl) this.Line23,
        (ARControl) this.Label42,
        (ARControl) this.txtNotes
      });
      this.Detail1.Height = 7.331944f;
      this.Detail1.Name = "Detail1";
      this.PageHeader1.Controls.AddRange(new ARControl[9]
      {
        (ARControl) this.Shape1,
        (ARControl) this.imgLogo,
        (ARControl) this.TextBox2,
        (ARControl) this.Label2,
        (ARControl) this.TextBox1,
        (ARControl) this.TextBox3,
        (ARControl) this.TextBox4,
        (ARControl) this.TextBox5,
        (ARControl) this.TextBox6
      });
      this.PageHeader1.Height = 1.802083f;
      this.PageHeader1.Name = "PageHeader1";
      this.PageFooter1.Height = 0.0f;
      this.PageFooter1.Name = "PageFooter1";
      this.Shape1.BackColor = Color.FromArgb(220, 220, 220);
      this.Shape1.Border.BottomColor = Color.Black;
      this.Shape1.Border.BottomStyle = BorderLineStyle.None;
      this.Shape1.Border.LeftColor = Color.Black;
      this.Shape1.Border.LeftStyle = BorderLineStyle.None;
      this.Shape1.Border.RightColor = Color.Black;
      this.Shape1.Border.RightStyle = BorderLineStyle.None;
      this.Shape1.Border.TopColor = Color.Black;
      this.Shape1.Border.TopStyle = BorderLineStyle.None;
      this.Shape1.Height = 0.75f;
      this.Shape1.Left = 5.25f;
      this.Shape1.Name = "Shape1";
      this.Shape1.RoundingRadius = 20f;
      this.Shape1.Style = ShapeType.RoundRect;
      this.Shape1.Top = 0.0f;
      this.Shape1.Width = 1.75f;
      this.imgLogo.Border.BottomColor = Color.Black;
      this.imgLogo.Border.BottomStyle = BorderLineStyle.None;
      this.imgLogo.Border.LeftColor = Color.Black;
      this.imgLogo.Border.LeftStyle = BorderLineStyle.None;
      this.imgLogo.Border.RightColor = Color.Black;
      this.imgLogo.Border.RightStyle = BorderLineStyle.None;
      this.imgLogo.Border.TopColor = Color.Black;
      this.imgLogo.Border.TopStyle = BorderLineStyle.None;
      this.imgLogo.DataField = "Logo";
      this.imgLogo.Height = 1f;
      this.imgLogo.Image = (System.Drawing.Image) null;
      this.imgLogo.ImageData = (Stream) null;
      this.imgLogo.Left = 0.0f;
      this.imgLogo.LineColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      this.imgLogo.LineWeight = 0.0f;
      this.imgLogo.Name = "imgLogo";
      this.imgLogo.SizeMode = SizeModes.Zoom;
      this.imgLogo.Top = 0.0f;
      this.imgLogo.Width = 4.8f;
      this.TextBox2.Border.BottomColor = Color.Black;
      this.TextBox2.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox2.Border.LeftColor = Color.Black;
      this.TextBox2.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox2.Border.RightColor = Color.Black;
      this.TextBox2.Border.RightStyle = BorderLineStyle.None;
      this.TextBox2.Border.TopColor = Color.Black;
      this.TextBox2.Border.TopStyle = BorderLineStyle.None;
      this.TextBox2.DataField = "Contact";
      this.TextBox2.Height = 0.7f;
      this.TextBox2.Left = 3.65f;
      this.TextBox2.Name = "TextBox2";
      this.TextBox2.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; ";
      this.TextBox2.Text = "Address, Postal, Tels";
      this.TextBox2.Top = 1f;
      this.TextBox2.Width = 3.35f;
      this.Label2.Border.BottomColor = Color.Black;
      this.Label2.Border.BottomStyle = BorderLineStyle.None;
      this.Label2.Border.LeftColor = Color.Black;
      this.Label2.Border.LeftStyle = BorderLineStyle.None;
      this.Label2.Border.RightColor = Color.Black;
      this.Label2.Border.RightStyle = BorderLineStyle.None;
      this.Label2.Border.TopColor = Color.Black;
      this.Label2.Border.TopStyle = BorderLineStyle.None;
      this.Label2.Height = 0.375f;
      this.Label2.HyperLink = (string) null;
      this.Label2.Left = 85f / 16f;
      this.Label2.Name = "Label2";
      this.Label2.Style = "color: Black; ddo-char-set: 0; text-align: left; font-size: 20.25pt; font-family: Arial Black; ";
      this.Label2.Text = "JOB CARD";
      this.Label2.Top = 1f / 16f;
      this.Label2.Width = 1.75f;
      this.TextBox1.Border.BottomColor = Color.Black;
      this.TextBox1.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox1.Border.LeftColor = Color.Black;
      this.TextBox1.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox1.Border.RightColor = Color.Black;
      this.TextBox1.Border.RightStyle = BorderLineStyle.None;
      this.TextBox1.Border.TopColor = Color.Black;
      this.TextBox1.Border.TopStyle = BorderLineStyle.None;
      this.TextBox1.DataField = "JobNr";
      this.TextBox1.Height = 0.25f;
      this.TextBox1.Left = 85f / 16f;
      this.TextBox1.Name = "TextBox1";
      this.TextBox1.Style = "text-align: right; font-weight: bold; font-size: 9.75pt; ";
      this.TextBox1.Text = "TextBox1";
      this.TextBox1.Top = 7f / 16f;
      this.TextBox1.Width = 1.625f;
      this.TextBox3.Border.BottomColor = Color.Black;
      this.TextBox3.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox3.Border.LeftColor = Color.Black;
      this.TextBox3.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox3.Border.RightColor = Color.Black;
      this.TextBox3.Border.RightStyle = BorderLineStyle.None;
      this.TextBox3.Border.TopColor = Color.Black;
      this.TextBox3.Border.TopStyle = BorderLineStyle.None;
      this.TextBox3.DataField = "CompanyName";
      this.TextBox3.Height = 0.3500001f;
      this.TextBox3.Left = 0.0f;
      this.TextBox3.Name = "TextBox3";
      this.TextBox3.Style = "font-weight: bold; font-size: 9pt; ";
      this.TextBox3.Text = "BRANCH";
      this.TextBox3.Top = 1f;
      this.TextBox3.Width = 3.6f;
      this.TextBox4.Border.BottomColor = Color.Black;
      this.TextBox4.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox4.Border.LeftColor = Color.Black;
      this.TextBox4.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox4.Border.RightColor = Color.Black;
      this.TextBox4.Border.RightStyle = BorderLineStyle.None;
      this.TextBox4.Border.TopColor = Color.Black;
      this.TextBox4.Border.TopStyle = BorderLineStyle.None;
      this.TextBox4.DataField = "TradingAs";
      this.TextBox4.Height = 0.15f;
      this.TextBox4.Left = 0.0f;
      this.TextBox4.Name = "TextBox4";
      this.TextBox4.Style = "font-size: 8.25pt; ";
      this.TextBox4.Text = "t/a";
      this.TextBox4.Top = 1.35f;
      this.TextBox4.Width = 3.6f;
      this.TextBox5.Border.BottomColor = Color.Black;
      this.TextBox5.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox5.Border.LeftColor = Color.Black;
      this.TextBox5.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox5.Border.RightColor = Color.Black;
      this.TextBox5.Border.RightStyle = BorderLineStyle.None;
      this.TextBox5.Border.TopColor = Color.Black;
      this.TextBox5.Border.TopStyle = BorderLineStyle.None;
      this.TextBox5.DataField = "RegNr";
      this.TextBox5.Height = 0.15f;
      this.TextBox5.Left = 0.0f;
      this.TextBox5.Name = "TextBox5";
      this.TextBox5.Style = "font-size: 8.25pt; ";
      this.TextBox5.Text = "CC Reg";
      this.TextBox5.Top = 1.5f;
      this.TextBox5.Width = 3.6f;
      this.TextBox6.Border.BottomColor = Color.Black;
      this.TextBox6.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox6.Border.LeftColor = Color.Black;
      this.TextBox6.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox6.Border.RightColor = Color.Black;
      this.TextBox6.Border.RightStyle = BorderLineStyle.None;
      this.TextBox6.Border.TopColor = Color.Black;
      this.TextBox6.Border.TopStyle = BorderLineStyle.None;
      this.TextBox6.DataField = "VatNr";
      this.TextBox6.Height = 0.1500001f;
      this.TextBox6.Left = 0.0f;
      this.TextBox6.Name = "TextBox6";
      this.TextBox6.Style = "font-size: 8.25pt; ";
      this.TextBox6.Text = "VAT Reg";
      this.TextBox6.Top = 1.65f;
      this.TextBox6.Width = 3.6f;
      this.lblCompleted.Angle = 400;
      this.lblCompleted.Border.BottomColor = Color.Black;
      this.lblCompleted.Border.BottomStyle = BorderLineStyle.None;
      this.lblCompleted.Border.LeftColor = Color.Black;
      this.lblCompleted.Border.LeftStyle = BorderLineStyle.None;
      this.lblCompleted.Border.RightColor = Color.Black;
      this.lblCompleted.Border.RightStyle = BorderLineStyle.None;
      this.lblCompleted.Border.TopColor = Color.Black;
      this.lblCompleted.Border.TopStyle = BorderLineStyle.None;
      this.lblCompleted.DataField = "Completed";
      this.lblCompleted.Height = 6.95f;
      this.lblCompleted.HyperLink = (string) null;
      this.lblCompleted.Left = 0.05f;
      this.lblCompleted.Name = "lblCompleted";
      this.lblCompleted.Style = "color: Gainsboro; font-weight: bold; font-size: 84.75pt; ";
      this.lblCompleted.Text = "COMPLETED";
      this.lblCompleted.Top = 0.3f;
      this.lblCompleted.Width = 7.45f;
      this.Shape6.BackColor = Color.FromArgb(220, 220, 220);
      this.Shape6.Border.BottomColor = Color.Black;
      this.Shape6.Border.BottomStyle = BorderLineStyle.None;
      this.Shape6.Border.LeftColor = Color.Black;
      this.Shape6.Border.LeftStyle = BorderLineStyle.None;
      this.Shape6.Border.RightColor = Color.Black;
      this.Shape6.Border.RightStyle = BorderLineStyle.None;
      this.Shape6.Border.TopColor = Color.Black;
      this.Shape6.Border.TopStyle = BorderLineStyle.None;
      this.Shape6.Height = 0.25f;
      this.Shape6.Left = 0.0f;
      this.Shape6.Name = "Shape6";
      this.Shape6.RoundingRadius = 9.999999f;
      this.Shape6.Top = 3.85f;
      this.Shape6.Width = 7f;
      this.Shape2.Border.BottomColor = Color.Black;
      this.Shape2.Border.BottomStyle = BorderLineStyle.None;
      this.Shape2.Border.LeftColor = Color.Black;
      this.Shape2.Border.LeftStyle = BorderLineStyle.None;
      this.Shape2.Border.RightColor = Color.Black;
      this.Shape2.Border.RightStyle = BorderLineStyle.None;
      this.Shape2.Border.TopColor = Color.Black;
      this.Shape2.Border.TopStyle = BorderLineStyle.None;
      this.Shape2.Height = 7.3f;
      this.Shape2.Left = 0.0f;
      this.Shape2.Name = "Shape2";
      this.Shape2.RoundingRadius = 5f;
      this.Shape2.Style = ShapeType.RoundRect;
      this.Shape2.Top = 0.0f;
      this.Shape2.Width = 7f;
      this.Shape3.BackColor = Color.FromArgb(220, 220, 220);
      this.Shape3.Border.BottomColor = Color.Black;
      this.Shape3.Border.BottomStyle = BorderLineStyle.None;
      this.Shape3.Border.LeftColor = Color.Black;
      this.Shape3.Border.LeftStyle = BorderLineStyle.None;
      this.Shape3.Border.RightColor = Color.Black;
      this.Shape3.Border.RightStyle = BorderLineStyle.None;
      this.Shape3.Border.TopColor = Color.Black;
      this.Shape3.Border.TopStyle = BorderLineStyle.None;
      this.Shape3.Height = 0.25f;
      this.Shape3.Left = 0.0f;
      this.Shape3.Name = "Shape3";
      this.Shape3.RoundingRadius = 9.999999f;
      this.Shape3.Top = 0.25f;
      this.Shape3.Width = 7f;
      this.Label1.Border.BottomColor = Color.Black;
      this.Label1.Border.BottomStyle = BorderLineStyle.None;
      this.Label1.Border.LeftColor = Color.Black;
      this.Label1.Border.LeftStyle = BorderLineStyle.None;
      this.Label1.Border.RightColor = Color.Black;
      this.Label1.Border.RightStyle = BorderLineStyle.None;
      this.Label1.Border.TopColor = Color.Black;
      this.Label1.Border.TopStyle = BorderLineStyle.None;
      this.Label1.Height = 0.2f;
      this.Label1.HyperLink = (string) null;
      this.Label1.Left = 0.05f;
      this.Label1.Name = "Label1";
      this.Label1.Style = "font-size: 9pt; ";
      this.Label1.Text = "DATE:";
      this.Label1.Top = 0.05f;
      this.Label1.Width = 0.5f;
      this.TextBox8.Border.BottomColor = Color.Black;
      this.TextBox8.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox8.Border.LeftColor = Color.Black;
      this.TextBox8.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox8.Border.RightColor = Color.Black;
      this.TextBox8.Border.RightStyle = BorderLineStyle.None;
      this.TextBox8.Border.TopColor = Color.Black;
      this.TextBox8.Border.TopStyle = BorderLineStyle.None;
      this.TextBox8.DataField = "Date";
      this.TextBox8.Height = 0.1979167f;
      this.TextBox8.Left = 0.55f;
      this.TextBox8.Name = "TextBox8";
      this.TextBox8.Style = "font-size: 9pt; ";
      this.TextBox8.Text = "JobDate";
      this.TextBox8.Top = 0.05f;
      this.TextBox8.Width = 1f;
      this.TextBox9.Border.BottomColor = Color.Black;
      this.TextBox9.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox9.Border.LeftColor = Color.Black;
      this.TextBox9.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox9.Border.RightColor = Color.Black;
      this.TextBox9.Border.RightStyle = BorderLineStyle.None;
      this.TextBox9.Border.TopColor = Color.Black;
      this.TextBox9.Border.TopStyle = BorderLineStyle.None;
      this.TextBox9.DataField = "Team";
      this.TextBox9.Height = 0.2f;
      this.TextBox9.Left = 3.65f;
      this.TextBox9.Name = "TextBox9";
      this.TextBox9.Style = "font-size: 9pt; ";
      this.TextBox9.Text = "Team";
      this.TextBox9.Top = 0.05f;
      this.TextBox9.Width = 3.25f;
      this.Label3.Border.BottomColor = Color.Black;
      this.Label3.Border.BottomStyle = BorderLineStyle.None;
      this.Label3.Border.LeftColor = Color.Black;
      this.Label3.Border.LeftStyle = BorderLineStyle.None;
      this.Label3.Border.RightColor = Color.Black;
      this.Label3.Border.RightStyle = BorderLineStyle.None;
      this.Label3.Border.TopColor = Color.Black;
      this.Label3.Border.TopStyle = BorderLineStyle.None;
      this.Label3.Height = 0.2f;
      this.Label3.HyperLink = (string) null;
      this.Label3.Left = 2.45f;
      this.Label3.Name = "Label3";
      this.Label3.Style = "font-size: 9pt; ";
      this.Label3.Text = "TEAM ALLOCATED:";
      this.Label3.Top = 0.05f;
      this.Label3.Width = 1.2f;
      this.Line1.Border.BottomColor = Color.Black;
      this.Line1.Border.BottomStyle = BorderLineStyle.None;
      this.Line1.Border.LeftColor = Color.Black;
      this.Line1.Border.LeftStyle = BorderLineStyle.None;
      this.Line1.Border.RightColor = Color.Black;
      this.Line1.Border.RightStyle = BorderLineStyle.None;
      this.Line1.Border.TopColor = Color.Black;
      this.Line1.Border.TopStyle = BorderLineStyle.None;
      this.Line1.Height = 0.0f;
      this.Line1.Left = 0.0f;
      this.Line1.LineWeight = 1f;
      this.Line1.Name = "Line1";
      this.Line1.Top = 0.25f;
      this.Line1.Width = 7f;
      this.Line1.X1 = 0.0f;
      this.Line1.X2 = 7f;
      this.Line1.Y1 = 0.25f;
      this.Line1.Y2 = 0.25f;
      this.Line2.Border.BottomColor = Color.Black;
      this.Line2.Border.BottomStyle = BorderLineStyle.None;
      this.Line2.Border.LeftColor = Color.Black;
      this.Line2.Border.LeftStyle = BorderLineStyle.None;
      this.Line2.Border.RightColor = Color.Black;
      this.Line2.Border.RightStyle = BorderLineStyle.None;
      this.Line2.Border.TopColor = Color.Black;
      this.Line2.Border.TopStyle = BorderLineStyle.None;
      this.Line2.Height = 0.25f;
      this.Line2.Left = 2.4f;
      this.Line2.LineWeight = 1f;
      this.Line2.Name = "Line2";
      this.Line2.Top = 0.0f;
      this.Line2.Width = 0.0f;
      this.Line2.X1 = 2.4f;
      this.Line2.X2 = 2.4f;
      this.Line2.Y1 = 0.0f;
      this.Line2.Y2 = 0.25f;
      this.Label4.Border.BottomColor = Color.Black;
      this.Label4.Border.BottomStyle = BorderLineStyle.None;
      this.Label4.Border.LeftColor = Color.Black;
      this.Label4.Border.LeftStyle = BorderLineStyle.None;
      this.Label4.Border.RightColor = Color.Black;
      this.Label4.Border.RightStyle = BorderLineStyle.None;
      this.Label4.Border.TopColor = Color.Black;
      this.Label4.Border.TopStyle = BorderLineStyle.None;
      this.Label4.Height = 0.2f;
      this.Label4.HyperLink = (string) null;
      this.Label4.Left = 0.05f;
      this.Label4.Name = "Label4";
      this.Label4.Style = "font-weight: bold; font-size: 8.25pt; ";
      this.Label4.Text = "CUSTOMER DETAILS:";
      this.Label4.Top = 0.3f;
      this.Label4.Width = 1.85f;
      this.Label5.Border.BottomColor = Color.Black;
      this.Label5.Border.BottomStyle = BorderLineStyle.None;
      this.Label5.Border.LeftColor = Color.Black;
      this.Label5.Border.LeftStyle = BorderLineStyle.None;
      this.Label5.Border.RightColor = Color.Black;
      this.Label5.Border.RightStyle = BorderLineStyle.None;
      this.Label5.Border.TopColor = Color.Black;
      this.Label5.Border.TopStyle = BorderLineStyle.None;
      this.Label5.Height = 0.2f;
      this.Label5.HyperLink = (string) null;
      this.Label5.Left = 0.05f;
      this.Label5.Name = "Label5";
      this.Label5.Style = "";
      this.Label5.Text = "ACCOUNT NUMBER:";
      this.Label5.Top = 0.55f;
      this.Label5.Width = 1.3f;
      this.TextBox10.Border.BottomColor = Color.Black;
      this.TextBox10.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox10.Border.LeftColor = Color.Black;
      this.TextBox10.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox10.Border.RightColor = Color.Black;
      this.TextBox10.Border.RightStyle = BorderLineStyle.None;
      this.TextBox10.Border.TopColor = Color.Black;
      this.TextBox10.Border.TopStyle = BorderLineStyle.None;
      this.TextBox10.DataField = "CustomerAccount";
      this.TextBox10.Height = 0.2f;
      this.TextBox10.Left = 1.35f;
      this.TextBox10.Name = "TextBox10";
      this.TextBox10.Style = "";
      this.TextBox10.Text = "AccountNr";
      this.TextBox10.Top = 0.55f;
      this.TextBox10.Width = 1.05f;
      this.TextBox11.Border.BottomColor = Color.Black;
      this.TextBox11.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox11.Border.LeftColor = Color.Black;
      this.TextBox11.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox11.Border.RightColor = Color.Black;
      this.TextBox11.Border.RightStyle = BorderLineStyle.None;
      this.TextBox11.Border.TopColor = Color.Black;
      this.TextBox11.Border.TopStyle = BorderLineStyle.None;
      this.TextBox11.DataField = "CustomerName";
      this.TextBox11.Height = 0.2f;
      this.TextBox11.Left = 2.95f;
      this.TextBox11.Name = "TextBox11";
      this.TextBox11.Style = "";
      this.TextBox11.Text = "CustomerName";
      this.TextBox11.Top = 0.55f;
      this.TextBox11.Width = 2.4f;
      this.Label6.Border.BottomColor = Color.Black;
      this.Label6.Border.BottomStyle = BorderLineStyle.None;
      this.Label6.Border.LeftColor = Color.Black;
      this.Label6.Border.LeftStyle = BorderLineStyle.None;
      this.Label6.Border.RightColor = Color.Black;
      this.Label6.Border.RightStyle = BorderLineStyle.None;
      this.Label6.Border.TopColor = Color.Black;
      this.Label6.Border.TopStyle = BorderLineStyle.None;
      this.Label6.Height = 0.2f;
      this.Label6.HyperLink = (string) null;
      this.Label6.Left = 2.45f;
      this.Label6.Name = "Label6";
      this.Label6.Style = "";
      this.Label6.Text = "NAME:";
      this.Label6.Top = 0.55f;
      this.Label6.Width = 0.4499999f;
      this.Label7.Border.BottomColor = Color.Black;
      this.Label7.Border.BottomStyle = BorderLineStyle.None;
      this.Label7.Border.LeftColor = Color.Black;
      this.Label7.Border.LeftStyle = BorderLineStyle.None;
      this.Label7.Border.RightColor = Color.Black;
      this.Label7.Border.RightStyle = BorderLineStyle.None;
      this.Label7.Border.TopColor = Color.Black;
      this.Label7.Border.TopStyle = BorderLineStyle.None;
      this.Label7.Height = 0.2f;
      this.Label7.HyperLink = (string) null;
      this.Label7.Left = 5.45f;
      this.Label7.Name = "Label7";
      this.Label7.Style = "";
      this.Label7.Text = "ID NR:";
      this.Label7.Top = 0.55f;
      this.Label7.Width = 0.45f;
      this.TextBox12.Border.BottomColor = Color.Black;
      this.TextBox12.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox12.Border.LeftColor = Color.Black;
      this.TextBox12.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox12.Border.RightColor = Color.Black;
      this.TextBox12.Border.RightStyle = BorderLineStyle.None;
      this.TextBox12.Border.TopColor = Color.Black;
      this.TextBox12.Border.TopStyle = BorderLineStyle.None;
      this.TextBox12.DataField = "CustomerID";
      this.TextBox12.Height = 0.2f;
      this.TextBox12.Left = 5.95f;
      this.TextBox12.Name = "TextBox12";
      this.TextBox12.Style = "";
      this.TextBox12.Text = "9999999999999";
      this.TextBox12.Top = 0.55f;
      this.TextBox12.Width = 1f;
      this.Label8.Border.BottomColor = Color.Black;
      this.Label8.Border.BottomStyle = BorderLineStyle.None;
      this.Label8.Border.LeftColor = Color.Black;
      this.Label8.Border.LeftStyle = BorderLineStyle.None;
      this.Label8.Border.RightColor = Color.Black;
      this.Label8.Border.RightStyle = BorderLineStyle.None;
      this.Label8.Border.TopColor = Color.Black;
      this.Label8.Border.TopStyle = BorderLineStyle.None;
      this.Label8.Height = 0.2f;
      this.Label8.HyperLink = (string) null;
      this.Label8.Left = 0.05f;
      this.Label8.Name = "Label8";
      this.Label8.Style = "";
      this.Label8.Text = "E-MAIL:";
      this.Label8.Top = 0.8f;
      this.Label8.Width = 0.5f;
      this.TextBox13.Border.BottomColor = Color.Black;
      this.TextBox13.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox13.Border.LeftColor = Color.Black;
      this.TextBox13.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox13.Border.RightColor = Color.Black;
      this.TextBox13.Border.RightStyle = BorderLineStyle.None;
      this.TextBox13.Border.TopColor = Color.Black;
      this.TextBox13.Border.TopStyle = BorderLineStyle.None;
      this.TextBox13.DataField = "CustomerEmail";
      this.TextBox13.Height = 0.2f;
      this.TextBox13.Left = 0.55f;
      this.TextBox13.Name = "TextBox13";
      this.TextBox13.Style = "";
      this.TextBox13.Text = "E-Mail";
      this.TextBox13.Top = 0.8f;
      this.TextBox13.Width = 1.85f;
      this.Label9.Border.BottomColor = Color.Black;
      this.Label9.Border.BottomStyle = BorderLineStyle.None;
      this.Label9.Border.LeftColor = Color.Black;
      this.Label9.Border.LeftStyle = BorderLineStyle.None;
      this.Label9.Border.RightColor = Color.Black;
      this.Label9.Border.RightStyle = BorderLineStyle.None;
      this.Label9.Border.TopColor = Color.Black;
      this.Label9.Border.TopStyle = BorderLineStyle.None;
      this.Label9.Height = 0.2f;
      this.Label9.HyperLink = (string) null;
      this.Label9.Left = 2.45f;
      this.Label9.Name = "Label9";
      this.Label9.Style = "";
      this.Label9.Text = "RESIDENTIAL ADDRESS:";
      this.Label9.Top = 0.8f;
      this.Label9.Width = 1.7f;
      this.TextBox7.Border.BottomColor = Color.Black;
      this.TextBox7.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox7.Border.LeftColor = Color.Black;
      this.TextBox7.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox7.Border.RightColor = Color.Black;
      this.TextBox7.Border.RightStyle = BorderLineStyle.None;
      this.TextBox7.Border.TopColor = Color.Black;
      this.TextBox7.Border.TopStyle = BorderLineStyle.None;
      this.TextBox7.DataField = "CustomerResidential";
      this.TextBox7.Height = 0.2f;
      this.TextBox7.Left = 2.45f;
      this.TextBox7.Name = "TextBox7";
      this.TextBox7.Style = "";
      this.TextBox7.Text = "Residential Address";
      this.TextBox7.Top = 1f;
      this.TextBox7.Width = 4.5f;
      this.TextBox14.Border.BottomColor = Color.Black;
      this.TextBox14.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox14.Border.LeftColor = Color.Black;
      this.TextBox14.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox14.Border.RightColor = Color.Black;
      this.TextBox14.Border.RightStyle = BorderLineStyle.None;
      this.TextBox14.Border.TopColor = Color.Black;
      this.TextBox14.Border.TopStyle = BorderLineStyle.None;
      this.TextBox14.DataField = "CustomerPOBox";
      this.TextBox14.Height = 0.3499999f;
      this.TextBox14.Left = 2.45f;
      this.TextBox14.Name = "TextBox14";
      this.TextBox14.Style = "";
      this.TextBox14.Text = "Residential Address";
      this.TextBox14.Top = 1.45f;
      this.TextBox14.Width = 4.5f;
      this.Label10.Border.BottomColor = Color.Black;
      this.Label10.Border.BottomStyle = BorderLineStyle.None;
      this.Label10.Border.LeftColor = Color.Black;
      this.Label10.Border.LeftStyle = BorderLineStyle.None;
      this.Label10.Border.RightColor = Color.Black;
      this.Label10.Border.RightStyle = BorderLineStyle.None;
      this.Label10.Border.TopColor = Color.Black;
      this.Label10.Border.TopStyle = BorderLineStyle.None;
      this.Label10.Height = 0.2f;
      this.Label10.HyperLink = (string) null;
      this.Label10.Left = 2.45f;
      this.Label10.Name = "Label10";
      this.Label10.Style = "";
      this.Label10.Text = "POSTAL ADDRESS:";
      this.Label10.Top = 1.25f;
      this.Label10.Width = 1.7f;
      this.Label11.Border.BottomColor = Color.Black;
      this.Label11.Border.BottomStyle = BorderLineStyle.None;
      this.Label11.Border.LeftColor = Color.Black;
      this.Label11.Border.LeftStyle = BorderLineStyle.None;
      this.Label11.Border.RightColor = Color.Black;
      this.Label11.Border.RightStyle = BorderLineStyle.None;
      this.Label11.Border.TopColor = Color.Black;
      this.Label11.Border.TopStyle = BorderLineStyle.None;
      this.Label11.Height = 0.2f;
      this.Label11.HyperLink = (string) null;
      this.Label11.Left = 0.05f;
      this.Label11.Name = "Label11";
      this.Label11.Style = "";
      this.Label11.Text = "TEL 1:";
      this.Label11.Top = 1f;
      this.Label11.Width = 0.5f;
      this.TextBox15.Border.BottomColor = Color.Black;
      this.TextBox15.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox15.Border.LeftColor = Color.Black;
      this.TextBox15.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox15.Border.RightColor = Color.Black;
      this.TextBox15.Border.RightStyle = BorderLineStyle.None;
      this.TextBox15.Border.TopColor = Color.Black;
      this.TextBox15.Border.TopStyle = BorderLineStyle.None;
      this.TextBox15.DataField = "CustomerTel1";
      this.TextBox15.Height = 0.2f;
      this.TextBox15.Left = 0.55f;
      this.TextBox15.Name = "TextBox15";
      this.TextBox15.Style = "";
      this.TextBox15.Text = "Tel 1";
      this.TextBox15.Top = 1f;
      this.TextBox15.Width = 1.85f;
      this.TextBox16.Border.BottomColor = Color.Black;
      this.TextBox16.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox16.Border.LeftColor = Color.Black;
      this.TextBox16.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox16.Border.RightColor = Color.Black;
      this.TextBox16.Border.RightStyle = BorderLineStyle.None;
      this.TextBox16.Border.TopColor = Color.Black;
      this.TextBox16.Border.TopStyle = BorderLineStyle.None;
      this.TextBox16.DataField = "CustomerTel2";
      this.TextBox16.Height = 0.2f;
      this.TextBox16.Left = 0.55f;
      this.TextBox16.Name = "TextBox16";
      this.TextBox16.Style = "";
      this.TextBox16.Text = "Tel 2";
      this.TextBox16.Top = 1.2f;
      this.TextBox16.Width = 1.85f;
      this.Label12.Border.BottomColor = Color.Black;
      this.Label12.Border.BottomStyle = BorderLineStyle.None;
      this.Label12.Border.LeftColor = Color.Black;
      this.Label12.Border.LeftStyle = BorderLineStyle.None;
      this.Label12.Border.RightColor = Color.Black;
      this.Label12.Border.RightStyle = BorderLineStyle.None;
      this.Label12.Border.TopColor = Color.Black;
      this.Label12.Border.TopStyle = BorderLineStyle.None;
      this.Label12.Height = 0.2f;
      this.Label12.HyperLink = (string) null;
      this.Label12.Left = 0.05f;
      this.Label12.Name = "Label12";
      this.Label12.Style = "";
      this.Label12.Text = "TEL 2:";
      this.Label12.Top = 1.2f;
      this.Label12.Width = 0.5f;
      this.TextBox17.Border.BottomColor = Color.Black;
      this.TextBox17.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox17.Border.LeftColor = Color.Black;
      this.TextBox17.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox17.Border.RightColor = Color.Black;
      this.TextBox17.Border.RightStyle = BorderLineStyle.None;
      this.TextBox17.Border.TopColor = Color.Black;
      this.TextBox17.Border.TopStyle = BorderLineStyle.None;
      this.TextBox17.DataField = "CustomerCell";
      this.TextBox17.Height = 0.2f;
      this.TextBox17.Left = 0.55f;
      this.TextBox17.Name = "TextBox17";
      this.TextBox17.Style = "";
      this.TextBox17.Text = "Cell";
      this.TextBox17.Top = 1.4f;
      this.TextBox17.Width = 1.85f;
      this.Label13.Border.BottomColor = Color.Black;
      this.Label13.Border.BottomStyle = BorderLineStyle.None;
      this.Label13.Border.LeftColor = Color.Black;
      this.Label13.Border.LeftStyle = BorderLineStyle.None;
      this.Label13.Border.RightColor = Color.Black;
      this.Label13.Border.RightStyle = BorderLineStyle.None;
      this.Label13.Border.TopColor = Color.Black;
      this.Label13.Border.TopStyle = BorderLineStyle.None;
      this.Label13.Height = 0.2f;
      this.Label13.HyperLink = (string) null;
      this.Label13.Left = 0.05f;
      this.Label13.Name = "Label13";
      this.Label13.Style = "";
      this.Label13.Text = "CELL:";
      this.Label13.Top = 1.4f;
      this.Label13.Width = 0.5f;
      this.TextBox18.Border.BottomColor = Color.Black;
      this.TextBox18.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox18.Border.LeftColor = Color.Black;
      this.TextBox18.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox18.Border.RightColor = Color.Black;
      this.TextBox18.Border.RightStyle = BorderLineStyle.None;
      this.TextBox18.Border.TopColor = Color.Black;
      this.TextBox18.Border.TopStyle = BorderLineStyle.None;
      this.TextBox18.DataField = "CustomerFax";
      this.TextBox18.Height = 0.2f;
      this.TextBox18.Left = 0.55f;
      this.TextBox18.Name = "TextBox18";
      this.TextBox18.Style = "";
      this.TextBox18.Text = "Fax";
      this.TextBox18.Top = 1.6f;
      this.TextBox18.Width = 1.85f;
      this.Label14.Border.BottomColor = Color.Black;
      this.Label14.Border.BottomStyle = BorderLineStyle.None;
      this.Label14.Border.LeftColor = Color.Black;
      this.Label14.Border.LeftStyle = BorderLineStyle.None;
      this.Label14.Border.RightColor = Color.Black;
      this.Label14.Border.RightStyle = BorderLineStyle.None;
      this.Label14.Border.TopColor = Color.Black;
      this.Label14.Border.TopStyle = BorderLineStyle.None;
      this.Label14.Height = 0.2f;
      this.Label14.HyperLink = (string) null;
      this.Label14.Left = 0.05f;
      this.Label14.Name = "Label14";
      this.Label14.Style = "";
      this.Label14.Text = "FAX:";
      this.Label14.Top = 1.6f;
      this.Label14.Width = 0.5f;
      this.Line3.Border.BottomColor = Color.Black;
      this.Line3.Border.BottomStyle = BorderLineStyle.None;
      this.Line3.Border.LeftColor = Color.Black;
      this.Line3.Border.LeftStyle = BorderLineStyle.None;
      this.Line3.Border.RightColor = Color.Black;
      this.Line3.Border.RightStyle = BorderLineStyle.None;
      this.Line3.Border.TopColor = Color.Black;
      this.Line3.Border.TopStyle = BorderLineStyle.None;
      this.Line3.Height = 0.0f;
      this.Line3.Left = 0.0f;
      this.Line3.LineWeight = 1f;
      this.Line3.Name = "Line3";
      this.Line3.Top = 1.8f;
      this.Line3.Width = 7f;
      this.Line3.X1 = 0.0f;
      this.Line3.X2 = 7f;
      this.Line3.Y1 = 1.8f;
      this.Line3.Y2 = 1.8f;
      this.Line4.Border.BottomColor = Color.Black;
      this.Line4.Border.BottomStyle = BorderLineStyle.None;
      this.Line4.Border.LeftColor = Color.Black;
      this.Line4.Border.LeftStyle = BorderLineStyle.None;
      this.Line4.Border.RightColor = Color.Black;
      this.Line4.Border.RightStyle = BorderLineStyle.None;
      this.Line4.Border.TopColor = Color.Black;
      this.Line4.Border.TopStyle = BorderLineStyle.None;
      this.Line4.Height = 0.0f;
      this.Line4.Left = 0.0f;
      this.Line4.LineWeight = 1f;
      this.Line4.Name = "Line4";
      this.Line4.Top = 0.75f;
      this.Line4.Width = 7f;
      this.Line4.X1 = 0.0f;
      this.Line4.X2 = 7f;
      this.Line4.Y1 = 0.75f;
      this.Line4.Y2 = 0.75f;
      this.Line5.Border.BottomColor = Color.Black;
      this.Line5.Border.BottomStyle = BorderLineStyle.None;
      this.Line5.Border.LeftColor = Color.Black;
      this.Line5.Border.LeftStyle = BorderLineStyle.None;
      this.Line5.Border.RightColor = Color.Black;
      this.Line5.Border.RightStyle = BorderLineStyle.None;
      this.Line5.Border.TopColor = Color.Black;
      this.Line5.Border.TopStyle = BorderLineStyle.None;
      this.Line5.Height = 0.0f;
      this.Line5.Left = 2.4f;
      this.Line5.LineWeight = 1f;
      this.Line5.Name = "Line5";
      this.Line5.Top = 1.2f;
      this.Line5.Width = 4.6f;
      this.Line5.X1 = 2.4f;
      this.Line5.X2 = 7f;
      this.Line5.Y1 = 1.2f;
      this.Line5.Y2 = 1.2f;
      this.Line6.Border.BottomColor = Color.Black;
      this.Line6.Border.BottomStyle = BorderLineStyle.None;
      this.Line6.Border.LeftColor = Color.Black;
      this.Line6.Border.LeftStyle = BorderLineStyle.None;
      this.Line6.Border.RightColor = Color.Black;
      this.Line6.Border.RightStyle = BorderLineStyle.None;
      this.Line6.Border.TopColor = Color.Black;
      this.Line6.Border.TopStyle = BorderLineStyle.None;
      this.Line6.Height = 1.3f;
      this.Line6.Left = 2.4f;
      this.Line6.LineWeight = 1f;
      this.Line6.Name = "Line6";
      this.Line6.Top = 0.5f;
      this.Line6.Width = 0.0f;
      this.Line6.X1 = 2.4f;
      this.Line6.X2 = 2.4f;
      this.Line6.Y1 = 0.5f;
      this.Line6.Y2 = 1.8f;
      this.Line7.Border.BottomColor = Color.Black;
      this.Line7.Border.BottomStyle = BorderLineStyle.None;
      this.Line7.Border.LeftColor = Color.Black;
      this.Line7.Border.LeftStyle = BorderLineStyle.None;
      this.Line7.Border.RightColor = Color.Black;
      this.Line7.Border.RightStyle = BorderLineStyle.None;
      this.Line7.Border.TopColor = Color.Black;
      this.Line7.Border.TopStyle = BorderLineStyle.None;
      this.Line7.Height = 0.25f;
      this.Line7.Left = 5.4f;
      this.Line7.LineWeight = 1f;
      this.Line7.Name = "Line7";
      this.Line7.Top = 0.5f;
      this.Line7.Width = 0.0f;
      this.Line7.X1 = 5.4f;
      this.Line7.X2 = 5.4f;
      this.Line7.Y1 = 0.5f;
      this.Line7.Y2 = 0.75f;
      this.Shape4.BackColor = Color.FromArgb(220, 220, 220);
      this.Shape4.Border.BottomColor = Color.Black;
      this.Shape4.Border.BottomStyle = BorderLineStyle.None;
      this.Shape4.Border.LeftColor = Color.Black;
      this.Shape4.Border.LeftStyle = BorderLineStyle.None;
      this.Shape4.Border.RightColor = Color.Black;
      this.Shape4.Border.RightStyle = BorderLineStyle.None;
      this.Shape4.Border.TopColor = Color.Black;
      this.Shape4.Border.TopStyle = BorderLineStyle.None;
      this.Shape4.Height = 0.25f;
      this.Shape4.Left = 0.0f;
      this.Shape4.Name = "Shape4";
      this.Shape4.RoundingRadius = 9.999999f;
      this.Shape4.Top = 1.8f;
      this.Shape4.Width = 7f;
      this.Label15.Border.BottomColor = Color.Black;
      this.Label15.Border.BottomStyle = BorderLineStyle.None;
      this.Label15.Border.LeftColor = Color.Black;
      this.Label15.Border.LeftStyle = BorderLineStyle.None;
      this.Label15.Border.RightColor = Color.Black;
      this.Label15.Border.RightStyle = BorderLineStyle.None;
      this.Label15.Border.TopColor = Color.Black;
      this.Label15.Border.TopStyle = BorderLineStyle.None;
      this.Label15.Height = 0.2f;
      this.Label15.HyperLink = (string) null;
      this.Label15.Left = 0.05f;
      this.Label15.Name = "Label15";
      this.Label15.Style = "font-weight: bold; font-size: 8.25pt; ";
      this.Label15.Text = "JOB DESCRIPTION:";
      this.Label15.Top = 1.85f;
      this.Label15.Width = 1.85f;
      this.Label16.Border.BottomColor = Color.Black;
      this.Label16.Border.BottomStyle = BorderLineStyle.None;
      this.Label16.Border.LeftColor = Color.Black;
      this.Label16.Border.LeftStyle = BorderLineStyle.None;
      this.Label16.Border.RightColor = Color.Black;
      this.Label16.Border.RightStyle = BorderLineStyle.None;
      this.Label16.Border.TopColor = Color.Black;
      this.Label16.Border.TopStyle = BorderLineStyle.None;
      this.Label16.Height = 0.2f;
      this.Label16.HyperLink = (string) null;
      this.Label16.Left = 0.05f;
      this.Label16.Name = "Label16";
      this.Label16.Style = "";
      this.Label16.Text = "ADDRESS OF PROBLEM:";
      this.Label16.Top = 3.25f;
      this.Label16.Width = 1.7f;
      this.TextBox19.Border.BottomColor = Color.Black;
      this.TextBox19.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox19.Border.LeftColor = Color.Black;
      this.TextBox19.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox19.Border.RightColor = Color.Black;
      this.TextBox19.Border.RightStyle = BorderLineStyle.None;
      this.TextBox19.Border.TopColor = Color.Black;
      this.TextBox19.Border.TopStyle = BorderLineStyle.None;
      this.TextBox19.DataField = "JobAddress";
      this.TextBox19.Height = 0.4499999f;
      this.TextBox19.Left = 0.05f;
      this.TextBox19.Name = "TextBox19";
      this.TextBox19.Style = "font-size: 8.25pt; ";
      this.TextBox19.Text = "Residential Address";
      this.TextBox19.Top = 3.4f;
      this.TextBox19.Width = 2.3f;
      this.Line8.Border.BottomColor = Color.Black;
      this.Line8.Border.BottomStyle = BorderLineStyle.None;
      this.Line8.Border.LeftColor = Color.Black;
      this.Line8.Border.LeftStyle = BorderLineStyle.None;
      this.Line8.Border.RightColor = Color.Black;
      this.Line8.Border.RightStyle = BorderLineStyle.None;
      this.Line8.Border.TopColor = Color.Black;
      this.Line8.Border.TopStyle = BorderLineStyle.None;
      this.Line8.Height = 1.2f;
      this.Line8.Left = 3.4f;
      this.Line8.LineWeight = 1f;
      this.Line8.Name = "Line8";
      this.Line8.Top = 2.05f;
      this.Line8.Width = 0.0f;
      this.Line8.X1 = 3.4f;
      this.Line8.X2 = 3.4f;
      this.Line8.Y1 = 2.05f;
      this.Line8.Y2 = 3.25f;
      this.Line9.Border.BottomColor = Color.Black;
      this.Line9.Border.BottomStyle = BorderLineStyle.None;
      this.Line9.Border.LeftColor = Color.Black;
      this.Line9.Border.LeftStyle = BorderLineStyle.None;
      this.Line9.Border.RightColor = Color.Black;
      this.Line9.Border.RightStyle = BorderLineStyle.None;
      this.Line9.Border.TopColor = Color.Black;
      this.Line9.Border.TopStyle = BorderLineStyle.None;
      this.Line9.Height = 0.0f;
      this.Line9.Left = 0.0f;
      this.Line9.LineWeight = 1f;
      this.Line9.Name = "Line9";
      this.Line9.Top = 3.2f;
      this.Line9.Width = 7f;
      this.Line9.X1 = 0.0f;
      this.Line9.X2 = 7f;
      this.Line9.Y1 = 3.2f;
      this.Line9.Y2 = 3.2f;
      this.Label17.Border.BottomColor = Color.Black;
      this.Label17.Border.BottomStyle = BorderLineStyle.None;
      this.Label17.Border.LeftColor = Color.Black;
      this.Label17.Border.LeftStyle = BorderLineStyle.None;
      this.Label17.Border.RightColor = Color.Black;
      this.Label17.Border.RightStyle = BorderLineStyle.None;
      this.Label17.Border.TopColor = Color.Black;
      this.Label17.Border.TopStyle = BorderLineStyle.None;
      this.Label17.Height = 0.2f;
      this.Label17.HyperLink = (string) null;
      this.Label17.Left = 0.05f;
      this.Label17.Name = "Label17";
      this.Label17.Style = "";
      this.Label17.Text = "PROBLEM:";
      this.Label17.Top = 2.1f;
      this.Label17.Width = 1.7f;
      this.TextBox20.Border.BottomColor = Color.Black;
      this.TextBox20.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox20.Border.LeftColor = Color.Black;
      this.TextBox20.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox20.Border.RightColor = Color.Black;
      this.TextBox20.Border.RightStyle = BorderLineStyle.None;
      this.TextBox20.Border.TopColor = Color.Black;
      this.TextBox20.Border.TopStyle = BorderLineStyle.None;
      this.TextBox20.DataField = "JobProblem";
      this.TextBox20.Height = 0.95f;
      this.TextBox20.Left = 0.05f;
      this.TextBox20.Name = "TextBox20";
      this.TextBox20.Style = "font-size: 8.25pt; ";
      this.TextBox20.Text = "Problems";
      this.TextBox20.Top = 2.25f;
      this.TextBox20.Width = 3.3f;
      this.TextBox21.Border.BottomColor = Color.Black;
      this.TextBox21.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox21.Border.LeftColor = Color.Black;
      this.TextBox21.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox21.Border.RightColor = Color.Black;
      this.TextBox21.Border.RightStyle = BorderLineStyle.None;
      this.TextBox21.Border.TopColor = Color.Black;
      this.TextBox21.Border.TopStyle = BorderLineStyle.None;
      this.TextBox21.DataField = "JobFeedback";
      this.TextBox21.Height = 0.95f;
      this.TextBox21.Left = 3.45f;
      this.TextBox21.Name = "TextBox21";
      this.TextBox21.Style = "font-size: 8.25pt; ";
      this.TextBox21.Text = "Feedback";
      this.TextBox21.Top = 2.25f;
      this.TextBox21.Width = 3.5f;
      this.Label18.Border.BottomColor = Color.Black;
      this.Label18.Border.BottomStyle = BorderLineStyle.None;
      this.Label18.Border.LeftColor = Color.Black;
      this.Label18.Border.LeftStyle = BorderLineStyle.None;
      this.Label18.Border.RightColor = Color.Black;
      this.Label18.Border.RightStyle = BorderLineStyle.None;
      this.Label18.Border.TopColor = Color.Black;
      this.Label18.Border.TopStyle = BorderLineStyle.None;
      this.Label18.Height = 0.2f;
      this.Label18.HyperLink = (string) null;
      this.Label18.Left = 3.45f;
      this.Label18.Name = "Label18";
      this.Label18.Style = "";
      this.Label18.Text = "FEEDBACK:";
      this.Label18.Top = 2.1f;
      this.Label18.Width = 1.7f;
      this.Shape5.BackColor = Color.FromArgb(220, 220, 220);
      this.Shape5.Border.BottomColor = Color.Black;
      this.Shape5.Border.BottomStyle = BorderLineStyle.None;
      this.Shape5.Border.LeftColor = Color.Black;
      this.Shape5.Border.LeftStyle = BorderLineStyle.None;
      this.Shape5.Border.RightColor = Color.Black;
      this.Shape5.Border.RightStyle = BorderLineStyle.None;
      this.Shape5.Border.TopColor = Color.Black;
      this.Shape5.Border.TopStyle = BorderLineStyle.None;
      this.Shape5.Height = 0.25f;
      this.Shape5.Left = 2.4f;
      this.Shape5.Name = "Shape5";
      this.Shape5.RoundingRadius = 9.999999f;
      this.Shape5.Top = 3.2f;
      this.Shape5.Width = 4.6f;
      this.Label19.Border.BottomColor = Color.Black;
      this.Label19.Border.BottomStyle = BorderLineStyle.None;
      this.Label19.Border.LeftColor = Color.Black;
      this.Label19.Border.LeftStyle = BorderLineStyle.None;
      this.Label19.Border.RightColor = Color.Black;
      this.Label19.Border.RightStyle = BorderLineStyle.None;
      this.Label19.Border.TopColor = Color.Black;
      this.Label19.Border.TopStyle = BorderLineStyle.None;
      this.Label19.Height = 0.2000002f;
      this.Label19.HyperLink = (string) null;
      this.Label19.Left = 2.45f;
      this.Label19.Name = "Label19";
      this.Label19.Style = "font-weight: bold; font-size: 8.25pt; ";
      this.Label19.Text = "THIS PROPERTY IS RENTED OUT BY THE FOLLOWING TENANT:";
      this.Label19.Top = 3.25f;
      this.Label19.Width = 4.5f;
      this.Label20.Border.BottomColor = Color.Black;
      this.Label20.Border.BottomStyle = BorderLineStyle.None;
      this.Label20.Border.LeftColor = Color.Black;
      this.Label20.Border.LeftStyle = BorderLineStyle.None;
      this.Label20.Border.RightColor = Color.Black;
      this.Label20.Border.RightStyle = BorderLineStyle.None;
      this.Label20.Border.TopColor = Color.Black;
      this.Label20.Border.TopStyle = BorderLineStyle.None;
      this.Label20.Height = 0.2f;
      this.Label20.HyperLink = (string) null;
      this.Label20.Left = 2.45f;
      this.Label20.Name = "Label20";
      this.Label20.Style = "";
      this.Label20.Text = "NAME:";
      this.Label20.Top = 3.45f;
      this.Label20.Width = 0.45f;
      this.TextBox22.Border.BottomColor = Color.Black;
      this.TextBox22.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox22.Border.LeftColor = Color.Black;
      this.TextBox22.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox22.Border.RightColor = Color.Black;
      this.TextBox22.Border.RightStyle = BorderLineStyle.None;
      this.TextBox22.Border.TopColor = Color.Black;
      this.TextBox22.Border.TopStyle = BorderLineStyle.None;
      this.TextBox22.DataField = "TenantName";
      this.TextBox22.Height = 0.2f;
      this.TextBox22.Left = 2.95f;
      this.TextBox22.Name = "TextBox22";
      this.TextBox22.Style = "";
      this.TextBox22.Text = "CustomerName";
      this.TextBox22.Top = 3.45f;
      this.TextBox22.Width = 2.3f;
      this.Line10.Border.BottomColor = Color.Black;
      this.Line10.Border.BottomStyle = BorderLineStyle.None;
      this.Line10.Border.LeftColor = Color.Black;
      this.Line10.Border.LeftStyle = BorderLineStyle.None;
      this.Line10.Border.RightColor = Color.Black;
      this.Line10.Border.RightStyle = BorderLineStyle.None;
      this.Line10.Border.TopColor = Color.Black;
      this.Line10.Border.TopStyle = BorderLineStyle.None;
      this.Line10.Height = 0.6499999f;
      this.Line10.Left = 2.4f;
      this.Line10.LineWeight = 1f;
      this.Line10.Name = "Line10";
      this.Line10.Top = 3.2f;
      this.Line10.Width = 0.0f;
      this.Line10.X1 = 2.4f;
      this.Line10.X2 = 2.4f;
      this.Line10.Y1 = 3.2f;
      this.Line10.Y2 = 3.85f;
      this.Label21.Border.BottomColor = Color.Black;
      this.Label21.Border.BottomStyle = BorderLineStyle.None;
      this.Label21.Border.LeftColor = Color.Black;
      this.Label21.Border.LeftStyle = BorderLineStyle.None;
      this.Label21.Border.RightColor = Color.Black;
      this.Label21.Border.RightStyle = BorderLineStyle.None;
      this.Label21.Border.TopColor = Color.Black;
      this.Label21.Border.TopStyle = BorderLineStyle.None;
      this.Label21.Height = 0.2f;
      this.Label21.HyperLink = (string) null;
      this.Label21.Left = 5.45f;
      this.Label21.Name = "Label21";
      this.Label21.Style = "";
      this.Label21.Text = "ID NR:";
      this.Label21.Top = 3.45f;
      this.Label21.Width = 0.45f;
      this.TextBox23.Border.BottomColor = Color.Black;
      this.TextBox23.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox23.Border.LeftColor = Color.Black;
      this.TextBox23.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox23.Border.RightColor = Color.Black;
      this.TextBox23.Border.RightStyle = BorderLineStyle.None;
      this.TextBox23.Border.TopColor = Color.Black;
      this.TextBox23.Border.TopStyle = BorderLineStyle.None;
      this.TextBox23.DataField = "TenantID";
      this.TextBox23.Height = 0.2f;
      this.TextBox23.Left = 5.95f;
      this.TextBox23.Name = "TextBox23";
      this.TextBox23.Style = "";
      this.TextBox23.Text = "9999999999999";
      this.TextBox23.Top = 3.45f;
      this.TextBox23.Width = 1f;
      this.Label22.Border.BottomColor = Color.Black;
      this.Label22.Border.BottomStyle = BorderLineStyle.None;
      this.Label22.Border.LeftColor = Color.Black;
      this.Label22.Border.LeftStyle = BorderLineStyle.None;
      this.Label22.Border.RightColor = Color.Black;
      this.Label22.Border.RightStyle = BorderLineStyle.None;
      this.Label22.Border.TopColor = Color.Black;
      this.Label22.Border.TopStyle = BorderLineStyle.None;
      this.Label22.Height = 0.2f;
      this.Label22.HyperLink = (string) null;
      this.Label22.Left = 2.45f;
      this.Label22.Name = "Label22";
      this.Label22.Style = "";
      this.Label22.Text = "TEL:";
      this.Label22.Top = 3.65f;
      this.Label22.Width = 0.5f;
      this.TextBox24.Border.BottomColor = Color.Black;
      this.TextBox24.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox24.Border.LeftColor = Color.Black;
      this.TextBox24.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox24.Border.RightColor = Color.Black;
      this.TextBox24.Border.RightStyle = BorderLineStyle.None;
      this.TextBox24.Border.TopColor = Color.Black;
      this.TextBox24.Border.TopStyle = BorderLineStyle.None;
      this.TextBox24.DataField = "TenantTel";
      this.TextBox24.Height = 0.1999999f;
      this.TextBox24.Left = 2.95f;
      this.TextBox24.Name = "TextBox24";
      this.TextBox24.Style = "";
      this.TextBox24.Text = "0000000000";
      this.TextBox24.Top = 3.65f;
      this.TextBox24.Width = 2.3f;
      this.Label24.Border.BottomColor = Color.Black;
      this.Label24.Border.BottomStyle = BorderLineStyle.None;
      this.Label24.Border.LeftColor = Color.Black;
      this.Label24.Border.LeftStyle = BorderLineStyle.None;
      this.Label24.Border.RightColor = Color.Black;
      this.Label24.Border.RightStyle = BorderLineStyle.None;
      this.Label24.Border.TopColor = Color.Black;
      this.Label24.Border.TopStyle = BorderLineStyle.None;
      this.Label24.Height = 0.2f;
      this.Label24.HyperLink = (string) null;
      this.Label24.Left = 5.45f;
      this.Label24.Name = "Label24";
      this.Label24.Style = "";
      this.Label24.Text = "CELL:";
      this.Label24.Top = 3.65f;
      this.Label24.Width = 0.5f;
      this.TextBox26.Border.BottomColor = Color.Black;
      this.TextBox26.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox26.Border.LeftColor = Color.Black;
      this.TextBox26.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox26.Border.RightColor = Color.Black;
      this.TextBox26.Border.RightStyle = BorderLineStyle.None;
      this.TextBox26.Border.TopColor = Color.Black;
      this.TextBox26.Border.TopStyle = BorderLineStyle.None;
      this.TextBox26.DataField = "TenantCell";
      this.TextBox26.Height = 0.1999999f;
      this.TextBox26.Left = 5.95f;
      this.TextBox26.Name = "TextBox26";
      this.TextBox26.Style = "";
      this.TextBox26.Text = (string) null;
      this.TextBox26.Top = 3.65f;
      this.TextBox26.Width = 1f;
      this.Line11.Border.BottomColor = Color.Black;
      this.Line11.Border.BottomStyle = BorderLineStyle.None;
      this.Line11.Border.LeftColor = Color.Black;
      this.Line11.Border.LeftStyle = BorderLineStyle.None;
      this.Line11.Border.RightColor = Color.Black;
      this.Line11.Border.RightStyle = BorderLineStyle.None;
      this.Line11.Border.TopColor = Color.Black;
      this.Line11.Border.TopStyle = BorderLineStyle.None;
      this.Line11.Height = 0.0f;
      this.Line11.Left = 0.0f;
      this.Line11.LineWeight = 1f;
      this.Line11.Name = "Line11";
      this.Line11.Top = 3.85f;
      this.Line11.Width = 7f;
      this.Line11.X1 = 0.0f;
      this.Line11.X2 = 7f;
      this.Line11.Y1 = 3.85f;
      this.Line11.Y2 = 3.85f;
      this.Label23.Border.BottomColor = Color.Black;
      this.Label23.Border.BottomStyle = BorderLineStyle.None;
      this.Label23.Border.LeftColor = Color.Black;
      this.Label23.Border.LeftStyle = BorderLineStyle.None;
      this.Label23.Border.RightColor = Color.Black;
      this.Label23.Border.RightStyle = BorderLineStyle.None;
      this.Label23.Border.TopColor = Color.Black;
      this.Label23.Border.TopStyle = BorderLineStyle.None;
      this.Label23.Height = 0.2f;
      this.Label23.HyperLink = (string) null;
      this.Label23.Left = 0.05f;
      this.Label23.Name = "Label23";
      this.Label23.Style = "font-weight: bold; font-size: 8.25pt; ";
      this.Label23.Text = "TIMESHEET:";
      this.Label23.Top = 3.9f;
      this.Label23.Width = 1.85f;
      this.Label25.Border.BottomColor = Color.Black;
      this.Label25.Border.BottomStyle = BorderLineStyle.None;
      this.Label25.Border.LeftColor = Color.Black;
      this.Label25.Border.LeftStyle = BorderLineStyle.None;
      this.Label25.Border.RightColor = Color.Black;
      this.Label25.Border.RightStyle = BorderLineStyle.None;
      this.Label25.Border.TopColor = Color.Black;
      this.Label25.Border.TopStyle = BorderLineStyle.None;
      this.Label25.Height = 0.1500001f;
      this.Label25.HyperLink = (string) null;
      this.Label25.Left = 0.05f;
      this.Label25.Name = "Label25";
      this.Label25.Style = "font-size: 8.25pt; ";
      this.Label25.Text = "START TIME:";
      this.Label25.Top = 4.1f;
      this.Label25.Width = 0.8f;
      this.Label26.Border.BottomColor = Color.Black;
      this.Label26.Border.BottomStyle = BorderLineStyle.None;
      this.Label26.Border.LeftColor = Color.Black;
      this.Label26.Border.LeftStyle = BorderLineStyle.None;
      this.Label26.Border.RightColor = Color.Black;
      this.Label26.Border.RightStyle = BorderLineStyle.None;
      this.Label26.Border.TopColor = Color.Black;
      this.Label26.Border.TopStyle = BorderLineStyle.None;
      this.Label26.Height = 0.1500001f;
      this.Label26.HyperLink = (string) null;
      this.Label26.Left = 1.35f;
      this.Label26.Name = "Label26";
      this.Label26.Style = "font-size: 8.25pt; ";
      this.Label26.Text = "END TIME:";
      this.Label26.Top = 4.1f;
      this.Label26.Width = 0.6499999f;
      this.Label27.Border.BottomColor = Color.Black;
      this.Label27.Border.BottomStyle = BorderLineStyle.None;
      this.Label27.Border.LeftColor = Color.Black;
      this.Label27.Border.LeftStyle = BorderLineStyle.None;
      this.Label27.Border.RightColor = Color.Black;
      this.Label27.Border.RightStyle = BorderLineStyle.None;
      this.Label27.Border.TopColor = Color.Black;
      this.Label27.Border.TopStyle = BorderLineStyle.None;
      this.Label27.Height = 0.1500001f;
      this.Label27.HyperLink = (string) null;
      this.Label27.Left = 2.45f;
      this.Label27.Name = "Label27";
      this.Label27.Style = "font-size: 8.25pt; ";
      this.Label27.Text = "TOTAL HOURS:";
      this.Label27.Top = 4.1f;
      this.Label27.Width = 0.95f;
      this.Line13.Border.BottomColor = Color.Black;
      this.Line13.Border.BottomStyle = BorderLineStyle.None;
      this.Line13.Border.LeftColor = Color.Black;
      this.Line13.Border.LeftStyle = BorderLineStyle.None;
      this.Line13.Border.RightColor = Color.Black;
      this.Line13.Border.RightStyle = BorderLineStyle.None;
      this.Line13.Border.TopColor = Color.Black;
      this.Line13.Border.TopStyle = BorderLineStyle.None;
      this.Line13.Height = 0.7000003f;
      this.Line13.Left = 1.2f;
      this.Line13.LineWeight = 1f;
      this.Line13.Name = "Line13";
      this.Line13.Top = 4.1f;
      this.Line13.Width = 0.0f;
      this.Line13.X1 = 1.2f;
      this.Line13.X2 = 1.2f;
      this.Line13.Y1 = 4.1f;
      this.Line13.Y2 = 4.8f;
      this.Line14.Border.BottomColor = Color.Black;
      this.Line14.Border.BottomStyle = BorderLineStyle.None;
      this.Line14.Border.LeftColor = Color.Black;
      this.Line14.Border.LeftStyle = BorderLineStyle.None;
      this.Line14.Border.RightColor = Color.Black;
      this.Line14.Border.RightStyle = BorderLineStyle.None;
      this.Line14.Border.TopColor = Color.Black;
      this.Line14.Border.TopStyle = BorderLineStyle.None;
      this.Line14.Height = 0.7000003f;
      this.Line14.Left = 2.4f;
      this.Line14.LineWeight = 1f;
      this.Line14.Name = "Line14";
      this.Line14.Top = 4.1f;
      this.Line14.Width = 0.0f;
      this.Line14.X1 = 2.4f;
      this.Line14.X2 = 2.4f;
      this.Line14.Y1 = 4.1f;
      this.Line14.Y2 = 4.8f;
      this.Label28.Border.BottomColor = Color.Black;
      this.Label28.Border.BottomStyle = BorderLineStyle.None;
      this.Label28.Border.LeftColor = Color.Black;
      this.Label28.Border.LeftStyle = BorderLineStyle.None;
      this.Label28.Border.RightColor = Color.Black;
      this.Label28.Border.RightStyle = BorderLineStyle.None;
      this.Label28.Border.TopColor = Color.Black;
      this.Label28.Border.TopStyle = BorderLineStyle.None;
      this.Label28.Height = 0.2f;
      this.Label28.HyperLink = (string) null;
      this.Label28.Left = 3.45f;
      this.Label28.Name = "Label28";
      this.Label28.Style = "font-weight: bold; font-size: 8.25pt; ";
      this.Label28.Text = "TRAVEL:";
      this.Label28.Top = 3.9f;
      this.Label28.Width = 1.85f;
      this.Label29.Border.BottomColor = Color.Black;
      this.Label29.Border.BottomStyle = BorderLineStyle.None;
      this.Label29.Border.LeftColor = Color.Black;
      this.Label29.Border.LeftStyle = BorderLineStyle.None;
      this.Label29.Border.RightColor = Color.Black;
      this.Label29.Border.RightStyle = BorderLineStyle.None;
      this.Label29.Border.TopColor = Color.Black;
      this.Label29.Border.TopStyle = BorderLineStyle.None;
      this.Label29.Height = 0.1500001f;
      this.Label29.HyperLink = (string) null;
      this.Label29.Left = 3.45f;
      this.Label29.Name = "Label29";
      this.Label29.Style = "font-size: 8.25pt; ";
      this.Label29.Text = "DATE:";
      this.Label29.Top = 4.1f;
      this.Label29.Width = 0.8f;
      this.Label30.Border.BottomColor = Color.Black;
      this.Label30.Border.BottomStyle = BorderLineStyle.None;
      this.Label30.Border.LeftColor = Color.Black;
      this.Label30.Border.LeftStyle = BorderLineStyle.None;
      this.Label30.Border.RightColor = Color.Black;
      this.Label30.Border.RightStyle = BorderLineStyle.None;
      this.Label30.Border.TopColor = Color.Black;
      this.Label30.Border.TopStyle = BorderLineStyle.None;
      this.Label30.Height = 0.1500001f;
      this.Label30.HyperLink = (string) null;
      this.Label30.Left = 4.3f;
      this.Label30.Name = "Label30";
      this.Label30.Style = "font-size: 8.25pt; ";
      this.Label30.Text = "START KM";
      this.Label30.Top = 4.1f;
      this.Label30.Width = 0.6499999f;
      this.Label31.Border.BottomColor = Color.Black;
      this.Label31.Border.BottomStyle = BorderLineStyle.None;
      this.Label31.Border.LeftColor = Color.Black;
      this.Label31.Border.LeftStyle = BorderLineStyle.None;
      this.Label31.Border.RightColor = Color.Black;
      this.Label31.Border.RightStyle = BorderLineStyle.None;
      this.Label31.Border.TopColor = Color.Black;
      this.Label31.Border.TopStyle = BorderLineStyle.None;
      this.Label31.Height = 0.1500001f;
      this.Label31.HyperLink = (string) null;
      this.Label31.Left = 5.15f;
      this.Label31.Name = "Label31";
      this.Label31.Style = "font-size: 8.25pt; ";
      this.Label31.Text = "END KM:";
      this.Label31.Top = 4.1f;
      this.Label31.Width = 0.6499999f;
      this.Line16.Border.BottomColor = Color.Black;
      this.Line16.Border.BottomStyle = BorderLineStyle.None;
      this.Line16.Border.LeftColor = Color.Black;
      this.Line16.Border.LeftStyle = BorderLineStyle.None;
      this.Line16.Border.RightColor = Color.Black;
      this.Line16.Border.RightStyle = BorderLineStyle.None;
      this.Line16.Border.TopColor = Color.Black;
      this.Line16.Border.TopStyle = BorderLineStyle.None;
      this.Line16.Height = 0.7000003f;
      this.Line16.Left = 4.25f;
      this.Line16.LineWeight = 1f;
      this.Line16.Name = "Line16";
      this.Line16.Top = 4.1f;
      this.Line16.Width = 0.0f;
      this.Line16.X1 = 4.25f;
      this.Line16.X2 = 4.25f;
      this.Line16.Y1 = 4.1f;
      this.Line16.Y2 = 4.8f;
      this.Line17.Border.BottomColor = Color.Black;
      this.Line17.Border.BottomStyle = BorderLineStyle.None;
      this.Line17.Border.LeftColor = Color.Black;
      this.Line17.Border.LeftStyle = BorderLineStyle.None;
      this.Line17.Border.RightColor = Color.Black;
      this.Line17.Border.RightStyle = BorderLineStyle.None;
      this.Line17.Border.TopColor = Color.Black;
      this.Line17.Border.TopStyle = BorderLineStyle.None;
      this.Line17.Height = 0.7000003f;
      this.Line17.Left = 5.1f;
      this.Line17.LineWeight = 1f;
      this.Line17.Name = "Line17";
      this.Line17.Top = 4.1f;
      this.Line17.Width = 0.0f;
      this.Line17.X1 = 5.1f;
      this.Line17.X2 = 5.1f;
      this.Line17.Y1 = 4.1f;
      this.Line17.Y2 = 4.8f;
      this.Line12.Border.BottomColor = Color.Black;
      this.Line12.Border.BottomStyle = BorderLineStyle.None;
      this.Line12.Border.LeftColor = Color.Black;
      this.Line12.Border.LeftStyle = BorderLineStyle.None;
      this.Line12.Border.RightColor = Color.Black;
      this.Line12.Border.RightStyle = BorderLineStyle.None;
      this.Line12.Border.TopColor = Color.Black;
      this.Line12.Border.TopStyle = BorderLineStyle.None;
      this.Line12.Height = 0.7000003f;
      this.Line12.Left = 5.95f;
      this.Line12.LineWeight = 1f;
      this.Line12.Name = "Line12";
      this.Line12.Top = 4.1f;
      this.Line12.Width = 0.0f;
      this.Line12.X1 = 5.95f;
      this.Line12.X2 = 5.95f;
      this.Line12.Y1 = 4.1f;
      this.Line12.Y2 = 4.8f;
      this.Label32.Border.BottomColor = Color.Black;
      this.Label32.Border.BottomStyle = BorderLineStyle.None;
      this.Label32.Border.LeftColor = Color.Black;
      this.Label32.Border.LeftStyle = BorderLineStyle.None;
      this.Label32.Border.RightColor = Color.Black;
      this.Label32.Border.RightStyle = BorderLineStyle.None;
      this.Label32.Border.TopColor = Color.Black;
      this.Label32.Border.TopStyle = BorderLineStyle.None;
      this.Label32.Height = 0.1500001f;
      this.Label32.HyperLink = (string) null;
      this.Label32.Left = 6f;
      this.Label32.Name = "Label32";
      this.Label32.Style = "font-size: 8.25pt; ";
      this.Label32.Text = "VEHICLE REG #:";
      this.Label32.Top = 4.1f;
      this.Label32.Width = 1f;
      this.TextBox25.Border.BottomColor = Color.Black;
      this.TextBox25.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox25.Border.LeftColor = Color.Black;
      this.TextBox25.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox25.Border.RightColor = Color.Black;
      this.TextBox25.Border.RightStyle = BorderLineStyle.None;
      this.TextBox25.Border.TopColor = Color.Black;
      this.TextBox25.Border.TopStyle = BorderLineStyle.None;
      this.TextBox25.DataField = "TimeStart";
      this.TextBox25.Height = 0.5499999f;
      this.TextBox25.Left = 0.05f;
      this.TextBox25.Name = "TextBox25";
      this.TextBox25.Style = "font-size: 8.25pt; ";
      this.TextBox25.Text = (string) null;
      this.TextBox25.Top = 4.25f;
      this.TextBox25.Width = 1f;
      this.TextBox27.Border.BottomColor = Color.Black;
      this.TextBox27.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox27.Border.LeftColor = Color.Black;
      this.TextBox27.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox27.Border.RightColor = Color.Black;
      this.TextBox27.Border.RightStyle = BorderLineStyle.None;
      this.TextBox27.Border.TopColor = Color.Black;
      this.TextBox27.Border.TopStyle = BorderLineStyle.None;
      this.TextBox27.DataField = "TimeEnd";
      this.TextBox27.Height = 0.5499999f;
      this.TextBox27.Left = 1.35f;
      this.TextBox27.Name = "TextBox27";
      this.TextBox27.Style = "font-size: 8.25pt; ";
      this.TextBox27.Text = (string) null;
      this.TextBox27.Top = 4.25f;
      this.TextBox27.Width = 1f;
      this.TextBox28.Border.BottomColor = Color.Black;
      this.TextBox28.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox28.Border.LeftColor = Color.Black;
      this.TextBox28.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox28.Border.RightColor = Color.Black;
      this.TextBox28.Border.RightStyle = BorderLineStyle.None;
      this.TextBox28.Border.TopColor = Color.Black;
      this.TextBox28.Border.TopStyle = BorderLineStyle.None;
      this.TextBox28.DataField = "TimeTotal";
      this.TextBox28.Height = 0.5499999f;
      this.TextBox28.Left = 2.45f;
      this.TextBox28.Name = "TextBox28";
      this.TextBox28.Style = "font-size: 8.25pt; ";
      this.TextBox28.Text = (string) null;
      this.TextBox28.Top = 4.25f;
      this.TextBox28.Width = 0.9f;
      this.TextBox29.Border.BottomColor = Color.Black;
      this.TextBox29.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox29.Border.LeftColor = Color.Black;
      this.TextBox29.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox29.Border.RightColor = Color.Black;
      this.TextBox29.Border.RightStyle = BorderLineStyle.None;
      this.TextBox29.Border.TopColor = Color.Black;
      this.TextBox29.Border.TopStyle = BorderLineStyle.None;
      this.TextBox29.DataField = "TravelDate";
      this.TextBox29.Height = 0.5499999f;
      this.TextBox29.Left = 3.45f;
      this.TextBox29.Name = "TextBox29";
      this.TextBox29.Style = "font-size: 8.25pt; ";
      this.TextBox29.Text = (string) null;
      this.TextBox29.Top = 4.25f;
      this.TextBox29.Width = 0.75f;
      this.TextBox30.Border.BottomColor = Color.Black;
      this.TextBox30.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox30.Border.LeftColor = Color.Black;
      this.TextBox30.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox30.Border.RightColor = Color.Black;
      this.TextBox30.Border.RightStyle = BorderLineStyle.None;
      this.TextBox30.Border.TopColor = Color.Black;
      this.TextBox30.Border.TopStyle = BorderLineStyle.None;
      this.TextBox30.DataField = "TravelStartKM";
      this.TextBox30.Height = 0.5499999f;
      this.TextBox30.Left = 4.3f;
      this.TextBox30.Name = "TextBox30";
      this.TextBox30.Style = "font-size: 8.25pt; ";
      this.TextBox30.Text = (string) null;
      this.TextBox30.Top = 4.25f;
      this.TextBox30.Width = 0.8f;
      this.TextBox31.Border.BottomColor = Color.Black;
      this.TextBox31.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox31.Border.LeftColor = Color.Black;
      this.TextBox31.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox31.Border.RightColor = Color.Black;
      this.TextBox31.Border.RightStyle = BorderLineStyle.None;
      this.TextBox31.Border.TopColor = Color.Black;
      this.TextBox31.Border.TopStyle = BorderLineStyle.None;
      this.TextBox31.DataField = "TravelEndKM";
      this.TextBox31.Height = 0.5499999f;
      this.TextBox31.Left = 5.15f;
      this.TextBox31.Name = "TextBox31";
      this.TextBox31.Style = "font-size: 8.25pt; ";
      this.TextBox31.Text = (string) null;
      this.TextBox31.Top = 4.25f;
      this.TextBox31.Width = 0.8f;
      this.TextBox32.Border.BottomColor = Color.Black;
      this.TextBox32.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox32.Border.LeftColor = Color.Black;
      this.TextBox32.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox32.Border.RightColor = Color.Black;
      this.TextBox32.Border.RightStyle = BorderLineStyle.None;
      this.TextBox32.Border.TopColor = Color.Black;
      this.TextBox32.Border.TopStyle = BorderLineStyle.None;
      this.TextBox32.DataField = "TravelVehicleRegNr";
      this.TextBox32.Height = 0.5499999f;
      this.TextBox32.Left = 6f;
      this.TextBox32.Name = "TextBox32";
      this.TextBox32.Style = "font-size: 8.25pt; ";
      this.TextBox32.Text = (string) null;
      this.TextBox32.Top = 4.25f;
      this.TextBox32.Width = 1f;
      this.Line15.Border.BottomColor = Color.Black;
      this.Line15.Border.BottomStyle = BorderLineStyle.None;
      this.Line15.Border.LeftColor = Color.Black;
      this.Line15.Border.LeftStyle = BorderLineStyle.None;
      this.Line15.Border.RightColor = Color.Black;
      this.Line15.Border.RightStyle = BorderLineStyle.None;
      this.Line15.Border.TopColor = Color.Black;
      this.Line15.Border.TopStyle = BorderLineStyle.None;
      this.Line15.Height = 0.0f;
      this.Line15.Left = 0.0f;
      this.Line15.LineWeight = 1f;
      this.Line15.Name = "Line15";
      this.Line15.Top = 4.8f;
      this.Line15.Width = 7f;
      this.Line15.X1 = 0.0f;
      this.Line15.X2 = 7f;
      this.Line15.Y1 = 4.8f;
      this.Line15.Y2 = 4.8f;
      this.Label33.Border.BottomColor = Color.Black;
      this.Label33.Border.BottomStyle = BorderLineStyle.None;
      this.Label33.Border.LeftColor = Color.Black;
      this.Label33.Border.LeftStyle = BorderLineStyle.None;
      this.Label33.Border.RightColor = Color.Black;
      this.Label33.Border.RightStyle = BorderLineStyle.None;
      this.Label33.Border.TopColor = Color.Black;
      this.Label33.Border.TopStyle = BorderLineStyle.None;
      this.Label33.Height = 0.2000002f;
      this.Label33.HyperLink = (string) null;
      this.Label33.Left = 0.05f;
      this.Label33.Name = "Label33";
      this.Label33.Style = "";
      this.Label33.Text = "QUOTED AMOUNT:";
      this.Label33.Top = 4.85f;
      this.Label33.Width = 1.25f;
      this.TextBox33.Border.BottomColor = Color.Black;
      this.TextBox33.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox33.Border.LeftColor = Color.Black;
      this.TextBox33.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox33.Border.RightColor = Color.Black;
      this.TextBox33.Border.RightStyle = BorderLineStyle.None;
      this.TextBox33.Border.TopColor = Color.Black;
      this.TextBox33.Border.TopStyle = BorderLineStyle.None;
      this.TextBox33.DataField = "JobQuoteAmount";
      this.TextBox33.Height = 0.2f;
      this.TextBox33.Left = 1.35f;
      this.TextBox33.Name = "TextBox33";
      this.TextBox33.Style = "";
      this.TextBox33.Text = "quote";
      this.TextBox33.Top = 4.85f;
      this.TextBox33.Width = 1.05f;
      this.Label34.Border.BottomColor = Color.Black;
      this.Label34.Border.BottomStyle = BorderLineStyle.None;
      this.Label34.Border.LeftColor = Color.Black;
      this.Label34.Border.LeftStyle = BorderLineStyle.None;
      this.Label34.Border.RightColor = Color.Black;
      this.Label34.Border.RightStyle = BorderLineStyle.None;
      this.Label34.Border.TopColor = Color.Black;
      this.Label34.Border.TopStyle = BorderLineStyle.None;
      this.Label34.Height = 0.2000002f;
      this.Label34.HyperLink = (string) null;
      this.Label34.Left = 3.45f;
      this.Label34.Name = "Label34";
      this.Label34.Style = "";
      this.Label34.Text = "GATE FEE:";
      this.Label34.Top = 4.85f;
      this.Label34.Width = 0.75f;
      this.TextBox34.Border.BottomColor = Color.Black;
      this.TextBox34.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox34.Border.LeftColor = Color.Black;
      this.TextBox34.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox34.Border.RightColor = Color.Black;
      this.TextBox34.Border.RightStyle = BorderLineStyle.None;
      this.TextBox34.Border.TopColor = Color.Black;
      this.TextBox34.Border.TopStyle = BorderLineStyle.None;
      this.TextBox34.DataField = "GateFee";
      this.TextBox34.Height = 0.2000002f;
      this.TextBox34.Left = 4.2f;
      this.TextBox34.Name = "TextBox34";
      this.TextBox34.Style = "";
      this.TextBox34.Text = "GateFee";
      this.TextBox34.Top = 4.85f;
      this.TextBox34.Width = 0.8f;
      this.TextBox35.Border.BottomColor = Color.Black;
      this.TextBox35.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox35.Border.LeftColor = Color.Black;
      this.TextBox35.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox35.Border.RightColor = Color.Black;
      this.TextBox35.Border.RightStyle = BorderLineStyle.None;
      this.TextBox35.Border.TopColor = Color.Black;
      this.TextBox35.Border.TopStyle = BorderLineStyle.None;
      this.TextBox35.DataField = "GateFeeQty";
      this.TextBox35.Height = 0.2000002f;
      this.TextBox35.Left = 5.800001f;
      this.TextBox35.Name = "TextBox35";
      this.TextBox35.Style = "";
      this.TextBox35.Text = "qty";
      this.TextBox35.Top = 4.85f;
      this.TextBox35.Width = 0.8f;
      this.Label35.Border.BottomColor = Color.Black;
      this.Label35.Border.BottomStyle = BorderLineStyle.None;
      this.Label35.Border.LeftColor = Color.Black;
      this.Label35.Border.LeftStyle = BorderLineStyle.None;
      this.Label35.Border.RightColor = Color.Black;
      this.Label35.Border.RightStyle = BorderLineStyle.None;
      this.Label35.Border.TopColor = Color.Black;
      this.Label35.Border.TopStyle = BorderLineStyle.None;
      this.Label35.Height = 0.2000002f;
      this.Label35.HyperLink = (string) null;
      this.Label35.Left = 5.05f;
      this.Label35.Name = "Label35";
      this.Label35.Style = "";
      this.Label35.Text = "QUANTITY:";
      this.Label35.Top = 4.85f;
      this.Label35.Width = 0.75f;
      this.Line18.Border.BottomColor = Color.Black;
      this.Line18.Border.BottomStyle = BorderLineStyle.None;
      this.Line18.Border.LeftColor = Color.Black;
      this.Line18.Border.LeftStyle = BorderLineStyle.None;
      this.Line18.Border.RightColor = Color.Black;
      this.Line18.Border.RightStyle = BorderLineStyle.None;
      this.Line18.Border.TopColor = Color.Black;
      this.Line18.Border.TopStyle = BorderLineStyle.None;
      this.Line18.Height = 1.2f;
      this.Line18.Left = 3.4f;
      this.Line18.LineWeight = 1f;
      this.Line18.Name = "Line18";
      this.Line18.Top = 3.85f;
      this.Line18.Width = 0.0f;
      this.Line18.X1 = 3.4f;
      this.Line18.X2 = 3.4f;
      this.Line18.Y1 = 3.85f;
      this.Line18.Y2 = 5.05f;
      this.Line19.Border.BottomColor = Color.Black;
      this.Line19.Border.BottomStyle = BorderLineStyle.None;
      this.Line19.Border.LeftColor = Color.Black;
      this.Line19.Border.LeftStyle = BorderLineStyle.None;
      this.Line19.Border.RightColor = Color.Black;
      this.Line19.Border.RightStyle = BorderLineStyle.None;
      this.Line19.Border.TopColor = Color.Black;
      this.Line19.Border.TopStyle = BorderLineStyle.None;
      this.Line19.Height = 0.0f;
      this.Line19.Left = 0.0f;
      this.Line19.LineWeight = 1f;
      this.Line19.Name = "Line19";
      this.Line19.Top = 5.05f;
      this.Line19.Width = 7f;
      this.Line19.X1 = 0.0f;
      this.Line19.X2 = 7f;
      this.Line19.Y1 = 5.05f;
      this.Line19.Y2 = 5.05f;
      this.Label36.Border.BottomColor = Color.Black;
      this.Label36.Border.BottomStyle = BorderLineStyle.None;
      this.Label36.Border.LeftColor = Color.Black;
      this.Label36.Border.LeftStyle = BorderLineStyle.None;
      this.Label36.Border.RightColor = Color.Black;
      this.Label36.Border.RightStyle = BorderLineStyle.None;
      this.Label36.Border.TopColor = Color.Black;
      this.Label36.Border.TopStyle = BorderLineStyle.None;
      this.Label36.Height = 0.2000002f;
      this.Label36.HyperLink = (string) null;
      this.Label36.Left = 0.05f;
      this.Label36.Name = "Label36";
      this.Label36.Style = "";
      this.Label36.Text = "INVOICE NUMBER:";
      this.Label36.Top = 5.1f;
      this.Label36.Width = 1.25f;
      this.TextBox36.Border.BottomColor = Color.Black;
      this.TextBox36.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox36.Border.LeftColor = Color.Black;
      this.TextBox36.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox36.Border.RightColor = Color.Black;
      this.TextBox36.Border.RightStyle = BorderLineStyle.None;
      this.TextBox36.Border.TopColor = Color.Black;
      this.TextBox36.Border.TopStyle = BorderLineStyle.None;
      this.TextBox36.DataField = "InvoiceNr";
      this.TextBox36.Height = 0.2000002f;
      this.TextBox36.Left = 1.35f;
      this.TextBox36.Name = "TextBox36";
      this.TextBox36.Style = "";
      this.TextBox36.Text = "AccountNr";
      this.TextBox36.Top = 5.1f;
      this.TextBox36.Width = 1.3f;
      this.Label37.Border.BottomColor = Color.Black;
      this.Label37.Border.BottomStyle = BorderLineStyle.None;
      this.Label37.Border.LeftColor = Color.Black;
      this.Label37.Border.LeftStyle = BorderLineStyle.None;
      this.Label37.Border.RightColor = Color.Black;
      this.Label37.Border.RightStyle = BorderLineStyle.None;
      this.Label37.Border.TopColor = Color.Black;
      this.Label37.Border.TopStyle = BorderLineStyle.None;
      this.Label37.Height = 0.2000002f;
      this.Label37.HyperLink = (string) null;
      this.Label37.Left = 2.8f;
      this.Label37.Name = "Label37";
      this.Label37.Style = "";
      this.Label37.Text = "PAYMENT METHOD:";
      this.Label37.Top = 5.1f;
      this.Label37.Width = 1.25f;
      this.TextBox37.Border.BottomColor = Color.Black;
      this.TextBox37.Border.BottomStyle = BorderLineStyle.None;
      this.TextBox37.Border.LeftColor = Color.Black;
      this.TextBox37.Border.LeftStyle = BorderLineStyle.None;
      this.TextBox37.Border.RightColor = Color.Black;
      this.TextBox37.Border.RightStyle = BorderLineStyle.None;
      this.TextBox37.Border.TopColor = Color.Black;
      this.TextBox37.Border.TopStyle = BorderLineStyle.None;
      this.TextBox37.DataField = "PaymentMethod";
      this.TextBox37.Height = 0.2f;
      this.TextBox37.Left = 4.1f;
      this.TextBox37.Name = "TextBox37";
      this.TextBox37.Style = "";
      this.TextBox37.Text = "Pay method";
      this.TextBox37.Top = 5.1f;
      this.TextBox37.Width = 1.05f;
      this.Line20.Border.BottomColor = Color.Black;
      this.Line20.Border.BottomStyle = BorderLineStyle.None;
      this.Line20.Border.LeftColor = Color.Black;
      this.Line20.Border.LeftStyle = BorderLineStyle.None;
      this.Line20.Border.RightColor = Color.Black;
      this.Line20.Border.RightStyle = BorderLineStyle.None;
      this.Line20.Border.TopColor = Color.Black;
      this.Line20.Border.TopStyle = BorderLineStyle.None;
      this.Line20.Height = 0.0f;
      this.Line20.Left = 0.0f;
      this.Line20.LineWeight = 1f;
      this.Line20.Name = "Line20";
      this.Line20.Top = 5.3f;
      this.Line20.Width = 7f;
      this.Line20.X1 = 0.0f;
      this.Line20.X2 = 7f;
      this.Line20.Y1 = 5.3f;
      this.Line20.Y2 = 5.3f;
      this.Label38.Border.BottomColor = Color.Black;
      this.Label38.Border.BottomStyle = BorderLineStyle.None;
      this.Label38.Border.LeftColor = Color.Black;
      this.Label38.Border.LeftStyle = BorderLineStyle.None;
      this.Label38.Border.RightColor = Color.Black;
      this.Label38.Border.RightStyle = BorderLineStyle.None;
      this.Label38.Border.TopColor = Color.Black;
      this.Label38.Border.TopStyle = BorderLineStyle.None;
      this.Label38.Height = 0.4499999f;
      this.Label38.HyperLink = (string) null;
      this.Label38.Left = 0.05f;
      this.Label38.Name = "Label38";
      this.Label38.Style = "font-size: 8.25pt; ";
      this.Label38.Text = componentResourceManager.GetString("Label38.Text");
      this.Label38.Top = 6.4f;
      this.Label38.Width = 6.9f;
      this.Label39.Border.BottomColor = Color.Black;
      this.Label39.Border.BottomStyle = BorderLineStyle.None;
      this.Label39.Border.LeftColor = Color.Black;
      this.Label39.Border.LeftStyle = BorderLineStyle.None;
      this.Label39.Border.RightColor = Color.Black;
      this.Label39.Border.RightStyle = BorderLineStyle.None;
      this.Label39.Border.TopColor = Color.Black;
      this.Label39.Border.TopStyle = BorderLineStyle.None;
      this.Label39.Height = 0.2000002f;
      this.Label39.HyperLink = (string) null;
      this.Label39.Left = 0.05f;
      this.Label39.Name = "Label39";
      this.Label39.Style = "";
      this.Label39.Text = "Signature:";
      this.Label39.Top = 7f;
      this.Label39.Width = 0.7f;
      this.Line21.Border.BottomColor = Color.Black;
      this.Line21.Border.BottomStyle = BorderLineStyle.None;
      this.Line21.Border.LeftColor = Color.Black;
      this.Line21.Border.LeftStyle = BorderLineStyle.None;
      this.Line21.Border.RightColor = Color.Black;
      this.Line21.Border.RightStyle = BorderLineStyle.None;
      this.Line21.Border.TopColor = Color.Black;
      this.Line21.Border.TopStyle = BorderLineStyle.None;
      this.Line21.Height = 0.0f;
      this.Line21.Left = 0.75f;
      this.Line21.LineStyle = LineStyle.Dot;
      this.Line21.LineWeight = 1f;
      this.Line21.Name = "Line21";
      this.Line21.Top = 7.15f;
      this.Line21.Width = 2.65f;
      this.Line21.X1 = 0.75f;
      this.Line21.X2 = 3.4f;
      this.Line21.Y1 = 7.15f;
      this.Line21.Y2 = 7.15f;
      this.Line22.Border.BottomColor = Color.Black;
      this.Line22.Border.BottomStyle = BorderLineStyle.None;
      this.Line22.Border.LeftColor = Color.Black;
      this.Line22.Border.LeftStyle = BorderLineStyle.None;
      this.Line22.Border.RightColor = Color.Black;
      this.Line22.Border.RightStyle = BorderLineStyle.None;
      this.Line22.Border.TopColor = Color.Black;
      this.Line22.Border.TopStyle = BorderLineStyle.None;
      this.Line22.Height = 0.0f;
      this.Line22.Left = 3.95f;
      this.Line22.LineStyle = LineStyle.Dot;
      this.Line22.LineWeight = 1f;
      this.Line22.Name = "Line22";
      this.Line22.Top = 7.15f;
      this.Line22.Width = 2.65f;
      this.Line22.X1 = 3.95f;
      this.Line22.X2 = 6.6f;
      this.Line22.Y1 = 7.15f;
      this.Line22.Y2 = 7.15f;
      this.Label40.Border.BottomColor = Color.Black;
      this.Label40.Border.BottomStyle = BorderLineStyle.None;
      this.Label40.Border.LeftColor = Color.Black;
      this.Label40.Border.LeftStyle = BorderLineStyle.None;
      this.Label40.Border.RightColor = Color.Black;
      this.Label40.Border.RightStyle = BorderLineStyle.None;
      this.Label40.Border.TopColor = Color.Black;
      this.Label40.Border.TopStyle = BorderLineStyle.None;
      this.Label40.Height = 0.2000002f;
      this.Label40.HyperLink = (string) null;
      this.Label40.Left = 3.5f;
      this.Label40.Name = "Label40";
      this.Label40.Style = "";
      this.Label40.Text = "Date:";
      this.Label40.Top = 7f;
      this.Label40.Width = 0.4000002f;
      this.Label41.Border.BottomColor = Color.Black;
      this.Label41.Border.BottomStyle = BorderLineStyle.None;
      this.Label41.Border.LeftColor = Color.Black;
      this.Label41.Border.LeftStyle = BorderLineStyle.None;
      this.Label41.Border.RightColor = Color.Black;
      this.Label41.Border.RightStyle = BorderLineStyle.None;
      this.Label41.Border.TopColor = Color.Black;
      this.Label41.Border.TopStyle = BorderLineStyle.None;
      this.Label41.Height = 0.2f;
      this.Label41.HyperLink = (string) null;
      this.Label41.Left = 4.05f;
      this.Label41.Name = "Label41";
      this.Label41.Style = "color: LightGrey; ";
      this.Label41.Text = "DD  /    MM    /  YYCC";
      this.Label41.Top = 6.95f;
      this.Label41.Width = 1.65f;
      this.Line23.Border.BottomColor = Color.Black;
      this.Line23.Border.BottomStyle = BorderLineStyle.None;
      this.Line23.Border.LeftColor = Color.Black;
      this.Line23.Border.LeftStyle = BorderLineStyle.None;
      this.Line23.Border.RightColor = Color.Black;
      this.Line23.Border.RightStyle = BorderLineStyle.None;
      this.Line23.Border.TopColor = Color.Black;
      this.Line23.Border.TopStyle = BorderLineStyle.None;
      this.Line23.Height = 0.0f;
      this.Line23.Left = 0.0f;
      this.Line23.LineWeight = 1f;
      this.Line23.Name = "Line23";
      this.Line23.Top = 6.35f;
      this.Line23.Width = 7f;
      this.Line23.X1 = 0.0f;
      this.Line23.X2 = 7f;
      this.Line23.Y1 = 6.35f;
      this.Line23.Y2 = 6.35f;
      this.Label42.Border.BottomColor = Color.Black;
      this.Label42.Border.BottomStyle = BorderLineStyle.None;
      this.Label42.Border.LeftColor = Color.Black;
      this.Label42.Border.LeftStyle = BorderLineStyle.None;
      this.Label42.Border.RightColor = Color.Black;
      this.Label42.Border.RightStyle = BorderLineStyle.None;
      this.Label42.Border.TopColor = Color.Black;
      this.Label42.Border.TopStyle = BorderLineStyle.None;
      this.Label42.Height = 0.2000002f;
      this.Label42.HyperLink = (string) null;
      this.Label42.Left = 0.05f;
      this.Label42.Name = "Label42";
      this.Label42.Style = "";
      this.Label42.Text = "NOTES:";
      this.Label42.Top = 5.350001f;
      this.Label42.Width = 1.25f;
      this.txtNotes.Border.BottomColor = Color.Black;
      this.txtNotes.Border.BottomStyle = BorderLineStyle.None;
      this.txtNotes.Border.LeftColor = Color.Black;
      this.txtNotes.Border.LeftStyle = BorderLineStyle.None;
      this.txtNotes.Border.RightColor = Color.Black;
      this.txtNotes.Border.RightStyle = BorderLineStyle.None;
      this.txtNotes.Border.TopColor = Color.Black;
      this.txtNotes.Border.TopStyle = BorderLineStyle.None;
      this.txtNotes.DataField = "Notes";
      this.txtNotes.Height = 0.8f;
      this.txtNotes.Left = 0.05f;
      this.txtNotes.Name = "txtNotes";
      this.txtNotes.Style = "";
      this.txtNotes.Text = "TextBox38";
      this.txtNotes.Top = 5.5f;
      this.txtNotes.Width = 6.9f;
      this.pJobID.DefaultValue = "";
      this.pJobID.Key = "pJobID";
      this.pJobID.Prompt = "";
      this.pJobID.PromptUser = false;
      this.pJobID.QueryCreated = false;
      this.pJobID.Tag = (object) null;
      this.pJobID.Type = Parameter.DataType.String;
      this.MasterReport = false;
      this.PageSettings.Margins.Bottom = 0.5f;
      this.PageSettings.Margins.Left = 0.75f;
      this.PageSettings.Margins.Right = 0.4f;
      this.PageSettings.Margins.Top = 0.5f;
      this.PageSettings.PaperHeight = 11f;
      this.PageSettings.PaperWidth = 8.5f;
      this.Parameters.Add(this.pJobID);
      this.PrintWidth = 7.010417f;
      this.Sections.Add((Section) this.PageHeader1);
      this.Sections.Add((Section) this.Detail1);
      this.Sections.Add((Section) this.PageFooter1);
      this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; color: Black; ddo-char-set: 204; font-size: 9pt; ", "Normal"));
      this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
      this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
      this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
      ((ISupportInitialize) this.imgLogo).EndInit();
      this.TextBox2.EndInit();
      this.Label2.EndInit();
      this.TextBox1.EndInit();
      this.TextBox3.EndInit();
      this.TextBox4.EndInit();
      this.TextBox5.EndInit();
      this.TextBox6.EndInit();
      this.lblCompleted.EndInit();
      this.Label1.EndInit();
      this.TextBox8.EndInit();
      this.TextBox9.EndInit();
      this.Label3.EndInit();
      this.Label4.EndInit();
      this.Label5.EndInit();
      this.TextBox10.EndInit();
      this.TextBox11.EndInit();
      this.Label6.EndInit();
      this.Label7.EndInit();
      this.TextBox12.EndInit();
      this.Label8.EndInit();
      this.TextBox13.EndInit();
      this.Label9.EndInit();
      this.TextBox7.EndInit();
      this.TextBox14.EndInit();
      this.Label10.EndInit();
      this.Label11.EndInit();
      this.TextBox15.EndInit();
      this.TextBox16.EndInit();
      this.Label12.EndInit();
      this.TextBox17.EndInit();
      this.Label13.EndInit();
      this.TextBox18.EndInit();
      this.Label14.EndInit();
      this.Label15.EndInit();
      this.Label16.EndInit();
      this.TextBox19.EndInit();
      this.Label17.EndInit();
      this.TextBox20.EndInit();
      this.TextBox21.EndInit();
      this.Label18.EndInit();
      this.Label19.EndInit();
      this.Label20.EndInit();
      this.TextBox22.EndInit();
      this.Label21.EndInit();
      this.TextBox23.EndInit();
      this.Label22.EndInit();
      this.TextBox24.EndInit();
      this.Label24.EndInit();
      this.TextBox26.EndInit();
      this.Label23.EndInit();
      this.Label25.EndInit();
      this.Label26.EndInit();
      this.Label27.EndInit();
      this.Label28.EndInit();
      this.Label29.EndInit();
      this.Label30.EndInit();
      this.Label31.EndInit();
      this.Label32.EndInit();
      this.TextBox25.EndInit();
      this.TextBox27.EndInit();
      this.TextBox28.EndInit();
      this.TextBox29.EndInit();
      this.TextBox30.EndInit();
      this.TextBox31.EndInit();
      this.TextBox32.EndInit();
      this.Label33.EndInit();
      this.TextBox33.EndInit();
      this.Label34.EndInit();
      this.TextBox34.EndInit();
      this.TextBox35.EndInit();
      this.Label35.EndInit();
      this.Label36.EndInit();
      this.TextBox36.EndInit();
      this.Label37.EndInit();
      this.TextBox37.EndInit();
      this.Label38.EndInit();
      this.Label39.EndInit();
      this.Label40.EndInit();
      this.Label41.EndInit();
      this.Label42.EndInit();
      this.txtNotes.EndInit();
      this.EndInit();
    }

    internal virtual Detail Detail1
    {
      [DebuggerNonUserCode] get
      {
        return this._Detail1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Detail1 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label lblCompleted
    {
      [DebuggerNonUserCode] get
      {
        return this._lblCompleted;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblCompleted = value;
      }
    }

    internal virtual Shape Shape6
    {
      [DebuggerNonUserCode] get
      {
        return this._Shape6;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Shape6 = value;
      }
    }

    internal virtual Shape Shape2
    {
      [DebuggerNonUserCode] get
      {
        return this._Shape2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Shape2 = value;
      }
    }

    internal virtual Shape Shape3
    {
      [DebuggerNonUserCode] get
      {
        return this._Shape3;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Shape3 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label1
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

    internal virtual DataDynamics.ActiveReports.TextBox TextBox8
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox8;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox8 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.TextBox TextBox9
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox9;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox9 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label3
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

    internal virtual Line Line1
    {
      [DebuggerNonUserCode] get
      {
        return this._Line1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Line1 = value;
      }
    }

    internal virtual Line Line2
    {
      [DebuggerNonUserCode] get
      {
        return this._Line2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Line2 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label4
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

    internal virtual DataDynamics.ActiveReports.Label Label5
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

    internal virtual DataDynamics.ActiveReports.TextBox TextBox10
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox10;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox10 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.TextBox TextBox11
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox11;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox11 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label6
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

    internal virtual DataDynamics.ActiveReports.Label Label7
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

    internal virtual DataDynamics.ActiveReports.TextBox TextBox12
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox12;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox12 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label8
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

    internal virtual DataDynamics.ActiveReports.TextBox TextBox13
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox13;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox13 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label9
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

    internal virtual DataDynamics.ActiveReports.TextBox TextBox7
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox7;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox7 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.TextBox TextBox14
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox14;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox14 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label10
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

    internal virtual DataDynamics.ActiveReports.Label Label11
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

    internal virtual DataDynamics.ActiveReports.TextBox TextBox15
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox15;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox15 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.TextBox TextBox16
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox16;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox16 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label12
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

    internal virtual DataDynamics.ActiveReports.TextBox TextBox17
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox17;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox17 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label13
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

    internal virtual DataDynamics.ActiveReports.TextBox TextBox18
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox18;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox18 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label14
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

    internal virtual Line Line3
    {
      [DebuggerNonUserCode] get
      {
        return this._Line3;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Line3 = value;
      }
    }

    internal virtual Line Line4
    {
      [DebuggerNonUserCode] get
      {
        return this._Line4;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Line4 = value;
      }
    }

    internal virtual Line Line5
    {
      [DebuggerNonUserCode] get
      {
        return this._Line5;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Line5 = value;
      }
    }

    internal virtual Line Line6
    {
      [DebuggerNonUserCode] get
      {
        return this._Line6;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Line6 = value;
      }
    }

    internal virtual Line Line7
    {
      [DebuggerNonUserCode] get
      {
        return this._Line7;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Line7 = value;
      }
    }

    internal virtual Shape Shape4
    {
      [DebuggerNonUserCode] get
      {
        return this._Shape4;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Shape4 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label15
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

    internal virtual DataDynamics.ActiveReports.Label Label16
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

    internal virtual DataDynamics.ActiveReports.TextBox TextBox19
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox19;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox19 = value;
      }
    }

    internal virtual Line Line8
    {
      [DebuggerNonUserCode] get
      {
        return this._Line8;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Line8 = value;
      }
    }

    internal virtual Line Line9
    {
      [DebuggerNonUserCode] get
      {
        return this._Line9;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Line9 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label17
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

    internal virtual DataDynamics.ActiveReports.TextBox TextBox20
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox20;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox20 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.TextBox TextBox21
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox21;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox21 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label18
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

    internal virtual Shape Shape5
    {
      [DebuggerNonUserCode] get
      {
        return this._Shape5;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Shape5 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label19
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

    internal virtual DataDynamics.ActiveReports.Label Label20
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

    internal virtual DataDynamics.ActiveReports.TextBox TextBox22
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox22;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox22 = value;
      }
    }

    internal virtual Line Line10
    {
      [DebuggerNonUserCode] get
      {
        return this._Line10;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Line10 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label21
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

    internal virtual DataDynamics.ActiveReports.TextBox TextBox23
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox23;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox23 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label22
    {
      [DebuggerNonUserCode] get
      {
        return this._Label22;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label22 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.TextBox TextBox24
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox24;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox24 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label24
    {
      [DebuggerNonUserCode] get
      {
        return this._Label24;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label24 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.TextBox TextBox26
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox26;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox26 = value;
      }
    }

    internal virtual Line Line11
    {
      [DebuggerNonUserCode] get
      {
        return this._Line11;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Line11 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label23
    {
      [DebuggerNonUserCode] get
      {
        return this._Label23;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label23 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label25
    {
      [DebuggerNonUserCode] get
      {
        return this._Label25;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label25 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label26
    {
      [DebuggerNonUserCode] get
      {
        return this._Label26;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label26 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label27
    {
      [DebuggerNonUserCode] get
      {
        return this._Label27;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label27 = value;
      }
    }

    internal virtual Line Line13
    {
      [DebuggerNonUserCode] get
      {
        return this._Line13;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Line13 = value;
      }
    }

    internal virtual Line Line14
    {
      [DebuggerNonUserCode] get
      {
        return this._Line14;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Line14 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label28
    {
      [DebuggerNonUserCode] get
      {
        return this._Label28;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label28 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label29
    {
      [DebuggerNonUserCode] get
      {
        return this._Label29;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label29 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label30
    {
      [DebuggerNonUserCode] get
      {
        return this._Label30;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label30 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label31
    {
      [DebuggerNonUserCode] get
      {
        return this._Label31;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label31 = value;
      }
    }

    internal virtual Line Line16
    {
      [DebuggerNonUserCode] get
      {
        return this._Line16;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Line16 = value;
      }
    }

    internal virtual Line Line17
    {
      [DebuggerNonUserCode] get
      {
        return this._Line17;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Line17 = value;
      }
    }

    internal virtual Line Line12
    {
      [DebuggerNonUserCode] get
      {
        return this._Line12;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Line12 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label32
    {
      [DebuggerNonUserCode] get
      {
        return this._Label32;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label32 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.TextBox TextBox25
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox25;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox25 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.TextBox TextBox27
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox27;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox27 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.TextBox TextBox28
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox28;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox28 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.TextBox TextBox29
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox29;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox29 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.TextBox TextBox30
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox30;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox30 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.TextBox TextBox31
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox31;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox31 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.TextBox TextBox32
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox32;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox32 = value;
      }
    }

    internal virtual Line Line15
    {
      [DebuggerNonUserCode] get
      {
        return this._Line15;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Line15 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label33
    {
      [DebuggerNonUserCode] get
      {
        return this._Label33;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label33 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.TextBox TextBox33
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox33;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox33 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label34
    {
      [DebuggerNonUserCode] get
      {
        return this._Label34;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label34 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.TextBox TextBox34
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox34;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox34 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.TextBox TextBox35
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox35;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox35 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label35
    {
      [DebuggerNonUserCode] get
      {
        return this._Label35;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label35 = value;
      }
    }

    internal virtual Line Line18
    {
      [DebuggerNonUserCode] get
      {
        return this._Line18;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Line18 = value;
      }
    }

    internal virtual Line Line19
    {
      [DebuggerNonUserCode] get
      {
        return this._Line19;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Line19 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label36
    {
      [DebuggerNonUserCode] get
      {
        return this._Label36;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label36 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.TextBox TextBox36
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox36;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox36 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label37
    {
      [DebuggerNonUserCode] get
      {
        return this._Label37;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label37 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.TextBox TextBox37
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox37;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox37 = value;
      }
    }

    internal virtual Line Line20
    {
      [DebuggerNonUserCode] get
      {
        return this._Line20;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Line20 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label38
    {
      [DebuggerNonUserCode] get
      {
        return this._Label38;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label38 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label39
    {
      [DebuggerNonUserCode] get
      {
        return this._Label39;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label39 = value;
      }
    }

    internal virtual Line Line21
    {
      [DebuggerNonUserCode] get
      {
        return this._Line21;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Line21 = value;
      }
    }

    internal virtual Line Line22
    {
      [DebuggerNonUserCode] get
      {
        return this._Line22;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Line22 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label40
    {
      [DebuggerNonUserCode] get
      {
        return this._Label40;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label40 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label41
    {
      [DebuggerNonUserCode] get
      {
        return this._Label41;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label41 = value;
      }
    }

    internal virtual Line Line23
    {
      [DebuggerNonUserCode] get
      {
        return this._Line23;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Line23 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label42
    {
      [DebuggerNonUserCode] get
      {
        return this._Label42;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label42 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.TextBox txtNotes
    {
      [DebuggerNonUserCode] get
      {
        return this._txtNotes;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtNotes = value;
      }
    }

    internal virtual PageHeader PageHeader1
    {
      [DebuggerNonUserCode] get
      {
        return this._PageHeader1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._PageHeader1 = value;
      }
    }

    internal virtual Shape Shape1
    {
      [DebuggerNonUserCode] get
      {
        return this._Shape1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Shape1 = value;
      }
    }

    internal virtual Picture imgLogo
    {
      [DebuggerNonUserCode] get
      {
        return this._imgLogo;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._imgLogo = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.TextBox TextBox2
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox2 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.Label Label2
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

    internal virtual DataDynamics.ActiveReports.TextBox TextBox1
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox1 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.TextBox TextBox3
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox3;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox3 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.TextBox TextBox4
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox4;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox4 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.TextBox TextBox5
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox5;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox5 = value;
      }
    }

    internal virtual DataDynamics.ActiveReports.TextBox TextBox6
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox6;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox6 = value;
      }
    }

    internal virtual PageFooter PageFooter1
    {
      [DebuggerNonUserCode] get
      {
        return this._PageFooter1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._PageFooter1 = value;
      }
    }

    internal virtual Parameter pJobID
    {
      [DebuggerNonUserCode] get
      {
        return this._pJobID;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._pJobID = value;
      }
    }

    private void rptJobCard_DataInitialize(object sender, EventArgs e)
    {
      this.Fields.Add("Completed");
      this.Fields.Add("Logo");
      this.Fields.Add("CompanyName");
      this.Fields.Add("TradingAs");
      this.Fields.Add("RegNr");
      this.Fields.Add("VatNr");
      this.Fields.Add("Contact");
      this.Fields.Add("JobNr");
      this.Fields.Add("Date");
      this.Fields.Add("Team");
      this.Fields.Add("CustomerAccount");
      this.Fields.Add("CustomerName");
      this.Fields.Add("CustomerID");
      this.Fields.Add("CustomerEmail");
      this.Fields.Add("CustomerTel1");
      this.Fields.Add("CustomerTel2");
      this.Fields.Add("CustomerCell");
      this.Fields.Add("CustomerFax");
      this.Fields.Add("CustomerResidential");
      this.Fields.Add("CustomerPOBox");
      this.Fields.Add("CustomerRegNr");
      this.Fields.Add("CustomerVAT");
      this.Fields.Add("CustomerManager");
      this.Fields.Add("CustomerDirector1");
      this.Fields.Add("CustomerDirector2");
      this.Fields.Add("CustomerDirector3");
      this.Fields.Add("CustomerDirector4");
      this.Fields.Add("CustomerDirectorID1");
      this.Fields.Add("CustomerDirectorID2");
      this.Fields.Add("CustomerDirectorID3");
      this.Fields.Add("CustomerDirectorID4");
      this.Fields.Add("JobProblem");
      this.Fields.Add("JobFeedback");
      this.Fields.Add("JobAddress");
      this.Fields.Add("TenantName");
      this.Fields.Add("TenantID");
      this.Fields.Add("TenantTel");
      this.Fields.Add("TenantCell");
      this.Fields.Add("TimeStart");
      this.Fields.Add("TimeEnd");
      this.Fields.Add("TimeTotal");
      this.Fields.Add("TravelDate");
      this.Fields.Add("TravelStartKM");
      this.Fields.Add("TravelEndKM");
      this.Fields.Add("TravelVehicleRegNr");
      this.Fields.Add("JobQuoteAmount");
      this.Fields.Add("GateFee");
      this.Fields.Add("GateFeeQty");
      this.Fields.Add("InvoiceNr");
      this.Fields.Add("PaymentMethod");
      this.Fields.Add("Notes");
      this.Fields.Add("TandC");
    }

    private void rptJobCard_FetchData(object sender, ActiveReport3.FetchEventArgs eArgs)
    {
      Reytec.JobCard.DAL.JobCard dboJob = this.dboJob;
      dboJob.GetOne((object) this._JobID);
      if (Operators.ConditionalCompareObjectEqual(dboJob.JobCompleted, (object) true, false))
        this.Fields["Completed"].Value = (object) "COMPLETED";
      else
        this.Fields["Completed"].Value = (object) "";
      this._CustomerID = Conversions.ToInteger(dboJob.CustomerID);
      this.Fields["JobNr"].Value = RuntimeHelpers.GetObjectValue(dboJob.JobNr);
      this.Fields["Date"].Value = (object) Strings.Format(RuntimeHelpers.GetObjectValue(dboJob.JobDate), "dd/MM/yyyy");
      this.Fields["Team"].Value = RuntimeHelpers.GetObjectValue(dboJob.JobTeam);
      this.Fields["JobProblem"].Value = (object) dboJob.GetProblemsAsString();
      this.Fields["JobFeedback"].Value = (object) dboJob.GetFeedbackAsString();
      this.Fields["JobAddress"].Value = (object) DALGeneral.StripReturns(Conversions.ToString(dboJob.ProblemAddress));
      this.Fields["TenantName"].Value = RuntimeHelpers.GetObjectValue(dboJob.JobTenantName);
      this.Fields["TenantID"].Value = RuntimeHelpers.GetObjectValue(dboJob.JobTenantID);
      if (Operators.ConditionalCompareObjectNotEqual(dboJob.JobTenantTel2, (object) "", false))
        this.Fields["TenantTel"].Value = Operators.ConcatenateObject(Operators.ConcatenateObject(dboJob.JobTenantTel1, (object) " / "), dboJob.JobTenantTel2);
      else
        this.Fields["TenantTel"].Value = RuntimeHelpers.GetObjectValue(dboJob.JobTenantTel1);
      this.Fields["TenantCell"].Value = RuntimeHelpers.GetObjectValue(dboJob.JobTenantCell);
      this.Fields["TimeStart"].Value = (object) dboJob.GetStartTimeAsString();
      this.Fields["TimeEnd"].Value = (object) dboJob.GetEndTimeAsString();
      this.Fields["TimeTotal"].Value = (object) dboJob.GetTotalHoursAsString();
      this.Fields["TravelDate"].Value = (object) dboJob.GetKMDateAsString();
      this.Fields["TravelStartKM"].Value = (object) dboJob.GetKMStartAsString();
      this.Fields["TravelEndKM"].Value = (object) dboJob.GetKMEndAsString();
      this.Fields["TravelVehicleRegNr"].Value = (object) dboJob.GetKMVehicleRegNrAsString();
      this.Fields["JobQuoteAmount"].Value = Operators.ConcatenateObject((object) "R ", dboJob.QuotedAmount);
      this.Fields["GateFee"].Value = Operators.ConcatenateObject((object) "R ", dboJob.JobGateFee);
      this.Fields["GateFeeQty"].Value = RuntimeHelpers.GetObjectValue(dboJob.JobGateFeeQty);
      this.Fields["InvoiceNr"].Value = RuntimeHelpers.GetObjectValue(dboJob.JobInvoiceNr);
      this.Fields["PaymentMethod"].Value = (object) dboJob.PaymentMethod();
      this.Fields["Notes"].Value = RuntimeHelpers.GetObjectValue(dboJob.JobNote);
      this.Fields["TandC"].Value = (object) "";
      JobCardCompany dboCompany = this.dboCompany;
      dboCompany.GetInfo();
      this.Fields["Logo"].Value = (object) dboCompany.LogoFromField((TableField) dboCompany.Logo);
      this.Fields["CompanyName"].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Strings), "UCase", new object[1]
      {
        Operators.ConcatenateObject(Operators.ConcatenateObject(dboCompany.CompanyName, (object) " - "), dboCompany.BranchName)
      }, (string[]) null, (System.Type[]) null, (bool[]) null));
      Field field = this.Fields["TradingAs"];
      System.Type Type = typeof (Strings);
      object[] objArray1 = new object[1];
      object[] objArray2 = objArray1;
      JobCardCompany jobCardCompany = dboCompany;
      object objectValue = RuntimeHelpers.GetObjectValue(jobCardCompany.TradingAs);
      objArray2[0] = objectValue;
      object[] objArray3 = objArray1;
      object[] Arguments = objArray3;
      bool[] flagArray = new bool[1]{ true };
      bool[] CopyBack = flagArray;
      object Right = NewLateBinding.LateGet((object) null, Type, "UCase", Arguments, (string[]) null, (System.Type[]) null, CopyBack);
      if (flagArray[0])
        jobCardCompany.TradingAs = RuntimeHelpers.GetObjectValue(objArray3[0]);
      object obj = Operators.ConcatenateObject((object) "t/a ", Right);
      field.Value = obj;
      this.Fields["RegNr"].Value = Operators.ConcatenateObject((object) "CC. REG NR.: ", dboCompany.RegistrationNr);
      this.Fields["VatNr"].Value = Operators.ConcatenateObject((object) "VAT REG NR.: ", dboCompany.VATNr);
      this.Fields["Contact"].Value = (object) dboCompany.ConcatContact();
      Customer dboCustomer = this.dboCustomer;
      dboCustomer.GetOne((object) this._CustomerID);
      this.Fields["CustomerAccount"].Value = RuntimeHelpers.GetObjectValue(dboCustomer.AccountNumber);
      this.Fields["CustomerName"].Value = RuntimeHelpers.GetObjectValue(dboCustomer.Name);
      this.Fields["CustomerID"].Value = RuntimeHelpers.GetObjectValue(dboCustomer.PrivateIDNumber);
      this.Fields["CustomerEmail"].Value = RuntimeHelpers.GetObjectValue(dboCustomer.CustomerEmail);
      this.Fields["CustomerTel1"].Value = RuntimeHelpers.GetObjectValue(dboCustomer.Tel1);
      this.Fields["CustomerTel2"].Value = RuntimeHelpers.GetObjectValue(dboCustomer.Tel2);
      this.Fields["CustomerCell"].Value = RuntimeHelpers.GetObjectValue(dboCustomer.Cell);
      this.Fields["CustomerFax"].Value = RuntimeHelpers.GetObjectValue(dboCustomer.Fax);
      this.Fields["CustomerResidential"].Value = (object) DALGeneral.StripReturns(Conversions.ToString(dboCustomer.ResidentialAddress));
      this.Fields["CustomerPOBox"].Value = (object) DALGeneral.StripReturns(Conversions.ToString(dboCustomer.PostalAddress));
      this.Fields["CustomerRegNr"].Value = RuntimeHelpers.GetObjectValue(dboCustomer.RegistrationNr);
      this.Fields["CustomerVAT"].Value = RuntimeHelpers.GetObjectValue(dboCustomer.VATNr);
      this.Fields["CustomerManager"].Value = RuntimeHelpers.GetObjectValue(dboCustomer.ManagerName);
      this.Fields["CustomerDirector1"].Value = RuntimeHelpers.GetObjectValue(dboCustomer.Director1Name);
      this.Fields["CustomerDirector2"].Value = RuntimeHelpers.GetObjectValue(dboCustomer.Director2Name);
      this.Fields["CustomerDirector3"].Value = RuntimeHelpers.GetObjectValue(dboCustomer.Director3Name);
      this.Fields["CustomerDirector4"].Value = RuntimeHelpers.GetObjectValue(dboCustomer.Director4Name);
      this.Fields["CustomerDirectorID1"].Value = RuntimeHelpers.GetObjectValue(dboCustomer.Director1ID);
      this.Fields["CustomerDirectorID2"].Value = RuntimeHelpers.GetObjectValue(dboCustomer.Director2ID);
      this.Fields["CustomerDirectorID3"].Value = RuntimeHelpers.GetObjectValue(dboCustomer.Director3ID);
      this.Fields["CustomerDirectorID4"].Value = RuntimeHelpers.GetObjectValue(dboCustomer.Director4ID);
    }

    private void rptJobCard_ReportStart(object sender, EventArgs e)
    {
      this._JobID = Conversions.ToInteger(this.Parameters["pJobID"].Value);
      this.dboJob.GetOne((object) this._JobID);
      this.dboCustomer.GetOne(RuntimeHelpers.GetObjectValue(this.dboJob.CustomerID));
      if (Conversions.ToBoolean(this.dboJob.isPropertyRental))
      {
        if (Conversions.ToBoolean(this.dboCustomer.isCompany))
          this.LoadLayout(Application.StartupPath + "\\CompanyWithTenant.rpx");
        else
          this.LoadLayout(Application.StartupPath + "\\PrivateWithTenant.rpx");
      }
      else if (Conversions.ToBoolean(this.dboCustomer.isCompany))
        this.LoadLayout(Application.StartupPath + "\\Company.rpx");
      else
        this.LoadLayout(Application.StartupPath + "\\Private.rpx");
    }

    public rptJobCard(object GlobalConnection)
    {
      this.ReportStart += new EventHandler(this.rptJobCard_ReportStart);
      this.DataInitialize += new EventHandler(this.rptJobCard_DataInitialize);
      this.FetchData += new ActiveReport3.FetchEventHandler(this.rptJobCard_FetchData);
      this.InitializeComponent();
      this.dboCompany = new JobCardCompany((DataConnection) GlobalConnection);
      this.dboJob = new Reytec.JobCard.DAL.JobCard((DataConnection) GlobalConnection);
      this.dboCustomer = new Customer((DataConnection) GlobalConnection);
    }

    private void Detail1_Format(object sender, EventArgs e)
    {
    }

    private void PageHeader1_Format(object sender, EventArgs e)
    {
    }
  }
}
