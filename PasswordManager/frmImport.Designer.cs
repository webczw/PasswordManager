namespace Password.Manager
{
    partial class frmImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImport));
            this.palMain = new System.Windows.Forms.Panel();
            this.btnClassify = new System.Windows.Forms.Button();
            this.txtClassify = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectFilePath = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.palRight = new System.Windows.Forms.Panel();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.palMain.SuspendLayout();
            this.palRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // palMain
            // 
            this.palMain.BackColor = System.Drawing.Color.White;
            this.palMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.palMain.Controls.Add(this.btnClassify);
            this.palMain.Controls.Add(this.txtClassify);
            this.palMain.Controls.Add(this.label1);
            this.palMain.Controls.Add(this.btnSelectFilePath);
            this.palMain.Controls.Add(this.txtFilePath);
            this.palMain.Controls.Add(this.lblFilePath);
            this.palMain.Location = new System.Drawing.Point(6, 6);
            this.palMain.Margin = new System.Windows.Forms.Padding(6);
            this.palMain.Name = "palMain";
            this.palMain.Size = new System.Drawing.Size(366, 110);
            this.palMain.TabIndex = 6;
            // 
            // btnClassify
            // 
            this.btnClassify.BackColor = System.Drawing.SystemColors.Window;
            this.btnClassify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClassify.Location = new System.Drawing.Point(327, 51);
            this.btnClassify.Name = "btnClassify";
            this.btnClassify.Size = new System.Drawing.Size(26, 23);
            this.btnClassify.TabIndex = 24;
            this.btnClassify.Text = "...";
            this.btnClassify.UseVisualStyleBackColor = false;
            this.btnClassify.Click += new System.EventHandler(this.btnClassify_Click);
            // 
            // txtClassify
            // 
            this.txtClassify.Location = new System.Drawing.Point(67, 51);
            this.txtClassify.Name = "txtClassify";
            this.txtClassify.ReadOnly = true;
            this.txtClassify.Size = new System.Drawing.Size(261, 23);
            this.txtClassify.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "导入分类";
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
            this.palRight.Controls.Add(this.btnImport);
            this.palRight.Controls.Add(this.btnCancel);
            this.palRight.Controls.Add(this.btnHelp);
            this.palRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.palRight.Location = new System.Drawing.Point(372, 0);
            this.palRight.Name = "palRight";
            this.palRight.Size = new System.Drawing.Size(100, 122);
            this.palRight.TabIndex = 7;
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.SystemColors.Window;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Image = global::Password.Manager.Properties.Resources._549;
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.Location = new System.Drawing.Point(6, 6);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(88, 28);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "导入";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
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
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 122);
            this.Controls.Add(this.palMain);
            this.Controls.Add(this.palRight);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImport";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导入";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImport_KeyDown);
            this.palMain.ResumeLayout(false);
            this.palMain.PerformLayout();
            this.palRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palMain;
        private System.Windows.Forms.Button btnSelectFilePath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Panel palRight;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnClassify;
        private System.Windows.Forms.TextBox txtClassify;
        private System.Windows.Forms.Label label1;
    }
}