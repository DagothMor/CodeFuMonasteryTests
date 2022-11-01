using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFuMonastery;
using AlgorithmsDataStructures2;

namespace MSTest
{
    [TestClass]
    public class BalancedBSTUnitTest
    {
        [TestMethod]
        public void BalancedBSTStart()
        {
            var arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var bstArr = BalancedBST.GenerateBBSTArray(arr1);
            var arr2 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var bstArr2 = BalancedBST.GenerateBBSTArray(arr2);
            var test = " ";
        }
    }
}
