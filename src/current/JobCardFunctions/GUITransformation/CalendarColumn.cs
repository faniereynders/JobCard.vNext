// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.Functions.GUITransformation.CalendarColumn
// Assembly: JobCardFunctions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4C10EA47-A3AD-4C6F-A00C-A2AA06BFAAFE
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCardFunctions.dll

using System;
using System.Windows.Forms;

namespace Reytec.JobCard.Functions.GUITransformation
{
  public class CalendarColumn : DataGridViewColumn
  {
    public CalendarColumn()
      : base((DataGridViewCell) new CalendarCell())
    {
    }

    public override DataGridViewCell CellTemplate
    {
      get
      {
        return base.CellTemplate;
      }
      set
      {
        if (value != null && !value.GetType().IsAssignableFrom(typeof (CalendarCell)))
          throw new InvalidCastException("Must be a CalendarCell");
        base.CellTemplate = value;
      }
    }
  }
}
