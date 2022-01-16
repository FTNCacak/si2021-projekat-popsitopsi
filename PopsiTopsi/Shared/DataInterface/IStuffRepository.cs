
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
   public interface IStuffRepository
    {
        public List<Stuff> GetAllStuffs();
        public int InsertStuff(Stuff s);
        public int UpdateStuff(Stuff s);
        public int DeleteStuff(int id);
        public int GetStuffNewId();
    }
}
