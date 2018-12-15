using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.Tests
{
    [TestClass]
    public class WolfCreatorTest
    {
        Creator cr;
        [TestInitialize]
        public void TestInitiialize()
        {
            cr = new WolfCreator("Moon", 300);
        }
        [TestMethod]
        public void Add_new_object_returned_name_checked()
        {
            Animal expected = new Wolf("Moon", 300);
            Animal actual = cr.Add(cr.Name, cr.Weight);
            Assert.AreEqual(expected.name, actual.name);
        }
        [TestMethod]
        public void Add_new_object_returned_weight_checked()
        {
            Animal expected = new Wolf("Moon", 300);
            Animal actual = cr.Add(cr.Name, cr.Weight);
            Assert.AreEqual(expected.weight, actual.weight);
        }
    }
}
