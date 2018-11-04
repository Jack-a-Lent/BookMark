namespace Bookmark
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.mns_Menu = new System.Windows.Forms.MenuStrip();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssr_StatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.spl_Layout1 = new System.Windows.Forms.SplitContainer();
            this.tvw_BookmarkName = new System.Windows.Forms.TreeView();
            this.dgv_BookmarkList = new System.Windows.Forms.DataGridView();
            this.SelectFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Folder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewLinkColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mns_Menu.SuspendLayout();
            this.ssr_StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spl_Layout1)).BeginInit();
            this.spl_Layout1.Panel1.SuspendLayout();
            this.spl_Layout1.Panel2.SuspendLayout();
            this.spl_Layout1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BookmarkList)).BeginInit();
            this.SuspendLayout();
            // 
            // mns_Menu
            // 
            this.mns_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.mns_Menu.Location = new System.Drawing.Point(0, 0);
            this.mns_Menu.Name = "mns_Menu";
            this.mns_Menu.Size = new System.Drawing.Size(623, 25);
            this.mns_Menu.TabIndex = 0;
            this.mns_Menu.Text = "menuStrip";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.AddToolStripMenuItem.Text = "Add";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.AboutToolStripMenuItem.Text = "About";
            // 
            // ssr_StatusStrip
            // 
            this.ssr_StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.ssr_StatusStrip.Location = new System.Drawing.Point(0, 315);
            this.ssr_StatusStrip.Name = "ssr_StatusStrip";
            this.ssr_StatusStrip.Size = new System.Drawing.Size(623, 22);
            this.ssr_StatusStrip.TabIndex = 1;
            this.ssr_StatusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // spl_Layout1
            // 
            this.spl_Layout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spl_Layout1.Location = new System.Drawing.Point(0, 25);
            this.spl_Layout1.Name = "spl_Layout1";
            // 
            // spl_Layout1.Panel1
            // 
            this.spl_Layout1.Panel1.Controls.Add(this.tvw_BookmarkName);
            // 
            // spl_Layout1.Panel2
            // 
            this.spl_Layout1.Panel2.Controls.Add(this.dgv_BookmarkList);
            this.spl_Layout1.Size = new System.Drawing.Size(623, 290);
            this.spl_Layout1.SplitterDistance = 162;
            this.spl_Layout1.TabIndex = 2;
            // 
            // tvw_BookmarkName
            // 
            this.tvw_BookmarkName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvw_BookmarkName.Location = new System.Drawing.Point(0, 0);
            this.tvw_BookmarkName.Name = "tvw_BookmarkName";
            this.tvw_BookmarkName.Size = new System.Drawing.Size(162, 290);
            this.tvw_BookmarkName.TabIndex = 0;
            this.tvw_BookmarkName.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.tvw_BookmarkName_AfterCollapse);
            this.tvw_BookmarkName.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tvw_BookmarkName_AfterExpand);
            this.tvw_BookmarkName.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvw_BookmarkName_AfterSelect);
            this.tvw_BookmarkName.Click += new System.EventHandler(this.tvw_BookmarkName_Click);
            this.tvw_BookmarkName.DoubleClick += new System.EventHandler(this.tvw_BookmarkName_DoubleClick);
            // 
            // dgv_BookmarkList
            // 
            this.dgv_BookmarkList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BookmarkList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectFlag,
            this.Folder,
            this.Title,
            this.Link});
            this.dgv_BookmarkList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_BookmarkList.Location = new System.Drawing.Point(0, 0);
            this.dgv_BookmarkList.MultiSelect = false;
            this.dgv_BookmarkList.Name = "dgv_BookmarkList";
            this.dgv_BookmarkList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_BookmarkList.RowTemplate.Height = 23;
            this.dgv_BookmarkList.Size = new System.Drawing.Size(457, 290);
            this.dgv_BookmarkList.TabIndex = 0;
            this.dgv_BookmarkList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLink_CellContentClick);
            // 
            // SelectFlag
            // 
            this.SelectFlag.HeaderText = "Select";
            this.SelectFlag.Name = "SelectFlag";
            // 
            // Folder
            // 
            this.Folder.HeaderText = "Folder";
            this.Folder.Name = "Folder";
            this.Folder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Link
            // 
            this.Link.HeaderText = "Link";
            this.Link.Name = "Link";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 337);
            this.Controls.Add(this.spl_Layout1);
            this.Controls.Add(this.ssr_StatusStrip);
            this.Controls.Add(this.mns_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mns_Menu;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bookmark";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.mns_Menu.ResumeLayout(false);
            this.mns_Menu.PerformLayout();
            this.ssr_StatusStrip.ResumeLayout(false);
            this.ssr_StatusStrip.PerformLayout();
            this.spl_Layout1.Panel1.ResumeLayout(false);
            this.spl_Layout1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spl_Layout1)).EndInit();
            this.spl_Layout1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BookmarkList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mns_Menu;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ssr_StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SplitContainer spl_Layout1;
        private System.Windows.Forms.TreeView tvw_BookmarkName;
        private System.Windows.Forms.DataGridView dgv_BookmarkList;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewLinkColumn Link;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

