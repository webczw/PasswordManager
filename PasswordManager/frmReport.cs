using Password.Common;
using Password.Entity;
using Password.Manager.App_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Password.Manager
{
    public partial class frmReport : Form
    {
        frmMain parentMain;
        public frmReport(frmMain main)
        {
            InitializeComponent();
            parentMain = main;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            try
            {
                if (parentMain.dataTypeList != null || parentMain.dataTypeList.Count > 0)
                {
                    this.chartMain.Series.Clear();
                    List<DataType> dataTypeList = parentMain.dataTypeList.FindAll(p => p.CreateUserGuid == parentMain.ThisUser.Guid);
                    foreach (var dataType in dataTypeList)
                    {
                        var contentList = (from p in parentMain.contentList where p.DataTypeGuid == dataType.Guid select p).ToList();
                        Series series = new Series(dataType.Name);
                        series.IsValueShownAsLabel = true;
                        //series.Label = contentList.Count.ToString();
                        series.Points.AddY(contentList.Count);
                        chartMain.Series.Add(series);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);
            }

        }

        private void frmReport_KeyDown(object sender, KeyEventArgs e)
        {
            //注册键事件
            FormKeyEvent formKeyEvent = new FormKeyEvent();//创建键事件处理实例类
            formKeyEvent.KeyEscapeEvent += new FormKeyEvent.FormKey(Cancel);//取消
            formKeyEvent.KeyF1Event += new FormKeyEvent.FormKey(Help);//帮助
            formKeyEvent.Run(e);//运行注册的方法
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
        private void Help()
        {
            parentMain.ShowHelp(HelpIdDefines.HId_统计);
        }
    }
}
