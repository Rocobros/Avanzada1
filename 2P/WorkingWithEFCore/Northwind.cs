using static System.Console;
using Microsoft.EntityFrameworkCore;
namespace WorkingWithEFCore;
public class Northwind : DbContext{
    // DbSet: Para mapear la clase desde la DB
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Product>? Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string path = Path.Combine(Environment.CurrentDirectory, "Northwind.db");
        string connetion = $"Filename: {path}";
        ConsoleColor backgroundColor = ForegroundColor;
        ForegroundColor = ConsoleColor.DarkYellow;
        WriteLine($"Connection: {connetion}");
        ForegroundColor = backgroundColor;
        optionsBuilder.UseSqlite(connetion);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Fluent API
        //always uses the model builder
        //always define FIRST the ENTITY to Apply the validations
        modelBuilder.Entity<Category>()
        .Property(category => category.CategoryName)
        .IsRequired()
        .HasMaxLength(15); //Then the property to validate
        if(Database.ProviderName?.Contains("Sqlite") ?? false){
            modelBuilder.Entity<Product>()
            .Property(product => product.Cost)
            .HasConversion<double>();
        }
    }
}