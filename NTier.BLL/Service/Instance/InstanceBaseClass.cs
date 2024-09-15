using NTier.DAL.Datas;
using NTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.BLL.Service.Instance
{
    public class InstanceBaseClass:BaseClass
    {
        public InstanceBaseClass()
        {
            ClothData clothData = new ClothData();
            JobData jobData = new JobData();
            RaceData raceData = new RaceData();
            WeaponData weaponData = new WeaponData();

        }
        
    }
}
