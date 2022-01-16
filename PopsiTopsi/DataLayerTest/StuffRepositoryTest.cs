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
    public class StuffRepositoryTest
    {
        public Stuff stuff;
        public IStuffRepository stuffRepository;


        [TestInitialize]
        public void init()
        {
            stuff = new Stuff
            {
                Id = 98978,
                Username = "dwwa",
                Name = "Artikal broj 1",
                Surname = "Artikal",
                Email = "ssimi009@gmail.com",
                Password = "dadaf",
                PhoneNumber = "924924",
                
       

            };

            stuffRepository = new StuffRepository();

        }
        [TestMethod]
        public void GetAllStuffTest()
        {
            stuffRepository.InsertStuff(stuff);
            Assert.IsNotNull(stuffRepository.GetAllStuffs());
        }

        [TestMethod]
        public void InsertStuffTest()
        {
            int result = stuffRepository.InsertStuff(stuff);
            Assert.IsTrue(result > 0);
        }
        [TestMethod]
        public void UpdateStuffTest()
        {
            stuffRepository.InsertStuff(stuff);
            Stuff newStuff = stuffRepository.GetAllStuffs().Where(x => x.Id == stuff.Id).ToList()[0];
            int result = stuffRepository.UpdateStuff(newStuff);
            Assert.IsTrue(result > 0);
        }
    }
}
