using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password.Manager.App_Code
{
   public class FormKeyEvent
    {
        /// <summary>
        /// Form键 委托
        /// </summary>
        public delegate void FormKey();

        /// <summary>
        /// Enter键 事件
        /// </summary>
        public event FormKey KeyEnterEvent;
        /// <summary>
        /// Esc键 事件
        /// </summary>
        public event FormKey KeyEscapeEvent;
        /// <summary>
        /// Insert键 事件
        /// </summary>
        public event FormKey KeyInsertEvent;
        /// <summary>
        /// Delete键 事件
        /// </summary>
        public event FormKey KeyDeleteEvent;
        /// <summary>
        /// F1键 事件
        /// </summary>
        public event FormKey KeyF1Event;
        /// <summary>
        /// F8键 事件
        /// </summary>
        public event FormKey KeyF8Event;


        /// <summary>
        /// 运行注册的方法
        /// </summary>
        public void Run(KeyEventArgs e)
        {
            //Enter键
            if (this.KeyEnterEvent != null && e.KeyCode == Keys.Enter)
            {
                this.KeyEnterEvent();
            }
            //Esc键
            if (this.KeyEscapeEvent != null && e.KeyCode == Keys.Escape)
            {
                this.KeyEscapeEvent();
            }
            //Insert键
            if (this.KeyInsertEvent != null && e.KeyCode == Keys.Insert)
            {
                this.KeyInsertEvent();
            }
            //Delete键
            if (this.KeyDeleteEvent != null && e.KeyCode == Keys.Delete)
            {
                this.KeyDeleteEvent();
            }
            //F1键
            if (this.KeyF1Event != null && e.KeyCode == Keys.F1)
            {
                this.KeyF1Event();
            }
            //F8键
            if (this.KeyF8Event != null && e.KeyCode == Keys.F8)
            {
                this.KeyF8Event();
            }
        }
    }
}
