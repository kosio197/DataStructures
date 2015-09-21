using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace ImplementStack.Tests
{

    [TestClass]
    public class TestLinkedStack
    {
        [TestMethod]
        public void Test_Push_Pop()
        {
            LinkedStack<int> roo = new LinkedStack<int>();
            Assert.AreEqual(0, roo.Count);
            roo.Push(9);
            Assert.AreEqual(1, roo.Count);
            Assert.AreEqual(9, roo.Pop());
            Assert.AreEqual(0, roo.Count);

            LinkedStack<string> testPush = new LinkedStack<string>();
            Assert.AreEqual(0, testPush.Count);
            for (int i = 1; i <= 1000; i++)
            {
                testPush.Push("as" + i);
                Assert.AreEqual(i, testPush.Count);

            }

            for (int i = 1000; i >= 1; i--)
            {
                Assert.AreEqual("as" + i, testPush.Pop());
                Assert.AreEqual(i - 1, testPush.Count);

            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RemoveFirst_EmptyList_ShouldThrowException()
        {
            var list = new LinkedStack<int>();
            list.Pop();
        }

        [TestMethod]
        public void Pop_Push()
        {
            LinkedStack<int> testPop = new LinkedStack<int>();
            Assert.AreEqual(0, testPop.Count);
            testPop.Push(3);
            Assert.AreEqual(1, testPop.Count);
            testPop.Push(3);
            Assert.AreEqual(2, testPop.Count);
            Assert.AreEqual(3, testPop.Pop());
            Assert.AreEqual(1, testPop.Count);
            Assert.AreEqual(3, testPop.Pop());
            Assert.AreEqual(0, testPop.Count);
        }



        [TestMethod]
        public void array()
        {
            LinkedStack<int> testArray = new LinkedStack<int>();
            testArray.Push(3);
            testArray.Push(5);
            testArray.Push(-2);
            testArray.Push(7);

            CollectionAssert.AreEqual(new int[] { 7, -2, 5, 3 }, testArray.ToArray());
        }


        [TestMethod]
        public void Emptyarray()
        {
            LinkedStack<DateTime> testArray = new LinkedStack<DateTime>();


            CollectionAssert.AreEqual(new DateTime[0], testArray.ToArray());
        }

    }
}
