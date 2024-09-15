using NTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NTier.DAL.Datas
{
    public class JobData
    {
        public static List<Job> GetJobs()
        {
            return new List<Job>
            {
               new Job {ID=1,Name="Warrior"},
               new Job {ID=2,Name="Paladin"},
               new Job {ID=3,Name="Rogue"},
               new Job {ID=4,Name="Mage"},
            };
        }
    }
}
