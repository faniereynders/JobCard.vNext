// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.Functions.GUITransformation.JobFunctions
// Assembly: JobCardFunctions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4C10EA47-A3AD-4C6F-A00C-A2AA06BFAAFE
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCardFunctions.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Reytec.JobCard.Functions.GUITransformation
{
    [StandardModule]
    public sealed class JobFunctions
    {
        public static string LoggedUser = "";
        public static int LoggedUserID;

        public static string DoSearch(DataTable tbl, string s)
        {
            string str = "";
            int num = checked(tbl.Columns.Count - 1);
            int index = 0;
            while (index <= num)
            {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tbl.Columns[index].DataType.ToString(), "System.String", false) == 0)
                {
                    str = str + "[" + tbl.Columns[index].ColumnName + "] like '%" + s + "%' ";
                    if (index != checked(tbl.Columns.Count - 1))
                        str += " OR ";
                }
                checked { ++index; }
            }
            return str;
        }

        public static void GroupColumns(ListView lst, int col)
        {
            lst.Groups.Clear();
            int num1 = checked(lst.Items.Count - 1);
            int index1 = 0;
            while (index1 <= num1)
            {
                lst.Groups.Add(lst.Items[index1].SubItems[col].Text, lst.Items[index1].SubItems[col].Text);
                checked { ++index1; }
            }
            if (col <= 0)
                return;
            int num2 = checked(lst.Items.Count - 1);
            int index2 = 0;
            while (index2 <= num2)
            {
                lst.Items[index2].Group = lst.Groups[lst.Items[index2].SubItems[col].Text];
                checked { ++index2; }
            }
        }

        public static void ShowForm(Form frm)
        {
            int num = (int)frm.ShowDialog();
        }

        public static void ShowBodyForm(Panel ParentPanel, Form ChildForm, Label title)
        {
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            ChildForm.TopLevel = false;
            //
            if (title.InvokeRequired)
            {
                title.Invoke(new Action(() =>
                {
                    title.Text = ChildForm.Text;
                    ParentPanel.Controls.Clear();
                    ParentPanel.Controls.Add((Control)ChildForm);
                    ChildForm.Show();
                }));
            }
            else
            {
                title.Text = ChildForm.Text;
                ParentPanel.Controls.Clear();
                ParentPanel.Controls.Add((Control)ChildForm);
                ChildForm.Show();
            }
            
        }

        public static ListView SearchListView(string value, ListView lt, ListView lstsearch)
        {
            string str = Strings.LCase(value);
            lstsearch.Items.Clear();
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(value, "", false) == 0)
            {
                int num = checked(lt.Items.Count - 1);
                int index = 0;
                while (index <= num)
                {
                    ListViewItem listViewItem = lt.Items[index];
                    NewLateBinding.LateCall((object)lstsearch.Items, (System.Type)null, "Add", new object[1]
                    {
            RuntimeHelpers.GetObjectValue(listViewItem.Clone())
                    }, (string[])null, (System.Type[])null, (bool[])null, true);
                    lstsearch.Items[index].ForeColor = SystemColors.WindowText;
                    lstsearch.Items[index].BackColor = SystemColors.Window;
                    checked { ++index; }
                }
                ListView listView = lstsearch;
                return listView;
            }
            int num1 = checked(lt.Items.Count - 1);
            int index1 = 0;
            while (index1 <= num1)
            {
                int num2 = checked(lt.Columns.Count - 1);
                int index2 = 0;
                while (index2 <= num2)
                {
                    if (LikeOperator.LikeString(Strings.LCase(lt.Items[index1].SubItems[index2].Text), "*" + str + "*", CompareMethod.Binary))
                    {
                        ListViewItem listViewItem = lt.Items[index1];
                        NewLateBinding.LateCall((object)lstsearch.Items, (System.Type)null, "Add", new object[1]
                        {
              RuntimeHelpers.GetObjectValue(listViewItem.Clone())
                        }, (string[])null, (System.Type[])null, (bool[])null, true);
                        break;
                    }
                    checked { ++index2; }
                }
                checked { ++index1; }
            }
            if (lstsearch.Items.Count != 0 && lstsearch.Items.Count == 1)
            {
                lstsearch.Items[0].ForeColor = SystemColors.HighlightText;
                lstsearch.Items[0].BackColor = SystemColors.Highlight;
                lstsearch.Items[0].Selected = true;
            }
            return lstsearch;
        }
    }
}
