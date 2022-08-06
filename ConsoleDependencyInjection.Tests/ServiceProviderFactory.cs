using System;
using ConsoleDependencyInjection.Library;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleDependencyInjection.Tests
{
    public static class ServiceProviderFactory
    {
        public static IServiceProvider CreateServiceProvider()
        {
            var services = new ServiceCollection();

            LibraryBootstrapper.Bootstrap(services);
            TestBootstrapper.Bootstrap(services);

            return services.BuildServiceProvider();
        }
    }
}

