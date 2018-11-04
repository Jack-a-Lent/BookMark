using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bookmark
{
    public partial class Form_Add : Form
    {
        public Form_Add()
        {
            InitializeComponent();
        }
        private void Form_Add_Load(object sender, EventArgs e)
        {
            if (StaticVariables.bIsAddForm == true)
            {
                this.Icon = Bookmark.Properties.Resources.Add;
                this.Text = "Add";
                tb_Folder.Text = "";
                tb_Name.Text = "";
                tb_Link.Text = "";
            }
            else
            {
                this.Icon = Bookmark.Properties.Resources.Remove; 
                this.Text = "Remove";
                tb_Folder.Text =StaticVariables.StrSectionName;
                tb_Name.Text =StaticVariables.StrKey;
                tb_Link.Text = StaticVariables.StrValue;
            }

        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            string strIniFilePath = Application.StartupPath + "\\Bookmark.ini";
            string strReadBuffer = "";
            string[] strFoldersArray;
            bool bContainsFolder = false;

            if (StaticVariables.bIsAddForm == true)
            {
                if ((tb_Folder.Text == "") || (tb_Name.Text == "") || (tb_Link.Text == ""))
                {
                    MessageBox.Show("请输入内容！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    INI_Library.SetValue(tb_Folder.Text, tb_Name.Text, tb_Link.Text, strIniFilePath);

                    strReadBuffer = INI_Library.GetValue("Folder", "Folders", strIniFilePath);
                    strFoldersArray = strReadBuffer.Split(',');

                    bContainsFolder = strFoldersArray.Contains(tb_Folder.Text);
                    if (bContainsFolder == false)
                    {
                        strReadBuffer += "," + tb_Folder.Text;
                        INI_Library.SetValue("Folder", "Folders", strReadBuffer, strIniFilePath);
                    }

                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if ((tb_Folder.Text == "") || (tb_Name.Text == "") || (tb_Link.Text == ""))
                {
                    MessageBox.Show("请先选择内容！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                { 
                    INI_Library.Removekey(tb_Folder.Text, tb_Name.Text, strIniFilePath);
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Close();
                }
                
            }
        }
    }
}
