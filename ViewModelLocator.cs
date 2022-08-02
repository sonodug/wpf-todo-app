using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_todo_app.Services;
using wpf_todo_app.ViewModel;

namespace wpf_todo_app
{
    public class ViewModelLocator
    {
        private static ServiceProvider _provider;

        public static void Init()
        {
            var services = new ServiceCollection();

            services.AddTransient<MainViewModel>();

            services.AddSingleton<PageService>();

            _provider = services.BuildServiceProvider();

            foreach (var service in services)
            {
                _provider.GetRequiredService(service.ServiceType);
            }
        }

        public MainViewModel MainViewModel => _provider.GetRequiredService<MainViewModel>();
    }
}
