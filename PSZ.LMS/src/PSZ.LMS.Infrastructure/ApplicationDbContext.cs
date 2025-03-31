using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PSZ.LMS.Domain.Entities;

namespace PSZ.LMS.Infrastructure
{
    public class ApplicationDbContext : IdentityDbContext
    {
        private string _connectionString;
        private string _migrationAssembly;
        public ApplicationDbContext(string connectionString, string migrationAssembly)
        {
            _connectionString = connectionString;
            _migrationAssembly = migrationAssembly;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString, sqlOptions =>
            {
                sqlOptions.MigrationsAssembly(_migrationAssembly);
            });
        }

        public DbSet<Category> Categories { get; set; }
    }
}
