using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZooApp;

namespace ZooAppTest
{
    [TestClass]
    public class ZooTest
    {
        [TestMethod]
        public void PrintTest()
        {
            ZooApp.Component Aviary = new Zoo("Aviary", 0);
            Creator cr = new BearCreator("Ben", 300);
            Animal animal1 = cr.Add(cr.Name, cr.Weight);
            Aviary.Add(animal1);
            string[] expected = new string[] { }
            string[] actual;
            actual = target.GetLettersOfTheAlphabet();
            Assert.AreEqual(expected, actual);
        }
    }
}
