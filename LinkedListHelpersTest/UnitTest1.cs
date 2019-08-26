using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace LinkedListHelpersTest
{
    [TestClass]
    public class UnitTest1
    {
        LinkedListHelpers.LinkedList<String> lList = new LinkedListHelpers.LinkedList<String>();

        [TestMethod]
        public void TestRepeatedLessThanThrice()
        {

            string[] letters = { "E", "B", "E", "E", "B", "A", "B" };
            foreach (var letter in letters)
            {
                lList.addNode(letter);
            }

            foreach (var letter in letters)
            {
                bool result = lList.LessThanThree(letter);

                Assert.AreEqual(result, true);
            }
            
        }

     }
}
