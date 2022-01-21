using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yty.Shared.Repository.Master.Infrastructures.Configurations;

namespace Yty.Shared.Repository.Master.API.ExtensionMethods
{
    /// <summary>
    /// Custom options form config (json)
    /// </summary>
    public static class OptionsMethods
    {
        #region Public methods
        /// <summary>
        /// Add custom options form config (json)
        /// </summary>
        /// <param name="services"></param>
        public static void AddCustomOptions(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<SecurityOption>(configuration.GetSection("Jwt"));
        }
        #endregion
    }
}
