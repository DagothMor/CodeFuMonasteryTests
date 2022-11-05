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
            var bstArr = new BalancedBST();
            bstArr.GenerateTree(arr1);

            var arr2 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var bstArr2 = new BalancedBST();
            bstArr2.GenerateTree(arr2);

            var arr3 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var bstArr3 = new BalancedBST();
            bstArr3.GenerateTree(arr1);
            bstArr3.Root.RightChild.RightChild.RightChild.RightChild = new BSTNode(166, bstArr3.Root.RightChild.RightChild.RightChild) {Level=4 };
            bstArr3.Root.RightChild.RightChild.RightChild.RightChild.RightChild = new BSTNode(1663, bstArr3.Root.RightChild.RightChild.RightChild.RightChild) { Level =5};

            var bstArrIsBalanced =  bstArr.IsBalanced(bstArr.Root);

            var bstArr2IsBalanced = bstArr2.IsBalanced(bstArr2.Root);

            var bstArr3IsBalanced = bstArr3.IsBalanced(bstArr3.Root);
            var test = " ";
        }
    }
}
