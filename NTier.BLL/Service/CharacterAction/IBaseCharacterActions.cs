using NTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.BLL.Service.CharakterAction
{
    public interface IBaseCharacterActions
    {

        public string Attack();
        public string Defend();
        public string Walk();
        public string Rest();

    }
}
