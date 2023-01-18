using Autofac;
using PCI.VisualCheckingUI.Config;
using PCI.VisualCheckingUI.UseCase;
using PCI.VisualCheckingUI.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCI.VisualCheckingUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Connect to Network
            Bootstrapper.ConnectDirectoryServer();

            // Dependency injection
            var containerBuilder = Bootstrapper.DependencyInjectionBuilder(new ContainerBuilder());
            var container = containerBuilder.Build();

            AppSettings.AssemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<Main>());
        }
    }
}
