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

        public bool DeleteBillItem(int idBill, int idArticle)
        {
            if (this.billItemRepository.DeleteBillItem(idBill, idArticle) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateBillItem(BillItem b)
        {
            if (this.billItemRepository.UpdateBillItem(b) > 0)
            {
                return true;
            }
            return false;

        }
    }
}
