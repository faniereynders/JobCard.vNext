// Decompiled with JetBrains decompiler
// Type: Reytec.GUI.Controls.DataLookupWindow.ValueSubmission
// Assembly: ReytecDataLookupWindow, Version=1.0.3386.36143, Culture=neutral, PublicKeyToken=null
// MVID: E8FA6B8F-937A-43C2-80C5-9B0FB7B8E776
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\ReytecDataLookupWindow.dll

using Microsoft.VisualBasic;
using System;

namespace Reytec.GUI.Controls.DataLookupWindow
{
  public class ValueSubmission : EventArgs
  {
    private Collection _newValue;

    public ValueSubmission(Collection newValue)
    {
      this._newValue = newValue;
    }

    public Collection NewValue
    {
      get
      {
        return this._newValue;
      }
    }
  }
}
