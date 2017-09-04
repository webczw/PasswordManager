using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password.Manager.App_Code
{
    public class FormMessage : IMessageFilter
    {
        public bool PreFilterMessage(ref Message m)
        {
            //如果检测到有鼠标或则键盘的消息，则使计数为0.....
            if (m.Msg == 0x0200 || m.Msg == 0x0201 || m.Msg == 0x0204 || m.Msg == 0x0207 || m.Msg == 0x0100)
            {
                frmMain.OperCount = 0;
            }

            return false;
        }
    }
}
