using Microsoft.EntityFrameworkCore;
namespace Midterm_ToDoList.Models
{
    public class NAppDbContext: DbContext
    {
        public NAppDbContext(DbContextOptions<NAppDbContext> options) : base(options) { }
        public DbSet<NToDo> NToDo { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NToDo>().HasData(

                new NToDo { Id = 1, Description = "Generating Art", Category = "Activity", Done = false }
                );
        }

    }
}
