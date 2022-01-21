using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Yty.Shared.Repository.Master.API.ExtensionMethods;
using Yty.Shared.Repository.Master.API.Middlewares;
using Yty.Shared.Repository.Master.Infrastructures.Data;
using Yty.Shared.Repository.Master.Infrastructures.Loggers;

namespace Yty.Shared.Repository.Master.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        /// <summary>
        /// Configures the services.called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services">The services.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<RepositoryMasterContext>(options =>
            {
                options.UseSqlServer(this.Configuration.GetConnectionString("RepositoryMasterDB"), sqlOptions => {});
            });


            //services.AddDefaultIdentity<IdentityUser>(options =>
            //{
            //    // options.SignIn.RequireConfirmedEmail = true;
            //}).AddEntityFrameworkStores<SelfiesContext>();

            services.AddCustomOptions(this.Configuration);

            services.AddInjections().AddCustomSecurity(this.Configuration);

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Yty.Shared.Repository.Master.API", Version = "v1" });
            });
        }



        /// <summary>
        /// called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        /// <param name="loggerFactory"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddProvider(new CustomLoggerProvider());

            app.UseMiddleware<LogRequestMiddleware>();

            app.UseRouting();

            if (env.IsDevelopment())
            {
                //app.UseMiddleware(typeof(CorsMiddleware));

                app.UseDeveloperExceptionPage();
                app.UseCors(options => options.AllowAnyOrigin());
            }
            else
            {
                //app.UseCors(SecurityMethods.DEFAULT_POLICY_2);
                app.UseHttpsRedirection();
                app.UseHsts();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Yty.Shared.Repository.Master.API v1"));
            

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

    }
}
