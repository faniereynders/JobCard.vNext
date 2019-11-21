// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.Functions.GUITransformation.CalendarEditingControl
// Assembly: JobCardFunctions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4C10EA47-A3AD-4C6F-A00C-A2AA06BFAAFE
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCardFunctions.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Windows.Forms;

namespace Reytec.JobCard.Functions.GUITransformation
{
  internal class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
  {
    private DataGridView dataGridViewControl;
    private bool valueIsChanged;
    private int rowIndexNum;

    public CalendarEditingControl()
    {
      this.valueIsChanged = false;
      this.Format = DateTimePickerFormat.Custom;
      this.CustomFormat = "dd/MM/yyyy";
    }

    public object EditingControlFormattedValue
    {
      get
      {
        return (object) this.Value.ToShortDateString();
      }
      set
      {
        if (!(value is string))
          return;
        this.Value = DateTime.Parse(Conversions.ToString(value));
      }
    }

    public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
    {
      return (object) this.Value.ToShortDateString();
    }

    public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
    {
      this.Font = dataGridViewCellStyle.Font;
      this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
      this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
    }

    public int EditingControlRowIndex
    {
      get
      {
        return this.rowIndexNum;
      }
      set
      {
        this.rowIndexNum = value;
      }
    }

    public bool EditingControlWantsInputKey(Keys key, bool dataGridViewWantsInputKey)
    {
      switch (key & Keys.KeyCode)
      {
        case Keys.Prior:
        case Keys.Next:
        case Keys.End:
        case Keys.Home:
        case Keys.Left:
        case Keys.Up:
        case Keys.Right:
        case Keys.Down:
          return true;
        default:
          return !dataGridViewWantsInputKey;
      }
    }

    public void PrepareEditingControlForEdit(bool selectAll)
    {
    }

    public bool RepositionEditingControlOnValueChange
    {
      get
      {
        return false;
      }
    }

    public DataGridView EditingControlDataGridView
    {
      get
      {
        return this.dataGridViewControl;
      }
      set
      {
        this.dataGridViewControl = value;
      }
    }

    public bool EditingControlValueChanged
    {
      get
      {
        return this.valueIsChanged;
      }
      set
      {
        this.valueIsChanged = value;
      }
    }

    public Cursor EditingControlCursor
    {
      get
      {
        return this.Cursor;
      }
    }

        public Cursor EditingPanelCursor => this.Cursor;

        protected override void OnValueChanged(EventArgs eventargs)
    {
      this.valueIsChanged = true;
      this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
      base.OnValueChanged(eventargs);
    }
  }
}
