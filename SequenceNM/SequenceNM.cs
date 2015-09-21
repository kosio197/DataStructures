using System;
using System.Collections.Generic;

namespace SequenceNM
{
    public class SequenceNM
    {
        public int[] sequense(int n,int m)
        {
            Queue<Nodeindex> qu = new Queue<Nodeindex>();
            qu.Enqueue(new Nodeindex(n, null));
            Nodeindex item=null;
            bool check = false;

            while (qu.Count > 0) 
            {
                item= qu.Dequeue();
                if (item.value == m) 
                {
                    check = true;
                    break;
                }
                else if (item.value < m) 
                {
                    qu.Enqueue(new Nodeindex(item.value + 1, item));
                    qu.Enqueue(new Nodeindex(item.value + 2, item));
                    qu.Enqueue(new Nodeindex(item.value * 2, item));
                }
            }

            Stack<int> result=new Stack<int>();
            if (check) 
            {
                while (item != null) 
                {
                    result.Push(item.value);
                    item = item.NodePrev;
                }
            }
            return result.ToArray();
        }
    }
    public class Nodeindex 
    {
     
        public Nodeindex NodePrev;
        public int value;
        public Nodeindex(int value, Nodeindex NodePrev) 
        {
            this.value = value;
            this.NodePrev=NodePrev;
        }
        

    }

    public class example 
    {
        static void Main()
        {
            SequenceNM snm = new SequenceNM();
            Console.WriteLine(string.Join("->", snm.sequense(3,10)));
        }
    }
}
