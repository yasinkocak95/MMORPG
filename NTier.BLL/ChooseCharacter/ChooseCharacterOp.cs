using NTier.BLL.Service.Instance;
using NTier.DAL.Datas;
using NTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.BLL.ChooseCharacter
{
    public class ChooseCharacterOp
    {
        public void WelcomeText()
        {
            Console.WriteLine("Welcome Player");
        }
        public void EnterUserName() 
        {
           Console.WriteLine("Enter Your Character Name:");
           string gelenCharacterName = Console.ReadLine();
        }
        public void ChooseRace(Race race)
        {
            foreach (var r in RaceData.GetRaces())
            {
                Console.WriteLine($"{r.ID} || {r.Name}");
            }
        }
    }
}
