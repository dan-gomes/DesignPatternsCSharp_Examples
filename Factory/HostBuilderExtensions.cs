using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public static class HostBuilderExtensions
    {
        private const string ConfigureServicesMethodName = "ConfigureServices";
        private const string UseSchoolFactoryMethodName = "UseSchoolFactory";
        public static IHostBuilder UseStartup<T>(this IHostBuilder hostBuilder) where T : class
        {
            hostBuilder.ConfigureServices((ctx, serviceCollection) =>
            {
                // Find a method that has this signature: ConfigureServices(IServiceCollection)
                var cfgServicesMethod = typeof(T).GetMethod(
                    ConfigureServicesMethodName, new Type[] { typeof(T) });
                // Find a method that has this signuture: InitializeServies;
                var initCfgServiceMethod = typeof(T).GetMethod(UseSchoolFactoryMethodName, new Type[] { typeof(T) });

                // Check if TStartup has a ctor that takes a IConfiguration parameter
                var hasConfigCtor = typeof(T).GetConstructor(
                    new Type[] { typeof(IConfiguration) }) != null;

                // create a TStartup instance based on ctor
                var startupObj = hasConfigCtor ?
                    (T)Activator.CreateInstance(typeof(T), ctx.Configuration) :
                    (T)Activator.CreateInstance(typeof(T), null);

                // finally, call the ConfigureServices implemented by the TStartup object
                cfgServicesMethod?.Invoke(startupObj, new object[] { serviceCollection });
                initCfgServiceMethod.Invoke(startupObj, new object[] { typeof(IServiceProvider) });
            });
            return hostBuilder;
        }
    }
}
