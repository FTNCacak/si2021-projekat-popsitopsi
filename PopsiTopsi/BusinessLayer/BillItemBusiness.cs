using DataLayer;
using DataLayer.Models;
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

        public bool InsertBillItem(BillItem b)
        {
            if (this.billItemRepository.InsertBillItem(b) > 0)
            {
                return true;
            }
            else return false;
        }

        public List<BillItem> GetAllBillItems()
        {
            return this.billItemRepository.GetAllBillItems();
        }
    }
}
