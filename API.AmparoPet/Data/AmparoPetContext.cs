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
    public DbSet<Vaccine> Vaccines { get; set; }
    public DbSet<CardVaccine> CardVaccines { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pet>().ToTable(nameof(Pet))
            .HasOne(p => p.CardVaccine)
            .WithOne(cv => cv.Pet)
            .HasForeignKey<CardVaccine>(cv => cv.CardVaccineID);

        modelBuilder.Entity<Pet>()
            .HasMany(c => c.Caregivers)
            .WithMany(i => i.Pets);

        modelBuilder.Entity<Carer>().ToTable(nameof(Carer));
        modelBuilder.Entity<Vaccine>().ToTable(nameof(Vaccine));
        modelBuilder.Entity<Vaccine>()
            .HasOne(v => v.CardVaccine)
            .WithMany()
            .HasForeignKey(v => v.CardVaccineId);
    }
}
