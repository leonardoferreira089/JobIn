using JobIn.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Infrastructure.Persistence
{
    public class JobInDbContext : DbContext
    {
        public JobInDbContext(DbContextOptions<JobInDbContext>options) : base(options)
        {

        }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Competence> Competences { get; set; }
        public DbSet<JobComment> JobComments { get; set; }
        public DbSet<UserCompetence> UserCompetences { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
