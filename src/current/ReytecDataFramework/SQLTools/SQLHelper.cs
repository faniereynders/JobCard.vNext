// Decompiled with JetBrains decompiler
// Type: Reytec.Data.SQLTools.SQLHelper
// Assembly: ReytecDataFramework, Version=1.0.3388.24262, Culture=neutral, PublicKeyToken=null
// MVID: C6FC685A-05C5-46DC-AD97-080BB8BD92A6
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\ReytecDataFramework.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Reytec.Data.Attributes;
using Reytec.Security.Cryptography;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Reytec.Data.SQLTools
{
  public class SQLHelper
  {
    [DebuggerNonUserCode]
    public SQLHelper()
    {
    }

    public string valSQLValue(TableField field)
    {
      object fieldDataType = field.FieldDataType;
      if (Conversions.ToBoolean(Conversions.ToBoolean(Operators.CompareObjectEqual(fieldDataType, (object) TableField.FieldType.LongText, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(fieldDataType, (object) TableField.FieldType.ProtectedText, false)) || (Conversions.ToBoolean(Operators.CompareObjectEqual(fieldDataType, (object) TableField.FieldType.Text, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(fieldDataType, (object) TableField.FieldType.DateTime, false))) ? (object) true : (object) false))
        return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object) "'", field.Value), (object) "'"));
     // if (Conversions.ToBoolean(Conversions.ToBoolean(Operators.CompareObjectEqual(fieldDataType, (object) TableField.FieldType.DecimalNumber, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(fieldDataType, (object) TableField.FieldType.Number, false)) ? (object) true : (object) false))
     //   return Conversions.ToString(Interaction.IIf(Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(field.Value)), RuntimeHelpers.GetObjectValue(field.Value), (object) 0));
    //  if (Operators.ConditionalCompareObjectEqual(fieldDataType, (object) TableField.FieldType.YesNo, false))
    //    return Conversions.ToString(Interaction.IIf(Conversions.ToBoolean(field.Value), (object) 1, (object) 0));
      return Conversions.ToString(field.Value);
    }

    public string SelectStatement(
      string _TableName,
      Collection _Fields = null,
      string SpecialConditions = "",
      string OrderBy = "")
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendLine("SELECT ");
      if (_Fields != null)
      {
        int count = _Fields.Count;
        int num = count;
        int index = 1;
        while (index <= num)
        {
          stringBuilder.Append(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateGet(_Fields[index], (Type) null, "FieldName", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) " as '"), NewLateBinding.LateGet(_Fields[index], (Type) null, "FieldTitle", new object[0], (string[]) null, (Type[]) null, (bool[]) null)), (object) "'"));
          if (index != count)
            stringBuilder.Append(",");
          checked { ++index; }
        }
      }
      else
        stringBuilder.AppendLine(" * ");
      stringBuilder.AppendLine("FROM " + _TableName);
      if (Operators.CompareString(SpecialConditions, "", false) != 0)
        stringBuilder.AppendLine("WHERE " + SpecialConditions);
      if (Operators.CompareString(OrderBy, "", false) != 0)
        stringBuilder.AppendLine(" ORDER BY " + OrderBy);
      return stringBuilder.ToString();
    }

    public string InsertStatement(string _TableName, Collection _Fields)
    {
      StringBuilder stringBuilder = new StringBuilder();
      int count1 = _Fields.Count;
      stringBuilder.AppendLine("INSERT INTO " + _TableName);
      stringBuilder.AppendLine("(");
      int num1 = count1;
      int index1 = 1;
      while (index1 <= num1)
      {
        if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(_Fields[index1], (Type) null, "FieldDataType", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) 0, false))))
        {
          stringBuilder.Append(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(_Fields[index1], (Type) null, "FieldName", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
          if (index1 != count1)
            stringBuilder.Append(",");
        }
        checked { ++index1; }
      }
      stringBuilder.Append(")");
      stringBuilder.AppendLine("VALUES");
      stringBuilder.AppendLine("(");
      int count2 = _Fields.Count;
      int num2 = count2;
      int index2 = 1;
      while (index2 <= num2)
      {
        if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(_Fields[index2], (Type) null, "FieldDataType", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) TableField.FieldType.ProtectedText, false))
          NewLateBinding.LateSetComplex(_Fields[index2], (Type) null, "Value", new object[1]
          {
            (object) StringCrypography.EncryptString(Conversions.ToString(NewLateBinding.LateGet(_Fields[index2], (Type) null, "Value", new object[0], (string[]) null, (Type[]) null, (bool[]) null)))
          }, (string[]) null, (Type[]) null, false, true);
        if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(_Fields[index2], (Type) null, "FieldDataType", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) 0, false))))
        {
          stringBuilder.Append(this.valSQLValue((TableField) _Fields[index2]));
          if (index2 != count2)
            stringBuilder.Append(",");
        }
        checked { ++index2; }
      }
      stringBuilder.Append(")");
      return stringBuilder.ToString();
    }

    public string UpdateStatement(string _TableName, Collection _Fields, string SpecialConditions = "")
    {
      StringBuilder stringBuilder = new StringBuilder();
      if (Operators.CompareString(SpecialConditions, "", false) == 0)
        SpecialConditions = (string) null;
      int count = _Fields.Count;
      stringBuilder.AppendLine("UPDATE " + _TableName);
      stringBuilder.AppendLine("SET");
      stringBuilder.AppendLine();
      int num = count;
      int index = 1;
      while (index <= num)
      {
        if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(_Fields[index], (Type) null, "FieldDataType", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) TableField.FieldType.ProtectedText, false))
          NewLateBinding.LateSetComplex(_Fields[index], (Type) null, "Value", new object[1]
          {
            (object) StringCrypography.EncryptString(Conversions.ToString(NewLateBinding.LateGet(_Fields[index], (Type) null, "value", new object[0], (string[]) null, (Type[]) null, (bool[]) null)))
          }, (string[]) null, (Type[]) null, false, true);
        if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(_Fields[index], (Type) null, "FieldDataType", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) 0, false))))
        {
          stringBuilder.Append(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateGet(_Fields[index], (Type) null, "FieldName", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) "="), (object) this.valSQLValue((TableField) _Fields[index])));
          if (index != count)
            stringBuilder.Append(",");
        }
        checked { ++index; }
      }
      if (SpecialConditions != null)
      {
        stringBuilder.AppendLine(" WHERE ");
        stringBuilder.AppendLine("(" + SpecialConditions + ")");
      }
      return stringBuilder.ToString();
    }

    public string DeleteStatement(string _TableName, Collection _Fields, string SpecialConditions = "")
    {
      StringBuilder stringBuilder = new StringBuilder();
      if (Operators.CompareString(SpecialConditions, "", false) == 0)
        SpecialConditions = (string) null;
      stringBuilder.AppendLine("DELETE FROM " + _TableName);
      if (SpecialConditions != null)
      {
        stringBuilder.AppendLine("WHERE ");
        stringBuilder.AppendLine("(" + SpecialConditions + ")");
      }
      stringBuilder.Append(" ");
      return stringBuilder.ToString();
    }
  }
}
