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
    public class StuffRepositoryTest
    {
        public Stuff stuff;
        public IStuffRepository stuffRepository;
        public List<int> listIDS = new List<int>();

        [TestInitialize]
        public void init()
        {
            stuff = new Stuff
            {
                
                Username = "dwwa",
                Name = "Stevo",
                Surname = "Stevanovic",
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
            listIDS.Add(stuffRepository.GetStuffNewId());
            Assert.IsNotNull(stuffRepository.GetAllStuffs());
        }

        [TestMethod]
        public void InsertStuffTest()
        {
            int result = stuffRepository.InsertStuff(stuff);
            listIDS.Add(stuffRepository.GetStuffNewId());
            Assert.IsTrue(result > 0);
        }
       [TestMethod]
        public void UpdateStuffTest()
        {
            stuffRepository.InsertStuff(stuff);
            int newId = stuffRepository.GetStuffNewId();
            stuff.Name = "Izmenjeni radnik!";
            stuff.Id = newId;
            listIDS.Add(newId);
            stuffRepository.UpdateStuff(stuff);
            string result = stuffRepository.GetAllStuffs().FirstOrDefault(x => x.Id == stuff.Id).Name;
            Assert.AreEqual(result, "Izmenjeni radnik!");
        }
        [TestCleanup]
        public void CleanUpAfterTest()
        {
            foreach (int item in listIDS)
            {
                stuffRepository.DeleteStuff(item);
            }
        }
    }
}
