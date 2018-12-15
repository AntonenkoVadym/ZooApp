using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZooApp.Tests
{
    [TestClass]
    public class WolfTest
    {
        Component Aviary;
        Creator cr;
        Animal animal1;
        [TestInitialize]
        public void TestInitiialize()
        {
            Aviary = new Zoo("Aviary", 0);
            cr = new WolfCreator("Moon", 300);
            animal1 = cr.Add(cr.Name, cr.Weight);
        }
        [TestMethod]
        public void AddMsg_message_string_returned()
        {
            string expected = "Wolf Moon added with weight 300";
            string actual = animal1.AddMsg();
            Assert.AreEqual(expected, actual);
        }
    }
}
