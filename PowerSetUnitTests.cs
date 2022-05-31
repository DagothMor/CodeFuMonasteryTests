using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AlgorithmsDataStructures;
using System.Collections.Generic;
using CodeFuMonastery;

namespace MSTest
{
    [TestClass]
    public class PowerSetUnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var pw = new PowerSet<string>();

            pw.Put("a");
            pw.Put("a");
            pw.Put("a");
            pw.Put("a");

            pw.Put("b");
            pw.Put("c");
            pw.Put("d");
            pw.Put("e");
            pw.Put("f");
            pw.Put(null);

            pw.Remove("a");
            pw.Remove("b");
            pw.Remove("c");
            pw.Remove("g");
            pw.Remove("d");
            pw.Remove("e");
            pw.Remove("f");
            pw.Remove("b");
            pw.Remove(null);

            var pwIsSubsetTest = new string[] { "a", "b", "c" };
            var pw1 = new PowerSet<string>();
        }

        [TestMethod]
        public void TestIsSubSet()
        {
            var pw = new PowerSet<string>();
            pw.Put("a");
            pw.Put("b");
            pw.Put("c");
            pw.Put("d");
            pw.Put("e");
            pw.Put("f");
            var pw2 = new PowerSet<string>();
            pw2.Put("b");
            pw2.Put("c");
            pw2.Put("d");

            var pw3 = new PowerSet<string>();
            pw3.Put("a");
            pw3.Put("b");
            pw3.Put("c");
            pw3.Put("d");
            pw3.Put("e");
            pw3.Put("f");
            pw3.Put("g");

            var pw4 = new PowerSet<string>();
            pw4.Put("a");
            pw4.Put("b");
            pw4.Put("c");
            pw4.Put("d");
            pw4.Put("e");
            pw4.Put("f");
            pw4.Put("g");

            Assert.IsTrue(pw.IsSubset(pw2));
            Assert.IsFalse(pw2.IsSubset(pw));
            Assert.IsTrue(pw4.IsSubset(pw));
        }

        [TestMethod]
        public void TestDifference()
        {
            var pw = new PowerSet<string>();
            pw.Put("a");
            pw.Put("b");
            pw.Put("c");
            pw.Put("d");
            pw.Put("e");
            pw.Put("f");
            var pw2 = new PowerSet<string>();
            pw2.Put("a");
            pw2.Put("b");
            pw2.Put("c");
            pw2.Put("d");

            var pw3 = pw.Difference(pw2);

            var stringcontain = new string[]{"e","f"};
            var stringNotContain = new string[] { "a", "b","c","d" };

            foreach (var item in stringcontain)
            {
                Assert.IsTrue(pw3.Get(item));
            }

            foreach (var item in stringNotContain)
            {
                Assert.IsFalse(pw3.Get(item));
            }
        }

        [TestMethod]
        public void TestUnion()
        {
            var pw = new PowerSet<string>();
            pw.Put("a");
            pw.Put("b");
            pw.Put("c");
            pw.Put("d");
            pw.Put("e");
            pw.Put("f");
            var pw2 = new PowerSet<string>();
            pw2.Put("a");
            pw2.Put("b");
            pw2.Put("c");
            pw2.Put("d");

            var pw3 = pw.Union(pw2);

            var stringContain = new string[] { "a", "b", "c", "d","e","f" };

            foreach (var item in stringContain)
            {
                Assert.IsTrue(pw3.Get(item));
            }
        }

        [TestMethod]
        public void TestIntersection()
        {
            var pw = new PowerSet<string>();
            pw.Put("a");
            pw.Put("b");
            pw.Put("c");
            pw.Put("d");
            pw.Put("e");
            pw.Put("f");
            var pw2 = new PowerSet<string>();
            pw2.Put("a");
            pw2.Put("b");
            pw2.Put("c");
            pw2.Put("d");

            var pw3 = pw.Intersection(pw2);

            var stringContain = new string[] { "a", "b", "c", "d" };

            foreach (var item in stringContain)
            {
                Assert.IsTrue(pw3.Get(item));
            }
        }

        [TestMethod]
        public void TestRemove()
        {

            var pw = new PowerSet<string>();
            var list = new List<int>();
            var number = 0;
            while (pw.Size() <20000)
            {
                if (number == 514)
                {
                    pw.Put(number.ToString());
                }
                pw.Put(number.ToString());
                list.Add(number);
                number++;
            }

            foreach (var item in list)
            {
                //if (item == 514)
                //{
                //    Assert.IsTrue(pw.Remove(item.ToString()));
                //    continue;
                //}
                Assert.IsTrue(pw.Remove(item.ToString()));
            }
            list.Clear();
            while (pw.Size() < 20000)
            {
                pw.Put(number.ToString());
                list.Add(number);
                number--;
            }

            foreach (var item in list)
            {
                //if (item == 514)
                //{
                //    Assert.IsTrue(pw.Remove(item.ToString()));
                //    continue;
                //}
                Assert.IsTrue(pw.Remove(item.ToString()));
            }
            Assert.AreEqual(0, pw.Size());
        }

        [TestMethod]
        public void TestSize()
        {

            var pw = new PowerSet<string>();
            Assert.AreEqual(pw.Size(), 0);
            pw.Put("1");
            Assert.AreEqual(pw.Size(), 1);
            pw.Remove("11");
            Assert.AreEqual(1, pw.Size());
            pw.Remove("1");
            Assert.AreEqual(0, pw.Size());
            pw.Remove("1");
            Assert.AreEqual(0, pw.Size());
        }
    }
}
