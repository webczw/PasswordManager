using Password.Common;
using Password.Manager.App_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password.Manager
{
    public partial class frmSetPassword : Form
    {
        frmUserManager parentMain;
        public frmSetPassword(frmUserManager form)
        {
            InitializeComponent();
            parentMain = form;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        /// <summary>
        /// 保存
        /// </summary>
        private void Save()
        {
            string strPasswred = txtPassword.Text.Trim();
            string strConfirmPassword = txtConfirmPassword.Text.Trim();
            if (string.IsNullOrWhiteSpace(strPasswred) || strPasswred.Length < 6 || strPasswred.Length > 16)
            {
                MessageBox.Show("密码不允许为空，并且长度为6~16个字符", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (strPasswred != strConfirmPassword)
            {
                MessageBox.Show("两次填写的密码不一致", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            strConfirmPassword = TripleDES.EncryptPassword(strConfirmPassword);//加密
            parentMain.UpdateUser((p) =>
            {
                bool retVal = false;
                if (p.Password != strConfirmPassword)
                {
                    p.Password = strConfirmPassword;
                    retVal = true;
                }
                return retVal;
            });
            MessageBox.Show("密码修改成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void Cancel()
        {
            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help();
        }

        private void frmSetPassword_KeyDown(object sender, KeyEventArgs e)
        {
            //注册键事件
            FormKeyEvent formKeyEvent = new FormKeyEvent();//创建键事件处理实例类
            formKeyEvent.KeyEnterEvent += new FormKeyEvent.FormKey(Save);//确定
            formKeyEvent.KeyEscapeEvent += new FormKeyEvent.FormKey(Cancel);//取消
            formKeyEvent.KeyF1Event += new FormKeyEvent.FormKey(Help);//帮助
            formKeyEvent.Run(e);//运行注册的方法
        }

        /// <summary>
        /// 帮助
        /// </summary>
        private void Help()
        {
            parentMain.parentMain.ShowHelp(HelpIdDefines.HId_密码);
        }
    }
}
