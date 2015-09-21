using System;
using System.Collections.Generic;
using System.Collections;

namespace ImplementQueue
{
    public class LinkedQueue<T>
    {
        public int Count { get; private set; }
        private QueueNode<T> head;
        private QueueNode<T> tail;

        public void Enqueue(T element)
        {
            QueueNode<T> input = new QueueNode<T>(element);
            if (Count == 0)
            {
                head = input;
                tail = input;
            }
            else
            {
                input.NextNode = head;
                head.PrevNode = input;
                head = input;
            }
            Count++;
        }


        public T Dequeue()
        {
            if (Count > 0)
            {
                T NodeValue = tail.Value;
                tail = tail.PrevNode;
                Count--;
                return NodeValue;
            }
            else
            {
                throw new InvalidOperationException("Queue is Empty");
            }
        }

        public T[] ToArray()
        {
            int j = Count;
            T[] result = new T[j];
            for (int i = 0; i < j; i++)
            {
                result[i] = Dequeue();
            }
            return result;
        }

        public class QueueNode<T>
        {
            public T Value { get; private set; }
            public QueueNode<T> NextNode { get; set; }
            public QueueNode<T> PrevNode { get; set; }

            public QueueNode(T Value)
            {
                this.Value = Value;
            }
        }
 
    }
    class ClassMain 
    {
         public static void Main() 
        {
          
        }
    }
}
