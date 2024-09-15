using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.DAL.Configurations
{
    public class CharacterConfiguration : IEntityTypeConfiguration<Character>
    {
        public void Configure(EntityTypeBuilder<Character> builder)
        {
            builder.HasKey(x => x.ID);
            
            builder.Property(x => x.Name).HasMaxLength(256).IsRequired(false);
            

            builder
               .HasOne(x => x.Race)
               .WithMany(x => x.Character)
               .HasForeignKey(x => x.RaceID)
               .IsRequired();

            builder
                .HasOne(x => x.Job)
                .WithMany(x => x.Character)
                .HasForeignKey(x => x.JobID)
                .IsRequired();

            builder
                .HasOne(x => x.Weapon)
                .WithMany(x => x.Character)
                .HasForeignKey(x => x.WeaponID)
                .IsRequired();

            builder
                .HasOne(x => x.Cloth)
                .WithMany(x => x.Character)
                .HasForeignKey(x => x.ClothID)
                .IsRequired();

        }
    }
}
