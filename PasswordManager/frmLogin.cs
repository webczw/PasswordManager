using Password.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Password.Interface;
using Password.Entity;
using Password.Common;
using System.Reflection;
using Password.Manager.App_Code;

namespace Password.Manager
{
    public partial class frmLogin : Form
    {
        /// <summary>
        /// 当前登录成功都用户
        /// </summary>
        public User ThisUser { private set; get; }
        /// <summary>
        /// 用户信息集合
        /// </summary>
        public List<User> UserList { private set; get; }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            //try
            //{
            //    String path = System.AppDomain.CurrentDomain.BaseDirectory;
            //    //给应用所在目录添加"Everyone,Users"用户组的完全控制权限  
            //    DirectoryInfo di = new DirectoryInfo(path);
            //    System.Security.AccessControl.DirectorySecurity dirSecurity = di.GetAccessControl();
            //    dirSecurity.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, AccessControlType.Allow));
            //    dirSecurity.AddAccessRule(new FileSystemAccessRule("Users", FileSystemRights.FullControl, AccessControlType.Allow));
            //    di.SetAccessControl(dirSecurity);
               
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("请以管理员身份运行，或将应用安装目录赋予相关权限！","系统提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //}
        }
        Point downPoint;
        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - downPoint.X,
                    this.Location.Y + e.Y - downPoint.Y);
            }
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            downPoint = new Point(e.X, e.Y);
        }

        private void panelBottom_MouseDown(object sender, MouseEventArgs e)
        {
            downPoint = new Point(e.X, e.Y);
        }

        private void panelBottom_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - downPoint.X,
                    this.Location.Y + e.Y - downPoint.Y);
            }
        }

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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            txtUserName.Focus();
            Task task = new Task(Login);
            task.Start();
        }

        private void Login()
        {
            this.Invoke(new Action(() =>
            {
                btnSubmit.Text = "登录中...";
                btnSubmit.Enabled = false;
            }));
            bool isLogin = false;
            string strUserName = this.txtUserName.Text.Trim();
            string strPassword = this.txtPassword.Text.Trim();
            string strError = "登录失败";
            if (string.IsNullOrWhiteSpace(strUserName) || string.IsNullOrWhiteSpace(strPassword))
            {
                strError += "：登录名及密码不允许为空。";
                Logger.Error(strError, MethodBase.GetCurrentMethod());//记录日志
                MessageBox.Show(strError, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            strError = "登录失败";
            try
            {
                Imanager<User> manager = Tools.DynamicCreateClass<Imanager<User>>("UserManager");
                if (manager == null)
                {
                    strError += "：创建用户管理实例异常。";
                    Logger.Error(strError, MethodBase.GetCurrentMethod());//记录日志
                    MessageBox.Show(strError, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                UserList = manager.Load();
                if (UserList.Count > 0)
                {
                    var result = (from u in UserList where u.LoginName == strUserName select u).ToList();
                    if (result != null && result.Count > 0)
                    {
                        if (TripleDES.EncryptPassword(strPassword) == result[0].Password)
                        {
                            this.ThisUser = result[0];
                            isLogin = true;
                        }
                        else
                        {
                            strError += "：密码错误。";
                        }
                    }
                    else
                    {
                        strError += "：系统不存在该用户。";
                    }
                }
                else
                {
                    strError += "：系统用户表无数据信息。";
                }
            }
            catch (Exception ex)
            {
                strError += string.Format("：{0}。", ex.Message);
            }

            if (isLogin)
            {
                Logger.Info("用户 " + ThisUser.ChineseName + " 成功登陆系统。", MethodBase.GetCurrentMethod(), this.ThisUser.UserID);
                this.DialogResult = DialogResult.OK;    //返回一个登录成功的对话框状态
                //this.Invoke(new Action(() => { this.Close(); }));
            }
            else
            {
                Logger.Error(strError, MethodBase.GetCurrentMethod());//记录日志
                MessageBox.Show(strError, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Invoke(new Action(() =>
                {
                    btnSubmit.Text = "登录";
                    btnSubmit.Enabled = true;
                }));
            }

        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            //Imanager<Content> manager = Tools.DynamicCreateClass<Imanager<Content>>("ContentManager");
            //List<Content> classifyList = manager.Load();

            //Imanager<Test> manager = Tools.DynamicCreateClass<Imanager<Test>>("TestManager");
            //List<Test> classifyList = manager.Load();

            //Imanager<DataType> manager = Tools.DynamicCreateClass<Imanager<DataType>>("DataTypeManager");
            //List<DataType> classifyList = manager.Load();

            //MessageBox.Show(classifyList.Count.ToString());
            //try
            //{
            //    throw new Exception("执行一次啦44");
            //}
            //catch (Exception ex)
            //{
            //    //Logger4net.GlobalContext.Properties["UserID"] = 0;
            //    //Logger4net.LoggericalThreadContext.Properties["UserID"] = 434;
            //    //ILogger Logger = Logger4net.LoggerManager.GetLoggerger(MethodBase.GetCurrentMethod().DeclaringType);

            //    //Logger.Error(ex.Message,ex);
            //    Logger.Error(ex, MethodBase.GetCurrentMethod());
            //}



        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            Task tase = new Task(Login);
            //注册键事件
            FormKeyEvent formKeyEvent = new FormKeyEvent();//创建键事件处理实例类
            formKeyEvent.KeyEnterEvent += new FormKeyEvent.FormKey(tase.Start);//保存
            formKeyEvent.KeyEscapeEvent += new FormKeyEvent.FormKey(Cancel);//取消
            formKeyEvent.Run(e);//运行注册的方法
        }
    }
}
