using AG.Book.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;


public class BookContext : DbContext
{
    public BookContext(DbContextOptions options) : base(options) { }

    public DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BookConfiguration());
        base.OnModelCreating(modelBuilder);
    }
}

