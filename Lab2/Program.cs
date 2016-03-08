using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myInts = { 1, 1, 2, 2, 2, 3 };
            smoosh(myInts);
            Console.WriteLine(string.Join(",", myInts));
            Console.ReadLine();
        }

        public static void smoosh(int[] ints)
        {
            int slowPointer = 0;
            int pointer = 0;
        
            for (int i = 0; i < ints.Length; i++)
            {
                pointer = ints[i];
                if (pointer == ints[slowPointer])
                {
                    //slowPointer doesn't move
                }
                else
                {
                    slowPointer = slowPointer + 1;
                    ints[slowPointer] = pointer;
                }
            }

            //add -1 to the end
            for (int j = slowPointer+1; j < ints.Length; j++) 
            {
                ints[j] = -1;
            }
        }
    }
}
