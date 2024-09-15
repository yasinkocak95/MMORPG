using Microsoft.EntityFrameworkCore;
using NTier.DAL.Context;
using NTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.BLL.Service.CharakterCreate
{
    public class CharacterCreate<T> where T : BaseClass
    {
        private MMORPGContext MMORPGContext = new MMORPGContext();
        public string Create(T model)
        {
            MMORPGContext.Set<T>().Add(model);
            MMORPGContext.SaveChanges();
            return "Add Succesfull!";

        }

        public T GetByID(int id)
        {
            MMORPGContext context = MMORPGContext;
            return context.Set<T>().Find(id);
        }
    }
}
