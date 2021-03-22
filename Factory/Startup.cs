using Factory.Interfaces;
using Factory.Repositories;
using Factory.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Factory
{
    /// <summary>
    /// Class to configure services.    
    /// </summary>
    public class Startup
    {
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Builder with application configuration properties <see cref="IConfiguration"/> 
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
            => Configuration = configuration;

        /// <summary>
        /// Method for configuring the service application.        
        ///<para>The <see cref="HostBuilderExtensions"/> 
        ///it is responsable for the implementation of the <paramref name="services"/>.</para> 
        /// </summary>
        /// <param name="services">Specifies the contract for a collection of service descriptors </param>
        public void ConfigureServices(IServiceCollection services)
            => services.AddSingleton<ISchoolFactory, SchoolFactory>()
                .AddTransient<EastSchoolRepository>()
                .AddTransient<WestSchoolRepository>()
                .AddTransient<NorthSchoolRepository>()
                .AddTransient<SouthShoolRepository>();

        /// <summary>
        /// Method that initializes the subclass of the <see cref="ISchoolFactory"/>
        /// </summary>
        /// <param name="serviceProvider">
        /// Defines a mechanism for retrieving a service object; that is, an object that
        /// provides custom support to other objects.</param>
        public void UseSchoolFactory(IServiceProvider serviceProvider)
            => serviceProvider
                .GetService<ISchoolFactory>()
                .Register("East", typeof(EastSchoolRepository))
                .Register("West", typeof(WestSchoolRepository))
                .Register("North", typeof(NorthSchoolRepository))
                .Register("South", typeof(SouthShoolRepository));

    }
}
