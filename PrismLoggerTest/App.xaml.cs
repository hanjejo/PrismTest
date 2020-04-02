using log4net;
using Prism.Ioc;
using Prism.Logging;
using Prism.Unity;
using PrismLoggerTest.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;

namespace PrismLoggerTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        
        protected override Window CreateShell()
        {
            return Container.Resolve<MainView>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Logger 초기화
            var logger = new Logger();

            // 닷넷 프레임워크일 경우 예외
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            log4net.Config.XmlConfigurator.Configure(logRepository);

            containerRegistry.RegisterInstance<ILoggerFacade>(logger);
        }
    }
}
