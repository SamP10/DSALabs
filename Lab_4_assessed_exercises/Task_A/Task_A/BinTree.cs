using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
{
    class BinTree
    {
        //Variables initializer for binary tree
        private Node root;

        //Cosntructor
        public BinTree()
        {
            root = null;
        }

        //Constructor for a given root node
        public BinTree(Node node)
        {
            root = node;
        }

        //Calls the buffer in order
        public void InOrder(ref string buffer)
        {
            inOrder(root, ref buffer);
        }

        //Recursive function to traverse a binary tree in order
        private void inOrder(Node tree, ref string buffer)
        {
            //Checks the tree is not empty 
            if(tree != null)
            {
                //runs the function again with the left hand node
                inOrder(tree.Left, ref buffer);
                //Adds the data to the buffer
                buffer += tree.Data.ToString() + ",";
                //Runs the function again with the right hand node
                inOrder(tree.Right, ref buffer);
            }
        }

        //Calls the buffer pre order
        public void PreOrder(ref string buffer)
        {
            preOrder(root, ref buffer);
        }

        //Recursive function to traverse a binary tree pre order
        private void preOrder(Node tree, ref string buffer)
        {
            //Checks the tree is not empty
            if (tree != null)
            {
                //Adds the data to the buffer
                buffer += tree.Data.ToString() + ",";

                //runs the function with the left of the node
                preOrder(tree.Left, ref buffer);
                //runs the function with the right of the node
                preOrder(tree.Right, ref buffer);
            }
        }

        //Calls the buffer with post order
        public void PostOrder(ref string buffer)
        {
            postOrder(root, ref buffer);
        }

        //Recursive function to traverse a binary tree post order
        private void postOrder(Node tree, ref string buffer)
        {
            //Checks if tree is not empty
            if(tree != null)
            {
                //runs the function with left and right nodes
                postOrder(tree.Left, ref buffer);
                postOrder(tree.Right, ref buffer);
                //adds them to the buffer after running
                buffer += tree.Data.ToString() + ",";
            }
        }
    }
}
