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
    public class BillItemBusinessTest
    {

        private Mock<IBillItemRepository> mockBillItemRepository = new Mock<IBillItemRepository>();

        private BillItem billitem1 = new BillItem
        {
            Quantity = 23,
            Bill_Id = 56,
            Article_Id = 33,
        };
        private BillItem billitem2 = new BillItem
        {
            Quantity = 65,
            Bill_Id = 42,
            Article_Id = 12,
        };
        private BillItem billitem3 = new BillItem
        {
            Quantity = 20,
            Bill_Id = 15,
            Article_Id = 23,
        };
        private BillItemBusiness billItemBusiness;
        private List<BillItem> list = new List<BillItem>();

        public BillItemBusinessTest()
        {
            list.Add(billitem1);
            list.Add(billitem2);
            list.Add(billitem3);
        }

        [TestMethod]
        public void GetAllBillItemTest()
        {
            mockBillItemRepository.Setup(a => a.GetAllBillItems()).Returns(list);
            this.billItemBusiness = new BillItemBusiness(mockBillItemRepository.Object);
            var result = billItemBusiness.GetAllBillItems();
            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void UpdateBillTest()
        {
            mockBillItemRepository.Setup(x => x.UpdateBillItem(billitem1)).Returns(1);
            this.billItemBusiness = new BillItemBusiness(mockBillItemRepository.Object);

            var result = billItemBusiness.UpdateBillItem(billitem1);

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void InsertBillTest()
        {
            mockBillItemRepository.Setup(x => x.InsertBillItem(billitem3)).Returns(1);
            this.billItemBusiness = new BillItemBusiness(mockBillItemRepository.Object);

            var result = billItemBusiness.InsertBillItem(billitem3);

            Assert.AreEqual(result, true);
        }
    }
}
