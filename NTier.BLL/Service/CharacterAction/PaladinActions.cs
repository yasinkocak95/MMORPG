using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.BLL.Service.CharakterAction
{
    public class PaladinActions : IBaseCharacterActions
    {
        public string Attack()
        {
            return "Paladin Saldırıyor...";
        }

        public string Defend()
        {
            return "Paladin Savunuyor...";
        }

        public string Rest()
        {
            return "Paladin Dinleniyor...";
        }

        public string Walk()
        {
            return "Paladin Yürüyor...";
        }
    }
}
