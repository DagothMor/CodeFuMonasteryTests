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
	public class DequeUnitTest
	{
		[TestMethod]
		public void FirstTest()
		{
			var deque = new Deque<int>();
			Assert.AreEqual(0,deque.Size());
			Assert.AreEqual(0, deque.RemoveFront());
			Assert.AreEqual(0, deque.RemoveTail());

			deque.AddFront(1);
			Assert.AreEqual(1, deque.Size());
			Assert.AreEqual(1, deque.RemoveFront());

			deque.AddFront(1);
			Assert.AreEqual(1, deque.Size());
			Assert.AreEqual(1, deque.RemoveTail());

			deque.AddFront(1);
			deque.AddFront(2);
			deque.AddFront(3);
			deque.AddFront(4);
			deque.AddFront(5);
			deque.AddFront(6);

			Assert.AreEqual(6, deque.RemoveFront());
			Assert.AreEqual(1, deque.RemoveTail());
			Assert.AreEqual(5, deque.RemoveFront());
			Assert.AreEqual(2, deque.RemoveTail());
			Assert.AreEqual(4, deque.RemoveFront());
			Assert.AreEqual(3, deque.RemoveTail());


			deque.AddTail(1);
			deque.AddTail(2);
			deque.AddTail(3);
			deque.AddTail(4);
			deque.AddTail(5);
			deque.AddTail(6);

			Assert.AreEqual(1, deque.RemoveFront());
			Assert.AreEqual(6, deque.RemoveTail());


			Assert.IsTrue(DequeController.IsPalindrome("aba"));
			Assert.IsTrue(DequeController.IsPalindrome("abba"));
			Assert.IsTrue(DequeController.IsPalindrome("ababa"));
			Assert.IsTrue(DequeController.IsPalindrome("abcba"));
			Assert.IsTrue(DequeController.IsPalindrome("abddba"));

			Assert.IsFalse(DequeController.IsPalindrome("abdccddba"));
		}
	}
}
