// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.DAL.JobCardCompany
// Assembly: JobCardDAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87AA1E8D-4FC8-49A0-84FD-8A245003C90A
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCardDAL.dll

using Jobcard.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Reytec.Data.Attributes;
using Reytec.Data.Connection;
using Reytec.Data.Engine;
using Reytec.Data.Functions;
//using Reytec.JobCard.DAL.My;
using Reytec.JobCard.Functions.GUITransformation;
using Reytec.Security.Cryptography;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace Reytec.JobCard.DAL
{
    public class JobCardCompany
    {
        private const string TableName = "CompanyInfo";
        private TableField _ID;
        private TableField _CompanyName;
        private TableField _TradingAs;
        private TableField _BranchName;
        private TableField _PostalAddress;
        private TableField _ResidentialAddress;
        private TableField _Tel1;
        private TableField _Tel2;
        private TableField _Cell1;
        private TableField _Cell2;
        private TableField _Fax;
        private TableField _VATNr;
        private TableField _RegistrationNr;
        private TableField _JobCardNrPrefix;
        private TableField _Logo;
        private TableField _MIMEType;
        private TableField _NextNumber;
        private string _ServerName;
        private string _DatabaseName;
        private string _FileName;
        private string CurrentDir;
        private string CompanyFileName;
        private const string DBUsr = "sa";
        private const string DBPwd = "zsa";
        public const string AutoOpenfile = "Default.jcc";
        private readonly ICompanyConnectionRepository companyConnectionRepository;

        public object CompanyID
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

        public object NextNumber
        {
            get
            {
                return this._NextNumber.Value;
            }
            set
            {
                this._NextNumber.Value = RuntimeHelpers.GetObjectValue(value);
            }
        }

        public object CompanyName
        {
            get
            {
                return this._CompanyName.Value;
            }
            set
            {
                this._CompanyName.Value = RuntimeHelpers.GetObjectValue(value);
            }
        }

        public object TradingAs
        {
            get
            {
                return this._TradingAs.Value;
            }
            set
            {
                this._TradingAs.Value = RuntimeHelpers.GetObjectValue(value);
            }
        }

        public object BranchName
        {
            get
            {
                return this._BranchName.Value;
            }
            set
            {
                this._BranchName.Value = RuntimeHelpers.GetObjectValue(value);
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

        public object Cell1
        {
            get
            {
                return this._Cell1.Value;
            }
            set
            {
                this._Cell1.Value = RuntimeHelpers.GetObjectValue(value);
            }
        }

        public object Cell2
        {
            get
            {
                return this._Cell2.Value;
            }
            set
            {
                this._Cell2.Value = RuntimeHelpers.GetObjectValue(value);
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
                return this._RegistrationNr.Value;
            }
            set
            {
                this._RegistrationNr.Value = RuntimeHelpers.GetObjectValue(value);
            }
        }

        public object JobCardNrPrefix
        {
            get
            {
                System.Type Type = typeof(Strings);
                object[] objArray1 = new object[1];
                object[] objArray2 = objArray1;
                TableField jobCardNrPrefix = this._JobCardNrPrefix;
                object objectValue = RuntimeHelpers.GetObjectValue(jobCardNrPrefix.Value);
                objArray2[0] = objectValue;
                object[] objArray3 = objArray1;
                object[] Arguments = objArray3;
                bool[] flagArray = new bool[1] { true };
                bool[] CopyBack = flagArray;
                object obj = NewLateBinding.LateGet((object)null, Type, "UCase", Arguments, (string[])null, (System.Type[])null, CopyBack);
                if (!flagArray[0])
                    return obj;
                jobCardNrPrefix.Value = RuntimeHelpers.GetObjectValue(objArray3[0]);
                return obj;
            }
            set
            {
                TableField jobCardNrPrefix = this._JobCardNrPrefix;
                System.Type Type = typeof(Strings);
                object[] objArray = new object[1]
                {
          RuntimeHelpers.GetObjectValue(value)
                };
                object[] Arguments = objArray;
                bool[] flagArray = new bool[1] { true };
                bool[] CopyBack = flagArray;
                object obj = NewLateBinding.LateGet((object)null, Type, "UCase", Arguments, (string[])null, (System.Type[])null, CopyBack);
                if (flagArray[0])
                    value = RuntimeHelpers.GetObjectValue(objArray[0]);
                object objectValue = RuntimeHelpers.GetObjectValue(obj);
                jobCardNrPrefix.Value = objectValue;
            }
        }

        public object Logo
        {
            get
            {
                return (object)this._Logo;
            }
            set
            {
                this._Logo = (TableField)value;
            }
        }

        public object MIMEType
        {
            get
            {
                return this._MIMEType.Value;
            }
            set
            {
                this._MIMEType.Value = RuntimeHelpers.GetObjectValue(value);
            }
        }

        public string ServerName
        {
            get
            {
                return this._ServerName;
            }
            set
            {
                this._ServerName = value;
            }
        }

        public string DatabaseName
        {
            get
            {
                return this._DatabaseName;
            }
            set
            {
                this._DatabaseName = value;
            }
        }

        public string FileName
        {
            get
            {
                return this._FileName;
            }
            set
            {
                this._FileName = value;
            }
        }

        private Collection AllFields()
        {
            Collection collection = new Collection();
            collection.Clear();
            collection.Add((object)this._ID, (string)null, (object)null, (object)null);
            collection.Add((object)this._CompanyName, (string)null, (object)null, (object)null);
            collection.Add((object)this._TradingAs, (string)null, (object)null, (object)null);
            collection.Add((object)this._BranchName, (string)null, (object)null, (object)null);
            collection.Add((object)this._PostalAddress, (string)null, (object)null, (object)null);
            collection.Add((object)this._ResidentialAddress, (string)null, (object)null, (object)null);
            collection.Add((object)this._Tel1, (string)null, (object)null, (object)null);
            collection.Add((object)this._Tel2, (string)null, (object)null, (object)null);
            collection.Add((object)this._Cell1, (string)null, (object)null, (object)null);
            collection.Add((object)this._Cell2, (string)null, (object)null, (object)null);
            collection.Add((object)this._Fax, (string)null, (object)null, (object)null);
            collection.Add((object)this._VATNr, (string)null, (object)null, (object)null);
            collection.Add((object)this._RegistrationNr, (string)null, (object)null, (object)null);
            collection.Add((object)this._JobCardNrPrefix, (string)null, (object)null, (object)null);
            collection.Add((object)this._NextNumber, (string)null, (object)null, (object)null);
            return collection;
        }

        public ListView ListCompanies(ListView lst)
        {

            lst.Items.Clear();
            lst.Columns.Clear();
            lst.Columns.Add("");
            lst.Columns.Add("");

            var companyConnections = companyConnectionRepository.GetAll(this.CurrentDir)
                .Where(c => !c.FileName.EndsWith("Default.jcc"));

            foreach (var connection in companyConnections)
            {

                var item = new ListViewItem(connection.Name);
                var subItem = new ListViewItem.ListViewSubItem(item, "JobCard Company");
                subItem.ForeColor = Color.Gray;
                item.SubItems.Add(subItem);
                item.SubItems.Add(connection.FileName);
                item.SubItems.Add(connection.DatabaseServer);
                item.ImageIndex = 0;
                item.Tag = connection;
                lst.Items.Add(item);

            }

            //foreach (var listViewItem in lst.Items)
            //{
            //  if (this.isAutoCompany(listViewItem.SubItems[2].Text))
            //  {
            //    listViewItem.ImageIndex = 1;
            //    listViewItem.SubItems[1].Text = "Default JobCard Company";
            //  }
            //}

            JobFunctions.GroupColumns(lst, 3);
            return lst;
        }

        public object CreateNew()
        {
            string databaseName = this._DatabaseName;
            string directoryPath = Application.ExecutablePath;
            string name = Environment.MachineName;
            File.Copy(directoryPath + "\\DB\\JobData.mdf", directoryPath + "\\DB\\" + databaseName + ".mdf", true);
            File.WriteAllText(directoryPath + "\\" + databaseName + ".jcc", Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(this._CompanyName.Value, (object)"\r\n"), (object)this._ServerName), (object)"\\REYTECSRV"), (object)"\r\n"), (object)databaseName)));
            new DataAccess(new DataConnection(name + "\\REYTECSRV", "master", "sa", "zsa", DataConnection.ProviderType.SQL)).Execute("exec sp_attach_db '" + databaseName + "','" + Application.StartupPath + "\\DB\\" + databaseName + ".mdf'");
            object obj = default(object);
            return obj;
        }

        public object SaveLogo(string fromPath)
        {
            FileStream fileStream = new FileStream(fromPath, FileMode.Open, FileAccess.Read);
            byte[] array = new byte[checked((int)(fileStream.Length - 1L) + 1)];
            fileStream.Read(array, 0, checked((int)fileStream.Length));
            fileStream.Close();
            DataAccess sql = DALGeneral.sql;
            string strKeyField = Conversions.ToString(this._ID.FieldName);
            string strKeyValue = Conversions.ToString(this._ID.Value);
            string ImageFld = Conversions.ToString(this._Logo.FieldName);
            string str = "JPEG";
            ref string local1 = ref str;
            ref byte[] local2 = ref array;
            return (object)sql.SaveImageToDB("CompanyInfo", strKeyField, strKeyValue, ImageFld, ref local1, ref local2);
        }

        public object SaveInfo()
        {
            if (!DataFunctions.ValidateBlanks(this.AllFields()))
                return (object)false;
            DALGeneral._StatementCollection.Clear();
            DALGeneral._Fields = this.AllFields();
            DALGeneral._PK = (object)this._ID;
            DALGeneral._StatementCollection.Add((object)DALGeneral.hlp.UpdateStatement("CompanyInfo", DALGeneral._Fields, Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(NewLateBinding.LateGet(DALGeneral._PK, (System.Type)null, "FieldName", new object[0], (string[])null, (System.Type[])null, (bool[])null), (object)"="), NewLateBinding.LateGet(DALGeneral._PK, (System.Type)null, "Value", new object[0], (string[])null, (System.Type[])null, (bool[])null)))), (string)null, (object)null, (object)null);
            return (object)DALGeneral.sql.ExecuteTransactions(DALGeneral._StatementCollection);
        }

        public object GetInfo()
        {
            DALGeneral._Fields = this.AllFields();
            DALGeneral._PK = (object)this._ID;
            DataTable table = DALGeneral.sql.GetDataset(DALGeneral.hlp.SelectStatement("CompanyInfo", DALGeneral._Fields, Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(NewLateBinding.LateGet(DALGeneral._PK, (System.Type)null, "FieldName", new object[0], (string[])null, (System.Type[])null, (bool[])null), (object)"="), NewLateBinding.LateGet(DALGeneral._PK, (System.Type)null, "Value", new object[0], (string[])null, (System.Type[])null, (bool[])null))), "")).Tables[0];
            if (table.Rows.Count <= 0)
                return (object)false;
            DALGeneral.SetFieldValues(table);
            return (object)true;
        }

        public bool DeleteCompany()
        {
            this.ReadFromFile();
            DataAccess dataAccess = new DataAccess(new DataConnection(this.ServerName, "master", "sa", "zsa", DataConnection.ProviderType.SQL));
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("ALTER DATABASE " + this.DatabaseName + " SET OFFLINE WITH ROLLBACK IMMEDIATE  ");
            stringBuilder.AppendLine("exec sp_detach_db '" + this.DatabaseName + "'");
            if (!dataAccess.Execute(stringBuilder.ToString()))
                return false;
            try
            {
                FileSystem.Kill(this.FileName);
                FileSystem.Kill(this.CurrentDir + "\\DB\\" + this.DatabaseName + ".MDF");
                FileSystem.Kill(this.CurrentDir + "\\DB\\" + this.DatabaseName + "_log.LDF");
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                throw ex;
            }
            return true;
        }

        public string ConcatContact()
        {
            string str1 = "" + DALGeneral.StripReturns(Conversions.ToString(this._ResidentialAddress.Value)) + "\r\n" + DALGeneral.StripReturns(Conversions.ToString(this._PostalAddress.Value)) + "\r\n";
            string str2 = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this._Tel2.Value, (object)"", false) ? Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object)(str1 + "Tel: "), this._Tel1.Value), (object)"\r\n")) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object)(str1 + "Tel: "), this._Tel1.Value), (object)" / "), this._Tel2.Value), (object)"\r\n"));
            return !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this._Cell2.Value, (object)"", false) ? Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object)(str2 + "Cell: "), this._Cell1.Value)) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object)(str2 + "Cell: "), this._Cell1.Value), (object)" / "), this._Cell2.Value), (object)"\r\n"));
        }

        public string GetAdminPassword()
        {
            this.ReadFromFile();
            return new DataAccess(new DataConnection(this.ServerName, this.DatabaseName, "sa", "zsa", DataConnection.ProviderType.SQL)).GetScalar("select systemuserpassword from systemuser where systemuserid=1");
        }

        public bool ValidateAdminPassword(string password)
        {
            DataTable table = DALGeneral.sql.GetDataset("select systemuserpassword from systemuser where deleted=0 and isAdmin=1").Tables[0];
            int num1 = checked(table.Rows.Count - 1);
            int num2 = 0;
            while (num2 <= num1)
            {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(password, StringCrypography.DecryptString(Conversions.ToString(table.Rows[0][0])), false) == 0)
                    return true;
                checked { ++num2; }
            }
            return false;
        }

        public Image LogoFromField(TableField Field)
        {
            Image image = (Image)null;
            DataAccess sql = DALGeneral.sql;
            string SQL = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object)"select * from CompanyInfo where ", this._ID.FieldName), (object)"= "), this._ID.Value));
            string Fld = Conversions.ToString(Field.FieldName);
            string str = "JPEG";
            ref string local1 = ref str;
            byte[] buffer = default(byte[]);
            ref byte[] local2 = ref buffer;
            if (sql.ReadImageFromDB(SQL, Fld, ref local1, ref local2))
                image = Image.FromStream((Stream)new MemoryStream(buffer, 0, checked(buffer.Length - 1)), true);
            return image;
        }

        public bool isAutoCompany(string DataFileName = "")
        {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(DataFileName, "", false) == 0)
                DataFileName = this.FileName;
            bool flag = default(bool);
            try
            {
                string[] strArray1 = new string[1];
                string[] strArray2 = new string[1];
                flag = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Split(File.ReadAllText(DataFileName), "\r\n", -1, CompareMethod.Binary)[2], Strings.Split(File.ReadAllText("Default.jcc"), "\r\n", -1, CompareMethod.Binary)[2], false) == 0;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
            }
            return flag;
        }

        public void AutoOpenCompany(bool yesno)
        {
            if (yesno)
            {
                this.ReadFromFile();
                File.WriteAllText("Default.jcc", Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(this._CompanyName.Value, (object)"\r\n"), (object)this.ServerName), (object)"\r\n"), (object)this.DatabaseName)));
            }
            else
            {
                this.FileName = this.CurrentDir + "\\Default.jcc";
                File.WriteAllText(this.FileName, "\r\n\r\n");
            }
        }

        public void ChangeConnection(DataConnection DALConnection)
        {
            DALGeneral.sql = new DataAccess(DALConnection);
        }

        private void ReadFromFile()
        {
            try
            {
                string[] strArray1 = new string[1];
                string[] strArray2 = Strings.Split(File.ReadAllText(this.FileName), "\r\n", -1, CompareMethod.Binary);
                this.CompanyName = (object)strArray2[0];
                this.ServerName = strArray2[1];
                this.DatabaseName = strArray2[2];
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
            }
        }

        public JobCardCompany(DataConnection DALConnection, ICompanyConnectionRepository companyConnectionRepository = null)
        {
            this._ID = new TableField(nameof(CompanyID), TableField.FieldType.Number, "ID", false, (object)1);
            this._CompanyName = new TableField(nameof(CompanyName), TableField.FieldType.Text, "Company Name", true, (object)"");
            this._TradingAs = new TableField(nameof(TradingAs), TableField.FieldType.Text, "Trading as", false, (object)"");
            this._BranchName = new TableField(nameof(BranchName), TableField.FieldType.Text, "Branch Name", false, (object)"");
            this._PostalAddress = new TableField("CompanyPostalAddress", TableField.FieldType.LongText, "Postal Address", true, (object)"");
            this._ResidentialAddress = new TableField("CompanyResidentialAddress", TableField.FieldType.LongText, "Residential Address", false, (object)"");
            this._Tel1 = new TableField("CompanyTel1", TableField.FieldType.Text, "Telephone 1", true, (object)"");
            this._Tel2 = new TableField("CompanyTel2", TableField.FieldType.Text, "Telephone 2", false, (object)"");
            this._Cell1 = new TableField("CompanyCell1", TableField.FieldType.Text, "Cellphone 1", false, (object)"");
            this._Cell2 = new TableField("CompanyCell2", TableField.FieldType.Text, "Cellphone 2", false, (object)"");
            this._Fax = new TableField("CompanyFax", TableField.FieldType.Text, nameof(Fax), false, (object)"");
            this._VATNr = new TableField("CompanyVATNr", TableField.FieldType.Text, "VAT Nr", false, (object)"");
            this._RegistrationNr = new TableField("CompanyRegNr", TableField.FieldType.Text, "Registration Nr", false, (object)"");
            this._JobCardNrPrefix = new TableField("JobCardPrefix", TableField.FieldType.Text, "Job Card Prefix", true, (object)"");
            this._Logo = new TableField("CompanyLogo", TableField.FieldType.Binary, nameof(Logo), false, (object)"");
            this._MIMEType = new TableField("MimeType", TableField.FieldType.Text, "Mime", false, (object)"");
            this._NextNumber = new TableField(nameof(NextNumber), TableField.FieldType.Number, "Next Number", true, (object)"");
            this._ServerName = "";
            this._DatabaseName = "";
            this._FileName = "";
            this.CurrentDir = Path.GetDirectoryName(Application.ExecutablePath);
            this.CompanyFileName = "";
            DALGeneral.sql = new DataAccess(DALConnection);
            this.companyConnectionRepository = companyConnectionRepository;
        }
    }
}
