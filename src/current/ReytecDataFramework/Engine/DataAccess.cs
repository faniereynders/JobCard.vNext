// Decompiled with JetBrains decompiler
// Type: Reytec.Data.Engine.DataAccess
// Assembly: ReytecDataFramework, Version=1.0.3388.24262, Culture=neutral, PublicKeyToken=null
// MVID: C6FC685A-05C5-46DC-AD97-080BB8BD92A6
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\ReytecDataFramework.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
//using Microsoft.VisualBasic.CompilerServices;
using Reytec.Data.Connection;
using Reytec.Data.Functions;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace Reytec.Data.Engine
{
  public class DataAccess
  {
    private DataConnection myConnection;
    private int DataSet_TO;
    private int Execute_TO;
    private string ConnString;
    public SqlConnection conn;

    public int DataSet_TimeOut
    {
      get
      {
        return this.DataSet_TO;
      }
      set
      {
        this.DataSet_TO = value;
      }
    }

    public int Execute_TimeOut
    {
      get
      {
        return this.Execute_TO;
      }
      set
      {
        this.Execute_TO = value;
      }
    }

    public void CloseConnection()
    {
    }

    public DataSet GetDataset(string SQLStr)
    {
      this.conn = new SqlConnection();
            NewLateBinding.LateSet(this.conn, (Type)null, "ConnectionString", new object[1]
            {
        RuntimeHelpers.GetObjectValue(this.myConnection.ConnectionString)
            }, (string[])null, (Type[])null);
            DataSet dataSet = new DataSet();
      SqlCommand selectCommand = new SqlCommand(SQLStr, (SqlConnection) this.conn);
      SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
      try
      {
        selectCommand.CommandTimeout = this.DataSet_TO;
        //NewLateBinding.LateCall(this.conn, (Type) null, "Open", new object[0], (string[]) null, (Type[]) null, (bool[]) null, true);
        sqlDataAdapter.Fill(dataSet);
        return DataFunctions.ParseNulls(dataSet);
      }
      catch (Exception ex)
      {
        //ProjectData.SetProjectError(ex);
        throw ex;
      }
      finally
      {
        //NewLateBinding.LateCall(this.conn, (Type) null, "Close", new object[0], (string[]) null, (Type[]) null, (bool[]) null, true);
      }
    }

    public bool ExecuteTransactions(Collection StatementCollection)
    {
      SqlConnection sqlConnection = new SqlConnection();
      SqlCommand sqlCommand = new SqlCommand();
      sqlConnection.ConnectionString = this.myConnection.ConnectionString.ToString();
      sqlCommand.Connection = sqlConnection;
      sqlCommand.CommandTimeout = this.DataSet_TO;
      sqlConnection.Open();
      SqlTransaction sqlTransaction = sqlCommand.Connection.BeginTransaction();
      bool flag;
      try
      {
        sqlCommand.Transaction = sqlTransaction;
        int count = StatementCollection.Count;
        int index = 1;
        while (index <= count)
        {
          sqlCommand.CommandText = StatementCollection[index].ToString();
          sqlCommand.ExecuteNonQuery();
          checked { ++index; }
        }
        sqlTransaction.Commit();
        flag = true;
      }
      catch (Exception ex)
      {
        //ProjectData.SetProjectError(ex);
        sqlTransaction.Rollback();
        flag = false;
        //ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection.Close();
      }
      return flag;
    }

    public bool Execute(string SQLStr)
    {
      SqlConnection connection = new SqlConnection();
      DataSet dataSet = new DataSet();
      SqlCommand sqlCommand = new SqlCommand(SQLStr, connection);
      bool flag;
      try
      {
        sqlCommand.CommandTimeout = this.DataSet_TO;
        connection.ConnectionString = this.myConnection.ConnectionString.ToString();
        connection.Open();
        sqlCommand.ExecuteNonQuery();
        flag = true;
      }
      catch (Exception ex)
      {
        //ProjectData.SetProjectError(ex);
        flag = false;
        //ProjectData.ClearProjectError();
      }
      finally
      {
        connection.Close();
      }
      return flag;
    }

    public string GetScalar(string SQLStr)
    {
      SqlConnection connection = new SqlConnection();
      SqlCommand sqlCommand = new SqlCommand(SQLStr, connection);
      try
      {
        connection.ConnectionString = this.myConnection.ConnectionString.ToString();
        sqlCommand.CommandTimeout = this.DataSet_TO;
        connection.Open();
        return DataAccess.DBNullToBlank(RuntimeHelpers.GetObjectValue(sqlCommand.ExecuteScalar()));
      }
      catch (Exception ex)
      {
        //ProjectData.SetProjectError(ex);
        throw ex;
      }
      finally
      {
        connection.Close();
      }
    }

    public static string DBNullToBlank(object value)
    {
      string str;
      try
      {
        return value.ToString();
      }
      catch (Exception ex)
      {
       // ProjectData.SetProjectError(ex);
        str = "";
       // ProjectData.ClearProjectError();
      }
      return str;
    }

    public int SaveDocumentToDB(
      int OrderID,
      int UserType,
      int DocumentType,
      string DocumentTitle,
      string MIMEType,
      byte[] ImageBytes)
    {
      int integer;
            using (SqlConnection connection = new SqlConnection(this.conn.ToString()))
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO [OrderTrackingDocuments] (OrderID, UserType, DocumentType, DocumentTitle, [MIMEType], [ImageBytes], [DateAdded]) VALUES (@OrderID, @UserType, @DocumentType, @DocumentTitle, @MIMEType, @ImageBytes, @DateAdded)", connection);
                sqlCommand.Parameters.AddWithValue("@OrderID", (object)OrderID);
                sqlCommand.Parameters.AddWithValue("@UserType", (object)UserType);
                sqlCommand.Parameters.AddWithValue("@DocumentType", (object)DocumentType);
                sqlCommand.Parameters.AddWithValue("@DocumentTitle", (object)DocumentTitle);
                sqlCommand.Parameters.AddWithValue("@MIMEType", (object)MIMEType);
                sqlCommand.Parameters.AddWithValue("@DateAdded", (object)DateTime.Now);
                sqlCommand.Parameters.AddWithValue("@ImageBytes", (object)ImageBytes);
                connection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                integer = Convert.ToInt32(new SqlCommand()
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = "SELECT IDENT_CURRENT('[dbo].[OrderTrackingDocuments]')"
                }.ExecuteScalar());
                connection.Close();
            }
      return integer;
    }

    public bool ReadDocumentFromDB(int ImageID, ref string MIMEType, ref byte[] ImageBytes)
    {
      bool flag = false;
            using (SqlConnection connection = new SqlConnection(this.conn.ToString()))
            {
        SqlCommand sqlCommand = new SqlCommand("SELECT [MIMEType], [ImageBytes] FROM [OrderTrackingDocuments] WHERE [ImageID] = @ImageID", connection);
        sqlCommand.Parameters.AddWithValue("@ImageID", (object) ImageID);
        connection.Open();
        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        if (sqlDataReader.Read())
        {
          MIMEType = sqlDataReader[nameof (MIMEType)].ToString();
          ImageBytes = (byte[]) sqlDataReader[nameof (ImageBytes)];
          flag = true;
        }
        sqlDataReader.Close();
        connection.Close();
      }
      return flag;
    }

    public bool ReadImageFromDB(
      string SQL,
      string Fld,
      ref string MIMEType,
      ref byte[] ImageBytes)
    {
      bool flag = false;
            using (SqlConnection connection = new SqlConnection(this.conn.ConnectionString))
            {
        connection.Open();
        SqlDataReader sqlDataReader = new SqlCommand(SQL, connection).ExecuteReader();
        if (sqlDataReader.Read())
        {
          MIMEType = sqlDataReader[nameof (MIMEType)].ToString();
          if (sqlDataReader[Fld] != DBNull.Value)
          {
            ImageBytes = (byte[]) sqlDataReader[Fld];
            flag = true;
          }
        }
        sqlDataReader.Close();
        connection.Close();
        return flag;
      }
    }

    public bool ReadDocFromDB(string SQL, string Fld, ref byte[] ImageBytes)
    {
      bool flag = false;
            using (SqlConnection connection = new SqlConnection(this.conn.ToString()))
            {
        connection.Open();
        SqlDataReader sqlDataReader = new SqlCommand(SQL, connection).ExecuteReader();
        if (sqlDataReader.Read() && sqlDataReader[Fld] != DBNull.Value)
        {
          ImageBytes = (byte[]) sqlDataReader[Fld];
          flag = true;
        }
        sqlDataReader.Close();
        connection.Close();
        return flag;
      }
    }

    public bool SaveImageToDB(
      string Tbl,
      string strKeyField,
      string strKeyValue,
      string ImageFld,
      ref string MIMEType,
      ref byte[] ImageBytes)
    {
      bool flag;
            using (SqlConnection connection = new SqlConnection(this.conn.ToString()))
            {
        SqlCommand sqlCommand = new SqlCommand("Update [" + Tbl + "] SET [MIMEType]=@MIMEType, [" + ImageFld + "]=@ImageBytes WHERE " + strKeyField + " = " + strKeyValue, connection);
        try
        {
          sqlCommand.Parameters.AddWithValue("@MIMEType", (object) MIMEType);
          sqlCommand.Parameters.AddWithValue("@ImageBytes", (object) ImageBytes);
          connection.Open();
          sqlCommand.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
         // ProjectData.SetProjectError(ex);
          flag = false;
        //  ProjectData.ClearProjectError();
          goto label_9;
        }
        finally
        {
          sqlCommand.Dispose();
          connection.Close();
        }
        flag = true;
      }
label_9:
      return flag;
    }

    public bool SaveDocToDB(
      string Tbl,
      string strKeyField,
      string strKeyValue,
      string ImageFld,
      ref byte[] ImageBytes)
    {
      bool flag;
            using (SqlConnection connection = new SqlConnection(this.conn.ToString()))
            {
        SqlCommand sqlCommand = new SqlCommand("Update [" + Tbl + "] SET [" + ImageFld + "]=@ImageBytes WHERE " + strKeyField + " = " + strKeyValue, connection);
        try
        {
          sqlCommand.Parameters.AddWithValue("@ImageBytes", (object) ImageBytes);
          connection.Open();
          sqlCommand.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
       //   ProjectData.SetProjectError(ex);
          flag = false;
       //   ProjectData.ClearProjectError();
          goto label_9;
        }
        finally
        {
          sqlCommand.Dispose();
          connection.Close();
        }
        flag = true;
      }
label_9:
      return flag;
    }

    ~DataAccess()
    {
      // ISSUE: explicit finalizer call
      //base.Finalize();
    }

    public DataAccess(DataConnection dbConn)
    {
      this.DataSet_TO = 120;
      this.Execute_TO = 120;
      this.myConnection = dbConn;
    }
  }
}
