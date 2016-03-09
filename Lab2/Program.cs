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
            //int[] myInts = { 1, 1, 2, 2, 2, 3 };
            //smoosh(myInts);
            //Console.WriteLine(string.Join(",", myInts));
            //Console.ReadLine();

            //test data
            LLNode head = new LLNode();
            LLNode secondNode = new LLNode();
            LLNode thirdNode = new LLNode();
            LLNode fourthNode = new LLNode();
            head.data = 3;
            head.next = secondNode;
            secondNode.data = 3;
            secondNode.next = thirdNode;
            thirdNode.data = 2;
            thirdNode.next = fourthNode;
            fourthNode.data = 1;
            fourthNode.next = null;

            LLNode newHead = squish(head);
            Console.WriteLine(newHead.data);
            newHead = newHead.next;
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
            for (int j = slowPointer + 1; j < ints.Length; j++)
            {
                ints[j] = -1;
            }
        }

        public static LLNode squish(LLNode head)
        {
            LLNode fastPointer = new LLNode();
            LLNode slowPointer = new LLNode();
            LLNode tempVar = new LLNode();
            tempVar = head;
            slowPointer = tempVar;
            fastPointer = head;

            while (fastPointer.next != null)
            {
                fastPointer = fastPointer.next;
                if (fastPointer.data == slowPointer.data)
                {
                    //nothing happens, slowPointer doesn't move
                }
                else
                {
                    slowPointer.next = fastPointer;
                    slowPointer = fastPointer;
                }
            }
            fastPointer.next = null;
            return tempVar;
        }

    }
}
