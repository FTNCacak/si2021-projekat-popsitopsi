
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.BusinessInterface
{
    public interface IBillBusiness
    {
        public bool InsertBill(Bill b);
        public List<Bill> GetAllBills();
        public bool DeleteBill(int idSelected);
        public bool UpdateBill(Bill b);
        public int GetNewBillId();

    }
}
