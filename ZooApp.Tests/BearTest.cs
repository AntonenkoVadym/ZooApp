using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZooApp.Tests
{
    [TestClass]
    public class BearTest
    {
        Component Aviary;
        Creator cr;
        Animal animal1;
        [TestInitialize]
        public void TestInitiialize()
        {
            Aviary = new Zoo("Aviary", 0);
            cr = new BearCreator("Ben", 300);
            animal1 = cr.Add(cr.Name, cr.Weight);
        }
        [TestMethod]
        public void AddMsg_message_string_returned()
        {
            string expected = "Bear Ben added with weight 300";
            string actual = animal1.AddMsg();
            Assert.AreEqual(expected, actual);
        }
    }
}
