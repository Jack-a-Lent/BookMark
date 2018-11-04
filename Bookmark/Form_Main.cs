using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Bookmark
{
    public partial class Form_Main : Form
    {
        Variables Sys = new Variables();

        public Form_Main()
        {
            InitializeComponent();
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            SysVariablesInitFunc();
            Information("");
            
        }
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticVariables.bIsAddForm = true;
            Form_Add Frm_Add = new Form_Add();
            Frm_Add.ShowDialog();
            //this.Close();
        }

        private bool SysVariablesInitFunc()
        {
            bool bInitResult = true;
            Sys.VariablesInitSub();

            Sys.strIniFilePath = Application.StartupPath + "\\Bookmark.ini";

            FileInfo fFileInfo = new FileInfo(Sys.strIniFilePath);
            if (false == fFileInfo.Exists)
            {
                bInitResult = false;
                //MessageBox.Show("Cannot Find Right Config File !!! ");

 
                WriteDefaultIniFileSub();
                return bInitResult;
            }
            else
            {
                bInitResult = true;
                ReadIniFileSub();
            }

            return bInitResult;
        }

        private void WriteDefaultIniFileSub()
        {
            if (!File.Exists(Sys.strIniFilePath))
            { 
                 //using (File.Create(Sys.strIniFilePath)) { };
                var utf8WithoutBom = new System.Text.UTF8Encoding(false);
                using (var sink = new StreamWriter(Sys.strIniFilePath, false, utf8WithoutBom))
                {
                    sink.WriteLine("; UTF8 Without BOM ");
                }
            }

            INI_Library.SetValue("Folder","Folders","Movie,Blog",Sys.strIniFilePath);
            INI_Library.SetValue("Movie", "SubHD", "http://subhd.com/", Sys.strIniFilePath);
            INI_Library.SetValue("Blog", "我的博客", "https://jack-a-lent.github.io/", Sys.strIniFilePath);
        
        }
        private void ReadIniFileSub()
        {
            string strReadBuffer = "";
            List<string> strListBuffer = new List<string>();
           string strLinkbuffer ="";


            strReadBuffer = INI_Library.GetValue("Folder", "Folders", Sys.strIniFilePath);
            string[] strFoldersArray = strReadBuffer.Split(',');
            AddTreeViewParentNodeFunc(strFoldersArray);
            
             for (int i = 0; i < strFoldersArray.Length; i++)
             {
                 strListBuffer = INI_Library.GetKeys(strFoldersArray[i], Sys.strIniFilePath);
                 Sys.i32NumOfFolders++;

                 for (int j = 0; j < strListBuffer.Count; j++)
                 { 
                    tvw_BookmarkName.Nodes[i].Nodes.Add(strListBuffer[j]);
                    strLinkbuffer = INI_Library.GetValue(strFoldersArray[i], strListBuffer[j], Sys.strIniFilePath);
                    DataGridViewAddRowFunc(Sys.i32NumOfBookmark, strFoldersArray[i], strListBuffer[j], strLinkbuffer);
                    Sys.i32NumOfBookmark++;
                 }
                 strListBuffer.Clear();    
             }

             UpdateDataGridViewFunc(dgv_BookmarkList);
        }
        private void AddTreeViewParentNodeFunc(string[] strNodeArray)
        {
             TreeNode ParentNode = new TreeNode(strNodeArray[0]); 

            for(int i=0;i<strNodeArray.Length;i++ )
            {
                 ParentNode = new TreeNode(strNodeArray[i]);
                 tvw_BookmarkName.Nodes.Add(ParentNode);
            } 
        }
        private void dataGridViewLink_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = dgv_BookmarkList.CurrentRow.Index;
            string strLink = dgv_BookmarkList.Rows[i].Cells[3].Value.ToString();


            if (e.ColumnIndex == 3)
            {
                //System.Diagnostics.Process.Start("iexplore.exe", strLink);
                System.Diagnostics.Process.Start(strLink);
            }
        }

        private void tvw_BookmarkName_AfterExpand(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show(e.Node.Text);
        }

        private void tvw_BookmarkName_AfterCollapse(object sender, TreeViewEventArgs e)
        {

        }

        void UpdateDataGridViewFunc(DataGridView dgvDataGridView)
        {
            //在HeaderCell中 显示行号
            for (int i = 0; i < dgvDataGridView.Rows.Count; i++)
            {
                dgvDataGridView.Rows[i].HeaderCell.Value = Convert.ToString(i);//string.Format("{0:X2}", i);
                dgvDataGridView.Rows[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            // https://blog.csdn.net/gane_cheng/article/details/52163912
            //列表的文字居中[要设置dataGridView列SortMode属性为NotSortable]
            //行号没有完全显示出来的解决办法是将DataGridView的RowHeadersWidthSizeMode属性设置为AutoSizeToAllHeaders、AutoSizeToDisplayedHeaders或者AutoSizeToFirstHeader。
            dgvDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //列Header的高度自动调整 
            //dgvDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize; 
            //行Header的宽度自动调整 
            dgvDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            //dgvDataGridView.RowHeadersWidth = 30;
            dgvDataGridView.DefaultCellStyle.Font = new Font("Calibri", 10);//设置网格中字体的样式


            //设置对齐方式 内容与单元格的垂直和水平中心对齐
            dgvDataGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 设定包括Header和所有单元格的列宽自动调整
            dgvDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDataGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;  //设置列标题不换行

            // 设定包括Header和所有单元格的行高自动调整
            dgvDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            dgvDataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvDataGridView.AllowUserToAddRows = false;          //禁止添加行
            dgvDataGridView.AllowUserToDeleteRows = false;       //禁止删除行
            dgvDataGridView.AllowUserToResizeColumns = false;    //禁止改变列的宽度
            dgvDataGridView.AllowUserToResizeRows = false;       //禁止改变行的高度
            dgvDataGridView.ReadOnly = true;                   //设置单元格为不可编辑  
        }
        void DataGridViewAddRowFunc(Int32 i32RowIndex, string strFolder,string strTitle,string strLink)
        {
            dgv_BookmarkList.Rows.Add(1);
            dgv_BookmarkList.Rows[i32RowIndex].Cells[1].Value= strFolder;//folder
            dgv_BookmarkList.Rows[i32RowIndex].Cells[2].Value = strTitle;//title
            dgv_BookmarkList.Rows[i32RowIndex].Cells[3].Value = strLink;//link
            dgv_BookmarkList.Update();
               
        }

        /// <summary>
        /// 普通状态信息提示
        /// </summary>
        /// <param name="message">提示信息</param>
        private void Information(string message)
        {

            // #FF007ACC
            toolStripStatusLabel1.BackColor = Color.LightBlue;
            //ssr_GuiStatus.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0x00, 0x7A, 0xCC));

            toolStripStatusLabel1.Text = message;
        }

        private void tvw_BookmarkName_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string strLink = "";
            
            string strReadBuffer = "";
            string[] strFoldersArray;
            bool bContainsFolder = false;

            if (tvw_BookmarkName.SelectedNode != null)
            {

                strReadBuffer = INI_Library.GetValue("Folder", "Folders", Sys.strIniFilePath);
                strFoldersArray = strReadBuffer.Split(',');

                bContainsFolder = strFoldersArray.Contains(tvw_BookmarkName.SelectedNode.Text);
                if (bContainsFolder == false)
                {
                    //Child Node
                    //MessageBox.Show(tvw_BookmarkName.SelectedNode.Text);
                    strLink = INI_Library.GetValue(e.Node.Parent.Text.ToString(), tvw_BookmarkName.SelectedNode.Text.ToString(), Sys.strIniFilePath);
                    //MessageBox.Show(strLink);
                    System.Diagnostics.Process.Start(strLink);
                    StaticVariables.StrSectionName = e.Node.Parent.Text.ToString();
                    StaticVariables.StrKey = tvw_BookmarkName.SelectedNode.Text.ToString();
                    StaticVariables.StrValue = strLink;
                }
            }
        }

        private void tvw_BookmarkName_DoubleClick(object sender, EventArgs e)
        {
        }

        private void tvw_BookmarkName_Click(object sender, EventArgs e)
        {

        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticVariables.bIsAddForm = false;
            Form_Add Frm_Add = new Form_Add();
            Frm_Add.ShowDialog();
        }


    }
}
