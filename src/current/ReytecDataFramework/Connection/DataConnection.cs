// Decompiled with JetBrains decompiler
// Type: Reytec.Data.Connection.DataConnection
// Assembly: ReytecDataFramework, Version=1.0.3388.24262, Culture=neutral, PublicKeyToken=null
// MVID: C6FC685A-05C5-46DC-AD97-080BB8BD92A6
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\ReytecDataFramework.dll

//using Microsoft.VisualBasic.CompilerServices;

using System;

namespace Reytec.Data.Connection
{
  public class DataConnection
  {
    public string DataSourceName;
    public string DatabaseName;
    public string Username;
    public string Password;
    public string _ConnectionString;
    public string _ProviderName;

    public object ConnectionString
    {
      get
      {
        return (object) this._ConnectionString;
      }
      set
      {
        this._ConnectionString = Convert.ToString(value);
      }
    }

    private void SetProvider(DataConnection.ProviderType DataProviderType)
    {
      switch (DataProviderType)
      {
        case DataConnection.ProviderType.SQL:
          this._ProviderName = "System.Data.SqlClient";
          break;
        case DataConnection.ProviderType.ODBC:
          this._ProviderName = "System.Data.Odbc";
          break;
        case DataConnection.ProviderType.OLEDB:
          this._ProviderName = "System.Data.OleDb";
          break;
      }
    }

        public DataConnection(
          string DALDataSourceName,
          string DALDatabaseName,
          string DALUserName,
          string DALPassword,
          DataConnection.ProviderType DataProvider = DataConnection.ProviderType.SQL)
        {
            this.DataSourceName = "";
            this.DatabaseName = "";
            this.Username = "";
            this.Password = "";
            this._ConnectionString = "";
            this._ProviderName = "System.Data.SqlClient";
            this.DataSourceName = DALDataSourceName;
            this.DatabaseName = DALDatabaseName;
            this.Username = DALUserName;
            this.Password = DALPassword;
            this.ConnectionString = (object)("Data Source=" + this.DataSourceName + ";Initial Catalog=" + this.DatabaseName + ";Persist Security Info=True;User ID=" + this.Username + ";Pwd=" + this.Password + ";MultipleActiveResultSets=True");
        }

        public DataConnection(
      string DALDataSourceName,
      string DALDatabaseName,
      DataConnection.ProviderType DataProvider = DataConnection.ProviderType.SQL)
        {
            this.DataSourceName = "";
            this.DatabaseName = "";
            this.Username = "";
            this.Password = "";
            this._ConnectionString = "";
            this._ProviderName = "System.Data.SqlClient";
            this.DataSourceName = DALDataSourceName;
            this.DatabaseName = DALDatabaseName;
            this.ConnectionString = (object)("Data Source=" + this.DataSourceName + ";Initial Catalog=" + this.DatabaseName + ";Persist Security Info=True;Trusted_Connection=True;MultipleActiveResultSets=True");
        }

        ~DataConnection()
    {
      // ISSUE: explicit finalizer call
      //base.Finalize();
    }

    public enum ProviderType
    {
      SQL,
      ODBC,
      OLEDB,
    }
  }
}
