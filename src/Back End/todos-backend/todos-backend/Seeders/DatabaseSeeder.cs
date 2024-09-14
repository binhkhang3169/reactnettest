using Microsoft.EntityFrameworkCore;
using todos_backend.Models;

namespace todos_backend.Seeders
{
    public static class DatabaseSeeder
    {
        public static void Seed(this ModelBuilder model)
        {
            model.Entity<Todo>().HasData(
                new Todo { Id = 1,Name = "Nhiệm vụ",IsComplete=true },
                new Todo { Id = 2,Name = "Thực hiện",IsComplete=true }

            );

        }
    }
}
