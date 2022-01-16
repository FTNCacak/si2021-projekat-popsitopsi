using DataLayer;
using Shared;
using Shared.BusinessInterface;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class BillItemBusiness :IBillItemBusiness
    {
        public readonly IBillItemRepository billItemRepository;

        public BillItemBusiness(IBillItemRepository _billItemRepository)
        {
            this.billItemRepository = _billItemRepository;
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
