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
            int[] myInts = { 1, 1, 2, 2 };
            smoosh(myInts);
            Console.WriteLine(string.Join(",", myInts));
            Console.ReadLine();
        }

        public static void smoosh(int[] ints)
        {
            int tempVar = ints[0];
            int slowPointer = ints[0];
            int pointer = 0;
        
            //count the number of dupes 
            for (int i = 0; i < ints.Length; i++)
            {
                pointer = ints[i];
                if (pointer == slowPointer)
                {
                    //slowPointer doesn't move
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        ints[j] = slowPointer;
                        slowPointer = pointer;
                        tempVar = j;
                    }
                }
            }

            //add -1 to the end
            for (int j = tempVar+1; j < ints.Length; j++) 
            {
                ints[j] = -1;
            }
        }
    }
}
