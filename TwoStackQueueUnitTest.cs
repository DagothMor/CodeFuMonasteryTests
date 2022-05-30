using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTest
{
    [TestClass]
    public class TwoStackQueueUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var stackFirst = new AlgorithmsDataStructures.Stack<int>();
            var stackSecond = new AlgorithmsDataStructures.Stack<int>();
            var queue = new AlgorithmsDataStructures.Queue<int>();
            var twoStacksQueue = new AlgorithmsDataStructures.TwoStacksQueue<int>();

            stackFirst.Push(1);
            stackFirst.Push(2);
            stackFirst.Push(3);
            stackFirst.Push(4);
            stackFirst.Push(5);
            stackFirst.Push(6);


            stackSecond.Push(2);
            stackSecond.Push(3);
            stackSecond.Push(4);
            stackSecond.Push(5);
            stackSecond.Push(6);

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);

            twoStacksQueue.Enqueue(1);
            twoStacksQueue.Enqueue(2);
            twoStacksQueue.Enqueue(3);
            twoStacksQueue.Enqueue(4);
            twoStacksQueue.Enqueue(5);
            twoStacksQueue.Enqueue(6);

            Assert.AreEqual(1, queue.Dequeue());
            Assert.AreEqual(2, queue.Dequeue());
            Assert.AreEqual(3, queue.Dequeue());
            Assert.AreEqual(4, queue.Dequeue());
            Assert.AreEqual(5, queue.Dequeue());
            Assert.AreEqual(6, queue.Dequeue());
            Assert.AreEqual(default, queue.Dequeue());

            Assert.AreEqual(1, twoStacksQueue.Dequeue());
            Assert.AreEqual(2, twoStacksQueue.Dequeue());
            Assert.AreEqual(3, twoStacksQueue.Dequeue());
            Assert.AreEqual(4, twoStacksQueue.Dequeue());
            Assert.AreEqual(5, twoStacksQueue.Dequeue());
            Assert.AreEqual(6, twoStacksQueue.Dequeue());
            Assert.AreEqual(default, twoStacksQueue.Dequeue());
        }
    }
}
