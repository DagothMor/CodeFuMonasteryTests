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
	public class QueueUnitTest
	{
		[TestMethod]
		public void FirstTest()
		{
			var queue = new AlgorithmsDataStructures.Queue<int>();





			var list = new List<int>();
			var stack = new AlgorithmsDataStructures.Stack<int>();

			Assert.AreEqual(0, stack.Size());
			Assert.AreEqual(0, stack.Peek());
			      
			stack.Push(1);
			stack.Push(2);
			stack.Push(3);

			Assert.AreEqual(3, stack.Pop());
			Assert.AreEqual(2, stack.Pop());
			Assert.AreEqual(1, stack.Pop());
			Assert.AreEqual(0, stack.Size());
			Assert.AreEqual(0, stack.Peek());
		}
	}
}
