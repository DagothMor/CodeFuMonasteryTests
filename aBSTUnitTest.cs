using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFuMonastery;
using AlgorithmsDataStructures2;

namespace MSTest
{
    [TestClass]
    public class aBSTUnitTest
    {
		[TestMethod]
		public void BFSAndDFS()
		{
			var bstTree = new BST<int>();
			bstTree.AddKeyValue(8, 8);

			bstTree.AddKeyValue(4, 4);

			bstTree.AddKeyValue(12, 12);

			bstTree.AddKeyValue(2, 2);

			bstTree.AddKeyValue(6, 6);

			bstTree.AddKeyValue(10, 10);

			bstTree.AddKeyValue(14, 14);

			bstTree.AddKeyValue(1, 1);

			bstTree.AddKeyValue(3, 3);

			bstTree.AddKeyValue(5, 5);

			bstTree.AddKeyValue(7, 7);

			bstTree.AddKeyValue(9, 9);

			bstTree.AddKeyValue(11, 11);

			bstTree.AddKeyValue(13, 13);

			bstTree.AddKeyValue(15, 15);

			var widelist = bstTree.WideAllNodes();

			var deepListIn = bstTree.DeepAllNodes(0);
			var deepListPre = bstTree.DeepAllNodes(1);
			var deepListPost = bstTree.DeepAllNodes(2);
		}
	}
}
