using System;
using System.Globalization;

namespace WebApi.Helpers
{
    /// <summary>
    /// [自定义异常类]
    /// 用于抛出应用程序特定的异常(例如验证)，可以在应用程序内捕获和处理
    /// 用于区分已处理和未处理的异常
    /// 1. 已处理异常是由应用程序生成并用于向客户端显示友好错误消息的异常，例如由用户错误输入引起的业务逻辑或验证异常
    /// 2. 未处理异常由.NET框架生成并由应用程序代码中的错误引起
    /// </summary>
    public class AppException : Exception
    {
        public AppException() : base() {}

        public AppException(string message) : base(message) { }

        public AppException(string message, params object[] args) 
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}