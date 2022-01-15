using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared;
using Shared.BusinessInterface;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayerTest
{
    [TestClass]
    public class BillBusinessTest
    {

        private Mock<IBillRepository> mockBillRepository = new Mock<IBillRepository>();

        private Bill bill1 = new Bill
        {
            Date= DateTime.Now,
            Id= 15,
            Stuff_Id= 35,
            Total= 121511
        };
        private Bill bill2 = new Bill
        {
            Date = DateTime.Now,
            Id = 32,
            Stuff_Id = 11,
            Total = 1012
        };
        private Bill bill3 = new Bill
        {
            Date = DateTime.Now,
            Id = 5,
            Stuff_Id = 2,
            Total = 2352
        };
        private BillBusiness billBusiness;
        private List<Bill> list = new List<Bill>();

        public BillBusinessTest()
        {
            list.Add(bill1);
            list.Add(bill2);
            list.Add(bill3);
        }

        [TestMethod]
        public void GetAllBillsTest()
        {
            mockBillRepository.Setup(a => a.GetAllBills()).Returns(list);
            this.billBusiness = new BillBusiness(mockBillRepository.Object);
            var result = billBusiness.GetAllBills();
            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void UpdateBillTest()
        {
            mockBillRepository.Setup(x => x.UpdateBill(bill1)).Returns(1);
            this.billBusiness = new BillBusiness(mockBillRepository.Object);

            var result = billBusiness.UpdateBill(bill1);

            Assert.AreEqual(result,true);
        }

        [TestMethod]
        public void InsertBillTest()
        {
            mockBillRepository.Setup(x => x.InsertBill(bill3)).Returns(1);
            this.billBusiness = new BillBusiness(mockBillRepository.Object);

            var result = billBusiness.InsertBill(bill3);

            Assert.AreEqual(result,true);
        }
    }
}