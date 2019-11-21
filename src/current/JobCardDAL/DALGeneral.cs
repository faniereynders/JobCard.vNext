// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.DAL.DALGeneral
// Assembly: JobCardDAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87AA1E8D-4FC8-49A0-84FD-8A245003C90A
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCardDAL.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Reytec.Data.Attributes;
using Reytec.Data.Connection;
using Reytec.Data.Engine;
using Reytec.Data.Functions;
using Reytec.Data.SQLTools;
using Reytec.Security.Cryptography;
using System;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Reytec.JobCard.DAL
{
  [StandardModule]
  public sealed class DALGeneral
  {
    internal static SQLHelper hlp = new SQLHelper();
    internal static DataFunctions sqlF = new DataFunctions();
    internal static Collection _Fields = new Collection();
    internal static Collection _StatementCollection = new Collection();
    internal static DataConnection myConn;
    internal static DataAccess sql;
    internal static object _PK;

    internal static void SetFieldValues(DataTable Table)
    {
      int count = DALGeneral._Fields.Count;
      int index = 1;
      while (index <= count)
      {
        object objectValue = RuntimeHelpers.GetObjectValue(DALGeneral._Fields[index]);
        NewLateBinding.LateSet(objectValue, (Type) null, "Value", new object[1]
        {
          (object) DataFunctions.DBNullToBlank(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type) null, "Value", new object[0], (string[]) null, (Type[]) null, (bool[]) null)))
        }, (string[]) null, (Type[]) null);
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, (Type) null, "FieldDataType", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) TableField.FieldType.ProtectedText, false))
          NewLateBinding.LateSet(objectValue, (Type) null, "Value", new object[1]
          {
            (object) StringCrypography.DecryptString(Conversions.ToString(Table.AsEnumerable().ElementAtOrDefault<DataRow>(0)[checked (index - 1)]))
          }, (string[]) null, (Type[]) null);
        else
          NewLateBinding.LateSet(objectValue, (Type) null, "Value", new object[1]
          {
            RuntimeHelpers.GetObjectValue(Table.AsEnumerable().ElementAtOrDefault<DataRow>(0)[checked (index - 1)])
          }, (string[]) null, (Type[]) null);
        checked { ++index; }
      }
    }

    public static string StripReturns(string str)
    {
      str = Microsoft.VisualBasic.Strings.Replace(str, ",", "", 1, -1, CompareMethod.Binary);
      str = Microsoft.VisualBasic.Strings.Replace(str, "\r\n", ", ", 1, -1, CompareMethod.Binary);
      return str;
    }
  }
}
