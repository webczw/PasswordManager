namespace Password.Manager
{
    partial class frmExport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExport));
            this.palMain = new System.Windows.Forms.Panel();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.rbThisShow = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.btnSelectFilePath = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.palRight = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.palMain.SuspendLayout();
            this.gbDetail.SuspendLayout();
            this.palRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // palMain
            // 
            this.palMain.BackColor = System.Drawing.Color.White;
            this.palMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.palMain.Controls.Add(this.gbDetail);
            this.palMain.Controls.Add(this.btnSelectFilePath);
            this.palMain.Controls.Add(this.txtFilePath);
            this.palMain.Controls.Add(this.lblFilePath);
            this.palMain.Location = new System.Drawing.Point(6, 6);
            this.palMain.Margin = new System.Windows.Forms.Padding(6);
            this.palMain.Name = "palMain";
            this.palMain.Size = new System.Drawing.Size(366, 110);
            this.palMain.TabIndex = 4;
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.rbThisShow);
            this.gbDetail.Controls.Add(this.rbAll);
            this.gbDetail.Location = new System.Drawing.Point(9, 43);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(343, 53);
            this.gbDetail.TabIndex = 6;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "选项";
            // 
            // rbThisShow
            // 
            this.rbThisShow.AutoSize = true;
            this.rbThisShow.Location = new System.Drawing.Point(143, 22);
            this.rbThisShow.Name = "rbThisShow";
            this.rbThisShow.Size = new System.Drawing.Size(74, 21);
            this.rbThisShow.TabIndex = 23;
            this.rbThisShow.Text = "当前显示";
            this.rbThisShow.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(57, 22);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(50, 21);
            this.rbAll.TabIndex = 22;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "所有";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // btnSelectFilePath
            // 
            this.btnSelectFilePath.BackColor = System.Drawing.SystemColors.Window;
            this.btnSelectFilePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFilePath.Location = new System.Drawing.Point(326, 14);
            this.btnSelectFilePath.Name = "btnSelectFilePath";
            this.btnSelectFilePath.Size = new System.Drawing.Size(26, 23);
            this.btnSelectFilePath.TabIndex = 21;
            this.btnSelectFilePath.Text = "...";
            this.btnSelectFilePath.UseVisualStyleBackColor = false;
            this.btnSelectFilePath.Click += new System.EventHandler(this.btnSelectFilePath_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(66, 14);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(261, 23);
            this.txtFilePath.TabIndex = 2;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(6, 17);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(56, 17);
            this.lblFilePath.TabIndex = 1;
            this.lblFilePath.Text = "文件路径";
            // 
            // palRight
            // 
            this.palRight.Controls.Add(this.btnExport);
            this.palRight.Controls.Add(this.btnCancel);
            this.palRight.Controls.Add(this.btnHelp);
            this.palRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.palRight.Location = new System.Drawing.Point(378, 0);
            this.palRight.Name = "palRight";
            this.palRight.Size = new System.Drawing.Size(100, 122);
            this.palRight.TabIndex = 5;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.Window;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Image = global::Password.Manager.Properties.Resources._550;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(6, 6);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(88, 28);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.Window;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Image = global::Password.Manager.Properties.Resources.help;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(6, 88);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(88, 28);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "帮助";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 122);
            this.Controls.Add(this.palMain);
            this.Controls.Add(this.palRight);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExport";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导出";
            this.Load += new System.EventHandler(this.frmExport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmExport_KeyDown);
            this.palMain.ResumeLayout(false);
            this.palMain.PerformLayout();
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.palRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palMain;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Panel palRight;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.RadioButton rbThisShow;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Button btnSelectFilePath;
    }
}