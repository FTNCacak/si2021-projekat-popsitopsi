
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public interface IBillItemRepository
    {
        public List<BillItem> GetAllBillItems();
        public int InsertBillItem(BillItem bi);
        public int UpdateBillItem(BillItem bi);
        public int DeleteBillItem(int billId, int articleId);
        
    }
}
