using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Yty.Shared.Repository.Master.Domain;
using Yty.Shared.Repository.Master.Domain.Entities;

namespace Yty.Shared.Repository.Master.Infrastructures.Data.TypeConfigurations
{
    class SelfieEntityTypeConfiguration : IEntityTypeConfiguration<Selfie>
    {
        public void Configure(EntityTypeBuilder<Selfie> builder)
        {
            builder.ToTable("Selfie");


            builder.HasKey(item => item.Id);

            builder.HasOne(item => item.Wookie)
                   .WithMany(item => item.Selfies);
        }
    }
}
