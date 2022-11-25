using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using wpfgestimo.Data.Models;

namespace wpfgestimo
{
    public class ImmoContext : DbContext
    {
        public DbSet<Bail> Bails { get; set; }
        public DbSet<Bien> Biens { get; set; }
        public DbSet<Locataire> Locataires { get; set; }
        public DbSet<Pret> Prets { get; set; }
        public DbSet<Intervention> Interventions { get; set; }
        public DbSet<Prestataire> Prestataires { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Database=gestImmo;Username=postgres;Password=123456");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Habitable>().ToTable("Habitable");
            modelBuilder.Entity<Maison>().ToTable("Maison");
            modelBuilder.Entity<Box>().ToTable("Box");
            modelBuilder.Entity<Appartement>().ToTable("Appartement");

        }

        private static ImmoContext instance;

        public static ImmoContext getInstance()
        {
            if (instance == null)
            {
                instance = new ImmoContext();
            }

            return instance;
        }
       
        
    }

}
