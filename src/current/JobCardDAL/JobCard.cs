// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.DAL.JobCard
// Assembly: JobCardDAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87AA1E8D-4FC8-49A0-84FD-8A245003C90A
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCardDAL.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Reytec.Data.Attributes;
using Reytec.Data.Connection;
using Reytec.Data.Engine;
using Reytec.Data.Functions;
using Reytec.JobCard.Functions.GUITransformation;
using System;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace Reytec.JobCard.DAL
{
  public class JobCard
  {
    private const string TableName = "Job";
    private TableField _JobID;
    private TableField _JobNr;
    private TableField _JobDate;
    private TableField _CustomerID;
    private TableField _JobGateFee;
    private TableField _JobGateFeeQty;
    private TableField _JobInvoiceNr;
    private TableField _JobCompleted;
    private TableField _PayID;
    private TableField _QuotedAmount;
    private TableField _isPropertyRental;
    private TableField _JobTenantName;
    private TableField _JobTenantID;
    private TableField _JobTenantTel1;
    private TableField _JobTenantTel2;
    private TableField _JobTenantCell;
    private TableField _ProblemAddress;
    private TableField _SystemUserID;
    private TableField _JobNote;
    private TableField _JobTeam;
    private DataGridView _ProblemDetail;
    private DataGridView _Timesheet;
    private DataGridView _Travel;
    private TableField _CustomerName;
    private TableField _UserName;

    public object ProblemDetail
    {
      get
      {
        return (object) this._ProblemDetail;
      }
      set
      {
        this._ProblemDetail = (DataGridView) value;
      }
    }

    public object Timesheet
    {
      get
      {
        return (object) this._Timesheet;
      }
      set
      {
        this._Timesheet = (DataGridView) value;
      }
    }

    public object Travel
    {
      get
      {
        return (object) this._Travel;
      }
      set
      {
        this._Travel = (DataGridView) value;
      }
    }

    public object JobID
    {
      get
      {
        return this._JobID.Value;
      }
      set
      {
        this._JobID.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object JobNr
    {
      get
      {
        return this._JobNr.Value;
      }
      set
      {
        this._JobNr.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object JobDate
    {
      get
      {
        return this._JobDate.Value;
      }
      set
      {
        this._JobDate.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object CustomerID
    {
      get
      {
        return this._CustomerID.Value;
      }
      set
      {
        this._CustomerID.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object JobGateFee
    {
      get
      {
        return this._JobGateFee.Value;
      }
      set
      {
        this._JobGateFee.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object JobGateFeeQty
    {
      get
      {
        return this._JobGateFeeQty.Value;
      }
      set
      {
        this._JobGateFeeQty.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object JobInvoiceNr
    {
      get
      {
        return this._JobInvoiceNr.Value;
      }
      set
      {
        this._JobInvoiceNr.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object JobCompleted
    {
      get
      {
        return this._JobCompleted.Value;
      }
      set
      {
        this._JobCompleted.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object PayID
    {
      get
      {
        return this._PayID.Value;
      }
      set
      {
        this._PayID.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object QuotedAmount
    {
      get
      {
        return this._QuotedAmount.Value;
      }
      set
      {
        this._QuotedAmount.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object isPropertyRental
    {
      get
      {
        return this._isPropertyRental.Value;
      }
      set
      {
        this._isPropertyRental.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object JobTenantName
    {
      get
      {
        return this._JobTenantName.Value;
      }
      set
      {
        this._JobTenantName.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object JobTenantID
    {
      get
      {
        return this._JobTenantID.Value;
      }
      set
      {
        this._JobTenantID.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object JobTenantTel1
    {
      get
      {
        return this._JobTenantTel1.Value;
      }
      set
      {
        this._JobTenantTel1.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object JobTenantTel2
    {
      get
      {
        return this._JobTenantTel2.Value;
      }
      set
      {
        this._JobTenantTel2.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object JobTenantCell
    {
      get
      {
        return this._JobTenantCell.Value;
      }
      set
      {
        this._JobTenantCell.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object ProblemAddress
    {
      get
      {
        return this._ProblemAddress.Value;
      }
      set
      {
        this._ProblemAddress.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object SystemUserID
    {
      get
      {
        return this._SystemUserID.Value;
      }
      set
      {
        this._SystemUserID.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object JobNote
    {
      get
      {
        return this._JobNote.Value;
      }
      set
      {
        this._JobNote.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object JobTeam
    {
      get
      {
        return this._JobTeam.Value;
      }
      set
      {
        this._JobTeam.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    private Collection AllFields()
    {
      Collection collection = new Collection();
      collection.Clear();
      collection.Add((object) this._JobID, (string) null, (object) null, (object) null);
      collection.Add((object) this._JobNr, (string) null, (object) null, (object) null);
      collection.Add((object) this._JobDate, (string) null, (object) null, (object) null);
      collection.Add((object) this._CustomerID, (string) null, (object) null, (object) null);
      collection.Add((object) this._JobGateFee, (string) null, (object) null, (object) null);
      collection.Add((object) this._JobGateFeeQty, (string) null, (object) null, (object) null);
      collection.Add((object) this._JobInvoiceNr, (string) null, (object) null, (object) null);
      collection.Add((object) this._JobCompleted, (string) null, (object) null, (object) null);
      collection.Add((object) this._PayID, (string) null, (object) null, (object) null);
      collection.Add((object) this._QuotedAmount, (string) null, (object) null, (object) null);
      collection.Add((object) this._isPropertyRental, (string) null, (object) null, (object) null);
      collection.Add((object) this._JobTenantName, (string) null, (object) null, (object) null);
      collection.Add((object) this._JobTenantID, (string) null, (object) null, (object) null);
      collection.Add((object) this._JobTenantTel1, (string) null, (object) null, (object) null);
      collection.Add((object) this._JobTenantTel2, (string) null, (object) null, (object) null);
      collection.Add((object) this._JobTenantCell, (string) null, (object) null, (object) null);
      collection.Add((object) this._ProblemAddress, (string) null, (object) null, (object) null);
      collection.Add((object) this._SystemUserID, (string) null, (object) null, (object) null);
      collection.Add((object) this._JobNote, (string) null, (object) null, (object) null);
      collection.Add((object) this._JobTeam, (string) null, (object) null, (object) null);
      return collection;
    }

    private Collection ListPendingFields()
    {
      Collection collection = new Collection();
      collection.Clear();
      collection.Add((object) this._JobID, (string) null, (object) null, (object) null);
      collection.Add((object) this._JobNr, (string) null, (object) null, (object) null);
      collection.Add((object) this._JobDate, (string) null, (object) null, (object) null);
      collection.Add((object) this._CustomerName, (string) null, (object) null, (object) null);
      collection.Add((object) this._JobTeam, (string) null, (object) null, (object) null);
      collection.Add((object) this._UserName, (string) null, (object) null, (object) null);
      return collection;
    }

    private Collection ListCompletedFields()
    {
      Collection collection = new Collection();
      collection.Clear();
      collection.Add((object) this._JobID, (string) null, (object) null, (object) null);
      collection.Add((object) this._JobNr, (string) null, (object) null, (object) null);
      collection.Add((object) this._JobDate, (string) null, (object) null, (object) null);
      collection.Add((object) this._CustomerName, (string) null, (object) null, (object) null);
      collection.Add((object) this._JobTeam, (string) null, (object) null, (object) null);
      collection.Add((object) this._UserName, (string) null, (object) null, (object) null);
      return collection;
    }

    public bool Update(object RowID)
    {
      if (!DataFunctions.ValidateBlanks(this.AllFields()))
        return false;
      DALGeneral._StatementCollection.Clear();
      this._JobID.Value = RuntimeHelpers.GetObjectValue(RowID);
      DALGeneral._Fields = this.AllFields();
      DALGeneral._PK = (object) this._JobID;
      DALGeneral._StatementCollection.Add((object) DALGeneral.hlp.UpdateStatement("Job", DALGeneral._Fields, Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(NewLateBinding.LateGet(DALGeneral._PK, (System.Type) null, "FieldName", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) " = "), RowID))), (string) null, (object) null, (object) null);
      DALGeneral._StatementCollection.Add((object) this.InsertProblems(Conversions.ToInteger(this._JobID.Value)), (string) null, (object) null, (object) null);
      DALGeneral._StatementCollection.Add((object) this.InsertTimesheet(Conversions.ToInteger(this._JobID.Value)), (string) null, (object) null, (object) null);
      DALGeneral._StatementCollection.Add((object) this.InsertTravel(Conversions.ToInteger(this._JobID.Value)), (string) null, (object) null, (object) null);
      return DALGeneral.sql.ExecuteTransactions(DALGeneral._StatementCollection);
    }

    public bool Delete(object RowID)
    {
      DALGeneral._StatementCollection.Clear();
      this._JobID.Value = RuntimeHelpers.GetObjectValue(RowID);
      DALGeneral._Fields = this.AllFields();
      DALGeneral._PK = (object) this._JobID;
      DALGeneral._StatementCollection.Add((object) DALGeneral.hlp.DeleteStatement("Job", DALGeneral._Fields, Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(NewLateBinding.LateGet(DALGeneral._PK, (System.Type) null, "FieldName", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "="), RowID))), (string) null, (object) null, (object) null);
      return DALGeneral.sql.ExecuteTransactions(DALGeneral._StatementCollection);
    }

    public string GetPrefix()
    {
      return DALGeneral.sql.GetScalar("SELECT JobCardPrefix FROM CompanyInfo");
    }

    public string GetNextJobCardNr()
    {
      return this.GetPrefix() + Conversions.ToInteger(DALGeneral.sql.GetScalar("SELECT NextNumber FROM CompanyInfo")).ToString("000000");
    }

    private int GetNextJobID()
    {
      return checked ((int) Math.Round(unchecked (Conversions.ToDouble(DALGeneral.sql.GetScalar("SELECT TOP 1 JobID FROM Job ORDER BY JobID DESC")) + 1.0)));
    }

    private string InsertProblems(int JobID = -1)
    {
      StringBuilder stringBuilder = new StringBuilder();
      int num1 = JobID != -1 ? JobID : this.GetNextJobID();
      stringBuilder.AppendLine("DELETE FROM JobProblemDetail WHERE JobID = " + Conversions.ToString(num1));
      int num2 = checked (this._ProblemDetail.Rows.Count - 2);
      int index = 0;
      while (index <= num2)
      {
        stringBuilder.AppendLine("INSERT INTO JobProblemDetail ");
        stringBuilder.AppendLine("(ID,JobID,ProblemDescription,ProblemFeedback)");
        stringBuilder.AppendLine("VALUES");
        stringBuilder.AppendLine("(" + Conversions.ToString(checked (index + 1)) + ",");
        stringBuilder.AppendLine(Conversions.ToString(num1) + ",");
        stringBuilder.AppendLine(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "'", this._ProblemDetail[0, index].Value), (object) "',")));
        stringBuilder.AppendLine(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "'", this._ProblemDetail[1, index].Value), (object) "')")));
        checked { ++index; }
      }
      return stringBuilder.ToString();
    }

    public void GetProblems(DataGridView grd)
    {
      DataTable dataTable = new DataTable();
      DataTable table = DALGeneral.sql.GetDataset(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "SELECT * FROM JobProblemDetail WHERE JobID = ", this._JobID.Value))).Tables[0];
      int num = checked (table.Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        grd.Rows.Add();
        grd.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(table.Rows[index]["ProblemDescription"]);
        grd.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(table.Rows[index]["ProblemFeedback"]);
        checked { ++index; }
      }
    }

    public void GetTravel(DataGridView grd)
    {
      DataTable dataTable = new DataTable();
      DataTable table = DALGeneral.sql.GetDataset(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "SELECT * FROM JobKM WHERE JobID = ", this._JobID.Value))).Tables[0];
      int num = checked (table.Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        grd.Rows.Add();
        grd.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(table.Rows[index]["KMDate"]);
        grd.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(table.Rows[index]["KMStart"]);
        grd.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(table.Rows[index]["KMEnd"]);
        grd.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(table.Rows[index]["KMVehicleRegNr"]);
        checked { ++index; }
      }
    }

    public void GetTimeSheet(DataGridView grd)
    {
      DataTable dataTable = new DataTable();
      DataTable table = DALGeneral.sql.GetDataset(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "SELECT * FROM JobTimeSheet WHERE JobID = ", this._JobID.Value))).Tables[0];
      int num = checked (table.Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        grd.Rows.Add();
        grd.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(table.Rows[index]["StartTime"]);
        grd.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(table.Rows[index]["EndTime"]);
        grd.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(table.Rows[index]["TotalHours"]);
        checked { ++index; }
      }
    }

    private string InsertTimesheet(int JobID = -1)
    {
      StringBuilder stringBuilder = new StringBuilder();
      int num1 = JobID != -1 ? JobID : this.GetNextJobID();
      stringBuilder.AppendLine("DELETE FROM JobTimeSheet WHERE JobID = " + Conversions.ToString(num1));
      int num2 = checked (this._Timesheet.Rows.Count - 2);
      int index = 0;
      while (index <= num2)
      {
        stringBuilder.AppendLine("INSERT INTO JobTimeSheet ");
        stringBuilder.AppendLine("(ID,JobID,StartTime,EndTime,TotalHours)");
        stringBuilder.AppendLine("VALUES");
        stringBuilder.AppendLine("(" + Conversions.ToString(checked (index + 1)) + ",");
        stringBuilder.AppendLine(Conversions.ToString(num1) + ",");
        stringBuilder.AppendLine(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "'", this._Timesheet[0, index].Value), (object) "',")));
        stringBuilder.AppendLine(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "'", this._Timesheet[1, index].Value), (object) "',")));
        stringBuilder.AppendLine(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(this._Timesheet[2, index].Value, (object) ")")));
        checked { ++index; }
      }
      return stringBuilder.ToString();
    }

    private string InsertTravel(int JobID = -1)
    {
      StringBuilder stringBuilder = new StringBuilder();
      int num1 = JobID != -1 ? JobID : this.GetNextJobID();
      stringBuilder.AppendLine("DELETE FROM JobKM WHERE JobID = " + Conversions.ToString(num1));
      int num2 = checked (this._Travel.Rows.Count - 2);
      int index = 0;
      while (index <= num2)
      {
        stringBuilder.AppendLine("INSERT INTO JobKM ");
        stringBuilder.AppendLine("(ID,JobID,KMDate,KMStart,KMEnd,KMVehicleRegNr)");
        stringBuilder.AppendLine("VALUES");
        stringBuilder.AppendLine("(" + Conversions.ToString(checked (index + 1)) + ",");
        stringBuilder.AppendLine(Conversions.ToString(num1) + ",");
        stringBuilder.AppendLine(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "'", this._Travel[0, index].Value), (object) "',")));
        stringBuilder.AppendLine(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(this._Travel[1, index].Value, (object) ",")));
        stringBuilder.AppendLine(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(this._Travel[2, index].Value, (object) ",")));
        stringBuilder.AppendLine(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "'", this._Travel[3, index].Value), (object) "')")));
        checked { ++index; }
      }
      return stringBuilder.ToString();
    }

    public bool Add()
    {
      this._JobNr.Value = (object) this.GetNextJobCardNr();
      DALGeneral._StatementCollection.Clear();
      DALGeneral._Fields = this.AllFields();
      DALGeneral._StatementCollection.Add((object) DALGeneral.hlp.InsertStatement("Job", DALGeneral._Fields), (string) null, (object) null, (object) null);
      DALGeneral._StatementCollection.Add((object) this.InsertProblems(-1), (string) null, (object) null, (object) null);
      DALGeneral._StatementCollection.Add((object) this.InsertTimesheet(-1), (string) null, (object) null, (object) null);
      DALGeneral._StatementCollection.Add((object) this.InsertTravel(-1), (string) null, (object) null, (object) null);
      DALGeneral._StatementCollection.Add((object) "UPDATE CompanyInfo SET NextNumber = NextNumber+1", (string) null, (object) null, (object) null);
      return DALGeneral.sql.ExecuteTransactions(DALGeneral._StatementCollection);
    }

    public bool GetOne(object RowID)
    {
      DALGeneral._StatementCollection.Clear();
      this._JobID.Value = RuntimeHelpers.GetObjectValue(RowID);
      DALGeneral._Fields = this.AllFields();
      DALGeneral._PK = (object) this._JobID;
      DataTable table = DALGeneral.sql.GetDataset(DALGeneral.hlp.SelectStatement("Job", DALGeneral._Fields, Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(NewLateBinding.LateGet(DALGeneral._PK, (System.Type) null, "FieldName", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "="), RowID)), "")).Tables[0];
      if (table.Rows.Count <= 0)
        return false;
      DALGeneral.SetFieldValues(table);
      return true;
    }

    public DataTable GetOneSet(object RowID)
    {
      DALGeneral._StatementCollection.Clear();
      this._JobID.Value = RuntimeHelpers.GetObjectValue(RowID);
      DALGeneral._Fields = this.AllFields();
      DALGeneral._PK = (object) this._JobID;
      return DALGeneral.sql.GetDataset(DALGeneral.hlp.SelectStatement("Job", DALGeneral._Fields, Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(NewLateBinding.LateGet(DALGeneral._PK, (System.Type) null, "FieldName", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "="), RowID)), "")).Tables[0];
    }

    public string PaymentMethod()
    {
      return DALGeneral.sql.GetScalar(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "SELECT PaymentMethod FROM PaymentMethod WHERE PayID = ", this._PayID.Value)));
    }

    public string GetProblemsAsString()
    {
      string str = "";
      DataTable table = DALGeneral.sql.GetDataset(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "SELECT ProblemDescription FROM JobProblemDetail WHERE JobID = ", this._JobID.Value))).Tables[0];
      int num = checked (table.Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) str, table.Rows[index][0]), (object) "\r\n"));
        checked { ++index; }
      }
      return str;
    }

    public string GetFeedbackAsString()
    {
      string str = "";
      DataTable table = DALGeneral.sql.GetDataset(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "SELECT ProblemFeedback FROM JobProblemDetail WHERE JobID = ", this._JobID.Value))).Tables[0];
      int num = checked (table.Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) str, table.Rows[index][0]), (object) "\r\n"));
        checked { ++index; }
      }
      return str;
    }

    public string GetStartTimeAsString()
    {
      string str = "";
      DataTable table = DALGeneral.sql.GetDataset(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "SELECT StartTime FROM JobTimeSheet WHERE JobID = ", this._JobID.Value))).Tables[0];
      int num = checked (table.Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) str, table.Rows[index][0]), (object) "\r\n"));
        checked { ++index; }
      }
      return str;
    }

    public string GetEndTimeAsString()
    {
      string str = "";
      DataTable table = DALGeneral.sql.GetDataset(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "SELECT EndTime FROM JobTimeSheet WHERE JobID = ", this._JobID.Value))).Tables[0];
      int num = checked (table.Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) str, table.Rows[index][0]), (object) "\r\n"));
        checked { ++index; }
      }
      return str;
    }

    public string GetTotalHoursAsString()
    {
      string str = "";
      DataTable table = DALGeneral.sql.GetDataset(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "SELECT TotalHours FROM JobTimeSheet WHERE JobID = ", this._JobID.Value))).Tables[0];
      int num = checked (table.Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) str, table.Rows[index][0]), (object) "\r\n"));
        checked { ++index; }
      }
      return str;
    }

    public string GetKMDateAsString()
    {
      string str = "";
      DataTable table = DALGeneral.sql.GetDataset(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "SELECT KMDate FROM JobKM WHERE JobID = ", this._JobID.Value))).Tables[0];
      int num = checked (table.Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        str = str + Strings.Format(RuntimeHelpers.GetObjectValue(table.Rows[index][0]), "dd/MM/yyyy") + "\r\n";
        checked { ++index; }
      }
      return str;
    }

    public string GetKMStartAsString()
    {
      string str = "";
      DataTable table = DALGeneral.sql.GetDataset(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "SELECT KMStart FROM JobKM WHERE JobID = ", this._JobID.Value))).Tables[0];
      int num = checked (table.Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) str, table.Rows[index][0]), (object) "\r\n"));
        checked { ++index; }
      }
      return str;
    }

    public string GetKMEndAsString()
    {
      string str = "";
      DataTable table = DALGeneral.sql.GetDataset(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "SELECT KMEnd FROM JobKM WHERE JobID = ", this._JobID.Value))).Tables[0];
      int num = checked (table.Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) str, table.Rows[index][0]), (object) "\r\n"));
        checked { ++index; }
      }
      return str;
    }

    public string GetKMVehicleRegNrAsString()
    {
      string str = "";
      DataTable table = DALGeneral.sql.GetDataset(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "SELECT KMVehicleRegNr FROM JobKM WHERE JobID = ", this._JobID.Value))).Tables[0];
      int num = checked (table.Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) str, table.Rows[index][0]), (object) "\r\n"));
        checked { ++index; }
      }
      return str;
    }

    public DataTable GetAll()
    {
      DALGeneral._Fields = this.AllFields();
      return DALGeneral.sql.GetDataset(DALGeneral.hlp.SelectStatement("Job", DALGeneral._Fields, "", "")).Tables[0];
    }

    public DataTable GetPending()
    {
      DALGeneral._Fields = this.ListPendingFields();
      return DALGeneral.sql.GetDataset(DALGeneral.hlp.SelectStatement("Job,Customer,SystemUser", DALGeneral._Fields, "JobCompleted=0 AND Job.CustomerID=Customer.CustomerID AND Job.SystemUserID=SystemUser.SystemUserID", "JobDate asc")).Tables[0];
    }

    public DataTable GetCompleted(Reytec.JobCard.DAL.JobCard.CompletedListType filter = Reytec.JobCard.DAL.JobCard.CompletedListType.Today)
    {
      DALGeneral._Fields = this.ListPendingFields();
      string str = "";
      switch (filter)
      {
        case Reytec.JobCard.DAL.JobCard.CompletedListType.Today:
          str = " AND (jobdate >='" + Conversions.ToString(DateAndTime.Today) + "')";
          break;
        case Reytec.JobCard.DAL.JobCard.CompletedListType.Week:
          str = " AND (jobdate >= '" + Conversions.ToString(DateAndTime.Today.AddDays(-7.0)) + "' AND jobdate <= '" + Conversions.ToString(DateAndTime.Today.AddDays(1.0)) + "' )";
          break;
        case Reytec.JobCard.DAL.JobCard.CompletedListType.Month:
          str = " AND (jobdate >= '" + Conversions.ToString(DateAndTime.Today.AddMonths(-1)) + "' AND jobdate <= '" + Conversions.ToString(DateAndTime.Today.AddDays(1.0)) + "' )";
          break;
        case Reytec.JobCard.DAL.JobCard.CompletedListType.All:
          str = "";
          break;
      }
      return DALGeneral.sql.GetDataset(DALGeneral.hlp.SelectStatement("Job,Customer,SystemUser", DALGeneral._Fields, "JobCompleted=1 AND Job.CustomerID=Customer.CustomerID AND Job.SystemUserID=SystemUser.SystemUserID " + str, "JobDate desc")).Tables[0];
    }

    public int GetLatestOneID()
    {
      DALGeneral._PK = (object) this._JobID;
      return Conversions.ToInteger(DALGeneral.sql.GetScalar(DALGeneral.hlp.SelectStatement("Job", DALGeneral._Fields, "SystemUserID = " + Conversions.ToString(JobFunctions.LoggedUserID), "JobID DESC")));
    }

    public MemoryStream GetCompletedImage()
    {
      byte[] ImageBytes = default(byte[]);
      if (DALGeneral.sql.ReadDocFromDB(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "select * from job where jobid=", this._JobID.Value)), "Image", ref ImageBytes))
        return new MemoryStream(ImageBytes);
      return (MemoryStream) null;
    }

    public void SaveCompletedImage(byte[] data)
    {
      DALGeneral.sql.SaveDocToDB("Job", Conversions.ToString(this._JobID.FieldName), Conversions.ToString(this._JobID.Value), "Image", ref data);
    }

    public JobCard(DataConnection DALConnection)
    {
      this._JobID = new TableField(nameof (JobID), TableField.FieldType.AutoNumber, "ID", true, (object) "");
      this._JobNr = new TableField(nameof (JobNr), TableField.FieldType.Text, "Job Number", true, (object) "");
      this._JobDate = new TableField(nameof (JobDate), TableField.FieldType.DateTime, "Date", true, (object) "");
      this._CustomerID = new TableField(nameof (CustomerID), TableField.FieldType.Number, "Customer", true, (object) "");
      this._JobGateFee = new TableField(nameof (JobGateFee), TableField.FieldType.DecimalNumber, "Gate Fee", false, (object) "");
      this._JobGateFeeQty = new TableField(nameof (JobGateFeeQty), TableField.FieldType.Number, "Gate Fee Qty", false, (object) "");
      this._JobInvoiceNr = new TableField(nameof (JobInvoiceNr), TableField.FieldType.Text, "Invoice Number", false, (object) "");
      this._JobCompleted = new TableField(nameof (JobCompleted), TableField.FieldType.YesNo, "Completed", false, (object) "");
      this._PayID = new TableField(nameof (PayID), TableField.FieldType.Number, "Payment Method", true, (object) "");
      this._QuotedAmount = new TableField(nameof (QuotedAmount), TableField.FieldType.DecimalNumber, "Quoted Amount", false, (object) "");
      this._isPropertyRental = new TableField(nameof (isPropertyRental), TableField.FieldType.YesNo, "Rented Property", false, (object) "");
      this._JobTenantName = new TableField(nameof (JobTenantName), TableField.FieldType.Text, "Tenant Name", false, (object) "");
      this._JobTenantID = new TableField(nameof (JobTenantID), TableField.FieldType.Text, "Tenant ID Number", false, (object) "");
      this._JobTenantTel1 = new TableField(nameof (JobTenantTel1), TableField.FieldType.Text, "Tenant Tel 1", false, (object) "");
      this._JobTenantTel2 = new TableField(nameof (JobTenantTel2), TableField.FieldType.Text, "Tenant Tel 2", false, (object) "");
      this._JobTenantCell = new TableField(nameof (JobTenantCell), TableField.FieldType.Text, "Tenant Cell", false, (object) "");
      this._ProblemAddress = new TableField(nameof (ProblemAddress), TableField.FieldType.Text, "Address of problem", false, (object) "");
      this._SystemUserID = new TableField(nameof (SystemUserID), TableField.FieldType.Number, "User", true, (object) "");
      this._JobNote = new TableField(nameof (JobNote), TableField.FieldType.Text, "Notes", false, (object) "");
      this._JobTeam = new TableField(nameof (JobTeam), TableField.FieldType.Text, "Team", false, (object) "");
      this._ProblemDetail = new DataGridView();
      this._Timesheet = new DataGridView();
      this._Travel = new DataGridView();
      this._CustomerName = new TableField("CustomerName", TableField.FieldType.Text, "Customer", false, (object) "");
      this._UserName = new TableField("SystemUserName", TableField.FieldType.Text, "Logged by", false, (object) "");
      DALGeneral.myConn = DALConnection;
      DALGeneral.sql = new DataAccess(DALConnection);
    }

    public enum CompletedListType
    {
      Today,
      Week,
      Month,
      All,
    }
  }
}
