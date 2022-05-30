using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFuMonastery;

namespace MSTest
{
    [TestClass]
    public class PowerSetUnitTest
    {
        [TestMethod]
        public void FirstTest()
        {
            var firstPowerSet = new PowerSet<string>();
            firstPowerSet.Put("a");
            firstPowerSet.Put("a");
            firstPowerSet.Put("a");

            Assert.AreEqual(firstPowerSet.Size(), 1);

            firstPowerSet.Remove("a");
            Assert.AreEqual(firstPowerSet.Size(), 0);

            firstPowerSet.Put("a");
            firstPowerSet.Put("b");
            firstPowerSet.Put("c");
            firstPowerSet.Put("d");

            var secondPowerSet = new PowerSet<string>();
            secondPowerSet.Put("a");
            secondPowerSet.Put("b");
            secondPowerSet.Put("e");
            secondPowerSet.Put("d");

            var intersectionPowerSet = new PowerSet<string>();
            intersectionPowerSet.Put("a");
            intersectionPowerSet.Put("b");
            intersectionPowerSet.Put("d");

            //Assert.AreEqual(intersectionPowerSet, firstPowerSet.Intersection(secondPowerSet));

            var unionPowerSetTest = new string[] { "a", "b", "c", "d", "e" };
            var unionPowerSet = firstPowerSet.Union(secondPowerSet);

            foreach (var item in unionPowerSetTest)
            {
                Assert.IsTrue(unionPowerSet.Get(item));
            }

            var differenceSetTest = new string[] { "c" };
            var differencePowerSet = firstPowerSet.Difference(secondPowerSet);

            foreach (var item in differenceSetTest)
            {
                Assert.IsTrue(differencePowerSet.Get(item));
            }

            var isSubSetPowerSetTest = new PowerSet<string>();
            isSubSetPowerSetTest.Put("a");
            isSubSetPowerSetTest.Put("b");
            isSubSetPowerSetTest.Put("d");

            var isSubSetPowerSetTestBigger = new PowerSet<string>();
            isSubSetPowerSetTestBigger.Put("a");
            isSubSetPowerSetTestBigger.Put("b");
            isSubSetPowerSetTestBigger.Put("d");
            isSubSetPowerSetTestBigger.Put("c");

            var isSubSetPowerSetTestEqual = new PowerSet<string>();
            isSubSetPowerSetTestEqual.Put("a");
            isSubSetPowerSetTestEqual.Put("b");
            isSubSetPowerSetTestEqual.Put("d");

            var isSubSetPowerSetTestLess = new PowerSet<string>();
            isSubSetPowerSetTestLess.Put("a");
            isSubSetPowerSetTestLess.Put("b");


            Assert.IsFalse(isSubSetPowerSetTest.IsSubset(isSubSetPowerSetTestBigger));
            Assert.IsTrue(isSubSetPowerSetTest.IsSubset(isSubSetPowerSetTestEqual));
            Assert.IsTrue(isSubSetPowerSetTest.IsSubset(isSubSetPowerSetTestLess));

        }
    }
}
