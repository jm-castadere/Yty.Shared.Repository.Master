using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yty.Shared.Repository.Master.Domain;
using Yty.Shared.Repository.Master.Domain.Entities;

namespace Yty.Shared.Repository.Master.Infrastructures.Data.TypeConfigurations
{
    class WookieEntityTypeConfiguration : IEntityTypeConfiguration<Wookie>
    {
        public void Configure(EntityTypeBuilder<Wookie> builder)
        {
            builder.ToTable("Wookie");
        }
    }
}
