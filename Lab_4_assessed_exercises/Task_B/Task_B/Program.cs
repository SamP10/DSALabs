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
            //Creates node relationship of ancestors
            Node root = new Node("BP");
            root.Left = new Node("GP");
            root.Right = new Node("LP");
            root.Left.Left = new Node("PMHP");
            root.Left.Right = new Node("JP");
            root.Right.Left = new Node("JM");
            root.Right.Right = new Node("CM");
            root.Left.Left.Left = new Node("SCP");
            root.Right.Right.Right = new Node("PM");

            /* Tree Diagram
             * -----------------------
             *               BP
             *             /    \
             *           GP      LP
             *          /  \    /  \
             *      PMHP   JP  JM   CM
             *       /                \
             *     SCP                PM
             *      
             * 
             */
            //Initializes the binary tree with the previously created nodes
            BinTree mytree = new BinTree(root);

            string s = "";
            string x = "";
            //Calls the largest lexicographically largest entry through the Largest function
            mytree.Largest(ref s, ref x);
            //Prints longest lexicographical entry
            Console.WriteLine("Longest lexicographically family member: " + x);
            //Prompts for user entry
            Console.WriteLine("Enter person one: ");
            string p1 = Console.ReadLine();

            Console.WriteLine("Enter person two: ");
            string p2 = Console.ReadLine();

            string path = "";
            //Runs the LCA function within the binary tree
            mytree.Ancestor(p1, p2, ref path);
            Console.ReadKey();
        }
    }
}
