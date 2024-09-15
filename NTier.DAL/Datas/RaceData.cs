using NTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.DAL.Datas
{
    public class RaceData
    {
        public static List<Race> GetRaces()
        {
            return new List<Race>
            {
               new Race {ID=1,Name="Human"},
               new Race {ID=2,Name="NightElf"},
               new Race {ID=3,Name="Dwarf"},
               new Race {ID=4,Name="Orc"},
               new Race {ID=5,Name="Undead"},

            };
        }
    }

}
