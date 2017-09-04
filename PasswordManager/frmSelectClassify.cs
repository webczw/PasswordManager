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
    public partial class frmSelectClassify : Form
    {
        /// <summary>
        /// 当前选择的类型
        /// </summary>
        public DataType SelectDataType { private set; get; }
        frmMain parentMain;
        public frmSelectClassify(frmMain main)
        {
            InitializeComponent();
            parentMain = main;
        }

        private void frmSelectClassify_Load(object sender, EventArgs e)
        {
            try
            {
                tvClassify.ImageList = new frmMain(parentMain.ThisUser, parentMain.userList).ilClassify;
                if (parentMain.DataTypeManager != null)
                {
                    new frmClassify(parentMain).LoadDataType(this.tvClassify);//绑定控件
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Confirm();
        }
        /// <summary>
        /// 确定
        /// </summary>
        private void Confirm()
        {
            OKSelect(tvClassify.SelectedNode);//确定选择
        }

        /// <summary>
        /// 确定选择
        /// </summary>
        private void OKSelect(TreeNode node)
        {
            try
            {
                this.SelectDataType = (DataType)node.Tag;//获取当前节点对应都数据对象
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);
            }
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

        private void tvClassify_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            OKSelect(e.Node);//确定选择
        }

        private void frmSelectClassify_KeyDown(object sender, KeyEventArgs e)
        {

            //注册键事件
            FormKeyEvent formKeyEvent = new FormKeyEvent();//创建键事件处理实例类
            formKeyEvent.KeyEnterEvent += new FormKeyEvent.FormKey(Confirm);//确定
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
            parentMain.ShowHelp(HelpIdDefines.HId_选择分类);
        }
    }
}
