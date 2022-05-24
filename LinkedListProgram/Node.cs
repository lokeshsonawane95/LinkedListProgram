using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    internal class Node
    {
        //For holding the data
        public int data;

        //For holding the address of the next node
        public Node next;

        //Initialization of variable data
        public Node(int data)
        {
            this.data = data;
        }
    }
}
