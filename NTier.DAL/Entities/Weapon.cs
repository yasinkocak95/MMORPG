using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.DAL.Entities
{
    public class Weapon:BaseClass
    {
        
        //mapping
        public List<Character> Character { get; set; }
    }
}
