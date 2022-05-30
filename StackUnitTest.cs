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
	public class StackUnitTest
	{
		[TestMethod]
		public void FirstTest()
		{
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

			stack.Push(1);
			stack.Push(2);
			stack.Push(3);

			Assert.AreEqual(3, stack.Peek());
			Assert.AreEqual(3, stack.Peek());
			Assert.AreEqual(3, stack.Peek());

			Assert.AreEqual(3, stack.Size());
			Assert.AreEqual(3, stack.Peek());

		}

		[TestMethod]
		public void bracketsTest()
		{
			var first = "()()()()()";
			var second = "(((((())))))";
			var third = "()()(())";

			var fourth = ")";
			var fifth = "())";
			var sixth = "((())";


			Assert.IsTrue(StackController.BalancedRoundBrackets(first));
			Assert.IsTrue(StackController.BalancedRoundBrackets(second));
			Assert.IsTrue(StackController.BalancedRoundBrackets(third));

			Assert.IsFalse(StackController.BalancedRoundBrackets(fourth));
			Assert.IsFalse(StackController.BalancedRoundBrackets(fifth));
			Assert.IsFalse(StackController.BalancedRoundBrackets(sixth));


		}

		[TestMethod]
		public void PostfixNotationOfAnExpressionTest()
		{
			var first = "8 2 + 5 * 9 + =";

			Assert.AreEqual(59, StackController.PostfixNotationOfAnExpressionThroughString(first));

			var second = new AlgorithmsDataStructures.Stack<char>();
			second.Push('=');
			second.Push('+');
			second.Push('9');
			second.Push('*');
			second.Push('5');
			second.Push('+');
			second.Push('2');
			second.Push('8');


			Assert.AreEqual(59, StackController.PostfixNotationOfAnExpression(second));

			var third = new AlgorithmsDataStructures.Stack<char>();
			third.Push('=');
			third.Push('+');
			third.Push('9');
			third.Push('*');
			third.Push('5');
			third.Push('/');
			third.Push('2');
			third.Push('8');


			Assert.AreEqual(29, StackController.PostfixNotationOfAnExpression(third));
		}

	}
}
