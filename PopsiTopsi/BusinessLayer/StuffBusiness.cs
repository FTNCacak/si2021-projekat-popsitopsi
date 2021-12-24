using DataLayer;
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
    }
}
