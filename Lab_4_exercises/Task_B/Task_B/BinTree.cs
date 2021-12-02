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

        private void largest(Node tree, ref string longest, ref string longe)
        {
            if (tree != null)
            {
                if (longe == "")
                {
                    longe = longest;
                }
                if (longe.CompareTo(longest) == 1)
                {
                    longe = longest;
                }

                longest=tree.Data;
                
                largest(tree.Left, ref longest, ref longe);
                largest(tree.Right, ref longest, ref longe);
            }
            
        }

        public void Largest(ref string longest, ref string longe)
        {     
            largest(root, ref longest, ref longe);
        }

        private void ancestor(Node tree, string person1, string person2, ref string path)
        {
            if (tree != null)
            {
                string pL = "";
                string pR = "";
                person1=person1.ToUpper();
                person2=person2.ToUpper();
                leftTree(tree.Left, person1, person2, ref pL);
                rightTree(tree.Right, person1, person2, ref pR);
                if (pL.Contains(person1) && pL.Contains(person2)) 
                { 
                    string lca="";
                    findLCA(tree.Left, person1, person2, ref lca);
                    Console.WriteLine("The lowest common ancestor is: "+lca);
                }
                else if(pR.Contains(person1) && pR.Contains(person2))
                {
                    string lca="";
                    findLCA(tree.Right, person1, person2, ref lca);
                    Console.WriteLine("The lowest common ancestor is: "+lca);
                }
                else if(pR.Contains(person1) && pL.Contains(person2))
                {
                    Console.WriteLine("The lowest common ancestor is: "+root.Data);
                }
                else if(pR.Contains(person2) && pL.Contains(person1))
                {
                    Console.WriteLine("The lowest common ancestor is: "+root.Data);
                }
                else
                {
                    Console.WriteLine("Person not found within tree exiting!");
                }
            }
           
        }

        public void Ancestor(string person1, string person2, ref string path)
        {
            ancestor(root, person1, person2, ref path);
        }

        private void leftTree(Node tree, string person1, string person2, ref string pL)
        {
            if(tree != null) 
            { 
                pL += tree.Data + ", ";
                leftTree(tree.Left, person1, person2, ref pL);
                leftTree(tree.Right, person1, person2, ref pL);
            }
        }

        private void rightTree(Node tree, string person1, string person2, ref string pR)
        {
            if(tree != null) 
            { 
                pR += tree.Data + ", ";
                
                rightTree(tree.Left, person1, person2, ref pR);
                rightTree(tree.Right, person1, person2, ref pR);
            }
            
        }

        private void findLCA(Node tree, string x, string y, ref string lca)
        {
            if(tree != null)
            {
                
                if(tree.Left != null && tree.Right != null)
                { 
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
                        findLCA(tree.Left, x, y, ref lca);
                        findLCA(tree.Right, x, y, ref lca);
                    }
                }
                
                
            }
        }
    }
}
