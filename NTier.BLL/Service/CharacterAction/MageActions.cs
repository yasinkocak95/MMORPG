using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.BLL.Service.CharakterAction
{
    public class MageActions : IBaseCharacterActions
    {
        public string Attack()
        {
            return "Mage Saldırıyor...";
        }

        public string Defend()
        {
            return "Mage Savunuyor...";
        }

        public string Rest()
        {
            return "Mage Dinleniyor...";
        }

        public string Walk()
        {
            return "Mage Yürüyor...";
        }
    }
}
