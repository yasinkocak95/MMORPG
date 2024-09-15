using NTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.DAL.Datas
{
    public class ClothData
    {
        public static List<Cloth> GetCloths()
        {
            return new List<Cloth>
            {
               new Cloth {ID=1,Name="Steel Cloth"},
               new Cloth {ID=2,Name="Iron Cloth"},
               new Cloth {ID=3,Name="Gold Cloth"},
               new Cloth {ID=4,Name="Fabric Cloth"},
               new Cloth {ID=5,Name="Silk Cloth"},

            };
        }
    }
}
