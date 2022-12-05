using GestImmo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.Data.DAL
{
    public class GestImmoContext : DbContext
    {
        public DbSet<Pret> Pret { get; set; }

        public DbSet<Bien> Biens { get; set; }

        public DbSet<Locataire> Locataires { get; set; }

        public DbSet<Bail> Bails { get; set; }

        public DbSet<Intervention> Interventions { get; set; }

        public DbSet<Prestataire> Prestataires { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Database=gestImmo;Username=postgres;Password=postgres");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Habitable>().ToTable("Habitable");
            modelBuilder.Entity<Maison>().ToTable("Maison");
            modelBuilder.Entity<Box>().ToTable("Box");
            modelBuilder.Entity<Appartement>().ToTable("Appartement");
        }

        private static GestImmoContext instance;
        public static GestImmoContext getInstance()
        {
            if (instance == null)
            {
                instance = new GestImmoContext();
            }
            return instance;
        }

    }
}
