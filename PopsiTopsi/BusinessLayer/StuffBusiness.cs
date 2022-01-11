using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public Stuff GetSelectedStuff(int idSelected)
        {
            return this.stuffRepository.GetAllStuffs().FirstOrDefault(s => s.Id == idSelected);
        }


        public bool DeleteStuff(int idSelected)
        {
            if (this.stuffRepository.DeleteStuff(idSelected) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateStuff(Stuff s,int idSelected)
        {
            if (this.stuffRepository.UpdateStuff(s,idSelected) > 0)
            {
                return true;
            }
            return false;

        }
    }
}
