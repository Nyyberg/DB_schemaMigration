using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;

public class StoreContext : DbContext
{
    public DbSet<Products> Product { get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<Ratings> Ratings { get; set; }

    public string DbPath { get; }

    public StoreContext()
    {
       
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=localhost;Database=migrationDb;User Id=sa;Password=fuckth1sSh!t;Trusted_Connection=False;TrustServerCertificate=True;");
}

public class Products
{
    public int Id { get; set; }
    public string Name { get; set; }
    public float Price { get; set; }
    public virtual List<Ratings> Ratings { get; set; }
}

public class Category
{
    public int Id { get; set; }
    
    public string CategoryName { get; set; }

    public virtual List<Products> ProductName { get; set; }
}

public class Ratings
{
    public int RatingsID { get; set; }
    public float Rating { get; set; }

}