using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;

public class CarRentalContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.
            UseSqlite("Data Source=/Users/kaankahveci/RiderProjects/ReCapProject/carrental.sqlite");
    }
    
    public DbSet<Car>? Cars { get; set; }
    public DbSet<Brand>? Brands { get; set; }
    public DbSet<Color>? Colors { get; set; }
    public DbSet<User>? Users { get; set; }
    public DbSet<Customer>? Customers { get; set; }
    public DbSet<Rental>? Rentals { get; set; }
}