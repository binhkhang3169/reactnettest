using Microsoft.EntityFrameworkCore;
using todos_backend.Configuration;
using todos_backend.Models;
using todos_backend.Seeders;

namespace todos_backend.Data
{
    public class TodosDbContext : DbContext
    {
        public TodosDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TodoConfiguration());

            modelBuilder.Seed();
        }

        public DbSet<Todo> Todos { get; set; }
    }
}
