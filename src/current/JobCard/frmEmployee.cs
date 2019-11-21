// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.Core.frmEmployee
// Assembly: JobCard, Version=1.0.0.2, Culture=neutral, PublicKeyToken=null
// MVID: 355A629F-A2FA-4599-879B-59162A296DD0
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCard.exe

using Microsoft.VisualBasic.CompilerServices;
using Reytec.GUI.Controls.DataLookupWindow;
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
  public class frmEmployee : Form
  {
    private IContainer components;
    [AccessedThroughProperty("Button1")]
    private Button _Button1;
    [AccessedThroughProperty("TextBox1")]
    private TextBox _TextBox1;
    [AccessedThroughProperty("TextBox2")]
    private TextBox _TextBox2;
    [AccessedThroughProperty("Button2")]
    private Button _Button2;
    [AccessedThroughProperty("Button3")]
    private Button _Button3;
    [AccessedThroughProperty("l")]
    private ListView _l;
    [AccessedThroughProperty("Button4")]
    private Button _Button4;
    private Employee dbo;

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
      ListViewItem listViewItem = new ListViewItem("ttt");
      this.Button1 = new Button();
      this.TextBox1 = new TextBox();
      this.TextBox2 = new TextBox();
      this.Button2 = new Button();
      this.Button3 = new Button();
      this.l = new ListView();
      this.Button4 = new Button();
      this.SuspendLayout();
      Button button1_1 = this.Button1;
      Point point1 = new Point(355, 264);
      Point point2 = point1;
      button1_1.Location = point2;
      this.Button1.Name = "Button1";
      Button button1_2 = this.Button1;
      Size size1 = new Size(75, 23);
      Size size2 = size1;
      button1_2.Size = size2;
      this.Button1.TabIndex = 4;
      this.Button1.Text = "Add";
      this.Button1.UseVisualStyleBackColor = true;
      TextBox textBox1_1 = this.TextBox1;
      point1 = new Point(195, 72);
      Point point3 = point1;
      textBox1_1.Location = point3;
      this.TextBox1.Name = "TextBox1";
      TextBox textBox1_2 = this.TextBox1;
      size1 = new Size(100, 20);
      Size size3 = size1;
      textBox1_2.Size = size3;
      this.TextBox1.TabIndex = 5;
      TextBox textBox2_1 = this.TextBox2;
      point1 = new Point(195, 99);
      Point point4 = point1;
      textBox2_1.Location = point4;
      this.TextBox2.Name = "TextBox2";
      TextBox textBox2_2 = this.TextBox2;
      size1 = new Size(100, 20);
      Size size4 = size1;
      textBox2_2.Size = size4;
      this.TextBox2.TabIndex = 6;
      Button button2_1 = this.Button2;
      point1 = new Point(69, 205);
      Point point5 = point1;
      button2_1.Location = point5;
      this.Button2.Name = "Button2";
      Button button2_2 = this.Button2;
      size1 = new Size(75, 23);
      Size size5 = size1;
      button2_2.Size = size5;
      this.Button2.TabIndex = 7;
      this.Button2.Text = "Button2";
      this.Button2.UseVisualStyleBackColor = true;
      Button button3_1 = this.Button3;
      point1 = new Point(355, 293);
      Point point6 = point1;
      button3_1.Location = point6;
      this.Button3.Name = "Button3";
      Button button3_2 = this.Button3;
      size1 = new Size(75, 23);
      Size size6 = size1;
      button3_2.Size = size6;
      this.Button3.TabIndex = 9;
      this.Button3.Text = "Update";
      this.Button3.UseVisualStyleBackColor = true;
      this.l.Items.AddRange(new ListViewItem[1]
      {
        listViewItem
      });
      ListView l1 = this.l;
      point1 = new Point(12, 329);
      Point point7 = point1;
      l1.Location = point7;
      this.l.Name = "l";
      ListView l2 = this.l;
      size1 = new Size(426, 184);
      Size size7 = size1;
      l2.Size = size7;
      this.l.TabIndex = 10;
      this.l.UseCompatibleStateImageBehavior = false;
      Button button4_1 = this.Button4;
      point1 = new Point(298, 156);
      Point point8 = point1;
      button4_1.Location = point8;
      this.Button4.Name = "Button4";
      Button button4_2 = this.Button4;
      size1 = new Size(75, 23);
      Size size8 = size1;
      button4_2.Size = size8;
      this.Button4.TabIndex = 11;
      this.Button4.Text = "Delete";
      this.Button4.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(450, 516);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Button4);
      this.Controls.Add((Control) this.l);
      this.Controls.Add((Control) this.Button3);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.TextBox2);
      this.Controls.Add((Control) this.TextBox1);
      this.Controls.Add((Control) this.Button1);
      this.Name = nameof (frmEmployee);
      this.Text = "Employee";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Button Button1
    {
      [DebuggerNonUserCode] get
      {
        return this._Button1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        if (this._Button1 != null)
          this._Button1.Click -= eventHandler;
        this._Button1 = value;
        if (this._Button1 == null)
          return;
        this._Button1.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBox1
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TextBox1_TextChanged);
        if (this._TextBox1 != null)
          this._TextBox1.TextChanged -= eventHandler;
        this._TextBox1 = value;
        if (this._TextBox1 == null)
          return;
        this._TextBox1.TextChanged += eventHandler;
      }
    }

    internal virtual TextBox TextBox2
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

    internal virtual Button Button2
    {
      [DebuggerNonUserCode] get
      {
        return this._Button2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click);
        if (this._Button2 != null)
          this._Button2.Click -= eventHandler;
        this._Button2 = value;
        if (this._Button2 == null)
          return;
        this._Button2.Click += eventHandler;
      }
    }

    internal virtual Button Button3
    {
      [DebuggerNonUserCode] get
      {
        return this._Button3;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button3_Click);
        if (this._Button3 != null)
          this._Button3.Click -= eventHandler;
        this._Button3 = value;
        if (this._Button3 == null)
          return;
        this._Button3.Click += eventHandler;
      }
    }

    internal virtual ListView l
    {
      [DebuggerNonUserCode] get
      {
        return this._l;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ListViewItemSelectionChangedEventHandler changedEventHandler = new ListViewItemSelectionChangedEventHandler(this.l_ItemSelectionChanged);
        EventHandler eventHandler = new EventHandler(this.l_SelectedIndexChanged);
        if (this._l != null)
        {
          this._l.ItemSelectionChanged -= changedEventHandler;
          this._l.SelectedIndexChanged -= eventHandler;
        }
        this._l = value;
        if (this._l == null)
          return;
        this._l.ItemSelectionChanged += changedEventHandler;
        this._l.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Button Button4
    {
      [DebuggerNonUserCode] get
      {
        return this._Button4;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button4_Click);
        if (this._Button4 != null)
          this._Button4.Click -= eventHandler;
        this._Button4 = value;
        if (this._Button4 == null)
          return;
        this._Button4.Click += eventHandler;
      }
    }

    private void frmEmployee_Load(object sender, EventArgs e)
    {
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      Employee dbo = this.dbo;
      dbo.EmployeeName = (object) this.TextBox1.Text;
      dbo.EmployeeSurname = (object) this.TextBox2.Text;
      dbo.Add();
      this.LoadList();
    }

    private void Button2_Click(object sender, EventArgs e)
    {
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      Employee dbo = this.dbo;
      dbo.EmployeeName = (object) this.TextBox1.Text;
      dbo.EmployeeSurname = (object) this.TextBox2.Text;
      dbo.Update((object) this.l.SelectedItems[0].Text);
      this.LoadList();
    }

    private void LoadList()
    {
      LookupForm.CreateListview(this.l, this.dbo.GetAll(), (string) null);
      LookupForm.GroupColumns(this.l, 1);
    }

    public frmEmployee()
    {
      this.Load += new EventHandler(this.frmEmployee_Load);
      this.dbo = new Employee(ConnectionInfo.GlobalConnection);
      this.InitializeComponent();
      this.LoadList();
      this.l.View = View.Details;
      this.l.FullRowSelect = true;
    }

    private void Button4_Click(object sender, EventArgs e)
    {
      this.dbo.Delete((object) this.l.SelectedItems[0].Text);
      this.LoadList();
    }

    private void l_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
    {
      Employee dbo = this.dbo;
      dbo.GetOne((object) e.Item.Text);
      this.TextBox1.Text = Conversions.ToString(dbo.EmployeeName);
      this.TextBox2.Text = Conversions.ToString(dbo.EmployeeSurname);
    }

    private void l_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void TextBox1_TextChanged(object sender, EventArgs e)
    {
    }
  }
}
