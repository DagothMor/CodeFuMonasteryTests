using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFuMonastery;
using AlgorithmsDataStructures2;

namespace MSTest
{
	[TestClass]
	public class SimpleTreeUnitTest
	{
		[TestMethod]
		public void AddChildTest()
		{


			var a1 = new SimpleTreeNode<int>(1);
			var a2 = new SimpleTreeNode<int>(2);
			var a3 = new SimpleTreeNode<int>(3);
			var a4 = new SimpleTreeNode<int>(4);
			var a5 = new SimpleTreeNode<int>(5);
			var a6 = new SimpleTreeNode<int>(6);
			var a7 = new SimpleTreeNode<int>(7);
			var a8 = new SimpleTreeNode<int>(8);
			var a9 = new SimpleTreeNode<int>(9);

			var ASimpleTree = new SimpleTree<int>(a1);

			// тест: проверяем наличие добавленного узла)

			Assert.AreEqual(ASimpleTree.FindNode(a2), false);

			ASimpleTree.AddChild(a1, a2);
			Assert.AreEqual(ASimpleTree.FindNode(a2), true);

			ASimpleTree.AddChild(a1, a3);
			Assert.AreEqual(ASimpleTree.FindNode(a3), true);

			ASimpleTree.AddChild(a4, a5);
			ASimpleTree.AddChild(a5, a6);

			Assert.AreEqual(ASimpleTree.FindNode(a4), false);
			Assert.AreEqual(ASimpleTree.FindNode(a5), false);
			Assert.AreEqual(ASimpleTree.FindNode(a6), false);

			ASimpleTree.AddChild(a3, a4);

			Assert.AreEqual(ASimpleTree.FindNode(a4), true);
			Assert.AreEqual(ASimpleTree.FindNode(a5), true);
			Assert.AreEqual(ASimpleTree.FindNode(a6), true);

			var BSimpleTree = new SimpleTree<int>();
			var b1 = new SimpleTreeNode<int>(1);
			var b2 = new SimpleTreeNode<int>(1);
			var b3 = new SimpleTreeNode<int>(1);
			var b4 = new SimpleTreeNode<int>(4);
			var b5 = new SimpleTreeNode<int>(5);
			var b6 = new SimpleTreeNode<int>(6);
			var b7 = new SimpleTreeNode<int>(7);
			var b8 = new SimpleTreeNode<int>(8);
			var b9 = new SimpleTreeNode<int>(9);

			var CSimpleTree = new SimpleTree<int>();
			var c1 = new SimpleTreeNode<int>(10);
			var c2 = new SimpleTreeNode<int>(10);
			var c3 = new SimpleTreeNode<int>(10);

			var DSimpleTree = new SimpleTree<int>();
			var d1 = new SimpleTreeNode<int>(20);
			var d2 = new SimpleTreeNode<int>(20);
			var d3 = new SimpleTreeNode<int>(25);

			var ESimpleTree = new SimpleTree<int>();
			var e1 = new SimpleTreeNode<int>(30);
			var e2 = new SimpleTreeNode<int>(30);
			var e3 = new SimpleTreeNode<int>(30);

			var FSimpleTree = new SimpleTree<int>();
			var f1 = new SimpleTreeNode<int>(41);
			var f2 = new SimpleTreeNode<int>(42);
			var f3 = new SimpleTreeNode<int>(43);


		}
		//-------------------------------------------
		[TestMethod]
		// проверяем отсутствие удалённого узла и его потомков);
		public void DeleteTest()
		{


			var a1 = new SimpleTreeNode<int>(1);
			var a2 = new SimpleTreeNode<int>(2);
			var a3 = new SimpleTreeNode<int>(3);
			var a4 = new SimpleTreeNode<int>(4);
			var a5 = new SimpleTreeNode<int>(5);
			var a6 = new SimpleTreeNode<int>(6);
			var a7 = new SimpleTreeNode<int>(7);
			var a8 = new SimpleTreeNode<int>(8);
			var a9 = new SimpleTreeNode<int>(9);

			var ASimpleTree = new SimpleTree<int>(a1);

			// тест: проверяем наличие добавленного узла)

			Assert.AreEqual(ASimpleTree.FindNode(a2), false);

			ASimpleTree.AddChild(a1, a2);
			Assert.AreEqual(ASimpleTree.FindNode(a2), true);

			ASimpleTree.AddChild(a1, a3);
			Assert.AreEqual(ASimpleTree.FindNode(a3), true);

			ASimpleTree.AddChild(a4, a5);
			ASimpleTree.AddChild(a5, a6);

			Assert.AreEqual(ASimpleTree.FindNode(a4), false);
			Assert.AreEqual(ASimpleTree.FindNode(a5), false);
			Assert.AreEqual(ASimpleTree.FindNode(a6), false);

			ASimpleTree.AddChild(a3, a4);

			Assert.AreEqual(ASimpleTree.FindNode(a4), true);
			Assert.AreEqual(ASimpleTree.FindNode(a5), true);
			Assert.AreEqual(ASimpleTree.FindNode(a6), true);

			ASimpleTree.DeleteNode(a4);

			Assert.AreEqual(ASimpleTree.FindNode(a4), false);
			Assert.AreEqual(ASimpleTree.FindNode(a5), false);
			Assert.AreEqual(ASimpleTree.FindNode(a6), false);

			var BSimpleTree = new SimpleTree<int>();
			var b1 = new SimpleTreeNode<int>(1);
			var b2 = new SimpleTreeNode<int>(1);
			var b3 = new SimpleTreeNode<int>(1);
			var b4 = new SimpleTreeNode<int>(4);
			var b5 = new SimpleTreeNode<int>(5);
			var b6 = new SimpleTreeNode<int>(6);
			var b7 = new SimpleTreeNode<int>(7);
			var b8 = new SimpleTreeNode<int>(8);
			var b9 = new SimpleTreeNode<int>(9);

			var CSimpleTree = new SimpleTree<int>();
			var c1 = new SimpleTreeNode<int>(10);
			var c2 = new SimpleTreeNode<int>(10);
			var c3 = new SimpleTreeNode<int>(10);

			var DSimpleTree = new SimpleTree<int>();
			var d1 = new SimpleTreeNode<int>(20);
			var d2 = new SimpleTreeNode<int>(20);
			var d3 = new SimpleTreeNode<int>(25);

			var ESimpleTree = new SimpleTree<int>();
			var e1 = new SimpleTreeNode<int>(30);
			var e2 = new SimpleTreeNode<int>(30);
			var e3 = new SimpleTreeNode<int>(30);

			var FSimpleTree = new SimpleTree<int>();
			var f1 = new SimpleTreeNode<int>(41);
			var f2 = new SimpleTreeNode<int>(42);
			var f3 = new SimpleTreeNode<int>(43);
		}

		[TestMethod]
		public void SearchTest()
		{


			var a1 = new SimpleTreeNode<int>(1);
			var a2 = new SimpleTreeNode<int>(2);
			var a3 = new SimpleTreeNode<int>(3);
			var a4 = new SimpleTreeNode<int>(4);
			var a5 = new SimpleTreeNode<int>(5);
			var a6 = new SimpleTreeNode<int>(6);
			var a7 = new SimpleTreeNode<int>(7);
			var a8 = new SimpleTreeNode<int>(8);
			var a9 = new SimpleTreeNode<int>(9);

			var ASimpleTree = new SimpleTree<int>(a1);

			// тест: проверяем наличие добавленного узла)

			Assert.AreEqual(ASimpleTree.FindNode(a2), false);

			ASimpleTree.AddChild(a1, a2);
			Assert.AreEqual(ASimpleTree.FindNode(a2), true);

			ASimpleTree.AddChild(a1, a3);
			Assert.AreEqual(ASimpleTree.FindNode(a3), true);

			ASimpleTree.AddChild(a4, a5);
			ASimpleTree.AddChild(a5, a6);

			Assert.AreEqual(ASimpleTree.FindNode(a4), false);
			Assert.AreEqual(ASimpleTree.FindNode(a5), false);
			Assert.AreEqual(ASimpleTree.FindNode(a6), false);

			ASimpleTree.AddChild(a3, a4);

			Assert.AreEqual(ASimpleTree.FindNode(a4), true);
			Assert.AreEqual(ASimpleTree.FindNode(a5), true);
			Assert.AreEqual(ASimpleTree.FindNode(a6), true);

			var factList = ASimpleTree.GetAllNodes();

			var expectedList = new List<SimpleTreeNode<int>>() { a1,a2,a3,a4,a5,a6};

			Assert.AreEqual(6, ASimpleTree.Count());
			Assert.AreEqual(2, ASimpleTree.LeafCount());

			//Assert.AreEqual(factList, expectedList);



			
			var b1 = new SimpleTreeNode<int>(1);
			var b2 = new SimpleTreeNode<int>(2);
			var b3 = new SimpleTreeNode<int>(3);
			var b4 = new SimpleTreeNode<int>(4);
			var b5 = new SimpleTreeNode<int>(5);
			var b6 = new SimpleTreeNode<int>(6);
			var b7 = new SimpleTreeNode<int>(1);
			var b8 = new SimpleTreeNode<int>(1);
			var b9 = new SimpleTreeNode<int>(1);
			var BSimpleTree = new SimpleTree<int>(b1);

			BSimpleTree.AddChild(b1, b2);
			BSimpleTree.AddChild(b2, b3);
			BSimpleTree.AddChild(b3, b4);
			BSimpleTree.AddChild(b4, b5);
			BSimpleTree.AddChild(b5, b6);


			BSimpleTree.AddChild(b2,b9);
			BSimpleTree.AddChild(b3, b8);
			BSimpleTree.AddChild(b4, b7);
			var BfactList = BSimpleTree.FindNodesByValue(1);

			var BexpectedList = new List<SimpleTreeNode<int>>() { b1, b9, b8, b7 };

			//Assert.AreEqual(BfactList, BexpectedList);

			var CSimpleTree = new SimpleTree<int>();
			var c1 = new SimpleTreeNode<int>(10);
			var c2 = new SimpleTreeNode<int>(10);
			var c3 = new SimpleTreeNode<int>(10);

			var DSimpleTree = new SimpleTree<int>();
			var d1 = new SimpleTreeNode<int>(20);
			var d2 = new SimpleTreeNode<int>(20);
			var d3 = new SimpleTreeNode<int>(25);

			var ESimpleTree = new SimpleTree<int>();
			var e1 = new SimpleTreeNode<int>(30);
			var e2 = new SimpleTreeNode<int>(30);
			var e3 = new SimpleTreeNode<int>(30);

			var FSimpleTree = new SimpleTree<int>();
			var f1 = new SimpleTreeNode<int>(41);
			var f2 = new SimpleTreeNode<int>(42);
			var f3 = new SimpleTreeNode<int>(43);
		}

		[TestMethod]
		public void MoveTest()
		{


			var a1 = new SimpleTreeNode<int>(1);
			var a2 = new SimpleTreeNode<int>(2);
			var a3 = new SimpleTreeNode<int>(3);
			var a4 = new SimpleTreeNode<int>(4);
			var a5 = new SimpleTreeNode<int>(5);
			var a6 = new SimpleTreeNode<int>(6);
			var a7 = new SimpleTreeNode<int>(7);
			var a8 = new SimpleTreeNode<int>(8);
			var a9 = new SimpleTreeNode<int>(9);

			var ASimpleTree = new SimpleTree<int>(a1);

			ASimpleTree.AddChild(a1, a2);
			ASimpleTree.AddChild(a2, a3);
			ASimpleTree.AddChild(a3, a4);
			ASimpleTree.AddChild(a4, a5);
			ASimpleTree.AddChild(a5, a6);
			ASimpleTree.AddChild(a6, a7);
			Assert.IsTrue(a5.Children.Contains(a6));
			Assert.IsFalse(a2.Children.Contains(a6));
			ASimpleTree.MoveNode(a6,a2);
			Assert.IsFalse(a5.Children.Contains(a6));
			Assert.IsTrue(a2.Children.Contains(a6));

		}

		[TestMethod]
		public void EvenForestTest()
		{


			var a1 = new SimpleTreeNode<int>(1);
			var a2 = new SimpleTreeNode<int>(2);
			var a3 = new SimpleTreeNode<int>(3);
			var a4 = new SimpleTreeNode<int>(4);
			var a5 = new SimpleTreeNode<int>(5);
			var a6 = new SimpleTreeNode<int>(6);
			var a7 = new SimpleTreeNode<int>(7);
			var a8 = new SimpleTreeNode<int>(8);
			var a9 = new SimpleTreeNode<int>(9);
			var a10 = new SimpleTreeNode<int>(10);

			var ASimpleTree = new SimpleTree<int>(a1);

			ASimpleTree.AddChild(a1, a2);
			ASimpleTree.AddChild(a1, a3);
			ASimpleTree.AddChild(a1, a4);
			ASimpleTree.AddChild(a2, a5);
			ASimpleTree.AddChild(a4, a7);
			ASimpleTree.AddChild(a3, a6);
			ASimpleTree.AddChild(a4, a8);
			ASimpleTree.AddChild(a5, a9);
			ASimpleTree.AddChild(a5, a10);

			var res = ASimpleTree.EvenTrees();

			var b1 = new SimpleTreeNode<int>(1);
			var b2 = new SimpleTreeNode<int>(2);
			var b3 = new SimpleTreeNode<int>(3);
			var b4 = new SimpleTreeNode<int>(4);
			var b5 = new SimpleTreeNode<int>(5);
			var b6 = new SimpleTreeNode<int>(6);
			var b7 = new SimpleTreeNode<int>(7);
			var b8 = new SimpleTreeNode<int>(8);
			var b9 = new SimpleTreeNode<int>(9);
			var b10 = new SimpleTreeNode<int>(10);

			var bSimpleTree = new SimpleTree<int>(b1);

			bSimpleTree.AddChild(b1, b2);
			bSimpleTree.AddChild(b1, b3);
			bSimpleTree.AddChild(b1, b6);
			bSimpleTree.AddChild(b2, b5);
			bSimpleTree.AddChild(b2, b7);
			bSimpleTree.AddChild(b3, b4);
			bSimpleTree.AddChild(b6, b8);
			bSimpleTree.AddChild(b7, b9);
			bSimpleTree.AddChild(b7, b10);

			var resb = bSimpleTree.EvenTrees();

			var keke = "";

		}
	}
	}
