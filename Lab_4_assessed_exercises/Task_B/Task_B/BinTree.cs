using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
    class BinTree
    {
        //Varaible initializer
        private Node root;

        //Constructor
        public BinTree()
        {
            root = null;
        }

        //Constructor of a given root binary tree
        public BinTree(Node node)
        {
            root = node;
        }

        //Returns the largest lexigraphic entry
        private void largest(Node tree, ref string longest, ref string longe)
        {
            //Checks tree is not empty
            if (tree != null)
            {
                //Checks if the longe variable is blank, if so longe equals the current string
                if (longe == "")
                {
                    longe = longest;
                }
                //Checks the currently stored longe record against the next entry, if equals 1 means the longe is smaller lexicographically then the next entry
                if (longe.CompareTo(longest) == 1)
                {
                    longe = longest;
                }

                longest=tree.Data;
                //Reruns the code for either side of the current node to assess them
                largest(tree.Left, ref longest, ref longe);
                largest(tree.Right, ref longest, ref longe);
            }
            
        }

        //Calls on the largest function to find the lexicographically
        public void Largest(ref string longest, ref string longe)
        {     
            largest(root, ref longest, ref longe);
        }

        //Function serves to return the LCA of two given ancestors
        private void ancestor(Node tree, string person1, string person2, ref string path)
        {
            //Checks the tree is not empty
            if (tree != null)
            {
                //initializes person left and person right
                string pL = "";
                string pR = "";
                //Allows users to enter initials that aren't capitalised
                person1=person1.ToUpper();
                person2=person2.ToUpper();
                //These functions splits the tree left and right
                leftTree(tree.Left, person1, person2, ref pL);
                rightTree(tree.Right, person1, person2, ref pR);

                //If the left side contains person 1 and 2
                if (pL.Contains(person1) && pL.Contains(person2)) 
                { 
                    //Initializes LCA variable
                    string lca="";
                    //Runs the findLCA function with the left side of the tree
                    findLCA(tree.Left, person1, person2, ref lca);
                    Console.WriteLine("The lowest common ancestor is: "+lca);
                }
                //If the person right contains 1 and 2
                else if(pR.Contains(person1) && pR.Contains(person2))
                {
                    //Initializes LCA variable
                    string lca ="";
                    //Runs the findLCA function with the left side of the tree
                    findLCA(tree.Right, person1, person2, ref lca);
                    Console.WriteLine("The lowest common ancestor is: "+lca);
                }
                //else the persons reside in seperate branches of the tree the LCA will be the root.
                else if(pR.Contains(person1) && pL.Contains(person2))
                {
                    Console.WriteLine("The lowest common ancestor is: "+root.Data);
                }
                else if(pR.Contains(person2) && pL.Contains(person1))
                {
                    Console.WriteLine("The lowest common ancestor is: "+root.Data);
                }
                //If not found returns error
                else
                {
                    Console.WriteLine("Person not found within tree exiting!");
                }
            }
           
        }

        //Calls the ancestor function above
        public void Ancestor(string person1, string person2, ref string path)
        {
            ancestor(root, person1, person2, ref path);
        }

        //Checks the left hand of the tree and adds to a string
        private void leftTree(Node tree, string person1, string person2, ref string pL)
        {
            if(tree != null) 
            { 
                pL += tree.Data + ", ";
                leftTree(tree.Left, person1, person2, ref pL);
                leftTree(tree.Right, person1, person2, ref pL);
            }
        }

        //Checks the right hand of the tree and adds to a string
        private void rightTree(Node tree, string person1, string person2, ref string pR)
        {
            if(tree != null) 
            { 
                pR += tree.Data + ", ";
                
                rightTree(tree.Left, person1, person2, ref pR);
                rightTree(tree.Right, person1, person2, ref pR);
            }
            
        }

        //Find the lowest common ancestor function from a given position
        private void findLCA(Node tree, string x, string y, ref string lca)
        {
            //Checks tree is not null
            if(tree != null)
            {
                //As long as the next subsoquent children nodes are not null
                if(tree.Left != null && tree.Right != null)
                { 
                    //Returns the parent if either are equal to p1 or p2 (x y Respectively)
                    if (tree.Left.Data == x || tree.Right.Data == y)
                    {
                        string parent = tree.Data;
                        lca += parent+" ";
                        
                    }
                    else if (tree.Left.Data == y || tree.Right.Data == x)
                    {
                        string parent = tree.Data;
                        lca += parent+" ";
                      
                    }
                    else
                    {
                        //If not found rerun this function with the right and left nodes next
                        findLCA(tree.Left, x, y, ref lca);
                        findLCA(tree.Right, x, y, ref lca);
                    }
                }
                
                
            }
        }
    }
}
