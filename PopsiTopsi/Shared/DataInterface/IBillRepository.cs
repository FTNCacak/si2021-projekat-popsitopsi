
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public interface IBillRepository
    {
        public List<Bill> GetAllBills();
        public int InsertBill(Bill b);
        public int UpdateBill(Bill b);
        public int DeleteBill(int id);
        public int GetNewBillId();
    }
}
