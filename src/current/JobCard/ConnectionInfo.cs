// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.Core.ConnectionInfo
// Assembly: JobCard, Version=1.0.0.2, Culture=neutral, PublicKeyToken=null
// MVID: 355A629F-A2FA-4599-879B-59162A296DD0
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCard.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Reytec.Data.Connection;
using System;
using System.IO;

namespace Reytec.JobCard.Core
{
  [StandardModule]
  public sealed class ConnectionInfo
  {
    public static string ConnectionFile = "Default.jcc";
    public static DataConnection GlobalConnection = new DataConnection(ConnectionInfo.GetServerName(), ConnectionInfo.GetDatabaseName(), DataConnection.ProviderType.SQL);
    public const string AutoOpenfile = "Default.jcc";

    public static void RefreshConnection()
    {
      ConnectionInfo.GlobalConnection = new DataConnection(ConnectionInfo.GetServerName(), ConnectionInfo.GetDatabaseName(), DataConnection.ProviderType.SQL);
    }

    public static void CloseConnection()
    {
      ConnectionInfo.GlobalConnection = (DataConnection) null;
      ConnectionInfo.ConnectionFile = "Default.jcc";
    }

    public static string GetServerName()
    {
      string str = null;
      try
      {
        str = Strings.Split(File.ReadAllText(ConnectionInfo.ConnectionFile), "\r\n", -1, CompareMethod.Binary)[1];
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return str;
    }

    public static string GetDatabaseName()
    {
      string str = default(string);
      try
      {
        str = Strings.Split(File.ReadAllText(ConnectionInfo.ConnectionFile), "\r\n", -1, CompareMethod.Binary)[2];
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return str;
    }

    public static string GetUser()
    {
      return "sa";
    }

    public static string GetPassword()
    {
      return "zsa";
    }
  }
}
