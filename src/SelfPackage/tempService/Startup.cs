using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Surging.Core.CPlatform.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace tempService
{
    public class Startup
    {
        public Startup(IConfigurationBuilder config)
        {
            //ConfigureEventBus(config);
            //  ConfigureCache(config);
        }

        public IContainer ConfigureServices(ContainerBuilder builder)
        {
            var services = new ServiceCollection();
            //ConfigureLogging(services);
            builder.Populate(services);
            ServiceLocator.Current = builder.Build();
            return ServiceLocator.Current;
        }

        public void Configure(IContainer app)
        {

        }
    }
}
