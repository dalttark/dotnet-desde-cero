using Microsoft.EntityFrameworkCore;

namespace TODO.WebApi.Models
{
    public class TODOAppDbContextClass : DbContext
    {
        public TODOAppDbContextClass(DbContextOptions<TODOAppDbContextClass> options) : base(options) { } 
        
        public DbSet<User> Users { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("TODOAppUsers");
            modelBuilder.Entity<TodoItem>().ToTable("TodoItems");
        }
        */

    }
}
