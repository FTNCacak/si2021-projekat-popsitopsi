using DataLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
   public class BillBusiness
    {
        public readonly BillRepository billRepository;

        public BillBusiness()
        {
            this.billRepository = new BillRepository();
        }
    }
}
