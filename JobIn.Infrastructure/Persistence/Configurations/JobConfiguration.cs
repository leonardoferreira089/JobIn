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
    public class JobConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder
                .HasKey(j => j.Id);

            builder
                .HasOne(j => j.Company)
                .WithMany(j => j.CompanyJobs)
                .HasForeignKey(j => j.IdCompany)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(j => j.Candidate)
                .WithMany(j => j.CandidateJobs)
                .HasForeignKey(j => j.IdCandidate)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
