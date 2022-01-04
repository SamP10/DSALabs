using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
{
    class Node
    {
        //Node variables
        private int data;
        //node objects left and right of current node
        public Node Left, Right;

        //Constructor
        public Node(int item)
        {
            data = item;
            Left = null;
            Right = null;
        }

        //Getter and setter of data
        public int Data
        {
            set { data = value; }
            get { return data; }
        }
    }
}
