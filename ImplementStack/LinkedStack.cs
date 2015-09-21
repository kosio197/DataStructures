using System;
using System.Collections.Generic;
using System.Collections;

namespace ImplementStack
{
     public class LinkedStack<T>
    {
        private Node<T> firstNode;
        public int Count { get; private set; }

        public void Push(T element)
        {
            if(Count==0)
            {
               firstNode = new Node<T>(element,null);
            }else
            {
            Node<T> next=new Node<T>(element,firstNode);
                firstNode=next;
            }
            Count++;
        }


        public T Pop() 
        {
            if(Count==0)
            {
                throw new InvalidOperationException();
            }
        T Popvalue=firstNode.value;
            Count--;
            firstNode=firstNode.NextNode;
            return Popvalue;
        }


        public T[] ToArray() 
        {
            T[] output=new T[Count];
            int i=0;
            while(Count>0)
            {
              output[i++]=Pop(); 
            }
            return output;
        }
   
        private class Node<T>
        {
            public T value{get;private set;}
            public Node<T> NextNode { set; get; }
            public Node(T value, Node<T> nextNode = null) 
            {
                this.value=value;
                this.NextNode=nextNode;
            }
        }

    }
}
