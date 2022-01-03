using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class StuffBusiness
    {
        public readonly StuffRepository stuffRepository;

        public StuffBusiness()
        {
            this.stuffRepository = new StuffRepository();
        }

        public bool InsertStuff(Stuff s)
        {
            if (this.stuffRepository.InsertStuff(s) > 0)
            {
                return true;
            }
            else return false;
        }

        public List<Stuff> GetAllStuffs()
        {
            return this.stuffRepository.GetAllStuffs();
        }
    }
}
