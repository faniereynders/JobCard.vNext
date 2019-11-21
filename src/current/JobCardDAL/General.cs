// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.DAL.General
// Assembly: JobCardDAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87AA1E8D-4FC8-49A0-84FD-8A245003C90A
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCardDAL.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Reytec.Data.Connection;
using Reytec.Data.Engine;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Reytec.JobCard.DAL
{
  [StandardModule]
  public sealed class General
  {
    public static DataTable GetPaymentMethods(DataConnection Connect)
    {
      return new DataAccess(Connect).GetDataset("SELECT * FROM PaymentMethod").Tables[0];
    }

    public static object ShowValidationMessage(string Message, Control control = null)
    {
      int num = (int) MessageBox.Show(Message, "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      control?.Focus();
      return (object) false;
    }

    public static object BackUpData(
      DataConnection Connect,
      string DatabaseName,
      string Destination)
    {
      return (object) new DataAccess(Connect).Execute("BACKUP DATABASE " + DatabaseName + " TO DISK = '" + Destination + "'");
    }

    public static object RestoreData(
      DataConnection Connect,
      string DatabaseName,
      string SourceLocation)
    {
      DataAccess dataAccess = new DataAccess(Connect);
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendLine("ALTER DATABASE " + DatabaseName + " SET OFFLINE WITH ROLLBACK IMMEDIATE  ");
      stringBuilder.AppendLine("exec sp_detach_db '" + DatabaseName + "'");
      stringBuilder.AppendLine("RESTORE DATABASE " + DatabaseName + " FROM DISK = '" + SourceLocation + "' WITH REPLACE");
      return (object) dataAccess.Execute(stringBuilder.ToString());
    }
  }
}
