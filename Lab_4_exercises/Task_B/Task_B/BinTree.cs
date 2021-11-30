using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
    class BinTree
    {
        private Node root;
        public BinTree()
        {
            root = null;
        }
        public BinTree(Node node)
        {
            root = node;
        }

        private void largest(Node tree, ref string longest)
        {
            if (tree != null)
            {



                if (longest.CompareTo(tree.Data) == 1)
                {
                    Console.WriteLine(longest);
                }
                else
                {
                    longest = tree.Data;
                }
                largest(tree.Right, ref longest);
                largest(tree.Left, ref longest);

            }
            
        }
        public void Largest(ref string longest)
        {
            largest(root, ref longest);
        }
    }
}
