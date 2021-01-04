using System;
using Bugs.Models;
using Microsoft.EntityFrameworkCore;

namespace Bugs.DataAccess
{
    public class BugsContext : DbContext
    {
        public DbSet<BugModel> Bugs { get; set; }

        public BugsContext(DbContextOptions
            <BugsContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BugModel>().HasData(
                new BugModel { Description = "no Image", Status = false, Id = Guid.NewGuid()},
                new BugModel { Description = "no price", Status = false, Id = Guid.NewGuid() },
                new BugModel { Description = "no name", Status = false, Id = Guid.NewGuid() },
                new BugModel { Description = "no descriptive text", Status = false, Id = Guid.NewGuid() }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
