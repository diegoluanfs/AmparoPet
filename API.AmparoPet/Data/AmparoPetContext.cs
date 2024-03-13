using API.AmparoPet.Models;
using Microsoft.EntityFrameworkCore;

namespace API.AmparoPet.Data;

public class AmparoPetContext : DbContext
{
    public AmparoPetContext(DbContextOptions<AmparoPetContext> options) : base(options)
    {
    }

    public DbSet<Pet> Pets { get; set; }
    public DbSet<Carer> Caregivers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pet>().ToTable(nameof(Pet))
            .HasMany(c => c.Caregivers)
            .WithMany(i => i.Pets);
        modelBuilder.Entity<Carer>().ToTable(nameof(Carer));
    }
}
