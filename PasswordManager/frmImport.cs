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
    public partial class frmImport : Form
    {
        frmMain parentMain;
        public frmImport(frmMain parentMain)
        {
            InitializeComponent();
            this.parentMain = parentMain;
        }
        /// <summary>
        /// 选择分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClassify_Click(object sender, EventArgs e)
        {
            frmSelectClassify frm = new frmSelectClassify(parentMain);
            frm.ShowDialog();
            if (frm.SelectDataType != null)
            {
                txtClassify.Text = frm.SelectDataType.Name;
                txtClassify.Tag = frm.SelectDataType.Guid;
            }
        }
        /// <summary>
        /// 选择导入文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectFilePath_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "选择导入文件路径";
                openFileDialog.Filter = "PasswordManager Files(*.pm)|*.pm";
                //设置默认文件名（可以不设置）
                openFileDialog.FileName = "PasswordManager-Data";
                //主设置默认文件extension（可以不设置）
                openFileDialog.DefaultExt = "pm";
                //获取或设置一个值，该值指示如果用户省略扩展名，文件对话框是否自动在文件名中添加扩展名。（可以不设置）
                openFileDialog.AddExtension = true;
                //设置默认文件类型显示顺序（可以不设置）
                openFileDialog.FilterIndex = 1;
                //保存对话框是否记忆上次打开的目录
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fName = openFileDialog.FileName;
                    txtFilePath.Text = fName;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);
            }
        }
        /// <summary>
        /// 导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImport_Click(object sender, EventArgs e)
        {
            Import();
        }
        /// <summary>
        /// 导入
        /// </summary>
        private void Import()
        {
            try
            {
                string exportPaht = txtFilePath.Text;
                string strClassify = txtClassify.Text;
                if (string.IsNullOrWhiteSpace(exportPaht))
                {
                    MessageBox.Show("请选择导入文件路径", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(strClassify))
                {
                    MessageBox.Show("请选择导入分类", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string importString = string.Empty;
                // 直接读取出字符串
                importString = System.IO.File.ReadAllText(exportPaht);

                List<Content> contentList = JsonHelper.DeserializeJsonToObject<List<Content>>(importString);

                foreach (var content in contentList)
                {

                    content.DataTypeGuid = txtClassify.Tag.ToString();
                    content.Guid = Guid.NewGuid().ToString();
                    content.CreateDate = DateTime.Now;
                    content.CreateUserGuid = parentMain.ThisUser.Guid;
                    content.UpdateDate = DateTime.Now;
                    content.UpdateUserGuid = parentMain.ThisUser.Guid;
                }
                int retVal = parentMain.ContentManager.Add(contentList);
                if (retVal > 0)
                {
                    parentMain.LoadData();//重新加载数据
                    DialogResult result = MessageBox.Show("导出成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("导入失败：请查看日志。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);
            }
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
        /// 帮助
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help();
        }

        private void frmImport_KeyDown(object sender, KeyEventArgs e)
        {
            //注册键事件
            FormKeyEvent formKeyEvent = new FormKeyEvent();//创建键事件处理实例类
            formKeyEvent.KeyEnterEvent += new FormKeyEvent.FormKey(Import);//导入
            formKeyEvent.KeyEscapeEvent += new FormKeyEvent.FormKey(Cancel);//取消
            formKeyEvent.KeyF1Event += new FormKeyEvent.FormKey(Help);//帮助
            formKeyEvent.Run(e);//运行注册的方法
        }

        /// <summary>
        /// 帮助
        /// </summary>
        private void Help()
        {
            parentMain.ShowHelp(HelpIdDefines.HId_导入);
        }
    }
}
