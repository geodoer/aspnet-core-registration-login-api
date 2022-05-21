namespace WebApi.Helpers
{
    /// <summary>
    /// 自定义配置
    /// [如何将配置文件中的内容加载到AppSettings中]
    ///     在Startup.cs的ConfigureServices方法中完成（具体可查看Startup.cs文件）
    /// [代码使用]
    ///     IOptions<AppSettings> appSettings来访问设置
    /// </summary>
    public class AppSettings
    {
        public string Secret { get; set; }
    }
}