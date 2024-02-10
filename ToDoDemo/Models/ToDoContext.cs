using Microsoft.EntityFrameworkCore;

namespace ToDoDemo.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }
        public DbSet<ToDo> ToDos { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "trabalho", Name = "Trabalho" },
                new Category { CategoryId = "escola", Name = "Escola" },
                new Category { CategoryId = "casa", Name = "Casa" },
                new Category { CategoryId = "ativ", Name = "Atividade" },
                new Category { CategoryId = "acad", Name = "Academia" }
                );
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = "open", Name = "Aberto" },
                new Status { StatusId = "closed", Name = "Completo" }
                );
        }
    }
}
