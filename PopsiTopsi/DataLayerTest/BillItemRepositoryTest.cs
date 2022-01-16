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
    public class BillItemRepositoryTest
    {
        public BillItem billitem;
        public IBillItemRepository billitemRepository;
        public List<BillItem> list = new List<BillItem>();
        public BillItem billitem1, billitem2;

        [TestInitialize]
        public void init()
        {
           billitem = new BillItem
            {
                Article_Id = 7,
                Bill_Id = 5010,
                Quantity = 33333,
                

            };
           billitem1 = new BillItem
            {
                Article_Id = 9,
                Bill_Id = 5010,
                Quantity = 33333,


            };
            billitem2 = new BillItem
            {
                Article_Id = 8,
                Bill_Id = 5010,
                Quantity = 33333,


            };
            
            list.Add(billitem);
            list.Add(billitem1);
            list.Add(billitem2);

            billitemRepository = new BillItemRepository();

        }
        [TestMethod]
        public void GetAllBillItemTest()
        {
            billitemRepository.InsertBillItem(billitem);
            Assert.IsNotNull(billitemRepository.GetAllBillItems());
        }

        [TestMethod]
        public void InsertBillItemTest()
        {
            int result = billitemRepository.InsertBillItem(billitem1);
           
            Assert.IsTrue(result > 0);
        }
        [TestMethod]
        public void UpdateBillItemTest()
        {
            billitemRepository.InsertBillItem(billitem2);
           
            billitem2.Quantity = 256;
           
            billitemRepository.UpdateBillItem(billitem2);
            decimal result = billitemRepository.GetAllBillItems().FirstOrDefault(x => x.Bill_Id == billitem2.Bill_Id && x.Article_Id==billitem2.Article_Id).Quantity;
            Assert.AreEqual(result,256);
        }
        [TestCleanup]
        public void CleanUpAfterTest()
        {
            foreach (BillItem item in list)
            {
                billitemRepository.DeleteBillItem(item.Bill_Id,item.Article_Id);
            }
        }
    }
}
