using System;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleDependencyInjection.Library
{
    public static class LibraryBootstrapper
    {
        public static void Bootstrap(IServiceCollection services)
        {
            services.AddSingleton<IMyService, MyService>();
        }
    }
}

