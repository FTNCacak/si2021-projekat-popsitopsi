using DataLayer;
using DataLayer.Models;
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

        public bool InsertBill(Bill b)
        {
            if (this.billRepository.InsertBill(b) > 0)
            {
                return true;
            }
            else return false;
        }

        public List<Bill> GetAllBills()
        {
            return this.billRepository.GetAllBills();
        }

        public bool DeleteBill(int idSelected)
        {
            if (this.billRepository.DeleteBill(idSelected) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateBill(Bill b)
        {
            if (this.billRepository.UpdateBill(b) > 0)
            {
                return true;
            }
            return false;

        }
        public int GetNewBillId()
        {
            return this.billRepository.GetNewBillId();
        }
    }
}
