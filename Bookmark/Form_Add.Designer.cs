namespace Bookmark
{
    partial class Form_Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Add));
            this.lab_Folder = new System.Windows.Forms.Label();
            this.tb_Folder = new System.Windows.Forms.TextBox();
            this.lab_Name = new System.Windows.Forms.Label();
            this.lab_Link = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Link = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_Folder
            // 
            this.lab_Folder.AutoSize = true;
            this.lab_Folder.Location = new System.Drawing.Point(9, 35);
            this.lab_Folder.Name = "lab_Folder";
            this.lab_Folder.Size = new System.Drawing.Size(71, 18);
            this.lab_Folder.TabIndex = 0;
            this.lab_Folder.Text = "Folder:";
            // 
            // tb_Folder
            // 
            this.tb_Folder.Location = new System.Drawing.Point(86, 32);
            this.tb_Folder.Name = "tb_Folder";
            this.tb_Folder.Size = new System.Drawing.Size(389, 28);
            this.tb_Folder.TabIndex = 1;
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Location = new System.Drawing.Point(27, 77);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(53, 18);
            this.lab_Name.TabIndex = 2;
            this.lab_Name.Text = "Name:";
            // 
            // lab_Link
            // 
            this.lab_Link.AutoSize = true;
            this.lab_Link.Location = new System.Drawing.Point(27, 110);
            this.lab_Link.Name = "lab_Link";
            this.lab_Link.Size = new System.Drawing.Size(53, 18);
            this.lab_Link.TabIndex = 3;
            this.lab_Link.Text = "Link:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(86, 74);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(389, 28);
            this.tb_Name.TabIndex = 4;
            // 
            // tb_Link
            // 
            this.tb_Link.Location = new System.Drawing.Point(86, 110);
            this.tb_Link.Name = "tb_Link";
            this.tb_Link.Size = new System.Drawing.Size(389, 28);
            this.tb_Link.TabIndex = 5;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(140, 161);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(78, 35);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Enter
            // 
            this.btn_Enter.Location = new System.Drawing.Point(312, 161);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(78, 35);
            this.btn_Enter.TabIndex = 7;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // Form_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 208);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.tb_Link);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lab_Link);
            this.Controls.Add(this.lab_Name);
            this.Controls.Add(this.tb_Folder);
            this.Controls.Add(this.lab_Folder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Form_Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Folder;
        private System.Windows.Forms.TextBox tb_Folder;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.Label lab_Link;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Link;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Enter;
    }
}