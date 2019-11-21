// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.DAL.Employee
// Assembly: JobCardDAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87AA1E8D-4FC8-49A0-84FD-8A245003C90A
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCardDAL.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Reytec.Data.Attributes;
using Reytec.Data.Connection;
using Reytec.Data.Engine;
using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace Reytec.JobCard.DAL
{
  public class Employee
  {
    private const string TableName = "Employee";
    private TableField _ID;
    private TableField _Name;
    private TableField _Surname;

    public object EmployeeID
    {
      get
      {
        return this._ID.Value;
      }
      set
      {
        this._ID.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object EmployeeName
    {
      get
      {
        return this._Name.Value;
      }
      set
      {
        this._Name.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object EmployeeSurname
    {
      get
      {
        return this._Surname.Value;
      }
      set
      {
        this._Surname.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    private Collection AllFields()
    {
      Collection collection = new Collection();
      collection.Clear();
      collection.Add((object) this._ID, (string) null, (object) null, (object) null);
      collection.Add((object) this._Name, (string) null, (object) null, (object) null);
      collection.Add((object) this._Surname, (string) null, (object) null, (object) null);
      return collection;
    }

    public bool Update(object RowID)
    {
      DALGeneral._StatementCollection.Clear();
      this._ID.Value = RuntimeHelpers.GetObjectValue(RowID);
      DALGeneral._Fields = this.AllFields();
      DALGeneral._PK = (object) this._ID;
      DALGeneral._StatementCollection.Add((object) DALGeneral.hlp.UpdateStatement(nameof (Employee), DALGeneral._Fields, Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(NewLateBinding.LateGet(DALGeneral._PK, (Type) null, "FieldName", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) "="), RowID))), (string) null, (object) null, (object) null);
      return DALGeneral.sql.ExecuteTransactions(DALGeneral._StatementCollection);
    }

    public bool Delete(object RowID)
    {
      DALGeneral._StatementCollection.Clear();
      this._ID.Value = RuntimeHelpers.GetObjectValue(RowID);
      DALGeneral._Fields = this.AllFields();
      DALGeneral._PK = (object) this._ID;
      DALGeneral._StatementCollection.Add((object) DALGeneral.hlp.DeleteStatement(nameof (Employee), DALGeneral._Fields, Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(NewLateBinding.LateGet(DALGeneral._PK, (Type) null, "FieldName", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) "="), RowID))), (string) null, (object) null, (object) null);
      return DALGeneral.sql.ExecuteTransactions(DALGeneral._StatementCollection);
    }

    public bool Add()
    {
      DALGeneral._StatementCollection.Clear();
      DALGeneral._Fields = this.AllFields();
      DALGeneral._StatementCollection.Add((object) DALGeneral.hlp.InsertStatement(nameof (Employee), DALGeneral._Fields), (string) null, (object) null, (object) null);
      return DALGeneral.sql.ExecuteTransactions(DALGeneral._StatementCollection);
    }

    public object GetOne(object RowID)
    {
      this._ID.Value = RuntimeHelpers.GetObjectValue(RowID);
      DALGeneral._Fields = this.AllFields();
      DALGeneral._PK = (object) this._ID;
      DataTable table = DALGeneral.sql.GetDataset(DALGeneral.hlp.SelectStatement(nameof (Employee), DALGeneral._Fields, Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(NewLateBinding.LateGet(DALGeneral._PK, (Type) null, "FieldName", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) "="), RowID)), "")).Tables[0];
      if (table.Rows.Count <= 0)
        return (object) false;
      DALGeneral.SetFieldValues(table);
      return (object) true;
    }

    public DataTable GetAll()
    {
      DALGeneral._Fields = this.AllFields();
      return DALGeneral.sql.GetDataset(DALGeneral.hlp.SelectStatement(nameof (Employee), DALGeneral._Fields, "", "")).Tables[0];
    }

    public Employee(DataConnection DALConnection)
    {
      this._ID = new TableField(nameof (EmployeeID), TableField.FieldType.AutoNumber, "", false, (object) "");
      this._Name = new TableField(nameof (EmployeeName), TableField.FieldType.Text, "Employee Name", false, (object) "");
      this._Surname = new TableField(nameof (EmployeeSurname), TableField.FieldType.Text, "Employee Surname", false, (object) "");
      DALGeneral.myConn = DALConnection;
      DALGeneral.sql = new DataAccess(DALConnection);
    }
  }
}
