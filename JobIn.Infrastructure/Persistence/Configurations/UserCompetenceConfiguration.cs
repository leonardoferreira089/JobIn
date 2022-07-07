using JobIn.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Infrastructure.Persistence.Configurations
{
    public class UserCompetenceConfiguration : IEntityTypeConfiguration<UserCompetence>
    {
        public void Configure(EntityTypeBuilder<UserCompetence> builder)
        {
            builder
                .HasKey(c => c.Id);
        }
    }
}
