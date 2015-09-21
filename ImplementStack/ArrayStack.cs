using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace ImplementStack
{
    public class ImplementStack
    {

        public static void Main()
        {
        }
    }

    public  class ArrayStack<T>
  {

    private T[] elements;
    public int Count { get; private set; }
    private const int InitialCapacity = 16;

    public  ArrayStack(int capacity = InitialCapacity)
    {
        elements = new T[capacity];
       
    }

    public void Push(T element) 
    {
         if (Count == this.elements.Length) 
        {
            Grow();
        }
    elements[Count++]=element;
    }

    public T Pop() 
    {
        if (Count == 0) 
        {
            throw new InvalidOperationException();
        
        }
    return elements[--Count];
    }

    public T[] ToArray()
    {
      T[] result =new T[Count];
      int i = 0;
      while (Count > 0) 
      {
          result[i++] = Pop();
      }
      return result;
    }

    private void Grow()
    {
        T[] elements = new T[Count * 2];
        Array.Copy(this.elements, elements, Count);
        this.elements = elements;
    }


  }

}

