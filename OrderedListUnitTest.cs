using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AlgorithmsDataStructures;
using System.Collections.Generic;
using CodeFuMonastery;

namespace MSTest
{
	[TestClass]
	public class OrderedListUnitTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			var testListIntAscending = new OrderedList<int>(true);

			testListIntAscending.Add(10);
			testListIntAscending.Add(9);
			testListIntAscending.Add(8);
			testListIntAscending.Add(7);
			testListIntAscending.Add(6);
			testListIntAscending.Add(5);
			testListIntAscending.Add(4);
			testListIntAscending.Add(3);
			testListIntAscending.Add(2);
			testListIntAscending.Add(1);

			Assert.AreEqual(null, testListIntAscending.Find(11));

			Assert.AreEqual(1, testListIntAscending.Find(1).value);
			Assert.AreEqual(10, testListIntAscending.Find(10).value);

			Assert.AreEqual(5, testListIntAscending.Find(5).value);

			Assert.AreEqual(2, testListIntAscending.Find(2).value);

			testListIntAscending.Delete(10);
			testListIntAscending.Delete(1);
			testListIntAscending.Delete(5);

			Assert.AreEqual(null, testListIntAscending.Find(1));

			Assert.AreEqual(null, testListIntAscending.Find(10));

			Assert.AreEqual(null, testListIntAscending.Find(5));

			Assert.AreEqual(2, testListIntAscending.Find(2).value);



			var testListIntNotAscending = new OrderedList<int>(false);

			testListIntNotAscending.Add(10);
			testListIntNotAscending.Add(9);
			testListIntNotAscending.Add(8);
			testListIntNotAscending.Add(7);
			testListIntNotAscending.Add(6);
			testListIntNotAscending.Add(5);
			testListIntNotAscending.Add(4);
			testListIntNotAscending.Add(3);
			testListIntNotAscending.Add(2);
			testListIntNotAscending.Add(1);

			Assert.AreEqual(null, testListIntNotAscending.Find(11));

			Assert.AreEqual(1, testListIntNotAscending.Find(1).value);

			Assert.AreEqual(10, testListIntNotAscending.Find(10).value);

			Assert.AreEqual(5, testListIntNotAscending.Find(5).value);

			Assert.AreEqual(2, testListIntNotAscending.Find(2).value);

			testListIntNotAscending.Delete(10);
			testListIntNotAscending.Delete(1);
			testListIntNotAscending.Delete(5);

			Assert.AreEqual(null, testListIntNotAscending.Find(1));

			Assert.AreEqual(null, testListIntNotAscending.Find(10));

			Assert.AreEqual(null, testListIntNotAscending.Find(5));

			Assert.AreEqual(2, testListIntNotAscending.Find(2).value);

			var testListStringAscending = new OrderedList<string>(true);

			testListStringAscending.Add(" a");
			testListStringAscending.Add("ab");
			testListStringAscending.Add("ba");
			testListStringAscending.Add("abb");
			testListStringAscending.Add("abc");
			testListStringAscending.Add("abbc");
			testListStringAscending.Add("accbc");
			testListStringAscending.Add("abcbccc");
			testListStringAscending.Add("ba");
			testListStringAscending.Add("bac");

			Assert.AreEqual(null, testListStringAscending.Find("dd"));

			Assert.AreEqual("ab", testListStringAscending.Find("ab").value);

			Assert.AreEqual("abc", testListStringAscending.Find("abc").value);

			Assert.AreEqual("accbc", testListStringAscending.Find("accbc").value);

			Assert.AreEqual("abcbccc", testListStringAscending.Find("abcbccc").value);

			testListStringAscending.Delete("bac");
			testListStringAscending.Delete(" a");
			testListStringAscending.Delete("abbc");

			Assert.AreEqual(null, testListStringAscending.Find("abbc"));

			Assert.AreEqual(null, testListStringAscending.Find(" a"));

			Assert.AreEqual(null, testListStringAscending.Find("bac"));

			Assert.AreEqual("ab", testListStringAscending.Find("ab").value);

			var testListStringNotAscending = new OrderedList<string>(false);

			testListStringNotAscending.Add(" a");
			testListStringNotAscending.Add("ab");
			testListStringNotAscending.Add("ba");
			testListStringNotAscending.Add("abb");
			testListStringNotAscending.Add("abc");
			testListStringNotAscending.Add("abbc");
			testListStringNotAscending.Add("accbc");
			testListStringNotAscending.Add("abcbccc");
			testListStringNotAscending.Add("ba");
			testListStringNotAscending.Add("bac");

			Assert.AreEqual(null, testListStringNotAscending.Find("dd"));

			Assert.AreEqual("ab", testListStringNotAscending.Find("ab").value);

			Assert.AreEqual("abc", testListStringNotAscending.Find("abc").value);

			Assert.AreEqual("accbc", testListStringNotAscending.Find("accbc").value);

			Assert.AreEqual("abcbccc", testListStringNotAscending.Find("abcbccc").value);

			testListStringNotAscending.Delete("bac");
			testListStringNotAscending.Delete(" a");
			testListStringNotAscending.Delete("abbc");

			Assert.AreEqual(null, testListStringNotAscending.Find("abbc"));

			Assert.AreEqual(null, testListStringNotAscending.Find(" a"));

			Assert.AreEqual(null, testListStringNotAscending.Find("bac"));

			Assert.AreEqual("ab", testListStringNotAscending.Find("ab").value);
		}
	}
}
