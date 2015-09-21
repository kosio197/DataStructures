using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSequence
{
   public class CalculateSequence 
    {
        private int n;

        public CalculateSequence(int n) 
        {
            this.n=n;
        }
        
        public int[] getqu() 
        {
            Queue<int> qu = new Queue<int>();
            int[] result = new int[50];
            result[0] = n;
            int s = n;
            int idx = 1;
            while(qu.Count<49) 
            {
                qu.Enqueue(s + 1);
                qu.Enqueue(2 *s+1);
                qu.Enqueue(s + 2);

                s = qu.Dequeue();
                result[idx++] = s;
            }

                return result;
 //•	S1 = N
//•	S2 = S1 + 1
//•	S3 = 2*S1 + 1
//•	S4 = S1 + 2
//•	S5 = S2 + 1
//•	S6 = 2*S2 + 1
//•	S7 = S2 + 2
//•	…

        }

       
    }
    public class Example 
    {

       public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            CalculateSequence recuest = new CalculateSequence(n);
            int[] res = recuest.getqu();
            Console.WriteLine(string.Join(", ", res));
            //for (int i = 0; i < res.Length-1; i++) 
            //{
            //    Console.WriteLine();
            //}

        }
    } 
}
