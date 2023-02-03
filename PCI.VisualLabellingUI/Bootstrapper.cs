﻿using Autofac;
using PCI.VisualLabellingUI.Config;
using PCI.VisualLabellingUI.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCI.VisualLabellingUI
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
        public static bool ConnectDirectoryServer()
        {
            try
            {
                NetworkUNC.Connect();
                return true;
            }
            catch (Exception ex)
            {
                EventLogUtil.LogErrorEvent(AppSettings.AssemblyName == ex.Source ? MethodBase.GetCurrentMethod().Name : MethodBase.GetCurrentMethod().Name + "." + ex.Source, ex);
                return false;
            }
        }

        public static bool CheckConnection()
        {
            using (TcpClient tcpClient = new TcpClient())
            {
                try
                {
                    tcpClient.Connect(AppSettings.ExCoreHost, Convert.ToInt32(AppSettings.ExCorePort));
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
