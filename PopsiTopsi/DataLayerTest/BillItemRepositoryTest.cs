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
    public class BillItemRepositoryTest
    {
        public BillItem billitem;
        public IBillItemRepository billitemRepository;


        [TestInitialize]
        public void init()
        {
            billitem = new BillItem
            {
                Article_Id = 4141,
                Bill_Id = 41424,
                Quantity = 3,
                

            };

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
            int result = billitemRepository.InsertBillItem(billitem);
            Assert.IsTrue(result > 0);
        }
        [TestMethod]
        public void UpdateBillItemTest()
        {
            billitemRepository.InsertBillItem(billitem);
            BillItem newBillItem = billitemRepository.GetAllBillItems().Where(x => x.Bill_Id == billitem.Bill_Id && x.Article_Id==billitem.Article_Id).ToList()[0];
            int result = billitemRepository.UpdateBillItem(newBillItem);
            Assert.IsTrue(result > 0);
        }
    }
}
