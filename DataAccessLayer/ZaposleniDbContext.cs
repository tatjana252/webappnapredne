using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccessLayer
{
    public class ZaposleniDbContext : DbContext
    {
        public DbSet<Zaposleni> Zaposleni { get; set; }
        public DbSet<Odeljenje> Odeljenja { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source = (localdb)\MSSQLLocalDB; Initial catalog=ZaposleniDB; Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Zaposleni>().HasKey(z => z.ZaposleniId);
            modelBuilder.Entity<Zaposleni>().Property(z => z.ZaposleniId).ValueGeneratedNever();
            modelBuilder.Entity<Zaposleni>().Property(z => z.Ime).IsRequired();
            modelBuilder.Entity<Zaposleni>().Property(z => z.Prezime).IsRequired();

            modelBuilder.Entity<Zaposleni>()
                .HasOne(z => z.Odeljenje)
                .WithMany()
                .HasForeignKey(z => z.OdeljenjeId);
            modelBuilder.Entity<Odeljenje>().HasData(new Odeljenje { Id = 1, Naziv = "Finansije" }, new Odeljenje { Id = 2, Naziv = "Prodaja" });
            modelBuilder.Entity<Zaposleni>().HasData(new Zaposleni { ZaposleniId = 1, Ime ="Pera", Prezime = "Peric", OdeljenjeId = 2});
        }


    }
}
