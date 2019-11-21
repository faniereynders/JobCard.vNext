// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.DAL.Customer
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
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;

namespace Reytec.JobCard.DAL
{
  public class Customer
  {
    private const string TableName = "Customer";
    private TableField _ID;
    private TableField _LeftChar;
    private TableField _isCompany;
    private TableField _AccountNr;
    private TableField _Name;
    private TableField _PostalAddress;
    private TableField _ResidentialAddress;
    private TableField _Tel1;
    private TableField _Tel2;
    private TableField _Cell;
    private TableField _Fax;
    private TableField _Email;
    private TableField _RegNr;
    private TableField _VATNr;
    private TableField _Director1Name;
    private TableField _Director2Name;
    private TableField _Director3Name;
    private TableField _Director4Name;
    private TableField _Director1ID;
    private TableField _Director2ID;
    private TableField _Director3ID;
    private TableField _Director4ID;
    private TableField _Manager;
    private TableField _IDNumber;
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

    public object isCompany
    {
      get
      {
        return this._isCompany.Value;
      }
      set
      {
        this._isCompany.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object AccountNumber
    {
      get
      {
        return this._AccountNr.Value;
      }
      set
      {
        this._AccountNr.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object Name
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

    public object PostalAddress
    {
      get
      {
        return this._PostalAddress.Value;
      }
      set
      {
        this._PostalAddress.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object ResidentialAddress
    {
      get
      {
        return this._ResidentialAddress.Value;
      }
      set
      {
        this._ResidentialAddress.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object Tel1
    {
      get
      {
        return this._Tel1.Value;
      }
      set
      {
        this._Tel1.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object Tel2
    {
      get
      {
        return this._Tel2.Value;
      }
      set
      {
        this._Tel2.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object Cell
    {
      get
      {
        return this._Cell.Value;
      }
      set
      {
        this._Cell.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object Fax
    {
      get
      {
        return this._Fax.Value;
      }
      set
      {
        this._Fax.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object CustomerEmail
    {
      get
      {
        return this._Email.Value;
      }
      set
      {
        this._Email.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object VATNr
    {
      get
      {
        return this._VATNr.Value;
      }
      set
      {
        this._VATNr.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object RegistrationNr
    {
      get
      {
        return this._RegNr.Value;
      }
      set
      {
        this._RegNr.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object Director1Name
    {
      get
      {
        return this._Director1Name.Value;
      }
      set
      {
        this._Director1Name.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object Director2Name
    {
      get
      {
        return this._Director2Name.Value;
      }
      set
      {
        this._Director2Name.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object Director3Name
    {
      get
      {
        return this._Director3Name.Value;
      }
      set
      {
        this._Director3Name.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object Director4Name
    {
      get
      {
        return this._Director4Name.Value;
      }
      set
      {
        this._Director4Name.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object Director1ID
    {
      get
      {
        return this._Director1ID.Value;
      }
      set
      {
        this._Director1ID.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object Director2ID
    {
      get
      {
        return this._Director2ID.Value;
      }
      set
      {
        this._Director2ID.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object Director3ID
    {
      get
      {
        return this._Director3ID.Value;
      }
      set
      {
        this._Director3ID.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object Director4ID
    {
      get
      {
        return this._Director4ID.Value;
      }
      set
      {
        this._Director4ID.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object ManagerName
    {
      get
      {
        return this._Manager.Value;
      }
      set
      {
        this._Manager.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object PrivateIDNumber
    {
      get
      {
        return this._IDNumber.Value;
      }
      set
      {
        this._IDNumber.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    private Collection AllFields()
    {
            var collection = new Collection();
      collection.Clear();
      collection.Add((object) this._ID, (string) null, (object) null, (object) null);
      collection.Add((object) this._isCompany, (string) null, (object) null, (object) null);
      collection.Add((object) this._AccountNr, (string) null, (object) null, (object) null);
      collection.Add((object) this._Name, (string) null, (object) null, (object) null);
      collection.Add((object) this._PostalAddress, (string) null, (object) null, (object) null);
      collection.Add((object) this._ResidentialAddress, (string) null, (object) null, (object) null);
      collection.Add((object) this._Tel1, (string) null, (object) null, (object) null);
      collection.Add((object) this._Tel2, (string) null, (object) null, (object) null);
      collection.Add((object) this._Cell, (string) null, (object) null, (object) null);
      collection.Add((object) this._Fax, (string) null, (object) null, (object) null);
      collection.Add((object) this._Email, (string) null, (object) null, (object) null);
      collection.Add((object) this._RegNr, (string) null, (object) null, (object) null);
      collection.Add((object) this._VATNr, (string) null, (object) null, (object) null);
      collection.Add((object) this._Director1Name, (string) null, (object) null, (object) null);
      collection.Add((object) this._Director2Name, (string) null, (object) null, (object) null);
      collection.Add((object) this._Director3Name, (string) null, (object) null, (object) null);
      collection.Add((object) this._Director4Name, (string) null, (object) null, (object) null);
      collection.Add((object) this._Director1ID, (string) null, (object) null, (object) null);
      collection.Add((object) this._Director2ID, (string) null, (object) null, (object) null);
      collection.Add((object) this._Director3ID, (string) null, (object) null, (object) null);
      collection.Add((object) this._Director4ID, (string) null, (object) null, (object) null);
      collection.Add((object) this._Manager, (string) null, (object) null, (object) null);
      collection.Add((object) this._IDNumber, (string) null, (object) null, (object) null);
      return collection;
    }

    private Collection ListFields()
    {
      Collection collection = new Collection();
      collection.Clear();
      collection.Add((object) this._ID, (string) null, (object) null, (object) null);
      collection.Add((object) this._isCompany, (string) null, (object) null, (object) null);
      collection.Add((object) this._Name, (string) null, (object) null, (object) null);
      collection.Add((object) this._AccountNr, (string) null, (object) null, (object) null);
      collection.Add((object) this._Tel1, (string) null, (object) null, (object) null);
      collection.Add((object) this._Tel2, (string) null, (object) null, (object) null);
      collection.Add((object) this._Cell, (string) null, (object) null, (object) null);
      collection.Add((object) this._Email, (string) null, (object) null, (object) null);
      return collection;
    }

    private Collection ForDeletionFields()
    {
      Collection collection = new Collection();
      collection.Clear();
      collection.Add((object) this._isDeleted, (string) null, (object) null, (object) null);
      return collection;
    }

    public bool AlreadyExists(string accountnumber)
    {
      return Microsoft.VisualBasic.CompilerServices.Operators.CompareString(DALGeneral.sql.GetScalar("Select CustomerAccountNr from Customer where CustomerAccountNr = '" + accountnumber + "'"), "", false) != 0;
    }

    public bool Update(object RowID)
    {
      if (!DataFunctions.ValidateBlanks(this.AllFields()))
        return false;
      DALGeneral._StatementCollection.Clear();
      this._ID.Value = RuntimeHelpers.GetObjectValue(RowID);
      DALGeneral._Fields = this.AllFields();
      DALGeneral._PK = (object) this._ID;
      DALGeneral._StatementCollection.Add((object) DALGeneral.hlp.UpdateStatement(nameof (Customer), DALGeneral._Fields, Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(NewLateBinding.LateGet(DALGeneral._PK, (Type) null, "FieldName", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) "="), RowID), (object) " AND "), this._isDeleted.FieldName), (object) "=0"))), (string) null, (object) null, (object) null);
      return DALGeneral.sql.ExecuteTransactions(DALGeneral._StatementCollection);
    }

    public bool Delete(object RowID)
    {
      DALGeneral._StatementCollection.Clear();
      this._ID.Value = RuntimeHelpers.GetObjectValue(RowID);
      this._isDeleted.Value = (object) true;
      DALGeneral._Fields = this.ForDeletionFields();
      DALGeneral._PK = (object) this._ID;
      DALGeneral._StatementCollection.Add((object) DALGeneral.hlp.UpdateStatement(nameof (Customer), DALGeneral._Fields, Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(NewLateBinding.LateGet(DALGeneral._PK, (Type) null, "FieldName", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) "="), RowID))), (string) null, (object) null, (object) null);
      return DALGeneral.sql.ExecuteTransactions(DALGeneral._StatementCollection);
    }

    public bool Add()
    {
      if (!DataFunctions.ValidateBlanks(this.AllFields()))
        return false;
      DALGeneral._StatementCollection.Clear();
      DALGeneral._Fields = this.AllFields();
      DALGeneral._StatementCollection.Add((object) DALGeneral.hlp.InsertStatement(nameof (Customer), DALGeneral._Fields), (string) null, (object) null, (object) null);
      return DALGeneral.sql.ExecuteTransactions(DALGeneral._StatementCollection);
    }

    public object GetOne(object RowID)
    {
      this._ID.Value = RuntimeHelpers.GetObjectValue(RowID);
      DALGeneral._Fields = this.AllFields();
      DALGeneral._PK = (object) this._ID;
      DataTable table = DALGeneral.sql.GetDataset(DALGeneral.hlp.SelectStatement(nameof (Customer), DALGeneral._Fields, Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(NewLateBinding.LateGet(DALGeneral._PK, (Type) null, "FieldName", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) "="), RowID), (object) " AND "), this._isDeleted.FieldName), (object) "=0")), "")).Tables[0];
      if (table.Rows.Count <= 0)
        return (object) false;
      DALGeneral.SetFieldValues(table);
      return (object) true;
    }

    public object GetIDUsingAccountNr(object Accountnr)
    {
      DALGeneral._Fields = this.AllFields();
      DALGeneral._PK = (object) this._ID;
      object scalar = (object) DALGeneral.sql.GetScalar(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "SELECT ", this._ID.FieldName), (object) " FROM "), (object) nameof (Customer)), (object) " WHERE "), this._AccountNr.FieldName), (object) "='"), Accountnr), (object) "'")));
      if (scalar != null)
        return (object) Conversions.ToInteger(scalar);
      return (object) -2;
    }

    public object GetLatestOne()
    {
      DALGeneral._Fields = this.AllFields();
      DALGeneral._PK = (object) this._ID;
      DataTable table = DALGeneral.sql.GetDataset(DALGeneral.hlp.SelectStatement(nameof (Customer), DALGeneral._Fields, Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(this._isDeleted.FieldName, (object) "=0")), "CustomerID DESC")).Tables[0];
      if (table.Rows.Count <= 0)
        return (object) false;
      DALGeneral.SetFieldValues(table);
      return (object) true;
    }

    public DataTable GetAll()
    {
      DALGeneral._Fields = this.AllFields();
      return DALGeneral.sql.GetDataset(DALGeneral.hlp.SelectStatement(nameof (Customer), DALGeneral._Fields, Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(this._isDeleted.FieldName, (object) "=0")), "")).Tables[0];
    }

    public DataTable GetList()
    {
      DALGeneral._Fields = this.ListFields();
      return DALGeneral.sql.GetDataset(DALGeneral.hlp.SelectStatement(nameof (Customer), DALGeneral._Fields, Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(this._isDeleted.FieldName, (object) "=0")), "CustomerName ASC")).Tables[0];
    }

    public Customer(DataConnection DALConnection)
    {
      this._ID = new TableField("CustomerID", TableField.FieldType.AutoNumber, "", false, (object) "");
      this._LeftChar = new TableField("LeftChar", TableField.FieldType.Text, "", false, (object) "");
      this._isCompany = new TableField(nameof (isCompany), TableField.FieldType.YesNo, "", false, (object) "");
      this._AccountNr = new TableField("CustomerAccountNr", TableField.FieldType.Text, "Account Number", false, (object) "");
      this._Name = new TableField("CustomerName", TableField.FieldType.Text, "Customer Name", false, (object) "");
      this._PostalAddress = new TableField("CustomerPostalAddress", TableField.FieldType.Text, "", false, (object) "");
      this._ResidentialAddress = new TableField("CustomerResidentialAddress", TableField.FieldType.Text, "", false, (object) "");
      this._Tel1 = new TableField("CustomerTel1", TableField.FieldType.Text, "Telephone 1", false, (object) "");
      this._Tel2 = new TableField("CustomerTel2", TableField.FieldType.Text, "", false, (object) "");
      this._Cell = new TableField("CustomerCell", TableField.FieldType.Text, "", false, (object) "");
      this._Fax = new TableField("CustomerFax", TableField.FieldType.Text, "", false, (object) "");
      this._Email = new TableField(nameof (CustomerEmail), TableField.FieldType.Text, "E-Mail", false, (object) "");
      this._RegNr = new TableField("CCustomerRegNr", TableField.FieldType.Text, "", false, (object) "");
      this._VATNr = new TableField("CCustomerVatNr", TableField.FieldType.Text, "", false, (object) "");
      this._Director1Name = new TableField("CCustomerDirector1", TableField.FieldType.Text, "", false, (object) "");
      this._Director2Name = new TableField("CCustomerDirector2", TableField.FieldType.Text, "", false, (object) "");
      this._Director3Name = new TableField("CCustomerDirector3", TableField.FieldType.Text, "", false, (object) "");
      this._Director4Name = new TableField("CCustomerDirector4", TableField.FieldType.Text, "", false, (object) "");
      this._Director1ID = new TableField("CCustomerDirector1ID", TableField.FieldType.Text, "", false, (object) "");
      this._Director2ID = new TableField("CCustomerDirector2ID", TableField.FieldType.Text, "", false, (object) "");
      this._Director3ID = new TableField("CCustomerDirector3ID", TableField.FieldType.Text, "", false, (object) "");
      this._Director4ID = new TableField("CCustomerDirector4ID", TableField.FieldType.Text, "", false, (object) "");
      this._Manager = new TableField("CCustomerManager", TableField.FieldType.Text, "", false, (object) "");
      this._IDNumber = new TableField("PCustomerIDNr", TableField.FieldType.Text, "", false, (object) "");
      this._isDeleted = new TableField("Deleted", TableField.FieldType.YesNo, "", false, (object) "");
      DALGeneral.myConn = DALConnection;
      DALGeneral.sql = new DataAccess(DALConnection);
    }
  }
}
