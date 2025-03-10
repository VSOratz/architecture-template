namespace ATemplate.Database;

public class ApplicationDbContext(DbContextOptions options)
    : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
}
