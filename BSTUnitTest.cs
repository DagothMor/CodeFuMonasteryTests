using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFuMonastery;
using AlgorithmsDataStructures2;

namespace MSTest
{
    [TestClass]
    public class BSTUnitTest
    {
		[TestMethod]
		public void BFSAndDFS()
		{
			var test1aBST = new aBST(0);
			var test2aBST = new aBST(1);
			var test3aBST = new aBST(2);
			var test4aBST = new aBST(3);
			var test5aBST = new aBST(4);

			Assert.AreEqual(1,test1aBST.Tree.Length);
			Assert.AreEqual(3, test2aBST.Tree.Length);
			Assert.AreEqual(7, test3aBST.Tree.Length);
			Assert.AreEqual(15, test4aBST.Tree.Length);
			Assert.AreEqual(31, test5aBST.Tree.Length);

			Assert.AreEqual(0, test4aBST.AddKey(50));
			Assert.AreEqual(1, test4aBST.AddKey(25));
			Assert.AreEqual(2, test4aBST.AddKey(75));
			Assert.AreEqual(null, test4aBST.Tree[3]);
			Assert.AreEqual(4, test4aBST.AddKey(37));
			Assert.AreEqual(5, test4aBST.AddKey(62));
			Assert.AreEqual(6, test4aBST.AddKey(84));
			Assert.AreEqual(null, test4aBST.Tree[7]);
			Assert.AreEqual(null, test4aBST.Tree[8]);
			Assert.AreEqual(9, test4aBST.AddKey(31));
			Assert.AreEqual(10, test4aBST.AddKey(43));
			Assert.AreEqual(11, test4aBST.AddKey(55));
			Assert.AreEqual(null, test4aBST.Tree[12]);
			Assert.AreEqual(null, test4aBST.Tree[13]);
			Assert.AreEqual(14, test4aBST.AddKey(92));
			Assert.AreEqual(14, test4aBST.AddKey(92));

			Assert.AreEqual(-1, test4aBST.AddKey(93));
			Assert.AreEqual(-1, test4aBST.AddKey(94));

			Assert.AreEqual(null, test4aBST.FindKeyIndex(93));
			Assert.AreEqual(14, test4aBST.FindKeyIndex(92));
			Assert.AreEqual(0, test4aBST.FindKeyIndex(50));
			Assert.AreEqual(-3, test4aBST.FindKeyIndex(24));



		}
			[TestMethod]
		public void AddChildTest()
		{
			//____
			//____
			var bstTree = new BST<int>();
			var zeronotfound = bstTree.FindNodeByKey(0);
			Assert.AreEqual(0, bstTree.Count());
			bstTree.AddKeyValue(8, 8);
			var eightfounded = bstTree.FindNodeByKey(8);
			Assert.AreEqual(1, bstTree.Count());
			bstTree.AddKeyValue(4, 4);
			Assert.AreEqual(2, bstTree.Count());
			bstTree.AddKeyValue(12, 12);
			var founded10 = bstTree.FindNodeByKey(10);
			Assert.AreEqual(3, bstTree.Count());
			bstTree.AddKeyValue(2, 2);
			var twofounded = bstTree.FindNodeByKey(2);
			Assert.AreEqual(4, bstTree.Count());
			bstTree.AddKeyValue(6, 6);
			Assert.AreEqual(5, bstTree.Count());
			bstTree.AddKeyValue(10, 10);
			Assert.AreEqual(6, bstTree.Count());
			bstTree.AddKeyValue(14, 14);
			Assert.AreEqual(7, bstTree.Count());


			bstTree.AddKeyValue(1,1);
			
			bstTree.AddKeyValue(3, 3);
			
			bstTree.AddKeyValue(5, 5);
			
			bstTree.AddKeyValue(7, 7);
			
			bstTree.AddKeyValue(9, 9);
			
			bstTree.AddKeyValue(11, 11);
			
			bstTree.AddKeyValue(13, 13);
			var founded15 = bstTree.FindNodeByKey(15);
			bstTree.AddKeyValue(15, 15);

			Assert.AreEqual(15, bstTree.Count());

			var min = bstTree.FinMinMax(bstTree.Root,false);

			var max = bstTree.FinMinMax(bstTree.Root, true);

			var min4 = bstTree.FinMinMax(bstTree.FindNodeByKey(4).Node, false);
			var min12 = bstTree.FinMinMax(bstTree.FindNodeByKey(12).Node, false);
			var max12 = bstTree.FinMinMax(bstTree.FindNodeByKey(12).Node, true);
			var max4 = bstTree.FinMinMax(bstTree.FindNodeByKey(4).Node, true);

			Assert.AreEqual(true, bstTree.DeleteNodeByKey(11));
			Assert.AreEqual(true, bstTree.DeleteNodeByKey(10));
			Assert.AreEqual(true, bstTree.DeleteNodeByKey(9));

			Assert.AreEqual(true, bstTree.DeleteNodeByKey(8));


			Assert.AreEqual(true, bstTree.DeleteNodeByKey(5));
			Assert.AreEqual(true, bstTree.DeleteNodeByKey(4));

			Assert.AreEqual(true, bstTree.DeleteNodeByKey(3));
			Assert.AreEqual(true, bstTree.DeleteNodeByKey(2));
			Assert.AreEqual(true, bstTree.DeleteNodeByKey(1));
			Assert.AreEqual(true, bstTree.DeleteNodeByKey(15));
			Assert.AreEqual(true, bstTree.DeleteNodeByKey(14));
			Assert.AreEqual(true, bstTree.DeleteNodeByKey(13));
			Assert.AreEqual(true, bstTree.DeleteNodeByKey(12));
			
			Assert.AreEqual(true, bstTree.DeleteNodeByKey(8));
			Assert.AreEqual(true, bstTree.DeleteNodeByKey(7));
			Assert.AreEqual(true, bstTree.DeleteNodeByKey(6));
			
			//____

		}
	}
}
