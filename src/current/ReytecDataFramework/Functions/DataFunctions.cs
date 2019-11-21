// Decompiled with JetBrains decompiler
// Type: Reytec.Data.Functions.DataFunctions
// Assembly: ReytecDataFramework, Version=1.0.3388.24262, Culture=neutral, PublicKeyToken=null
// MVID: C6FC685A-05C5-46DC-AD97-080BB8BD92A6
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\ReytecDataFramework.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Reytec.Data.Attributes;
using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Reytec.Data.Functions
{
    public class DataFunctions
    {
        [DebuggerNonUserCode]
        public DataFunctions()
        {
        }

        public static string DBNullToBlank(object value)
        {
            if (RuntimeHelpers.GetObjectValue(value) == null)
                return "";
            return value.ToString();
        }

        public static int ParseBoolean(bool value)
        {
            return value ? 1 : 0;
        }

        public static DataSet ParseNulls(DataSet ds)
        {
            int num1 = checked(ds.Tables[0].Rows.Count - 1);
            int index1 = 0;
            while (index1 <= num1)
            {
                int num2 = checked(ds.Tables[0].Columns.Count - 1);
                int index2 = 0;
                while (index2 <= num2)
                {
                    try
                    {
#if NET471
                        ds.Tables[0].AsEnumerable().ElementAtOrDefault<DataRow>(index1)[index2] = (object)DataFunctions.DBNullToBlank(RuntimeHelpers.GetObjectValue(ds.Tables[0].AsEnumerable().ElementAtOrDefault<DataRow>(index1)[index2]));
#endif
                    }
                    catch (Exception ex)
                    {
                       // ProjectData.SetProjectError(ex);
                       // ProjectData.ClearProjectError();
                    }
                    checked { ++index2; }
                }
                checked { ++index1; }
            }
            return ds;
        }

        public static bool ValidateBlanks(Collection Fields)
        {
            int count = Fields.Count;
            int index = 1;
            while (index <= count)
            {
                TableField field = (TableField)Fields[index];
                if ((field.FieldDataType == (object)TableField.FieldType.Text ||
                    field.FieldDataType == (object)TableField.FieldType.ProtectedText ||
                    field.FieldDataType == (object)TableField.FieldType.LongText) &&
                    field.Value == null)
                {
#if NET472
                    int num = (int)Interaction.MsgBox(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(field.FieldTitle, (object)" is a required field."), MsgBoxStyle.Critical, (object)"Required");
#endif
                    return false;
                }
                checked { ++index; }
            }
            return true;
        }
    }
}
