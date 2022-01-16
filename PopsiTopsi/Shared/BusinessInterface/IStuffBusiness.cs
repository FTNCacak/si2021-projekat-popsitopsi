
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.BusinessInterface
{
    public interface IStuffBusiness
    {
        public bool InsertStuff(Stuff s);
        public List<Stuff> GetAllStuffs();
        public bool DeleteStuff(int idSelected);
        public bool UpdateStuff(Stuff s);
        public Stuff GetSelectedStuff(int idSelected);

        public int GetStuffNewId();
    }
}
