// Decompiled with JetBrains decompiler
// Type: Reytec.GUI.Controls.DataLookupWindow.LookupButton
// Assembly: ReytecDataLookupWindow, Version=1.0.3386.36143, Culture=neutral, PublicKeyToken=null
// MVID: E8FA6B8F-937A-43C2-80C5-9B0FB7B8E776
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\ReytecDataLookupWindow.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Reytec.GUI.Controls.DataLookupWindow
{
  public class LookupButton
  {
    private const string delm = "|:::|";
    [AccessedThroughProperty("frmLookup")]
    private LookupForm _frmLookup;
    private string _Caption;
    private string _ColumnCaptions;
    private Collection _SendBackValues;
    private Collection _DestControls;
    private Collection _SourceFields;
    private Collection _HiddenFields;
    private DataTable _ds;
    private string _SQL;

    public virtual LookupForm frmLookup
    {
      [DebuggerNonUserCode] get
      {
        return this._frmLookup;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LookupForm.ValueSubmittedEventHandler submittedEventHandler = new LookupForm.ValueSubmittedEventHandler(this.SetControlValues);
        if (this._frmLookup != null)
          this._frmLookup.ValueSubmitted -= submittedEventHandler;
        this._frmLookup = value;
        if (this._frmLookup == null)
          return;
        this._frmLookup.ValueSubmitted += submittedEventHandler;
      }
    }

    public event LookupButton.ValueSubmittedEventHandler ValueSubmitted;

    public event LookupButton.ButtonClickEventHandler ButtonClick;

    public string LookupCaption
    {
      get
      {
        return this._Caption;
      }
      set
      {
        this._Caption = value;
      }
    }

    public string SetColumnCaptions
    {
      get
      {
        return this._ColumnCaptions;
      }
      set
      {
        this._ColumnCaptions = value;
      }
    }

    private Collection SendBackValues
    {
      get
      {
        return this._SendBackValues;
      }
      set
      {
        this._SendBackValues = value;
      }
    }

    public DataTable DataSource
    {
      get
      {
        return this._ds;
      }
      set
      {
        this._ds = value;
      }
    }

    public string SQLCommand
    {
      get
      {
        return this._SQL;
      }
      set
      {
        this._SQL = value;
      }
    }

    public void AddControlMapping(object theControl, object DataField)
    {
      this._DestControls.Add(RuntimeHelpers.GetObjectValue(theControl), (string) null, (object) null, (object) null);
      this._SourceFields.Add(RuntimeHelpers.GetObjectValue(DataField), (string) null, (object) null, (object) null);
    }

    public void SetControlMapping(object theControl, object DataField)
    {
      this._DestControls.Clear();
      this._SourceFields.Clear();
      this._DestControls.Add(RuntimeHelpers.GetObjectValue(theControl), (string) null, (object) null, (object) null);
      this._SourceFields.Add(RuntimeHelpers.GetObjectValue(DataField), (string) null, (object) null, (object) null);
    }

    public void AddHiddenFields(object DataField)
    {
      this._HiddenFields.Add(RuntimeHelpers.GetObjectValue(DataField), (string) null, (object) null, (object) null);
    }

    private void SetControlValues(object sender, ValueSubmission e)
    {
      this.SendBackValues = e.NewValue;
      int count = this._DestControls.Count;
      int num1 = 1;
      while (num1 <= count)
      {
        object[] objArray = (object[]) Microsoft.VisualBasic.Strings.Split(Conversions.ToString(this.SendBackValues[1]), "|:::|", -1, CompareMethod.Binary);
        int num2 = checked (((IEnumerable<object>) objArray).Count<object>() - 1);
        int index = 0;
        while (index <= num2)
        {
          NewLateBinding.LateSetComplex(this._DestControls[checked (index + 1)], (Type) null, "Text", new object[1]
          {
            RuntimeHelpers.GetObjectValue(objArray[index])
          }, (string[]) null, (Type[]) null, false, true);
          checked { ++index; }
        }
        checked { ++num1; }
      }
    }

    public void PopupWindow()
    {
      this.frmLookup = new LookupForm(this._ds, this._SourceFields, this._HiddenFields, this._ColumnCaptions);
      this.frmLookup.ValueSubmitted += new LookupForm.ValueSubmittedEventHandler(this.SetControlValues);
      int num = (int) this.frmLookup.ShowDialog();
      ValueSubmission e = new ValueSubmission(this.SendBackValues);
      LookupButton.ValueSubmittedEventHandler valueSubmittedEvent = this.ValueSubmittedEvent;
      if (valueSubmittedEvent != null)
        valueSubmittedEvent((object) this, e);
      this.frmLookup = (LookupForm) null;
    }

    public LookupButton()
    {
      this._DestControls = new Collection();
      this._SourceFields = new Collection();
      this._HiddenFields = new Collection();
    }

    public delegate void ValueSubmittedEventHandler(object sender, ValueSubmission e);
    public event ValueSubmittedEventHandler ValueSubmittedEvent;

    public delegate void ButtonClickEventHandler(object sender, EventArgs e);
  }
}
