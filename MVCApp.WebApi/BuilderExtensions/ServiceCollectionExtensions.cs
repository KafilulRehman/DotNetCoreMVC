using Microsoft.Extensions.DependencyInjection;
using MVCApp.Repository.Interfaces;
using MVCApp.Repository.Repositories;
using MVCApp.Service.Interfaces;
using MVCApp.Service.Services;

namespace Pragati.Web.BuilderExtensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            //Configure UnitOfWorkAndRepositories
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));

            //Resister your Repositories Here
            services.AddScoped(typeof(ISubscriberRepository), typeof(SubscriberRepository));

            //Resister your Services Here
            services.AddScoped(typeof(ISubscriberService), typeof(SubscriberService));

            //Configure Other Services/Classes etc

            return services;
        }
    }
}
