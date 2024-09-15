using NTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.DAL.Datas
{
    public class WeaponData
    {
        public static List<Weapon> GetWeapons()
        {
            return new List<Weapon>
            {
               new Weapon {ID=1,Name="One Handed Sword"},
               new Weapon {ID=2,Name="Double Handed Sword"},
               new Weapon {ID=3,Name="Axe"},
               new Weapon {ID=4,Name="Knife"},
               new Weapon {ID=5,Name="Staff"},

            };
        }
    }
}
