using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace ImplementQueue.Tests
{

    [TestClass]
    public class TestLinkedQueue
    {
        [TestMethod]
        public void Test_Enqueue_Dequeue()
        {
            LinkedQueue<int> roo = new LinkedQueue<int>();
            Assert.AreEqual(0, roo.Count);
            roo.Enqueue(9);
            Assert.AreEqual(1, roo.Count);
            Assert.AreEqual(9, roo.Dequeue());
            Assert.AreEqual(0, roo.Count);

            LinkedQueue<string> testEnqueue = new LinkedQueue<string>();
            Assert.AreEqual(0, testEnqueue.Count);
            for (int i = 1; i <= 1000; i++)
            {
                testEnqueue.Enqueue("as" + i);
                Assert.AreEqual(i, testEnqueue.Count);

            }

            for (int i = 1; i <= 1000; i++)
            {
                Assert.AreEqual("as" + i, testEnqueue.Dequeue());
                Assert.AreEqual(1000-i, testEnqueue.Count);

            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RemoveFirst_EmptyList_ShouldThrowException()
        {
            var list = new LinkedQueue<int>();
            list.Dequeue();
        }

        [TestMethod]
        public void Dequeue_Enqueue()
        {
            LinkedQueue<int> testDequeue = new LinkedQueue<int>();
            Assert.AreEqual(0, testDequeue.Count);
            testDequeue.Enqueue(3);
            Assert.AreEqual(1, testDequeue.Count);
            testDequeue.Enqueue(3);
            Assert.AreEqual(2, testDequeue.Count);
            Assert.AreEqual(3, testDequeue.Dequeue());
            Assert.AreEqual(1, testDequeue.Count);
            Assert.AreEqual(3, testDequeue.Dequeue());
            Assert.AreEqual(0, testDequeue.Count);
        }



        [TestMethod]
        public void array()
        {
            LinkedQueue<int> testArray = new LinkedQueue<int>();
            testArray.Enqueue(3);
            testArray.Enqueue(5);
            testArray.Enqueue(2);
            testArray.Enqueue(7);
            testArray.Enqueue(-7);
            testArray.Enqueue(-7);
            testArray.Enqueue(7);

                CollectionAssert.AreEqual(new int[]{ 3, 5, 2, 7,-7,-7,7 },testArray.ToArray());
        }


        [TestMethod]
        public void Emptyarray()
        {
            LinkedQueue<DateTime> testArray = new LinkedQueue<DateTime>();


            CollectionAssert.AreEqual(new DateTime[0], testArray.ToArray());
        }

    }
}
