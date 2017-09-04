namespace Password.Manager
{
    partial class frmContentEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContentEdit));
            this.palRight = new System.Windows.Forms.Panel();
            this.btnDecoding = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.palMain = new System.Windows.Forms.Panel();
            this.btnClassify = new System.Windows.Forms.Button();
            this.txtClassify = new System.Windows.Forms.TextBox();
            this.lblClassify = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.palRight.SuspendLayout();
            this.palMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // palRight
            // 
            this.palRight.Controls.Add(this.btnDecoding);
            this.palRight.Controls.Add(this.btnSave);
            this.palRight.Controls.Add(this.btnHelp);
            this.palRight.Controls.Add(this.btnCancel);
            this.palRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.palRight.Location = new System.Drawing.Point(425, 0);
            this.palRight.Name = "palRight";
            this.palRight.Size = new System.Drawing.Size(100, 216);
            this.palRight.TabIndex = 13;
            // 
            // btnDecoding
            // 
            this.btnDecoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDecoding.BackColor = System.Drawing.SystemColors.Window;
            this.btnDecoding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecoding.Image = global::Password.Manager.Properties.Resources._703;
            this.btnDecoding.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecoding.Location = new System.Drawing.Point(6, 88);
            this.btnDecoding.Name = "btnDecoding";
            this.btnDecoding.Size = new System.Drawing.Size(88, 28);
            this.btnDecoding.TabIndex = 18;
            this.btnDecoding.Text = "解码";
            this.btnDecoding.UseVisualStyleBackColor = false;
            this.btnDecoding.Click += new System.EventHandler(this.btnDecoding_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Window;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::Password.Manager.Properties.Resources.page_save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(6, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 28);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.Window;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Image = global::Password.Manager.Properties.Resources.help;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(6, 136);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(88, 28);
            this.btnHelp.TabIndex = 10;
            this.btnHelp.Text = "帮助";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
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
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // palMain
            // 
            this.palMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.palMain.BackColor = System.Drawing.Color.White;
            this.palMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.palMain.Controls.Add(this.btnClassify);
            this.palMain.Controls.Add(this.txtClassify);
            this.palMain.Controls.Add(this.lblClassify);
            this.palMain.Controls.Add(this.btnView);
            this.palMain.Controls.Add(this.txtRemarks);
            this.palMain.Controls.Add(this.lblAddress);
            this.palMain.Controls.Add(this.txtTitle);
            this.palMain.Controls.Add(this.lblUserName);
            this.palMain.Controls.Add(this.lblCode);
            this.palMain.Controls.Add(this.txtUserName);
            this.palMain.Controls.Add(this.txtAddress);
            this.palMain.Controls.Add(this.lblTitle);
            this.palMain.Controls.Add(this.lblPassword);
            this.palMain.Controls.Add(this.lblEmail);
            this.palMain.Controls.Add(this.txtPassword);
            this.palMain.Controls.Add(this.txtCode);
            this.palMain.Controls.Add(this.lblRemarks);
            this.palMain.Controls.Add(this.txtEmail);
            this.palMain.Location = new System.Drawing.Point(6, 6);
            this.palMain.Name = "palMain";
            this.palMain.Size = new System.Drawing.Size(419, 204);
            this.palMain.TabIndex = 2;
            // 
            // btnClassify
            // 
            this.btnClassify.BackColor = System.Drawing.SystemColors.Window;
            this.btnClassify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClassify.Location = new System.Drawing.Point(385, 93);
            this.btnClassify.Name = "btnClassify";
            this.btnClassify.Size = new System.Drawing.Size(26, 23);
            this.btnClassify.TabIndex = 29;
            this.btnClassify.Text = "...";
            this.btnClassify.UseVisualStyleBackColor = false;
            this.btnClassify.Click += new System.EventHandler(this.btnClassify_Click);
            // 
            // txtClassify
            // 
            this.txtClassify.Location = new System.Drawing.Point(53, 93);
            this.txtClassify.Name = "txtClassify";
            this.txtClassify.ReadOnly = true;
            this.txtClassify.Size = new System.Drawing.Size(358, 23);
            this.txtClassify.TabIndex = 28;
            // 
            // lblClassify
            // 
            this.lblClassify.AutoSize = true;
            this.lblClassify.Location = new System.Drawing.Point(6, 95);
            this.lblClassify.Name = "lblClassify";
            this.lblClassify.Size = new System.Drawing.Size(32, 17);
            this.lblClassify.TabIndex = 27;
            this.lblClassify.Text = "分类";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.SystemColors.Window;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Location = new System.Drawing.Point(187, 64);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(26, 23);
            this.btnView.TabIndex = 17;
            this.btnView.Text = "...";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Location = new System.Drawing.Point(53, 122);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(358, 73);
            this.txtRemarks.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 67);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(32, 17);
            this.lblAddress.TabIndex = 18;
            this.lblAddress.Text = "地址";
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Location = new System.Drawing.Point(251, 6);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(160, 23);
            this.txtTitle.TabIndex = 2;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(6, 38);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(44, 17);
            this.lblUserName.TabIndex = 20;
            this.lblUserName.Text = "用户名";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(6, 9);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 17);
            this.lblCode.TabIndex = 14;
            this.lblCode.Text = "代码";
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Location = new System.Drawing.Point(53, 35);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(160, 23);
            this.txtUserName.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(53, 64);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(135, 23);
            this.txtAddress.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(216, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(32, 17);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "标题";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(216, 38);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(32, 17);
            this.lblPassword.TabIndex = 22;
            this.lblPassword.Text = "密码";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(216, 67);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 17);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "邮箱";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(251, 35);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(160, 23);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Location = new System.Drawing.Point(53, 6);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(160, 23);
            this.txtCode.TabIndex = 0;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(6, 124);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(32, 17);
            this.lblRemarks.TabIndex = 26;
            this.lblRemarks.Text = "备注";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(251, 64);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(160, 23);
            this.txtEmail.TabIndex = 6;
            // 
            // frmContentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 216);
            this.Controls.Add(this.palMain);
            this.Controls.Add(this.palRight);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmContentEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "内容";
            this.Load += new System.EventHandler(this.frmContentEdit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmContentEdit_KeyDown);
            this.palRight.ResumeLayout(false);
            this.palMain.ResumeLayout(false);
            this.palMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palRight;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel palMain;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnClassify;
        public System.Windows.Forms.TextBox txtClassify;
        private System.Windows.Forms.Label lblClassify;
        private System.Windows.Forms.Button btnDecoding;
    }
}