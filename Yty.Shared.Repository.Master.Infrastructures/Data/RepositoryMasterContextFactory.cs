using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Yty.Shared.Repository.Master.Infrastructures.Data
{
    public class RepositoryMasterContextFactory : IDesignTimeDbContextFactory<RepositoryMasterContext>
    {
        public RepositoryMasterContext CreateDbContext(string[] args)
        {
            ConfigurationBuilder configurationbuilder = new ConfigurationBuilder();


            //get Json appsetting file path 
            var pathJsonFile = Path.Combine(Directory.GetCurrentDirectory(), "appSettings.json");

            configurationbuilder.AddJsonFile(pathJsonFile);

            IConfigurationRoot configurationRoot = configurationbuilder.Build();

            DbContextOptionsBuilder builder = new DbContextOptionsBuilder();

            //Set dbconnec and config data migration lib
            builder.UseSqlServer(configurationRoot.GetConnectionString("RepositoryMasterDB"), 
                                b => b.MigrationsAssembly("Yty.Shared.Repository.Master.Data.Migrations"));

            RepositoryMasterContext context = new RepositoryMasterContext(builder.Options);

            return context;
        }
    }
}
