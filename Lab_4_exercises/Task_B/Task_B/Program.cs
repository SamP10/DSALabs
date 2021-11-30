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
            root.Left.Left = new Node("PMHP");
            root.Left.Right = new Node("JP");
            root.Right.Left = new Node("JM");
            root.Right.Right = new Node("CM");
            root.Left.Left.Left = new Node("SCP");
            root.Left.Left.Right = new Node("AJP");
            root.Left.Right.Left = new Node("GP");
            root.Left.Right.Right = new Node("JP");
            root.Right.Right.Left = new Node("CM");
            root.Left.Left.Right.Left = new Node("LMP");
            root.Left.Left.Right.Left = new Node("IMP");

            BinTree mytree = new BinTree(root);

            string s = "";
            string x = "";
            mytree.Largest(ref s, ref x);
            Console.WriteLine("Longest lexicographically family member: " + x);
            Console.WriteLine("Enter person one: ");
            string p1 = Console.ReadLine();

            Console.WriteLine("Enter person two: ");
            string p2 = Console.ReadLine();

            string path = "";
            mytree.Ancestor(p1, p2, ref path);

            Console.ReadKey();
        }
    }
}
