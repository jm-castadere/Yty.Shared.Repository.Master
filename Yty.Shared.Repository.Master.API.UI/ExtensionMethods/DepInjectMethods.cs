using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Yty.Shared.Repository.Master.Domain.Interfaces;
using Yty.Shared.Repository.Master.Infrastructures.Repositories;

namespace Yty.Shared.Repository.Master.API.ExtensionMethods
{
    public static class DepInjectMethods
    {
        #region Public methods
        /// <summary>
        /// Prepare customs dependency injections
        /// </summary>
        /// <param name="services">app service collection</param>
        public static IServiceCollection AddInjections(this IServiceCollection services)
        {
            
            services.AddScoped<ISelfieRepository, DefaultSelfieRepository>();

    

            services.AddMediatR(typeof(Startup));

            return services;
        }
        #endregion
    }
}
