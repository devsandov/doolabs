using Microsoft.EntityFrameworkCore;
using System;

namespace Doolabs;
public class RepositoryDBContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<Position> Positions { get; set; }
    public DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // shoulbd be has the db conection
        optionsBuilder.UseSqlServer("");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>()
            .HasOne(e => e.Position)
            .WithMany()
            .HasForeignKey("PositionId");

        modelBuilder.Entity<Employee>()
            .HasMany(e => e.EmpleadosACargo)
            .WithOne()
            .HasForeignKey("PersonId");
    }

}

// and also the entire crud operations