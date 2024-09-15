using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.BLL.Service.CharakterAction
{
    public class WarriorActions : IBaseCharacterActions
    {

        public string Attack()
        {
            return "Warrior Saldırıyor...";
        }

        public string Defend()
        {
            return "Warrior Savunuyor...";
        }

        public string Rest()
        {
            return "Warrior Dinleniyor...";
        }

        public string Walk()
        {
            return "Warrior Yürüyor...";
        }
    }
}
