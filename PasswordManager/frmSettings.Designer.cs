namespace Password.Manager
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.palRight = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.palMain = new System.Windows.Forms.Panel();
            this.gbViewWay = new System.Windows.Forms.GroupBox();
            this.rbViewWay1 = new System.Windows.Forms.RadioButton();
            this.rbViewWay0 = new System.Windows.Forms.RadioButton();
            this.gbYesOrNoStatus = new System.Windows.Forms.GroupBox();
            this.rbYesOrNoStatus1 = new System.Windows.Forms.RadioButton();
            this.rbYesOrNoStatus0 = new System.Windows.Forms.RadioButton();
            this.gbToolsButtonWay = new System.Windows.Forms.GroupBox();
            this.rbToolsButtonWay2 = new System.Windows.Forms.RadioButton();
            this.rbToolsButtonWay1 = new System.Windows.Forms.RadioButton();
            this.rbToolsButtonWay0 = new System.Windows.Forms.RadioButton();
            this.gbYesOrNoTools = new System.Windows.Forms.GroupBox();
            this.rbYesOrNoTools1 = new System.Windows.Forms.RadioButton();
            this.rbYesOrNoTools0 = new System.Windows.Forms.RadioButton();
            this.gbTimeOut = new System.Windows.Forms.GroupBox();
            this.txtTimeOut = new System.Windows.Forms.TextBox();
            this.palRight.SuspendLayout();
            this.palMain.SuspendLayout();
            this.gbViewWay.SuspendLayout();
            this.gbYesOrNoStatus.SuspendLayout();
            this.gbToolsButtonWay.SuspendLayout();
            this.gbYesOrNoTools.SuspendLayout();
            this.gbTimeOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // palRight
            // 
            this.palRight.Controls.Add(this.btnCancel);
            this.palRight.Controls.Add(this.btnSave);
            this.palRight.Controls.Add(this.btnHelp);
            this.palRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.palRight.Location = new System.Drawing.Point(275, 0);
            this.palRight.Name = "palRight";
            this.palRight.Size = new System.Drawing.Size(100, 259);
            this.palRight.TabIndex = 8;
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
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Window;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::Password.Manager.Properties.Resources.page_save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(6, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 28);
            this.btnSave.TabIndex = 9;
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
            this.btnHelp.Location = new System.Drawing.Point(6, 88);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(88, 28);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = "帮助";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // palMain
            // 
            this.palMain.BackColor = System.Drawing.Color.White;
            this.palMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.palMain.Controls.Add(this.gbTimeOut);
            this.palMain.Controls.Add(this.gbViewWay);
            this.palMain.Controls.Add(this.gbYesOrNoStatus);
            this.palMain.Controls.Add(this.gbToolsButtonWay);
            this.palMain.Controls.Add(this.gbYesOrNoTools);
            this.palMain.Location = new System.Drawing.Point(6, 6);
            this.palMain.Name = "palMain";
            this.palMain.Size = new System.Drawing.Size(269, 248);
            this.palMain.TabIndex = 1;
            // 
            // gbViewWay
            // 
            this.gbViewWay.Controls.Add(this.rbViewWay1);
            this.gbViewWay.Controls.Add(this.rbViewWay0);
            this.gbViewWay.Location = new System.Drawing.Point(8, 144);
            this.gbViewWay.Name = "gbViewWay";
            this.gbViewWay.Size = new System.Drawing.Size(250, 44);
            this.gbViewWay.TabIndex = 20;
            this.gbViewWay.TabStop = false;
            this.gbViewWay.Text = "预览方式";
            // 
            // rbViewWay1
            // 
            this.rbViewWay1.AutoSize = true;
            this.rbViewWay1.Location = new System.Drawing.Point(96, 17);
            this.rbViewWay1.Name = "rbViewWay1";
            this.rbViewWay1.Size = new System.Drawing.Size(139, 21);
            this.rbViewWay1.TabIndex = 16;
            this.rbViewWay1.Text = "Windows默认浏览器";
            this.rbViewWay1.UseVisualStyleBackColor = true;
            // 
            // rbViewWay0
            // 
            this.rbViewWay0.AutoSize = true;
            this.rbViewWay0.Checked = true;
            this.rbViewWay0.Location = new System.Drawing.Point(9, 17);
            this.rbViewWay0.Name = "rbViewWay0";
            this.rbViewWay0.Size = new System.Drawing.Size(74, 21);
            this.rbViewWay0.TabIndex = 15;
            this.rbViewWay0.TabStop = true;
            this.rbViewWay0.Text = "预览窗口";
            this.rbViewWay0.UseVisualStyleBackColor = true;
            // 
            // gbYesOrNoStatus
            // 
            this.gbYesOrNoStatus.Controls.Add(this.rbYesOrNoStatus1);
            this.gbYesOrNoStatus.Controls.Add(this.rbYesOrNoStatus0);
            this.gbYesOrNoStatus.Location = new System.Drawing.Point(8, 98);
            this.gbYesOrNoStatus.Name = "gbYesOrNoStatus";
            this.gbYesOrNoStatus.Size = new System.Drawing.Size(250, 44);
            this.gbYesOrNoStatus.TabIndex = 19;
            this.gbYesOrNoStatus.TabStop = false;
            this.gbYesOrNoStatus.Text = "是否显示状态栏";
            // 
            // rbYesOrNoStatus1
            // 
            this.rbYesOrNoStatus1.AutoSize = true;
            this.rbYesOrNoStatus1.Location = new System.Drawing.Point(96, 17);
            this.rbYesOrNoStatus1.Name = "rbYesOrNoStatus1";
            this.rbYesOrNoStatus1.Size = new System.Drawing.Size(38, 21);
            this.rbYesOrNoStatus1.TabIndex = 14;
            this.rbYesOrNoStatus1.Text = "否";
            this.rbYesOrNoStatus1.UseVisualStyleBackColor = true;
            // 
            // rbYesOrNoStatus0
            // 
            this.rbYesOrNoStatus0.AutoSize = true;
            this.rbYesOrNoStatus0.Checked = true;
            this.rbYesOrNoStatus0.Location = new System.Drawing.Point(9, 17);
            this.rbYesOrNoStatus0.Name = "rbYesOrNoStatus0";
            this.rbYesOrNoStatus0.Size = new System.Drawing.Size(38, 21);
            this.rbYesOrNoStatus0.TabIndex = 13;
            this.rbYesOrNoStatus0.TabStop = true;
            this.rbYesOrNoStatus0.Text = "是";
            this.rbYesOrNoStatus0.UseVisualStyleBackColor = true;
            // 
            // gbToolsButtonWay
            // 
            this.gbToolsButtonWay.Controls.Add(this.rbToolsButtonWay2);
            this.gbToolsButtonWay.Controls.Add(this.rbToolsButtonWay1);
            this.gbToolsButtonWay.Controls.Add(this.rbToolsButtonWay0);
            this.gbToolsButtonWay.Location = new System.Drawing.Point(8, 52);
            this.gbToolsButtonWay.Name = "gbToolsButtonWay";
            this.gbToolsButtonWay.Size = new System.Drawing.Size(250, 44);
            this.gbToolsButtonWay.TabIndex = 18;
            this.gbToolsButtonWay.TabStop = false;
            this.gbToolsButtonWay.Text = "工具栏显示方式";
            // 
            // rbToolsButtonWay2
            // 
            this.rbToolsButtonWay2.AutoSize = true;
            this.rbToolsButtonWay2.Location = new System.Drawing.Point(183, 17);
            this.rbToolsButtonWay2.Name = "rbToolsButtonWay2";
            this.rbToolsButtonWay2.Size = new System.Drawing.Size(50, 21);
            this.rbToolsButtonWay2.TabIndex = 13;
            this.rbToolsButtonWay2.Text = "文字";
            this.rbToolsButtonWay2.UseVisualStyleBackColor = true;
            // 
            // rbToolsButtonWay1
            // 
            this.rbToolsButtonWay1.AutoSize = true;
            this.rbToolsButtonWay1.Location = new System.Drawing.Point(96, 17);
            this.rbToolsButtonWay1.Name = "rbToolsButtonWay1";
            this.rbToolsButtonWay1.Size = new System.Drawing.Size(50, 21);
            this.rbToolsButtonWay1.TabIndex = 12;
            this.rbToolsButtonWay1.Text = "图标";
            this.rbToolsButtonWay1.UseVisualStyleBackColor = true;
            // 
            // rbToolsButtonWay0
            // 
            this.rbToolsButtonWay0.AutoSize = true;
            this.rbToolsButtonWay0.Checked = true;
            this.rbToolsButtonWay0.Location = new System.Drawing.Point(9, 17);
            this.rbToolsButtonWay0.Name = "rbToolsButtonWay0";
            this.rbToolsButtonWay0.Size = new System.Drawing.Size(83, 21);
            this.rbToolsButtonWay0.TabIndex = 11;
            this.rbToolsButtonWay0.TabStop = true;
            this.rbToolsButtonWay0.Text = "图标+文字";
            this.rbToolsButtonWay0.UseVisualStyleBackColor = true;
            // 
            // gbYesOrNoTools
            // 
            this.gbYesOrNoTools.Controls.Add(this.rbYesOrNoTools1);
            this.gbYesOrNoTools.Controls.Add(this.rbYesOrNoTools0);
            this.gbYesOrNoTools.Location = new System.Drawing.Point(8, 6);
            this.gbYesOrNoTools.Name = "gbYesOrNoTools";
            this.gbYesOrNoTools.Size = new System.Drawing.Size(250, 44);
            this.gbYesOrNoTools.TabIndex = 17;
            this.gbYesOrNoTools.TabStop = false;
            this.gbYesOrNoTools.Text = "是否显示工具栏";
            // 
            // rbYesOrNoTools1
            // 
            this.rbYesOrNoTools1.AutoSize = true;
            this.rbYesOrNoTools1.Location = new System.Drawing.Point(96, 17);
            this.rbYesOrNoTools1.Name = "rbYesOrNoTools1";
            this.rbYesOrNoTools1.Size = new System.Drawing.Size(38, 21);
            this.rbYesOrNoTools1.TabIndex = 10;
            this.rbYesOrNoTools1.Text = "否";
            this.rbYesOrNoTools1.UseVisualStyleBackColor = true;
            // 
            // rbYesOrNoTools0
            // 
            this.rbYesOrNoTools0.AutoSize = true;
            this.rbYesOrNoTools0.Checked = true;
            this.rbYesOrNoTools0.Location = new System.Drawing.Point(9, 17);
            this.rbYesOrNoTools0.Name = "rbYesOrNoTools0";
            this.rbYesOrNoTools0.Size = new System.Drawing.Size(38, 21);
            this.rbYesOrNoTools0.TabIndex = 9;
            this.rbYesOrNoTools0.TabStop = true;
            this.rbYesOrNoTools0.Text = "是";
            this.rbYesOrNoTools0.UseVisualStyleBackColor = true;
            // 
            // gbTimeOut
            // 
            this.gbTimeOut.Controls.Add(this.txtTimeOut);
            this.gbTimeOut.Location = new System.Drawing.Point(8, 190);
            this.gbTimeOut.Name = "gbTimeOut";
            this.gbTimeOut.Size = new System.Drawing.Size(250, 50);
            this.gbTimeOut.TabIndex = 21;
            this.gbTimeOut.TabStop = false;
            this.gbTimeOut.Text = "超时（秒）";
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.Location = new System.Drawing.Point(9, 19);
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(224, 23);
            this.txtTimeOut.TabIndex = 0;
            this.txtTimeOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimeOut_KeyPress);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 259);
            this.Controls.Add(this.palMain);
            this.Controls.Add(this.palRight);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSettings_KeyDown);
            this.palRight.ResumeLayout(false);
            this.palMain.ResumeLayout(false);
            this.gbViewWay.ResumeLayout(false);
            this.gbViewWay.PerformLayout();
            this.gbYesOrNoStatus.ResumeLayout(false);
            this.gbYesOrNoStatus.PerformLayout();
            this.gbToolsButtonWay.ResumeLayout(false);
            this.gbToolsButtonWay.PerformLayout();
            this.gbYesOrNoTools.ResumeLayout(false);
            this.gbYesOrNoTools.PerformLayout();
            this.gbTimeOut.ResumeLayout(false);
            this.gbTimeOut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palRight;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel palMain;
        private System.Windows.Forms.RadioButton rbYesOrNoTools1;
        private System.Windows.Forms.RadioButton rbYesOrNoTools0;
        private System.Windows.Forms.RadioButton rbViewWay1;
        private System.Windows.Forms.RadioButton rbViewWay0;
        private System.Windows.Forms.RadioButton rbYesOrNoStatus1;
        private System.Windows.Forms.RadioButton rbYesOrNoStatus0;
        private System.Windows.Forms.RadioButton rbToolsButtonWay1;
        private System.Windows.Forms.RadioButton rbToolsButtonWay0;
        private System.Windows.Forms.GroupBox gbViewWay;
        private System.Windows.Forms.GroupBox gbYesOrNoStatus;
        private System.Windows.Forms.GroupBox gbToolsButtonWay;
        private System.Windows.Forms.GroupBox gbYesOrNoTools;
        private System.Windows.Forms.RadioButton rbToolsButtonWay2;
        private System.Windows.Forms.GroupBox gbTimeOut;
        private System.Windows.Forms.TextBox txtTimeOut;
    }
}