using Autofac;
using PCI.VisualCheckingUI.Config;
using PCI.VisualCheckingUI.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PCI.VisualCheckingUI
{
    public static class Bootstrapper
    {
        public static ContainerBuilder DependencyInjectionBuilder(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterModule(new Util.Util());
            containerBuilder.RegisterModule(new Driver.Driver());
            containerBuilder.RegisterModule(new Repository.Repository());
            containerBuilder.RegisterModule(new UseCase.UseCase());
            containerBuilder.RegisterType<Main>().AsSelf();

            return containerBuilder;
        }
        public static void ConnectDirectoryServer()
        {
            try
            {
                NetworkUNC.Connect();
            }
            catch (Exception ex)
            {
                EventLogUtil.LogErrorEvent(AppSettings.AssemblyName == ex.Source ? MethodBase.GetCurrentMethod().Name : MethodBase.GetCurrentMethod().Name + "." + ex.Source, ex);
            }
        }
    }
}
