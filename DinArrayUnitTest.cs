using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;
using System.Collections.Generic;
using System;

namespace MSTest
{
	[TestClass]
	public class DinArrayUnitTest
	{
		[TestMethod]
		public void TestCount()
		{
			var except = new int[] { };
			var dynArray = new DynArray<int>();

			Assert.AreEqual(0, dynArray.count);

			Assert.AreEqual(16, dynArray.capacity);

			dynArray.Insert(1,0);

			Assert.AreEqual(1, dynArray.GetItem(0));

			Assert.AreEqual(1, dynArray.count);

			dynArray.Insert(2, 1);

			Assert.AreEqual(2, dynArray.count);

			for (int i = 2; i < 16; i++)
			{
				dynArray.Insert(i+1, i);
			}

			Assert.AreEqual(16, dynArray.count);


			dynArray.Insert(55, 1);

			Assert.AreEqual(32, dynArray.capacity);

			Assert.AreEqual(17, dynArray.count);

			dynArray.Insert(17, 17);

			// dynArray.Insert(19, 19)());

			dynArray.Insert(18, 18);

			Assert.AreEqual(19, dynArray.count);

			dynArray.Remove(0);

			Assert.AreEqual(18, dynArray.count);

			dynArray.Remove(0);

			Assert.AreEqual(17, dynArray.count);

			for (int i = 16; i >= 0; i--)
			{
				dynArray.Remove(i);
			}

			Assert.AreEqual(0, dynArray.count);

			for (int i = 0; i < 16; i++)
			{
				dynArray.Append(i);
			}

			Assert.AreEqual(16, dynArray.capacity);

			Assert.AreEqual(16, dynArray.count);

			dynArray.Append(16);

			Assert.AreEqual(32, dynArray.capacity);

			Assert.AreEqual(17, dynArray.count);

			dynArray.Append(16);
			dynArray.Append(16);
			dynArray.Append(16);
			dynArray.Append(16);
			dynArray.Append(16);
			dynArray.Append(16);

			Assert.AreEqual(23, dynArray.count);

			for (int i = 22; i > 16; i--)
			{
				dynArray.Remove(i);
			}

			Assert.AreEqual(21, dynArray.capacity);

			for (int i = 16; i < 21; i++)
			{
				dynArray.Insert(i + 1, i);
			}

			Assert.AreEqual(42, dynArray.capacity);

			dynArray.Remove(21);

			Assert.AreEqual(28, dynArray.capacity);

			for (int i = 21; i < 28; i++)
			{
				dynArray.Insert(i + 1, i);
			}

			Assert.AreEqual(28, dynArray.capacity);

			dynArray.Insert(29, 28);

			dynArray.Insert(29, 29);


			Assert.AreEqual(56, dynArray.capacity);

			//for (int i = 0; i < length; i++)
			//{

			//}
			//Assert.AreEqual();


			//Assert.ThrowsException<AssertFailedException>();
		}
	}
}
