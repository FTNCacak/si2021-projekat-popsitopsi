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
    [TestClass]
    public class BillRepositoryTest
    {
        public Bill bill;
        public IBillRepository billRepository;
        public List<int> listIDS = new List<int>();

        [TestInitialize]
        public void init()
        {
            bill = new Bill
            {
                Date = DateTime.Now,
                Stuff_Id = 1003,
                Total = 2442,
            };

            billRepository = new BillRepository();

        }
        [TestMethod]
        public void GetAllBillTest()
        {
            billRepository.InsertBill(bill);
            listIDS.Add(billRepository.GetNewBillId());
            Assert.IsNotNull(billRepository.GetAllBills());
        }

        [TestMethod]
        public void InsertBillTest()
        {
            int result = billRepository.InsertBill(bill);
            listIDS.Add(billRepository.GetNewBillId());
            Assert.IsTrue(result > 0);
        }
        [TestMethod]
        public void UpdateBillTest()
        {
            billRepository.InsertBill(bill);
            int newId = billRepository.GetNewBillId();
            bill.Total = 55000;
            bill.Id = newId;
            listIDS.Add(newId);
            billRepository.UpdateBill(bill);
            decimal result = billRepository.GetAllBills().FirstOrDefault(x => x.Id == bill.Id).Total;
            Assert.AreEqual(result, 55000);
        }
        [TestCleanup]
        public void CleanUpAfterTest()
        {
            foreach (int item in listIDS)
            {
                billRepository.DeleteBill(item);
            }
        }
    }
}

