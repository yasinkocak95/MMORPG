using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTier.DAL.Datas;
using NTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.DAL.Configurations
{
    public class WeaponConfiguration : IEntityTypeConfiguration<Weapon>
    {
        public void Configure(EntityTypeBuilder<Weapon> builder)
        {
            builder.HasKey(x=>x.ID);

            builder.HasData(WeaponData.GetWeapons());
        }
    }
}
