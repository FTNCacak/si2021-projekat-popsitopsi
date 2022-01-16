using DataLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shared;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayerTest
{
    public class BillRepositoryTest
    {
        public Bill bill;
        public IBillRepository billRepository;


        [TestInitialize]
        public void init()
        {
            bill = new Bill
            {
                Date = DateTime.Now,
                Id = 4141,
                Stuff_Id = 424,
                Total = 2442,
               


            };

            billRepository = new BillRepository();

        }
        [TestMethod]
        public void GetAllBillTest()
        {
            billRepository.InsertBill(bill);
            Assert.IsNotNull(billRepository.GetAllBills());
        }

        [TestMethod]
        public void InsertBillTest()
        {
            int result = billRepository.InsertBill(bill);
            Assert.IsTrue(result > 0);
        }
        [TestMethod]
        public void UpdateBillTest()
        {
            billRepository.InsertBill(bill);
            Bill newBill = billRepository.GetAllBills().Where(x => x.Id == bill.Id).ToList()[0];
            int result = billRepository.UpdateBill(newBill);
            Assert.IsTrue(result > 0);
        }
    }
}

