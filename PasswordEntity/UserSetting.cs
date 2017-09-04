using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password.Entity
{
    /// <summary>
    /// 用户系统设置信息
    /// </summary>
    public class UserSetting
    {
        public UserSetting()
        {
            YesOrNoTools = "0";
            ToolsButtonWay = "0";
            YesOrNoStatus = "0";
            ViewWay = "0";
            TimeOut = 1200;
        }
        /// <summary>
        /// 是否显示工具栏
        /// </summary>
        public string YesOrNoTools { set; get; }
        /// <summary>
        /// 工具栏显示方式
        /// </summary>
        public string ToolsButtonWay { set; get; }
        /// <summary>
        /// 是否显示状态栏
        /// </summary>
        public string YesOrNoStatus { set; get; }
        /// <summary>
        /// 预览方式
        /// </summary>
        public string ViewWay { get; set; }
        /// <summary>
        /// 超时时长（秒）
        /// </summary>
        public int TimeOut { get; set; }
    }

    /// <summary>
    /// 系统设置代码
    /// </summary>
    public enum SetCodes
    {
        /// <summary>
        /// 是否显示工具栏
        /// </summary>
        YesOrNoTools,
        /// <summary>
        /// 工具栏显示方式
        /// </summary>
        ToolsButtonWay,
        /// <summary>
        /// 是否显示状态栏
        /// </summary>
        YesOrNoStatus,
        /// <summary>
        /// 预览方式
        /// </summary>
        ViewWay,
        /// <summary>
        /// 超时时长（秒）
        /// </summary>
        TimeOut
    }
}
