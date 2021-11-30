using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node("BP");
            root.Left = new Node("GP");
            root.Right = new Node("LP");
            root.Left.Left = new Node("PP");
            root.Left.Right = new Node("JP");
            root.Right.Left = new Node("JM");
            root.Right.Right = new Node("CM");
            root.Left.Left.Left = new Node("SP");
            root.Left.Left.Right = new Node("AP");
            root.Left.Right.Left = new Node("GP");
            root.Left.Right.Right = new Node("JP");
            root.Right.Right.Left = new Node("CM");
            root.Left.Left.Right.Left = new Node("LP");
            root.Left.Left.Right.Left = new Node("IP");
        }
    }
}
