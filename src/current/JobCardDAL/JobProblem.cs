// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.DAL.JobProblem
// Assembly: JobCardDAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87AA1E8D-4FC8-49A0-84FD-8A245003C90A
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCardDAL.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Reytec.Data.Attributes;
using Reytec.Data.Connection;
using Reytec.Data.Engine;
using Reytec.Data.Functions;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Reytec.JobCard.DAL
{
  public class JobProblem
  {
    private const string TableName = "JobProblemDetail";
    private TableField _ID;
    private TableField _JobID;
    private TableField _ProblemDescription;
    private TableField _ProblemFeedback;

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

    public object ProblemDescription
    {
      get
      {
        return this._ProblemDescription.Value;
      }
      set
      {
        this._ProblemDescription.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object ProblemFeedback
    {
      get
      {
        return this._ProblemFeedback.Value;
      }
      set
      {
        this._ProblemFeedback.Value = RuntimeHelpers.GetObjectValue(value);
      }
    }

    private Collection AllFields()
    {
      Collection collection = new Collection();
      collection.Clear();
      collection.Add((object) this._ID, (string) null, (object) null, (object) null);
      collection.Add((object) this._JobID, (string) null, (object) null, (object) null);
      collection.Add((object) this._ProblemDescription, (string) null, (object) null, (object) null);
      collection.Add((object) this._ProblemFeedback, (string) null, (object) null, (object) null);
      return collection;
    }

    public bool Update(object RowID)
    {
      if (!DataFunctions.ValidateBlanks(this.AllFields()))
        return false;
      DALGeneral._StatementCollection.Clear();
      this._ID.Value = RuntimeHelpers.GetObjectValue(RowID);
      DALGeneral._Fields = this.AllFields();
      DALGeneral._PK = (object) this._ID;
      DALGeneral._StatementCollection.Add((object) DALGeneral.hlp.UpdateStatement("JobProblemDetail", DALGeneral._Fields, Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(NewLateBinding.LateGet(DALGeneral._PK, (System.Type) null, "FieldName", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) " = "), RowID))), (string) null, (object) null, (object) null);
      return DALGeneral.sql.ExecuteTransactions(DALGeneral._StatementCollection);
    }

    public bool Delete(object RowID)
    {
      DALGeneral._StatementCollection.Clear();
      this._ID.Value = RuntimeHelpers.GetObjectValue(RowID);
      DALGeneral._Fields = this.AllFields();
      DALGeneral._PK = (object) this._ID;
      DALGeneral._StatementCollection.Add((object) DALGeneral.hlp.DeleteStatement("JobProblemDetail", DALGeneral._Fields, Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(NewLateBinding.LateGet(DALGeneral._PK, (System.Type) null, "FieldName", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "="), RowID))), (string) null, (object) null, (object) null);
      return DALGeneral.sql.ExecuteTransactions(DALGeneral._StatementCollection);
    }

    public bool Add()
    {
      DALGeneral._StatementCollection.Clear();
      DALGeneral._Fields = this.AllFields();
      DALGeneral._StatementCollection.Add((object) DALGeneral.hlp.InsertStatement("JobProblemDetail", DALGeneral._Fields), (string) null, (object) null, (object) null);
      return DALGeneral.sql.ExecuteTransactions(DALGeneral._StatementCollection);
    }

    public bool GetOne(object RowID)
    {
      DALGeneral._StatementCollection.Clear();
      this._ID.Value = RuntimeHelpers.GetObjectValue(RowID);
      DALGeneral._Fields = this.AllFields();
      DALGeneral._PK = (object) this._ID;
      DataTable table = DALGeneral.sql.GetDataset(DALGeneral.hlp.SelectStatement("JobProblemDetail", DALGeneral._Fields, Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(NewLateBinding.LateGet(DALGeneral._PK, (System.Type) null, "FieldName", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "="), RowID)), "")).Tables[0];
      if (table.Rows.Count <= 0)
        return false;
      DALGeneral.SetFieldValues(table);
      return true;
    }

    public DataTable GetAll()
    {
      DALGeneral._Fields = this.AllFields();
      return DALGeneral.sql.GetDataset(DALGeneral.hlp.SelectStatement("JobProblemDetail", DALGeneral._Fields, "", "")).Tables[0];
    }

    public DataGridView GetAllForJob(DataGridView grd, int JobID)
    {
      DALGeneral._Fields = this.AllFields();
      grd.DataSource = (object) DALGeneral.sql.GetDataset(DALGeneral.hlp.SelectStatement("JobProblemDetail", DALGeneral._Fields, Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(this._JobID.FieldName, (object) " = "), (object) JobID)), "")).Tables[0];
      return grd;
    }

    public JobProblem(DataConnection DALConnection)
    {
      this._ID = new TableField(nameof (ID), TableField.FieldType.AutoNumber, nameof (ID), true, (object) "");
      this._JobID = new TableField(nameof (JobID), TableField.FieldType.Number, nameof (JobID), true, (object) "");
      this._ProblemDescription = new TableField(nameof (ProblemDescription), TableField.FieldType.Text, "Problem", false, (object) "");
      this._ProblemFeedback = new TableField(nameof (ProblemFeedback), TableField.FieldType.Text, "Feedback", false, (object) "");
      DALGeneral.myConn = DALConnection;
      DALGeneral.sql = new DataAccess(DALConnection);
    }
  }
}
