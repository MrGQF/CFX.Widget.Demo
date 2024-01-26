using CFX.Widget.Demo.AppWidget;
using CFX.Widget.Demo.Widget;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CFX.Widget.Demo
{
    public class TestWebViewWidget : UserControl, IAppWidget
    {
        private IWebView webView { get; set; }
        public virtual IAppContextInjection ContextInjection
        {
            get
            {
                return _contextInjection;
            }
            set
            {
                _contextInjection = value;
                try
                {
                    webView = _contextInjection.ThisAppContext.GlobalContexts.EngineContext.WebViewFactory.CreateWebView();
                    webView.Navigate("about:blank");
                    webView.WebMessageReceived += WebView_WebMessageReceived;
                    Content = webView;
                }
                catch (Exception ex)
                {
                    _contextInjection?.ThisAppContext?.AppLogger?.Log(1, $"TestWebViewWidget OnContextInjectionSet Failed:{ex}");
                }
            }
        }

        /// <summary>
        /// 接收前端网页js回调
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void WebView_WebMessageReceived(object sender, WebViewWebMessageReceivedEventArgs e)
        {
            // 调用前端网页js
            webView.ExecuteScriptAsync("");
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task PauseAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task ContinueAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
        public ICFXAppAccessProvider AccessProvider { get; set; }

        private ICFXAppContextInjection _contextInjection = null;
    }
}
