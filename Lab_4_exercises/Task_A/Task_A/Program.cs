using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(8);
            root.Left = new Node(3);
            root.Right = new Node(4);
            root.Right.Left = new Node(9);
            root.Right.Right = new Node(2);
            root.Left.Left = new Node(7);
            root.Left.Right = new Node(10);

            BinTree mytree = new BinTree(root);

            string s = " ";
            Console.WriteLine("Please enter an option: InOrder, PreOrder, PostOrder");
            string option = Console.ReadLine();
            if (option == "InOrder")
            {
                mytree.InOrder(ref s);
            }
            else if(option == "PreOrder")
            {
                mytree.PreOrder(ref s);
            }
            else if(option == "PostOrder")
            {
                mytree.PostOrder(ref s);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            
            
            Console.WriteLine(s);

            Console.ReadKey();

        }
    }
}
