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
    public class RaceConfiguration : IEntityTypeConfiguration<Race>
    {
        public void Configure(EntityTypeBuilder<Race> builder)
        {
            builder.HasKey(x=>x.ID);

            builder.HasData(RaceData.GetRaces());
        }
    }
}
