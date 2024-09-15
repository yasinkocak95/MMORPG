using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.DAL.Entities
{
    public class Character:BaseClass
    {

        //mapping
        public Cloth Cloth { get; set; }
        public Weapon Weapon { get; set; }
        public Job Job { get; set; }
        public Race Race { get; set; }

        public int ClothID { get; set; }
        public int JobID { get; set; }
        public int RaceID { get; set; }
        public int WeaponID { get; set; }


    }
}
