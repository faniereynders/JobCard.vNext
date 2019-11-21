// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.DAL.SystemUserGeneric
// Assembly: JobCardDAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87AA1E8D-4FC8-49A0-84FD-8A245003C90A
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCardDAL.dll

using Microsoft.VisualBasic.CompilerServices;
using Reytec.Data.Connection;
using Reytec.Data.Engine;

namespace Reytec.JobCard.DAL
{
  [StandardModule]
  public sealed class SystemUserGeneric
  {
    public static object isUserAdmin(int UserID, DataConnection DALConnection)
    {
      DALGeneral.myConn = DALConnection;
      DALGeneral.sql = new DataAccess(DALConnection);
      if (Conversions.ToBoolean(DALGeneral.sql.GetScalar("SELECT isAdmin FROM SystemUser WHERE SystemUserID = " + Conversions.ToString(UserID))))
        return (object) true;
      return (object) false;
    }
  }
}
