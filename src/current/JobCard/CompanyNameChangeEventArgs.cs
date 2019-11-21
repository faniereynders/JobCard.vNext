// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.Core.CompanyNameChangeEventArgs
// Assembly: JobCard, Version=1.0.0.2, Culture=neutral, PublicKeyToken=null
// MVID: 355A629F-A2FA-4599-879B-59162A296DD0
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCard.exe

using System;

namespace Reytec.JobCard.Core
{
  public class CompanyNameChangeEventArgs : EventArgs
  {
    private string _newValue;

    public CompanyNameChangeEventArgs(string newValue)
    {
      this._newValue = newValue;
    }

    public string NewValue
    {
      get
      {
        return this._newValue;
      }
    }
  }
}
