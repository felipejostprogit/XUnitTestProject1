using Application;
using Database;
using Domain;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using System;

namespace IOC
{
    public class IOC
    {
        public ServiceProvider Startup() {
            var services = new ServiceCollection();

            services.AddScoped<IDomainClass, DomainClass>();
            services.AddScoped<IAppClass, AppClass>();
            services.AddScoped<ITestRepository, TestRepository>();

            services.AddDbContext<TestContext>();

            return services.BuildServiceProvider();
        }
    }
}
