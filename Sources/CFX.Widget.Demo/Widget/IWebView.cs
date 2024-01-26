using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFX.Widget.Demo.Widget
{
    /// <summary>
    /// 浏览器视图抽象
    /// </summary>
    public interface IWebView
    {
        /// <summary>
        /// 
        /// </summary>
        public Uri Source { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool CanGoBack { get; }
        /// <summary>
        /// 
        /// </summary>
        public bool CanGoForward { get; }
        /// <summary>
        /// 
        /// </summary>
        public double ZoomFactor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool AllowExternalDrop { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        void Navigate(string url);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="javaScript"></param>
        /// <returns></returns>
        public Task<string> ExecuteScriptAsync(string javaScript);
        /// <summary>
        /// 
        /// </summary>
        public void GoBack();
        /// <summary>
        /// 
        /// </summary>
        public void GoForward();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlContent"></param>
        public void NavigateToString(string htmlContent);
        /// <summary>
        /// 
        /// </summary>
        public void Reload();
        /// <summary>
        /// 
        /// </summary>
        public void Stop();
        /// <summary>
        /// 
        /// </summary>
        public void Close();
        /// <summary>
        /// 
        /// </summary>
        void OpenDevToolsWindow();
        /// <summary>
        /// 
        /// </summary>
        public event EventHandler<WebViewWebMessageReceivedEventArgs> WebMessageReceived;
    }

    /// <summary>
    /// 浏览器消息接收事件参数
    /// </summary>
    public class WebViewWebMessageReceivedEventArgs
    {
        /// <summary>
        /// 
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string WebMessageAsJson { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string WebMessageAsString { get; set; }
    }
}

