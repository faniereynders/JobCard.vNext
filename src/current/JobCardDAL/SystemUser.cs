// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.DAL.SystemUser
// Assembly: JobCardDAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87AA1E8D-4FC8-49A0-84FD-8A245003C90A
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCardDAL.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Reytec.Data.Attributes;
using Reytec.Data.Connection;
using Reytec.Data.Engine;
using Reytec.Data.Functions;
using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace Reytec.JobCard.DAL
{
  public class SystemUser
  {
    private const string TableName = "SystemUser";
    private TableField _ID;
    private TableField _Name;
    private TableField _Surname;
    private TableField _Password;
    private TableField _isAdmin;
    private TableField _isDeleted;

    public object ID
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

    public object UserName
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

    public object UserSurname
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

    public object UserPassword
    {
      get
      {
        return this._Password.Value;
      }
      set
      {
        this._Password.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object isAdmin
    {
      get
      {
        return this._isAdmin.Value;
      }
      set
      {
        this._isAdmin.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    private Collection AllFields()
    {
      Collection collection = new Collection();
      collection.Clear();
      collection.Add((object) this._ID, (string) null, (object) null, (object) null);
      collection.Add((object) this._Name, (string) null, (object) null, (object) null);
      collection.Add((object) this._Surname, (string) null, (object) null, (object) null);
      collection.Add((object) this._Password, (string) null, (object) null, (object) null);
      collection.Add((object) this._isAdmin, (string) null, (object) null, (object) null);
      return collection;
    }

    private Collection ForDeletionFields()
    {
      Collection collection = new Collection();
      collection.Clear();
      collection.Add((object) this._isDeleted, (string) null, (object) null, (object) null);
      return collection;
    }

    public bool AlreadyExists(string Name, string Surname)
    {
      return Microsoft.VisualBasic.CompilerServices.Operators.CompareString(DALGeneral.sql.GetScalar("Select systemusername from systemuser where systemusername = '" + Name + "' and systemusersurname='" + Surname + "' and deleted=0"), "", false) != 0;
    }

    public bool Update(object RowID)
    {
      if (!DataFunctions.ValidateBlanks(this.AllFields()))
        return false;
      DALGeneral._StatementCollection.Clear();
      this._ID.Value = RuntimeHelpers.GetObjectValue(RowID);
      DALGeneral._Fields = this.AllFields();
      DALGeneral._PK = (object) this._ID;
      DALGeneral._StatementCollection.Add((object) DALGeneral.hlp.UpdateStatement(nameof (SystemUser), DALGeneral._Fields, Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(NewLateBinding.LateGet(DALGeneral._PK, (Type) null, "FieldName", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) "="), RowID))), (string) null, (object) null, (object) null);
      return DALGeneral.sql.ExecuteTransactions(DALGeneral._StatementCollection);
    }

    public bool Delete(object RowID)
    {
      DALGeneral._StatementCollection.Clear();
      this._ID.Value = RuntimeHelpers.GetObjectValue(RowID);
      this._isDeleted.Value = (object) true;
      DALGeneral._Fields = this.ForDeletionFields();
      DALGeneral._PK = (object) this._ID;
      DALGeneral._StatementCollection.Add((object) DALGeneral.hlp.UpdateStatement(nameof (SystemUser), DALGeneral._Fields, Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(NewLateBinding.LateGet(DALGeneral._PK, (Type) null, "FieldName", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) "="), RowID))), (string) null, (object) null, (object) null);
      return DALGeneral.sql.ExecuteTransactions(DALGeneral._StatementCollection);
    }

    public bool Add()
    {
      if (!DataFunctions.ValidateBlanks(this.AllFields()))
        return false;
      DALGeneral._StatementCollection.Clear();
      DALGeneral._Fields = this.AllFields();
      DALGeneral._StatementCollection.Add((object) DALGeneral.hlp.InsertStatement(nameof (SystemUser), DALGeneral._Fields), (string) null, (object) null, (object) null);
      return DALGeneral.sql.ExecuteTransactions(DALGeneral._StatementCollection);
    }

    public object GetOne(object RowID)
    {
      this._ID.Value = RuntimeHelpers.GetObjectValue(RowID);
      DALGeneral._Fields = this.AllFields();
      DALGeneral._PK = (object) this._ID;
      DataTable table = DALGeneral.sql.GetDataset(DALGeneral.hlp.SelectStatement(nameof (SystemUser), DALGeneral._Fields, Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(NewLateBinding.LateGet(DALGeneral._PK, (Type) null, "FieldName", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) "="), RowID), (object) " AND "), this._isDeleted.FieldName), (object) "=0")), "")).Tables[0];
      if (table.Rows.Count <= 0)
        return (object) false;
      DALGeneral.SetFieldValues(table);
      return (object) true;
    }

    public DataTable GetAll()
    {
      DALGeneral._Fields = this.AllFields();
      return DALGeneral.sql.GetDataset(DALGeneral.hlp.SelectStatement(nameof (SystemUser), DALGeneral._Fields, Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(this._isDeleted.FieldName, (object) "=0")), "")).Tables[0];
    }

    public SystemUser(DataConnection DALConnection)
    {
      this._ID = new TableField("SystemUserID", TableField.FieldType.AutoNumber, "", false, (object) "");
      this._Name = new TableField("SystemUsername", TableField.FieldType.Text, "User Name", true, (object) "");
      this._Surname = new TableField("SystemUserSurname", TableField.FieldType.Text, "User Surname", true, (object) "");
      this._Password = new TableField("SystemUserPassword", TableField.FieldType.ProtectedText, "User Password", false, (object) "");
      this._isAdmin = new TableField(nameof (isAdmin), TableField.FieldType.YesNo, "", false, (object) "");
      this._isDeleted = new TableField("Deleted", TableField.FieldType.YesNo, "", false, (object) "");
      DALGeneral.myConn = DALConnection;
      DALGeneral.sql = new DataAccess(DALConnection);
    }
  }
}
