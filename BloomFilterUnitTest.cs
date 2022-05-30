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
    public class BloomFilterUnitTest
    {
        [TestMethod]
        public void FirstTest()
        {
            var bf = new BloomFilter(32);
            bf.Add("0123456789");
            bf.Add("1234567890");
            bf.Add("2345678901");
            bf.Add("3456789012");
            bf.Add("4567890123");
            bf.Add("5678901234");
            bf.Add("6789012345");
            bf.Add("7890123456");
            bf.Add("8901234567");
            bf.Add("9012345678");
            bf.IsValue("1234567890");

            Assert.AreEqual(true,bf.IsValue("1234567890"));
            Assert.AreEqual(false, bf.IsValue("dsdsdsdsds"));
        }

    }
}
