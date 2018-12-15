using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ZooApp.Tests
{
    [TestClass]
    public class GiraffeTest
    {
        Component Aviary;
        Creator cr;
        Animal animal1;
        [TestInitialize]
        public void TestInitiialize()
        {
            Aviary = new Zoo("Aviary", 0);
            cr = new GiraffeCreator("Buch", 300);
            animal1 = cr.Add(cr.Name, cr.Weight);
        }
        [TestMethod]
        public void AddMsg_message_string_returned()
        {
            string expected = "Giraffe Buch added with weight 300";
            string actual = animal1.AddMsg();
            Assert.AreEqual(expected, actual);
        }
    }
}
