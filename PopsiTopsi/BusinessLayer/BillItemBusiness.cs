using DataLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
   public class BillItemsBusiness
    {
        public readonly BillItemRepository billItemRepository;

        public BillItemsBusiness()
        {
            this.billItemRepository = new BillItemRepository();
        }
    }
}
