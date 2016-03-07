using System;
using System.Collections;
using System.Collections.Generic;

public class DoublyLinkedList<T> : IEnumerable<T>
{
    private class Listnode<T> 
    {
        public T Value { get; private set; }
        public Listnode<T> nextnode { get; set; }
        public Listnode<T> prevnode { get; set; }


        public Listnode (T Value)
        {
            this.Value = Value;
        }
    }


   private Listnode<T> head { get; set; }
    private Listnode<T> tail { get; set; }

    public int Count { get; private set; }

    public void AddFirst(T element)
    {
        Listnode<T> newelement = new Listnode<T>(element);
        if (Count == 0)
        {
            head = newelement;
            tail = newelement;
        }
        else 
        {
            newelement.nextnode = head;
            head.prevnode = newelement;
            head = newelement;
            
        }
        Count++;
    }

    public void AddLast(T element)
    {
        Listnode<T> lastnode = new Listnode<T>(element);
        if (Count == 0)
        {
            head = lastnode;
            tail = lastnode;
        }
        else 
        {
            tail.nextnode = lastnode;
            lastnode.prevnode = tail;
            tail = lastnode;
        }
        Count++;
    }

    public T RemoveFirst()
    {
        if (Count > 1) 
        {
            T hhead = head.Value;
            head.nextnode.prevnode = null;
            head = head.nextnode;
            Count--;
            return hhead;
        }
        else if (Count == 1)
        {
            T hhead = head.Value;
            head = null;
            tail = null;
            Count--;
            return hhead;
        }
        else 
        {
            throw new InvalidOperationException("List Empty ");
        
        }
    }

    public T RemoveLast()
    {
        if (Count > 1) 
        {

            T ttail = tail.Value;
            tail.prevnode.nextnode = null;
            tail = tail.prevnode;
            Count--;
            return ttail;
        }
        else if (Count == 1)
        {
            T ttail = tail.Value;
            tail = null;
            head = null;
            Count--;
            return ttail;
        }
        else 
        {
            throw new InvalidOperationException("List Empty");
        }
    }

    public void ForEach(Action<T> action)
    {
        Listnode<T> curentnode = head;
        while (curentnode != null) 
        {
            action(curentnode.Value);
            curentnode = curentnode.nextnode;
        
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        var currentnod = head;
        while (currentnod != null) 
        {
            yield return currentnod.Value;
            currentnod = currentnod.nextnode;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public T[] ToArray()
    {
    T[] ku=new T[Count];
    var index = head;
    for (int i = 0; i < Count; i++) 
    {
        ku[i] = index.Value;
        index = index.nextnode;
    }

        return ku;
    }
}


class Example
{
    static void Main()
    {
        var list = new DoublyLinkedList<int>();

        list.ForEach(Console.WriteLine);
        Console.WriteLine("-------------------");


        list.AddLast(5);
        list.AddFirst(3);
        list.AddFirst(2);
        list.AddLast(10);
        Console.WriteLine("Count = {0}", list.Count);
	Console.WriteLine("mrun..........");
        list.ForEach(Console.WriteLine);

        Console.WriteLine("--------------------")

        list.RemoveFirst();
        list.RemoveLast();
        list.RemoveFirst();

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");

        list.RemoveLast();

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");
    }
}
