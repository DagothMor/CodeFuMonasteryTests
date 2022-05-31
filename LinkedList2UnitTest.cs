using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AlgorithmsDataStructures;
using System.Collections.Generic;
using CodeFuMonastery;

namespace MSTest
{
	[TestClass]
	public class LinkedList2UnitTest
	{
		[TestMethod]
		public void TestMethod1()
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

			var b1 = new Node(1);
			var b2 = new Node(1);
			var b3 = new Node(1);
			var b4 = new Node(4);
			var b5 = new Node(5);
			var b6 = new Node(6);
			var b7 = new Node(7);
			var b8 = new Node(8);
			var b9 = new Node(9);

			var c1 = new Node(10);
			var c2 = new Node(10);
			var c3 = new Node(10);

			var d1 = new Node(20);
			var d2 = new Node(20);
			var d3 = new Node(25);

			var e1 = new Node(30);
			var e2 = new Node(30);
			var e3 = new Node(30);

			var f1 = new Node(41);
			var f2 = new Node(42);
			var f3 = new Node(43);

			a1.next = a2;
			a2.next = a3;
			a3.next = a4;
			a4.next = a5;
			a5.next = a6;
			a6.next = a7;

			a2.prev = a1;
			a3.prev = a2;
			a4.prev = a3;
			a5.prev = a4;
			a6.prev = a5;
			a7.prev = a6;


			var testList = new LinkedList2();
			testList.head = a1;
			testList.tail = a7;

			var testList2 = new LinkedList2();
			testList2.head = a1;
			testList2.tail = a7;

			var testList3 = new LinkedList2();

			// AddInTail
			Assert.IsFalse(testList.Remove(9));
			testList.AddInTail(a9);
			Assert.IsTrue(testList.Remove(9));

			// InsertAfter
			Assert.IsFalse(testList.Remove(9));
			testList.InsertAfter(a7, a9);
			Assert.IsTrue(testList.Remove(9));
			testList.InsertAfter(a6, a9);
			Assert.IsTrue(testList.Remove(6));
			Assert.IsTrue(testList.Remove(1));

			Assert.IsTrue(testList2.Remove(9));
			testList2.AddInTail(b1);
			testList2.AddInTail(b2);
			testList2.AddInTail(b3);
			testList2.RemoveAll(1);
			Assert.IsFalse(testList2.Remove(1));

			// list is null.
			Assert.IsFalse(testList3.Remove(1));
			testList3.AddInTail(a3);
			Assert.AreEqual(a3, testList3.Find(3));
			testList3.AddInTail(c1);
			testList3.AddInTail(c2);
			testList3.AddInTail(c3);
			//Assert.AreEqual(new List<Node>() {c1,c2,c3},testList3.FindAll(10));
			var expected = new List<Node>() { c1, c2, c3 };
			var actual = testList3.FindAll(10);
			CollectionAssert.AreEqual(expected, actual);
			Assert.AreEqual(4, testList3.Count());
			testList3.RemoveAll(10);
			Assert.AreEqual(1, testList3.Count());
			Assert.IsTrue(testList3.Remove(3));
			Assert.AreEqual(0, testList3.Count());

			testList3.AddInTail(d1);
			testList3.InsertAfter(d1, d2);
			testList3.AddInTail(d3);

			Assert.IsTrue(testList3.Remove(20));
			Assert.IsTrue(testList3.Remove(20));
			//Assert.IsTrue(testList3.Remove(20));

			testList3.InsertAfter(null, e1);
			testList3.InsertAfter(null, e2);
			testList3.InsertAfter(null, e3);

			Assert.IsTrue(testList3.Remove(25));

			testList3.RemoveAll(30);

			testList3.InsertAfter(null, f1);
			testList3.InsertAfter(null, f3);
			testList3.InsertAfter(f3, f2);
			Assert.IsTrue(testList3.Remove(43));
			Assert.IsTrue(testList3.Remove(41));
			Assert.IsTrue(testList3.Remove(42));
		}

		[TestMethod]
		public void TestMethod2()
		{
			var a1 = new Node(1);
			var a2 = new Node(2);
			var a3 = new Node(3);
			var a4 = new Node(4);
			var a5 = new Node(5);
			var a6 = new Node(6);
			var a7 = new Node(7);

			var b1 = new Node(11);
			var b2 = new Node(12);
			var b3 = new Node(13);
			var b4 = new Node(14);
			var b5 = new Node(15);
			var b6 = new Node(16);
			var b7 = new Node(17);

			var c1 = new Node(12);
			var c2 = new Node(14);
			var c3 = new Node(16);
			var c4 = new Node(18);
			var c5 = new Node(20);
			var c6 = new Node(22);
			var c7 = new Node(24);


			a1.next = a2;
			a2.next = a3;
			a3.next = a4;
			a4.next = a5;
			a5.next = a6;
			a6.next = a7;

			a2.prev = a1;
			a3.prev = a2;
			a4.prev = a3;
			a5.prev = a4;
			a6.prev = a5;
			a7.prev = a6;

			b1.next = b2;
			b2.next = b3;
			b3.next = b4;
			b4.next = b5;
			b5.next = b6;
			b6.next = b7;

			b2.prev = b1;
			b3.prev = b2;
			b4.prev = b3;
			b5.prev = b4;
			b6.prev = b5;
			b7.prev = b6;

			c1.next = c2;
			c2.next = c3;
			c3.next = c4;
			c4.next = c5;
			c5.next = c6;
			c6.next = c7;

			c2.prev = c1;
			c3.prev = c2;
			c4.prev = c3;
			c5.prev = c4;
			c6.prev = c5;
			c7.prev = c6;


			var testList = new LinkedList2();
			testList.head = a1;
			testList.tail = a7;

			var testList2 = new LinkedList2();
			testList2.head = b1;
			testList2.tail = b7;

			var expected = new LinkedList2();
			expected.head = c1;
			expected.tail = c7;

			var sumOfList1And2 = LinkedList2Controller.SumTwoLinkedLists(testList, testList2);

			var twoLinkedListsAreEqual = LinkedList2Controller.TwoLinkedListsAreEqual(expected, sumOfList1And2);
			var twoLinkedListsAreNotEqual = LinkedList2Controller.TwoLinkedListsAreEqual(testList, testList2);

			Assert.IsTrue(twoLinkedListsAreEqual);
			Assert.IsFalse(twoLinkedListsAreNotEqual);
		}

		[TestMethod]
		public void TestRemove()
		{
			var a1 = new Node(1);
			var a2 = new Node(2);
			var a3 = new Node(3);
			var a4 = new Node(4);
			var a5 = new Node(5);
			var a6 = new Node(6);
			var a7 = new Node(7);

			a1.next = a2;
			a2.next = a3;
			a3.next = a4;
			a4.next = a5;
			a5.next = a6;
			a6.next = a7;

			a2.prev = a1;
			a3.prev = a2;
			a4.prev = a3;
			a5.prev = a4;
			a6.prev = a5;
			a7.prev = a6;


			var testList = new LinkedList2();
			testList.head = a1;
			testList.tail = a7;

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
		public void TestRemoveAll()
		{
			var a1 = new Node(1);
			var a2 = new Node(2);
			var a3 = new Node(2);
			var a4 = new Node(3);
			var a5 = new Node(3);
			var a6 = new Node(3);
			var a7 = new Node(4);

			a1.next = a2;
			a2.next = a3;
			a3.next = a4;
			a4.next = a5;
			a5.next = a6;
			a6.next = a7;

			a2.prev = a1;
			a3.prev = a2;
			a4.prev = a3;
			a5.prev = a4;
			a6.prev = a5;
			a7.prev = a6;


			var testList = new LinkedList2();
			testList.head = a1;
			testList.tail = a7;

			testList.RemoveAll(0);
			testList.RemoveAll(1);
			testList.RemoveAll(2);
			testList.RemoveAll(3);
			testList.RemoveAll(4);


		}

		[TestMethod]
		public void TestClear()
		{
			var a1 = new Node(1);
			var a2 = new Node(2);
			var a3 = new Node(2);
			var a4 = new Node(3);
			var a5 = new Node(3);
			var a6 = new Node(3);
			var a7 = new Node(4);

			a1.next = a2;
			a2.next = a3;
			a3.next = a4;
			a4.next = a5;
			a5.next = a6;
			a6.next = a7;

			a2.prev = a1;
			a3.prev = a2;
			a4.prev = a3;
			a5.prev = a4;
			a6.prev = a5;
			a7.prev = a6;


			var testList = new LinkedList2();
			testList.head = a1;
			testList.tail = a7;

			testList.Clear();
			testList.Clear();
			testList.Clear();

		}

		[TestMethod]
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

			a1.next = a2;
			a2.next = a3;
			a3.next = a4;
			a4.next = a5;
			a5.next = a6;
			a6.next = a7;

			a2.prev = a1;
			a3.prev = a2;
			a4.prev = a3;
			a5.prev = a4;
			a6.prev = a5;
			a7.prev = a6;


			var testList = new LinkedList2();
			testList.head = a1;
			testList.tail = a7;

			var testList3 = new LinkedList2();

			testList3.AddInTail(c1);
			testList3.AddInTail(c2);
			testList3.AddInTail(c3);

			var expected = new List<Node>() { c1, c2, c3 };
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
			CollectionAssert.AreEqual(expected, actual);
			CollectionAssert.AreEqual(expected, actualTestList);


			CollectionAssert.AreNotEqual(expected, notActual);
		}

		[TestMethod]
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

			a1.next = a2;
			a2.next = a3;
			a3.next = a4;
			a4.next = a5;
			a5.next = a6;
			a6.next = a7;

			a2.prev = a1;
			a3.prev = a2;
			a4.prev = a3;
			a5.prev = a4;
			a6.prev = a5;
			a7.prev = a6;


			var testList = new LinkedList2();

			testList.head = a1;
			testList.tail = a7;

			var testList3 = new LinkedList2();

			testList3.AddInTail(c1);
			testList3.AddInTail(c2);
			testList3.AddInTail(c3);

			Assert.IsTrue(3 == testList3.Count());

			Assert.IsTrue(7 == testList.Count());

			testList.RemoveAll(1);
			testList.RemoveAll(2);
			testList.RemoveAll(3);
			testList.RemoveAll(4);
			testList.RemoveAll(5);
			testList.RemoveAll(6);
			testList.RemoveAll(7);

			Assert.IsTrue(0 == testList.Count());
		}

		[TestMethod]
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

			var testList = new LinkedList2();

			testList.InsertAfter(null,null);

			Assert.IsTrue(testList.head == null && testList.tail == null);

			testList.InsertAfter(null,a1);
			Assert.IsTrue(testList.head == a1 && testList.tail == a1);

			testList.InsertAfter(null, a2);
			Assert.IsTrue(testList.head == a2 && testList.tail == a1);

			testList.InsertAfter(a2, a3);
			Assert.IsTrue(testList.head.next == a3 && testList.tail == a1);

			testList.InsertAfter(a2, null);
			Assert.IsTrue(testList.head.next == a3 && testList.tail == a1);

			testList.InsertAfter(a1, a4);
			Assert.IsTrue(testList.head == a2 && testList.tail == a4 && a3.next == a1 && a1.next == a4);
		}

	}
}
