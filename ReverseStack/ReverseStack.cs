using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStack
{
    class ReverseStack
    {
        static void Main()
        {
            string input = Console.ReadLine();
            if (input.Equals("")) 
            {
                Console.WriteLine("(empty)");
                return;
            }
            string[] charinp = input.Split(' ');
            int index = 0;
            Stack<int> resiver = new Stack<int>();
            for (int i = 0; i < charinp.Length; i++)
            {
                if (!int.TryParse(charinp[i], out index)) 
                {
                    Console.WriteLine("Invalid Input");
                    return;
                }
                resiver.Push(index);
            }
          while(resiver.Count>1)
            {
                int j = resiver.Pop();
                Console.Write(j+" ");
            }
          Console.WriteLine(resiver.Last());
        }
    }
}
