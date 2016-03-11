using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class LLNode
    {
        public int data;
        public LLNode next;

        public LLNode(int newData, LLNode nextNode)
        {
            data = newData;
            next = nextNode;
    }
    }
}
