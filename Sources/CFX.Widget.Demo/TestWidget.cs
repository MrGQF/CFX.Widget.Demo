using CFX.Widget.Demo.AppWidget;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CFX.Widget.Demo
{
    public class TestWidget : UserControl, IAppWidget
    {
        public IAppContextInjection ContextInjection { get; set; }
        public IAppAccessProvider AccessProvider { get; set; }

        public Task ContinueAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("恢复");
            return Task.CompletedTask;
        }

        public Task PauseAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("暂停");
            return Task.CompletedTask;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("启动");
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("停止");
            return Task.CompletedTask;
        }
    }
}