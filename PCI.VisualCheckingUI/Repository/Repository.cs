﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.VisualCheckingUI.Repository
{
    public class Repository : Module
    {
        protected override void Load(ContainerBuilder moduleBuilder)
        {
            moduleBuilder.RegisterType<Opcenter.MaintenanceTransaction>().AsSelf();
            moduleBuilder.RegisterType<Opcenter.ContainerTransaction>().AsSelf();
        }
    }
}
