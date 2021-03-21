using Factory.Interfaces;
using Factory.Repositories;
using Factory.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public static class Startup
    {
        public static IServiceProvider Iniciar() 
        {
           return ServiceProvider(AddService(new ServiceCollection()));
        }

        public static IServiceCollection AddService(this IServiceCollection services)
        {
            return services.AddSingleton<ISchoolFactory, SchoolFactory>()
                .AddTransient<EastSchoolRepository>()
                .AddTransient<WestSchoolRepository>()
                .AddTransient<NorthSchoolRepository>()
                .AddTransient<SouthShoolRepository>();                
        }
        public static IServiceProvider ServiceProvider(this IServiceCollection services)
        {
          ServiceProvider provider =   services.BuildServiceProvider();
            provider.GetService<ISchoolFactory>().Register("East", typeof(EastSchoolRepository));
            provider.GetService<ISchoolFactory>().Register("West", typeof(WestSchoolRepository));
            provider.GetService<ISchoolFactory>().Register("North", typeof(NorthSchoolRepository));
            provider.GetService<ISchoolFactory>().Register("South", typeof(SouthShoolRepository));

            return provider;
        }
    }
}
