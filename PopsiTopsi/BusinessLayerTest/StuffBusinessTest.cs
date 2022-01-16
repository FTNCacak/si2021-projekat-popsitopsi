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
    public class StuffBusinessTest
    {

        private Mock<IStuffRepository> mockStuffRepository = new Mock<IStuffRepository>();

        private Stuff stuff1 = new Stuff
        {
            Email="Njsnjjj@djdj.com",
            Id= 53,
            Name="Adnan",
            Password="password1",
            PhoneNumber= "062232233",
            Surname="Palic",
            Username="lalam"
        };
        private Stuff stuff2 = new Stuff
        {
            Email = "dcxd@djdj.com",
            Id = 32,
            Name = "Lale",
            Password = "pass1",
            PhoneNumber = "06522565623",
            Surname = "Lalic",
            Username = "laleee"
        };
        private Stuff stuff3 = new Stuff
        {
            Email = "dfsed@djdj.com",
            Id = 23,
            Name = "Milos",
            Password = "password2",
            PhoneNumber = "0613221212",
            Surname = "Ivanovic",
            Username = "msic"
        };
        private StuffBusiness stuffBusiness;
        private List<Stuff> list = new List<Stuff>();

        public StuffBusinessTest()
        {
            list.Add(stuff1);
            list.Add(stuff2);
            list.Add(stuff3);
        }

        [TestMethod]
        public void GetAllStuffsTest()
        {
            mockStuffRepository.Setup(a => a.GetAllStuffs()).Returns(list);
            this.stuffBusiness = new StuffBusiness(mockStuffRepository.Object);
            var result = stuffBusiness.GetAllStuffs();
            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void UpdateBillTest()
        {
            mockStuffRepository.Setup(x => x.UpdateStuff(stuff1)).Returns(1);
            this.stuffBusiness = new StuffBusiness(mockStuffRepository.Object);

            var result = stuffBusiness.UpdateStuff(stuff1 );

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void InsertStuffTest()
        {
            mockStuffRepository.Setup(x => x.InsertStuff(stuff1)).Returns(1);
            this.stuffBusiness = new StuffBusiness(mockStuffRepository.Object);

            var result = stuffBusiness.InsertStuff(stuff1);

            Assert.AreEqual(result, true);
        }
    }
}
