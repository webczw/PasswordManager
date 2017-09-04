using log4net;
using Password.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Password.Common
{
    /// <summary>
    /// 日志记录类
    /// </summary>
    public static class Logger
    {
        /// <summary>
        /// 记录Error日志
        /// </summary>
        /// <param name="ex">异常对象</param>
        /// <param name="methodBase">调用方法都基类路径</param>
        /// <param name="userID">当前用户ID</param>
        public static void Error(Exception ex, MethodBase methodBase, int userID = 0)
        {
            ILog log = GetILog(methodBase, userID);
            log.Error(ex.Message, ex);
        }
        /// <summary>
        /// 记录Error日志
        /// </summary>
        /// <param name="ex">异常对象</param>
        /// <param name="methodBase">调用方法都基类路径</param>
        /// <param name="sendBackParameter">客户端向后台传递参数对象</param>
        public static void Error(Exception ex, MethodBase methodBase, SendBackParameter sendBackParameter)
        {
            int userID = GetUserID(sendBackParameter);
            ILog log = GetILog(methodBase, userID);
            log.Error(ex.Message, ex);
        }
        /// <summary>
        /// 记录Error日志
        /// </summary>
        /// <param name="ex">异常对象</param>
        /// <param name="message">日志信息</param>
        /// <param name="methodBase">调用方法都基类路径</param>
        /// <param name="userID">当前用户ID</param>
        public static void Error(Exception ex, string message, MethodBase methodBase, int userID = 0)
        {
            ILog log = GetILog(methodBase, userID);
            log.Error(message, ex);
        }
        /// <summary>
        /// 记录Error日志
        /// </summary>
        /// <param name="ex">异常对象</param>
        /// <param name="message">日志信息</param>
        /// <param name="methodBase">调用方法都基类路径</param>
        /// <param name="sendBackParameter">客户端向后台传递参数对象</param>
        public static void Error(Exception ex, string message, MethodBase methodBase, SendBackParameter sendBackParameter)
        {
            int userID = GetUserID(sendBackParameter);
            ILog log = GetILog(methodBase, userID);
            log.Error(message, ex);
        }
        /// <summary>
        /// 记录Error日志
        /// </summary>
        /// <param name="message">日志信息</param>
        /// <param name="methodBase">调用方法都基类路径</param>
        /// <param name="userID">当前用户ID</param>
        public static void Error(string message, MethodBase methodBase, int userID = 0)
        {
            ILog log = GetILog(methodBase, userID);
            log.Error(message);
        }
        /// <summary>
        /// 记录Error日志
        /// </summary>
        /// <param name="message">日志信息</param>
        /// <param name="methodBase">调用方法都基类路径</param>
        /// <param name="sendBackParameter">客户端向后台传递参数对象</param>
        public static void Error(string message, MethodBase methodBase, SendBackParameter sendBackParameter)
        {
            int userID = GetUserID(sendBackParameter);
            ILog log = GetILog(methodBase, userID);
            log.Error(message);

        }



        /// <summary>
        /// 记录Info日志
        /// </summary>
        /// <param name="ex">异常对象</param>
        /// <param name="methodBase">调用方法都基类路径</param>
        /// <param name="userID">当前用户ID</param>
        public static void Info(Exception ex, MethodBase methodBase, int userID = 0)
        {
            ILog log = GetILog(methodBase, userID);
            log.Info(ex.Message, ex);
        }
        /// <summary>
        /// 记录Info日志
        /// </summary>
        /// <param name="ex">异常对象</param>
        /// <param name="methodBase">调用方法都基类路径</param>
        /// <param name="sendBackParameter">客户端向后台传递参数对象 </param>
        public static void Info(Exception ex, MethodBase methodBase, SendBackParameter sendBackParameter)
        {
            int userID = GetUserID(sendBackParameter);
            ILog log = GetILog(methodBase, userID);
            log.Info(ex.Message, ex);
        }
        /// <summary>
        /// 记录Info日志
        /// </summary>
        /// <param name="ex">异常对象</param>
        /// <param name="message">日志信息</param>
        /// <param name="methodBase">调用方法都基类路径</param>
        /// <param name="userID">当前用户ID</param>
        public static void Info(Exception ex, string message, MethodBase methodBase, int userID = 0)
        {
            ILog log = GetILog(methodBase, userID);
            log.Info(message, ex);
        }
        /// <summary>
        /// 记录Info日志
        /// </summary>
        /// <param name="ex">异常对象</param>
        /// <param name="message">日志信息</param>
        /// <param name="methodBase">调用方法都基类路径</param>
        /// <param name="sendBackParameter">客户端向后台传递参数对象 </param>
        public static void Info(Exception ex, string message, MethodBase methodBase, SendBackParameter sendBackParameter)
        {
            int userID = GetUserID(sendBackParameter);
            ILog log = GetILog(methodBase, userID);
            log.Info(message, ex);
        }
        /// <summary>
        /// 记录Info日志
        /// </summary>
        /// <param name="message">日志信息</param>
        /// <param name="methodBase">调用方法都基类路径</param>
        /// <param name="userID">当前用户ID</param>
        public static void Info(string message, MethodBase methodBase, int userID = 0)
        {
            ILog log = GetILog(methodBase, userID);
            log.Info(message);
        }
        /// <summary>
        /// 记录Info日志
        /// </summary>
        /// <param name="message">日志信息</param>
        /// <param name="methodBase">调用方法都基类路径</param>
        /// <param name="sendBackParameter">客户端向后台传递参数对象 </param>
        public static void Info(string message, MethodBase methodBase, SendBackParameter sendBackParameter)
        {
            int userID = GetUserID(sendBackParameter);
            ILog log = GetILog(methodBase, userID);
            log.Info(message);
        }
        /// <summary>
        /// 获取ILog对象
        /// </summary>
        /// <param name="methodBase">调用方法都基类路径</param>
        /// <param name="userID">当前用户ID</param>
        /// <returns></returns>
        private static ILog GetILog(MethodBase methodBase, int userID)
        {
            log4net.LogicalThreadContext.Properties["UserID"] = userID;
            ILog log = log4net.LogManager.GetLogger(methodBase.DeclaringType);
            return log;
        }

        /// <summary>
        /// 获取用户ID
        /// </summary>
        /// <param name="sendBackParameter"></param>
        /// <returns></returns>
        private static int GetUserID(SendBackParameter sendBackParameter)
        {
            int userId = 0;
            if (sendBackParameter != null && sendBackParameter.UserInfo != null)
            {
                userId = sendBackParameter.UserInfo.UserID;
            }
            return userId;
        }
    }
}
