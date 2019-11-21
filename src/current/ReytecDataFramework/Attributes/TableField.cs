// Decompiled with JetBrains decompiler
// Type: Reytec.Data.Attributes.TableField
// Assembly: ReytecDataFramework, Version=1.0.3388.24262, Culture=neutral, PublicKeyToken=null
// MVID: C6FC685A-05C5-46DC-AD97-080BB8BD92A6
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\ReytecDataFramework.dll

//using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;

namespace Reytec.Data.Attributes
{
  public class TableField
  {
    private bool _checkBlank;
    private object _ControlBound;
    private string _FieldTitle;
    private string _FieldName;
    private object _FieldValue;
    private TableField.FieldType _FieldType;

    public object FieldName
    {
      get
      {
        return (object) this._FieldName;
      }
    }

    public object ControlBound
    {
      get
      {
        return this._ControlBound;
      }
      set
      {
        this._ControlBound = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public bool checkBlank
    {
      get
      {
        return this._checkBlank;
      }
      set
      {
        this._checkBlank = value;
      }
    }

    public object Value
    {
      get
      {
        return this._FieldValue;
      }
      set
      {
        this._FieldValue = RuntimeHelpers.GetObjectValue(value);
      }
    }

    public object FieldDataType
    {
      get
      {
        return (object) this._FieldType;
      }
      set
      {
        this._FieldType = (TableField.FieldType) Convert.ToInt32(value);
      }
    }

    public object FieldTitle
    {
      get
      {
        return (object) this._FieldTitle;
      }
      set
      {
        this._FieldTitle = Convert.ToString(value);
      }
    }

    public TableField(
      string _Name,
      TableField.FieldType _DataType,
      string _Title = "",
      bool CheckBlanks = false,
      object _DefaultValue = default(object))
    {
      this._checkBlank = CheckBlanks;
      this._FieldName = _Name;
      this._FieldType = _DataType;
      this._FieldValue = RuntimeHelpers.GetObjectValue(_DefaultValue);
      if (string.IsNullOrWhiteSpace(_Title))
        this._FieldTitle = this._FieldName;
      else
        this._FieldTitle = _Title;
    }

    public enum FieldType
    {
      AutoNumber,
      Text,
      ProtectedText,
      LongText,
      Number,
      DecimalNumber,
      DateTime,
      Binary,
      YesNo,
    }
  }
}
