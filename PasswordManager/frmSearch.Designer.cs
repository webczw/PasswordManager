namespace Password.Manager
{
    partial class frmSearch
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
            this.palMain = new System.Windows.Forms.Panel();
            this.txtSearchContent = new System.Windows.Forms.TextBox();
            this.lblSearchContent = new System.Windows.Forms.Label();
            this.gbSelectItem = new System.Windows.Forms.GroupBox();
            this.cbAllType = new System.Windows.Forms.CheckBox();
            this.cbUpperLower = new System.Windows.Forms.CheckBox();
            this.palRight = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.palMain.SuspendLayout();
            this.gbSelectItem.SuspendLayout();
            this.palRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // palMain
            // 
            this.palMain.BackColor = System.Drawing.Color.White;
            this.palMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.palMain.Controls.Add(this.txtSearchContent);
            this.palMain.Controls.Add(this.lblSearchContent);
            this.palMain.Controls.Add(this.gbSelectItem);
            this.palMain.Location = new System.Drawing.Point(6, 6);
            this.palMain.Name = "palMain";
            this.palMain.Size = new System.Drawing.Size(348, 97);
            this.palMain.TabIndex = 9;
            // 
            // txtSearchContent
            // 
            this.txtSearchContent.Location = new System.Drawing.Point(95, 6);
            this.txtSearchContent.Name = "txtSearchContent";
            this.txtSearchContent.Size = new System.Drawing.Size(245, 23);
            this.txtSearchContent.TabIndex = 20;
            this.txtSearchContent.TextChanged += new System.EventHandler(this.txtSearchContent_TextChanged);
            // 
            // lblSearchContent
            // 
            this.lblSearchContent.AutoSize = true;
            this.lblSearchContent.Location = new System.Drawing.Point(6, 9);
            this.lblSearchContent.Name = "lblSearchContent";
            this.lblSearchContent.Size = new System.Drawing.Size(86, 17);
            this.lblSearchContent.TabIndex = 19;
            this.lblSearchContent.Text = "查找内容(&N)：";
            // 
            // gbSelectItem
            // 
            this.gbSelectItem.Controls.Add(this.cbAllType);
            this.gbSelectItem.Controls.Add(this.cbUpperLower);
            this.gbSelectItem.Location = new System.Drawing.Point(9, 35);
            this.gbSelectItem.Name = "gbSelectItem";
            this.gbSelectItem.Size = new System.Drawing.Size(331, 55);
            this.gbSelectItem.TabIndex = 18;
            this.gbSelectItem.TabStop = false;
            this.gbSelectItem.Text = "选项";
            // 
            // cbAllType
            // 
            this.cbAllType.AutoSize = true;
            this.cbAllType.Checked = true;
            this.cbAllType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAllType.Location = new System.Drawing.Point(122, 21);
            this.cbAllType.Name = "cbAllType";
            this.cbAllType.Size = new System.Drawing.Size(114, 21);
            this.cbAllType.TabIndex = 1;
            this.cbAllType.Text = "是否所有分类(&T)";
            this.cbAllType.UseVisualStyleBackColor = true;
            // 
            // cbUpperLower
            // 
            this.cbUpperLower.AutoSize = true;
            this.cbUpperLower.Location = new System.Drawing.Point(12, 21);
            this.cbUpperLower.Name = "cbUpperLower";
            this.cbUpperLower.Size = new System.Drawing.Size(103, 21);
            this.cbUpperLower.TabIndex = 0;
            this.cbUpperLower.Text = "区分大小写(&C)";
            this.cbUpperLower.UseVisualStyleBackColor = true;
            // 
            // palRight
            // 
            this.palRight.Controls.Add(this.btnCancel);
            this.palRight.Controls.Add(this.btnSearch);
            this.palRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.palRight.Location = new System.Drawing.Point(354, 0);
            this.palRight.Name = "palRight";
            this.palRight.Size = new System.Drawing.Size(100, 109);
            this.palRight.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::Password.Manager.Properties.Resources.cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(6, 40);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 28);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearch.Enabled = false;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::Password.Manager.Properties.Resources.magnifier;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(6, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 28);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "查找(&F)";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 109);
            this.Controls.Add(this.palMain);
            this.Controls.Add(this.palRight);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSearch_KeyDown);
            this.palMain.ResumeLayout(false);
            this.palMain.PerformLayout();
            this.gbSelectItem.ResumeLayout(false);
            this.gbSelectItem.PerformLayout();
            this.palRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palMain;
        private System.Windows.Forms.TextBox txtSearchContent;
        private System.Windows.Forms.Label lblSearchContent;
        private System.Windows.Forms.GroupBox gbSelectItem;
        private System.Windows.Forms.CheckBox cbAllType;
        private System.Windows.Forms.CheckBox cbUpperLower;
        private System.Windows.Forms.Panel palRight;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
    }
}