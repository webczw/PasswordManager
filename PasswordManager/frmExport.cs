using Password.Common;
using Password.Entity;
using Password.Manager.App_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password.Manager
{
    public partial class frmExport : Form
    {
        frmMain parentMain;
        public frmExport(frmMain parentMain)
        {
            InitializeComponent();
            this.parentMain = parentMain;
        }

        private void btnSelectFilePath_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "选择导出文件路径";
                //设置文件类型
                //书写规则例如：txt files(*.txt)|*.txt|xls files(*.xls)|*.xls|All files(*.*)|*.*
                saveFileDialog.Filter = "PasswordManager Files(*.pm)|*.pm";
                //设置默认文件名（可以不设置）
                saveFileDialog.FileName = "PasswordManager-Data";
                //主设置默认文件extension（可以不设置）
                saveFileDialog.DefaultExt = "pm";
                //获取或设置一个值，该值指示如果用户省略扩展名，文件对话框是否自动在文件名中添加扩展名。（可以不设置）
                saveFileDialog.AddExtension = true;
                //设置默认文件类型显示顺序（可以不设置）
                saveFileDialog.FilterIndex = 1;
                //保存对话框是否记忆上次打开的目录
                saveFileDialog.RestoreDirectory = true;
                // Show save file dialog box
                DialogResult result = saveFileDialog.ShowDialog();
                //点了保存按钮进入
                if (result == DialogResult.OK)
                {
                    //获得文件路径
                    string localFilePath = saveFileDialog.FileName.ToString();
                    txtFilePath.Text = localFilePath;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);
            }
        }

        private void frmExport_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }
        /// <summary>
        /// 取消
        /// </summary>
        private void Cancel()
        {
            this.Close();
        }

        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            Export();
        }
        /// <summary>
        /// 导出
        /// </summary>
        private void Export()
        {
            try
            {
                string exportPaht = txtFilePath.Text;
                if (string.IsNullOrWhiteSpace(exportPaht))
                {
                    MessageBox.Show("请选择导出文件路径", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string exportString = string.Empty;
                if (rbAll.Checked)
                {
                    exportString = JsonHelper.SerializeObject(parentMain.contentList.Where(p => p.CreateUserGuid == parentMain.ThisUser.Guid).Select(p => new { p.Code, p.Title, p.Email, p.Address, p.UserName, p.Password, p.Remarks }));
                }
                else
                {
                    exportString = JsonHelper.SerializeObject(parentMain.thisShowContentList.Select(p => new { p.Code, p.Title, p.Email, p.Address, p.UserName, p.Password, p.Remarks }));
                }
                if (!string.IsNullOrWhiteSpace(exportString))
                {
                    System.IO.File.WriteAllText(exportPaht, exportString, Encoding.UTF8);//如果文件不存在，则创建；存在则覆盖
                }
                DialogResult result = MessageBox.Show("导出成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);
            }
        }

        private void frmExport_KeyDown(object sender, KeyEventArgs e)
        {
            //注册键事件
            FormKeyEvent formKeyEvent = new FormKeyEvent();//创建键事件处理实例类
            formKeyEvent.KeyEnterEvent += new FormKeyEvent.FormKey(Export);//导出
            formKeyEvent.KeyEscapeEvent += new FormKeyEvent.FormKey(Cancel);//取消
            formKeyEvent.KeyF1Event += new FormKeyEvent.FormKey(Help);//帮助
            formKeyEvent.Run(e);//运行注册的方法
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help();
        }

        /// <summary>
        /// 帮助
        /// </summary>
        private void Help()
        {
            parentMain.ShowHelp(HelpIdDefines.HId_导出);
        }
    }
}
