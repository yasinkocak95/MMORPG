using Microsoft.EntityFrameworkCore;
using NTier.DAL.Configurations;
using NTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.DAL.Context
{
    public class MMORPGContext:DbContext
    {
        const string server = "Server=KOCAK\\SQLEXPRESS;Database=MMORPGContextNTIER;Trusted_Connection=True;TrustServerCertificate=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(server);
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClothConfiguration());
            modelBuilder.ApplyConfiguration(new JobConfiguration());
            modelBuilder.ApplyConfiguration(new CharacterConfiguration());
            modelBuilder.ApplyConfiguration(new RaceConfiguration());
            modelBuilder.ApplyConfiguration(new WeaponConfiguration());


            base.OnModelCreating(modelBuilder);
        }

        DbSet<Character> Characters { get; set; }
        DbSet<Cloth> Cloths { get; set; }
        DbSet<Race> Races { get; set; }
        DbSet<Weapon> Weapons { get; set; }
        DbSet<Job> Jobs { get; set; }

    }
}
