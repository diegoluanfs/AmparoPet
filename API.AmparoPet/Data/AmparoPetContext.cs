using API.AmparoPet.Models;
using Microsoft.EntityFrameworkCore;

namespace API.AmparoPet.Data
{
    public class AmparoPetContext : DbContext
    {
        public AmparoPetContext(DbContextOptions<AmparoPetContext> options) : base(options)
        {
        }

        //public DbSet<Pet> Pets { get; set; }
        public DbSet<Carer> Caregivers { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }
        //public DbSet<Photo> Photos { get; set; }
        public DbSet<Address> Addresses { get; set; }
        //public DbSet<Document> Documents { get; set; }
        public DbSet<CardVaccine> CardVaccines { get; set; }
        public DbSet<Post> Posts { get; set; }
        //public DbSet<Comment> Comments { get; set; }
        //public DbSet<Reaction> Reactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().ToTable(nameof(Address));
            modelBuilder.Entity<Carer>().ToTable(nameof(Carer));
            modelBuilder.Entity<Pet>().ToTable(nameof(Pet));
            modelBuilder.Entity<CardVaccine>().ToTable(nameof(CardVaccine));
            modelBuilder.Entity<Vaccine>().ToTable(nameof(Vaccine));
            modelBuilder.Entity<Post>().ToTable(nameof(Post));
            //modelBuilder.Entity<Photo>().ToTable(nameof(Photo));

            modelBuilder.Entity<Carer>()
                .HasOne(c => c.Address)
                .WithMany()
                .HasForeignKey(c => c.AddressID)
                .IsRequired(false);

            modelBuilder.Entity<Carer>()
                .HasMany(c => c.Pets)
                .WithOne(p => p.Carer)
                .HasForeignKey(p => p.CarerID)
                .IsRequired(false);

            modelBuilder.Entity<Pet>()
                .HasOne(cv => cv.CardVaccine)
                .WithMany()
                .HasForeignKey(cv => cv.CardVaccineID)
                .IsRequired(false);

            modelBuilder.Entity<CardVaccine>()
                .HasMany(cv => cv.Vaccines)
                .WithOne(v => v.CardVaccine)
                .HasForeignKey(v => v.CardVaccineID);

            modelBuilder.Entity<Carer>()
                .HasMany(c => c.Posts)
                .WithOne(p => p.Carer)
                .HasForeignKey(p => p.CarerID)
                .IsRequired(false);

            //modelBuilder.Entity<Post>()
            //    .HasMany(c => c.Photo)
            //    .WithOne(p => p.Post)
            //    .HasForeignKey(p => p.PostID)
            //    .IsRequired(false);
        }
    }
}
