using DataLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
   public class BillItemBusiness
    {
        public readonly BillItemRepository billItemRepository;

        public BillItemBusiness()
        {
            this.billItemRepository = new BillItemRepository();
        }
    }
}
