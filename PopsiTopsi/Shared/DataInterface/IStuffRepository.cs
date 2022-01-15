
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
        public int UpdateStuff(Stuff s, int id);
        public int DeleteStuff(int id);
    }
}
