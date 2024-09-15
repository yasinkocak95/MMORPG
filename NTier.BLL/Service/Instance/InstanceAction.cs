using NTier.BLL.Service.CharakterAction;
using NTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.BLL.Service.Instance
{
    public class InstanceAction
    {
        public InstanceAction()
        {
            MageActions mageActions = new MageActions();
            PaladinActions paladinActions = new PaladinActions();
            RogueAction rogueAction = new RogueAction();
            WarriorActions warriorActions = new WarriorActions();
        }
    }
}
