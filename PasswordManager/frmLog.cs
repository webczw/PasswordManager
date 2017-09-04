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
    public partial class frmLog : Form
    {
        frmMain parentMain;
        int pageSize = 100;
        string selectContent = "";
        public frmLog(frmMain main)
        {
            InitializeComponent();
            parentMain = main;
        }

        private void frmLog_Load(object sender, EventArgs e)
        {
            StartDate.Value = StartDate.Value.AddMonths(-1);
            SetPage();//设置分页
        }
        /// <summary>
        /// 设置分页
        /// </summary>
        private void SetPage()
        {
            try
            {
                if (parentMain.LogManager != null)
                {
                    dgvMain.Rows.Clear();
                    DateTime statrDate = this.StartDate.Value;
                    DateTime endDate = this.EndDate.Value;
                    List<Log> logList = new List<Log>();
                    int pageIndex = Convert.ToInt32(tstPageIndex.Text);//获取当前页数
                    int Total_ = 0;
                    if (string.IsNullOrWhiteSpace(selectContent))
                    {
                        logList = parentMain.LogManager.GetPageData<Log, int>(p => p, p => p.UserID == parentMain.ThisUser.UserID && p.Date >= statrDate && p.Date <= endDate, p => p.LogID , pageIndex, pageSize, out Total_).ConvertAll(p => (Log)p);
                    }
                    else {
                        logList = parentMain.LogManager.GetPageData<Log, int>(p => p, p => p.UserID == parentMain.ThisUser.UserID && p.Date>=statrDate && p.Date<=endDate && (p.Level.Contains(selectContent)||p.Logger.Contains(selectContent) || p.Message.Contains(selectContent) || p.Location.Contains(selectContent) || p.Exception.Contains(selectContent)), p => p.LogID, pageIndex, pageSize, out Total_).ConvertAll(p => (Log)p);
                    }
                    foreach (var log in logList)
                    {
                        int rowIndex = dgvMain.Rows.Add();
                        int newRowIndex = rowIndex + 1;
                        if (pageIndex > 1)
                        {
                            newRowIndex = newRowIndex + (pageSize * pageIndex);
                        }
                        dgvMain.Rows[rowIndex].Cells["RowNumer"].Value = newRowIndex;
                        dgvMain.Rows[rowIndex].Cells["LogId"].Value = log.LogID;
                        dgvMain.Rows[rowIndex].Cells["dgvDate"].Value = log.Date;
                        dgvMain.Rows[rowIndex].Cells["dgvLevel"].Value = log.Level;
                        dgvMain.Rows[rowIndex].Cells["dgvLogger"].Value = log.Logger;
                        dgvMain.Rows[rowIndex].Cells["dgvMessage"].Value = log.Message;
                        dgvMain.Rows[rowIndex].Cells["dgvLocation"].Value = log.Location;
                        dgvMain.Rows[rowIndex].Cells["dgvException"].Value = log.Exception;
                    }
                    this.lblRowsCount.Text = Total_.ToString();
                    int pageCount = Total_ / pageSize;
                    if (Total_ % pageSize > 0)
                    {
                        pageCount = pageCount + 1;
                    }
                    this.lblPageCount.Text = pageCount.ToString();
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);
            }
        }


        /// <summary>
        /// 第一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbFirst_Click(object sender, EventArgs e)
        {
            tstPageIndex.Text = "1";
            SetPage();//设置分页
        }
        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbPrevious_Click(object sender, EventArgs e)
        {
            int pageCount = Convert.ToInt32(lblPageCount.Text);
            int pageIndex = Convert.ToInt32(tstPageIndex.Text) - 1;
            if (pageIndex > 0 && pageIndex <= pageCount)
            {
                tstPageIndex.Text = pageIndex.ToString();
                SetPage();//设置分页
            }
        }
        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbNext_Click(object sender, EventArgs e)
        {
            int pageCount = Convert.ToInt32(lblPageCount.Text);
            int pageIndex = Convert.ToInt32(tstPageIndex.Text)+1;
            if (pageIndex > 0 && pageIndex <= pageCount)
            {
                tstPageIndex.Text = pageIndex.ToString();
                SetPage();//设置分页
            }
        }
        /// <summary>
        /// 最后一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbLast_Click(object sender, EventArgs e)
        {
            tstPageIndex.Text = this.lblPageCount.Text;
            SetPage();//设置分页
        }
        /// <summary>
        /// GO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbGO_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tstPageIndex.Text)) return;
            int pageCount = Convert.ToInt32(lblPageCount.Text);
            int thisPageIndex = Convert.ToInt32(tstPageIndex.Text);
            if (thisPageIndex > 0 && thisPageIndex <= pageCount)
            {
                tstPageIndex.Text = thisPageIndex.ToString();
                SetPage();//设置分页
            }
        }

        private void tstPageIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectData();
        }
        /// <summary>
        /// 查询
        /// </summary>
        private void SelectData()
        {
            tstPageIndex.Text = "1";
            selectContent = txtContent.Text.Trim();
            SetPage();//设置分页
        }

        private void tsmiSelectPanel_Click(object sender, EventArgs e)
        {
            if (gbSelect.Visible)
            {
                tsmiSelectPanel.Text = "打开查询面板";
                gbSelect.Visible = false;
                dgvMain.Location = new Point(0);
                dgvMain.Height = dgvMain.Height + 53;
                //449
            }
            else {
                tsmiSelectPanel.Text = "关闭查询面板";
                gbSelect.Visible = true;
                dgvMain.Location = new Point(0,53);
                dgvMain.Height = dgvMain.Height - 53;
            }
        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) {
              DataGridViewRow row=  dgvMain.Rows[e.RowIndex];
                frmLogView frm = new frmLogView(row);
                frm.Show();
            }
        }

        private void frmLog_KeyDown(object sender, KeyEventArgs e)
        {
            //注册键事件
            FormKeyEvent formKeyEvent = new FormKeyEvent();//创建键事件处理实例类
            if (gbSelect.Visible)
            {
                formKeyEvent.KeyEnterEvent += new FormKeyEvent.FormKey(SelectData);//查询
            }
            formKeyEvent.KeyEscapeEvent += new FormKeyEvent.FormKey(Cancel);//取消
            formKeyEvent.KeyF1Event += new FormKeyEvent.FormKey(Help);//帮助
            formKeyEvent.Run(e);//运行注册的方法
        }
        /// <summary>
        /// 取消
        /// </summary>
        private void Cancel() {
            this.Close();
        }
        /// <summary>
        /// 帮助
        /// </summary>
        private void Help()
        {
            parentMain.ShowHelp(HelpIdDefines.HId_日志);
        }
    }
}
