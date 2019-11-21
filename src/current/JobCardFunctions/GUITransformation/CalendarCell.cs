// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.Functions.GUITransformation.CalendarCell
// Assembly: JobCardFunctions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4C10EA47-A3AD-4C6F-A00C-A2AA06BFAAFE
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCardFunctions.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Reytec.JobCard.Functions.GUITransformation
{
  public class CalendarCell : DataGridViewTextBoxCell
  {
    public CalendarCell()
    {
      this.Style.Format = "dd/MM/yyyy";
    }

    public override void InitializeEditingControl(
      int rowIndex,
      object initialFormattedValue,
      DataGridViewCellStyle dataGridViewCellStyle)
    {
      base.InitializeEditingControl(rowIndex, RuntimeHelpers.GetObjectValue(initialFormattedValue), dataGridViewCellStyle);
      ((DateTimePicker) this.DataGridView.EditingControl).Value = Conversions.ToDate(this.Value);
    }

    public override System.Type EditType
    {
      get
      {
        return typeof (CalendarEditingControl);
      }
    }

    public override System.Type ValueType
    {
      get
      {
        return typeof (DateTime);
      }
    }

    public override object DefaultNewRowValue
    {
      get
      {
        return (object) DateTime.Now;
      }
    }
  }
}
