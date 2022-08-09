using System.Reflection;
using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Infrastructure
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Reminder> Reminders { get; set; }

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetConfigurationsAssembly());
            base.OnModelCreating(modelBuilder);
        }

        private Assembly GetConfigurationsAssembly()
        {
            return typeof(DatabaseContext).Assembly;
        }
    }
}