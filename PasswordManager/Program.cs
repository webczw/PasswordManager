using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password.Manager
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin Login = new frmLogin();
            Login.ShowDialog();
            if (Login.DialogResult == DialogResult.OK && Login.ThisUser != null)
            {
                Application.Run(new frmMain(Login.ThisUser,Login.UserList));
            }
            else
            {
                return;
            }
        }
    }
}
