using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.BLL.Service.CharakterAction
{
    public class RogueAction : IBaseCharacterActions
    {
        public string Attack()
        {
            return "Rogue Saldırıyor...";
        }

        public string Defend()
        {
            return "Rogue Savunuyor...";
        }

        public string Rest()
        {
            return "Rogue Dinleniyor...";
        }

        public string Walk()
        {
            return "Rogue Yürüyor...";
        }
    }
}
