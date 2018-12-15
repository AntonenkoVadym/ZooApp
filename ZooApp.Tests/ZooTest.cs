using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZooApp.Tests
{
    [TestClass]
    public class ZooTest
    {
        Component Aviary;
        [TestInitialize]
        public void TestInitiialize()
        {
            Aviary = new Zoo("Aviary", 0);
            Creator cr = new BearCreator("Ben", 300);
            Animal animal1 = cr.Add(cr.Name, cr.Weight);
            Aviary.Add(animal1);
            Creator cr2 = new GiraffeCreator("Buch", 300);
            Animal animal2 = cr2.Add(cr2.Name, cr2.Weight);
            Aviary.Add(animal2);

        }
        [TestMethod]
        public void Print_array_of_string_returned()
        {
            string[] expected=new string []{
                0 + "-" + "Bear"+ " " + "Ben" + " " + 300 + "kg",
                1 + "-" + "Giraffe"+ " " + "Buch" + " " + 300 + "kg"};
            string[] actual = Aviary.Print();
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddingStaff_type_returned()
        {
            string expected = "Bear";
            int i = 0;
            string actual = Aviary.AddingStaff(i);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void VoiceStaff_index_str_returned()
        {
            string expected ="arrrrrrh - It is bear, Ben"; 
            int i = 0;
            string actual = Aviary.VoiceStaff(i);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void WeightStat_array_with_weight_returned()
        {
            string[] expected = new string[2] {
                "Total Weight 600",
                "Average weight 300" };
            string [] actual = Aviary.WeightStat();
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Voice_array_with_voice_returned()
        {
            string [] expected =new string[] {
                "arrrrrrh - It is bear, Ben",
                "hhhhhh - It is giraffe, Buch"};
            string [] actual = Aviary.Voice();
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SingleVoice_index_str_returned()
        {
            string expected = "arrrrrrh - It is bear, Ben";
            int i = 0;
            string actual = Aviary.VoiceStaff(i);
            Assert.AreEqual(expected, actual);
        }
    }
}
