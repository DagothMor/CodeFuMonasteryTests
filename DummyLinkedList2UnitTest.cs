using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AlgorithmsDataStructures;
using System.Collections.Generic;
using CodeFuMonastery;

namespace MSTest
{
	[TestClass]
	public class DummyLinkedList2UnitTest
	{
		[TestMethod]
		// Working.
		public void TestRemove()
		{
			var a1 = new Node(1);
			var a2 = new Node(2);
			var a3 = new Node(3);
			var a4 = new Node(4);
			var a5 = new Node(5);
			var a6 = new Node(6);
			var a7 = new Node(7);



			var testList = new DLinkedList();

			testList.AddInTail(a7);
			testList.InsertAfter(null,a1);
			testList.InsertAfter(a1,a2);

			testList.InsertAfter(a2, a3);

			testList.InsertAfter(a3, a4);

			testList.InsertAfter(a4, a5);

			testList.InsertAfter(a5, a6);

			Assert.IsFalse(testList.Remove(0));

			Assert.IsTrue(testList.Remove(1));
			Assert.IsTrue(testList.Remove(2));
			Assert.IsTrue(testList.Remove(3));
			Assert.IsTrue(testList.Remove(4));
			Assert.IsTrue(testList.Remove(5));
			Assert.IsTrue(testList.Remove(6));
			Assert.IsTrue(testList.Remove(7));
			Assert.IsFalse(testList.Remove(8));


		}

		[TestMethod]
		// Working.
		public void TestRemoveAll()
		{
			var a1 = new Node(1);
			var a2 = new Node(2);
			var a3 = new Node(2);
			var a4 = new Node(3);
			var a5 = new Node(3);
			var a6 = new Node(3);
			var a7 = new Node(4);


			var testList = new DLinkedList();

			testList.AddInTail(a1);
			testList.AddInTail(a2);
			testList.AddInTail(a3);
			testList.AddInTail(a4);
			testList.AddInTail(a5);
			testList.AddInTail(a6);
			testList.AddInTail(a7);

			testList.RemoveAll(0);
			testList.RemoveAll(1);
			testList.RemoveAll(2);
			testList.RemoveAll(3);
			testList.RemoveAll(4);


		}

		[TestMethod]
		// Working
		public void TestClear()
		{
			var a1 = new Node(1);
			var a2 = new Node(2);
			var a3 = new Node(2);
			var a4 = new Node(3);
			var a5 = new Node(3);
			var a6 = new Node(3);
			var a7 = new Node(4);


			var testList = new DLinkedList();


			testList.AddInTail(a1);
			testList.AddInTail(a2);
			testList.AddInTail(a3);
			testList.AddInTail(a4);
			testList.AddInTail(a5);
			testList.AddInTail(a6);
			testList.AddInTail(a7);

			testList.Clear();
			testList.Clear();

		}

		[TestMethod]
		// Working.
		public void TestFindAll()
		{
			var a1 = new Node(1);
			var a2 = new Node(2);
			var a3 = new Node(3);
			var a4 = new Node(4);
			var a5 = new Node(5);
			var a6 = new Node(6);
			var a7 = new Node(7);
			var a8 = new Node(8);
			var a9 = new Node(9);

			var c1 = new Node(10);
			var c2 = new Node(10);
			var c3 = new Node(10);

			var testList = new DLinkedList();

			testList.AddInTail(a1);
			testList.AddInTail(a2);
			testList.AddInTail(a3);
			testList.AddInTail(a4);
			testList.AddInTail(a5);
			testList.AddInTail(a6);
			testList.AddInTail(a7);

			var testList3 = new DLinkedList();

			testList3.AddInTail(c1);
			testList3.InsertAfter(c1, c2);
			testList3.InsertAfter(null, c3);

			var expected312 = new List<Node>() { c3, c1, c2 };
			var expected123 = new List<Node>() { c1, c2, c3 };
			var actual = testList3.FindAll(10);
			var notActual = testList.FindAll(1);

			testList.AddInTail(c1);
			testList.AddInTail(c2);
			testList.AddInTail(c3);

			testList.RemoveAll(1);
			testList.RemoveAll(2);
			testList.RemoveAll(3);
			testList.RemoveAll(4);
			testList.RemoveAll(5);
			testList.RemoveAll(6);
			testList.RemoveAll(7);

			var actualTestList = testList.FindAll(10);
			CollectionAssert.AreEqual(expected312, actual);
			CollectionAssert.AreEqual(expected123, actualTestList);


			CollectionAssert.AreNotEqual(expected312, notActual);
		}

		[TestMethod]
		// Working.
		public void TestCount()
		{
			var a1 = new Node(1);
			var a2 = new Node(2);
			var a3 = new Node(3);
			var a4 = new Node(4);
			var a5 = new Node(5);
			var a6 = new Node(6);
			var a7 = new Node(7);

			var c1 = new Node(10);
			var c2 = new Node(10);
			var c3 = new Node(10);


			var testList = new DLinkedList();

			testList.AddInTail(a1);
			testList.AddInTail(a2);
			testList.AddInTail(a3);
			testList.AddInTail(a4);
			testList.AddInTail(a5);
			testList.AddInTail(a6);
			testList.AddInTail(a7);



			var testList3 = new DLinkedList();

			testList3.AddInTail(c1);
			testList3.InsertAfter(c1,c2);
			testList3.InsertAfter(null,c3);

			Assert.IsTrue(3 == testList3.Count());

			Assert.IsTrue(7 == testList.Count());

			testList.RemoveAll(1);
			testList.RemoveAll(1);
			testList.RemoveAll(3);
			testList.RemoveAll(4);
			testList.RemoveAll(5);
			testList.RemoveAll(6);
			testList.RemoveAll(7);

			Assert.IsTrue(1 == testList.Count());

			testList.RemoveAll(2);

			Assert.IsTrue(0 == testList.Count());
		}

		[TestMethod]
		//Working
		public void TestInsertAfter()
		{
			var a1 = new Node(1);
			var a2 = new Node(2);
			var a3 = new Node(3);
			var a4 = new Node(4);
			var a5 = new Node(5);
			var a6 = new Node(6);
			var a7 = new Node(7);
			var a8 = new Node(8);
			var a9 = new Node(9);

			var testList = new DLinkedList();

			testList.InsertAfter(null,null);

			Assert.IsTrue(testList.head.next == testList.tail && testList.tail.next == testList.head);

			testList.InsertAfter(null,a1);
			Assert.IsTrue(testList.head.next == a1 && testList.tail.prev == a1);

			testList.InsertAfter(null, a2);
			Assert.IsTrue(testList.head.next == a2 && testList.tail.prev == a1);

			testList.InsertAfter(a2, a3);
			Assert.IsTrue(testList.head.next.next == a3 && testList.tail.prev == a1);

			testList.InsertAfter(a2, null);
			Assert.IsTrue(testList.head.next.next == a3 && testList.tail.prev == a1);

			testList.InsertAfter(a1, a4);
			Assert.IsTrue(testList.head.next == a2 && testList.tail.prev == a4 && a3.next == a1 && a1.next == a4);
		}

	}
}
