
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.BusinessInterface
{
   public  interface IBillItemBusiness
    {
        public bool InsertBillItem(BillItem b);
        public List<BillItem> GetAllBillItems();
        public bool DeleteBillItem(int idBill, int idArticle);
        public bool UpdateBillItem(BillItem b);
      

    }
}
