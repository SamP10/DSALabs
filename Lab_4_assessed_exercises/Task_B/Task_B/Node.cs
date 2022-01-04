using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
    class Node
    {
        //node data initializers
        private string data;
        public Node Left, Right;

        //Constructor
        public Node(string item)
        {
            data = item;
            Left = null;
            Right = null;
        }

        //Data getters and setters
        public string Data
        {
            set { data = value; }
            get { return data; }
        }
    }
}
