using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using Yty.Shared.Repository.Master.Domain.Entities;
using Yty.Shared.Repository.Master.Framework;
using Yty.Shared.Repository.Master.Infrastructures.Data.TypeConfigurations;

namespace Yty.Shared.Repository.Master.Infrastructures.Data
{
    public class RepositoryMasterContext : IdentityDbContext, IUnitOfWork
    {
        public RepositoryMasterContext([NotNullAttribute] DbContextOptions options) : base(options) { }

        public RepositoryMasterContext() : base() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new SelfieEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new WookieEntityTypeConfiguration());
        }

        //Set dbset entities
        public DbSet<EntityDefinition> EntityDefinition { get; set; }


        //Only test
        public DbSet<Selfie> Selfies { get; set; }
        public DbSet<Wookie> Wookies { get; set; }
        public DbSet<Picture> Pictures { get; set; }



    }
}
