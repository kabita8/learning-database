using Microsoft.EntityFrameworkCore;
public class BasicDbContext: DbContext
{
    public DbSet<Teacher> Teachers {get; set;}
 protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
 {
    optionsbuilder.UseSqlite("Data Source=College.db");
 }
}
