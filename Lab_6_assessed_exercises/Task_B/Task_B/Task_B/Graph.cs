using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
    class Graph
    {
        //Linkedlist of class GraphNode
        private LinkedList<GraphNode> nodes;

        //Constructor
        public Graph()
        {
            nodes = new LinkedList<GraphNode>();
        }

        //Add node function to the tree
        public void AddNode(string id)
        {
            //Adds last a instance of graphnode to the nodes linked list
            nodes.AddLast(new GraphNode(id));
        }

        //Gets the object instance of a node from a given ID
        public GraphNode GetNodeByID(string id)
        {
            //Checks the id is not null
            if(id != null)
            {
                //Searches through every entry wihin nodes
                foreach (GraphNode n in nodes)
                {
                    //If found returns the object instance
                    if (id == n.ID)
                    {
                        return n;
                    }
                        
                }
                //Otherwise return null
                return null;
            }return null;
            
        }

        //Add edge takes two variables from and to
        public void AddEdge(string from, string to)
        {
            //Calls getNodeID to return the object
            GraphNode n1 = GetNodeByID(from);

            GraphNode n2 = GetNodeByID(to);
            
            //Calls the add edge function from graphnode to add edge between n1 and 
            n1.AddEdge(n2);
        }

        //Delete edge takes two variables from and to
        public void delEdge(string from, string to)
        {
            //Uses getnodebyid to get instance of the object with that id
            GraphNode n1 = GetNodeByID(from);

            GraphNode n2 = GetNodeByID(to);

            //Calls the remove edge function
            n1.RemoveEdge(n2);
        }

        //Checks the graph is not empty
        public bool IsEmptyGraph()
        {
            if (nodes.Count == 0)
            {
                return true;
            }
            return false;
        }

        //Counts the number of nodes within the tree and returns the number
        public int NumOfNodes()
        {
            if (nodes.Count != 0)
            {
                return nodes.Count;
            }
            return 0;
        }

        //Returns list of nodes.
        public LinkedList<GraphNode> ListOfNodes()
        {
            return nodes;

        }

        //A function to identify all direct flights of the adjacency list from a given node
        public string DirectF(string n)
        {
            string path = "";
            //Gets the object instance using getnodebyid function
            GraphNode n1 = GetNodeByID(n);
            //Then grabbing the adjacency list assosciated with the node
            LinkedList<string> adjList = n1.GetAdjList();
            
            //Loops through and passes the results to the path variable
            foreach(string adj in adjList)
            {
                path = path +" "+  adj;
            }
            //Returns path
            return path;
        }

        //Depth first search algorithm for finding all the flights within the graph
        public void DFS(string n, ref LinkedList<string> stack, ref LinkedList<string> visited)
        {
            //Checks the node is existant
            if (GetNodeByID(n) != null)
            {
                //gets object instance from id
                GraphNode n1 = GetNodeByID(n);
                LinkedList<string> adjList = n1.GetAdjList();
                //Checks the adjacency list has entries
                if (adjList.Count == 0)
                {
                    //Checks the count of the stack, the stack contains all nodes yet to visit
                    if (stack.Count != 0)
                    {
                        //Appends the current id to the visited list if not already in it
                        if (visited.Contains(n1.ID)==false) 
                        {
                            visited.AddLast(n1.ID); 
                        }

                        //Gets the last id in the stack and removes it from the stack
                        string nextN = stack.Last();
                        stack.Remove(nextN);
                        //This id is then ran recursively throught this function
                        DFS(nextN, ref stack, ref visited);
                    }
                }
                //If the adjacency count is more than 0
                else if (adjList.Count != 0)
                {
                    //Loop through and identify the adjacency list
                    foreach (string adj in adjList)
                    {
                        //Add the id of the children to the stack
                        stack.AddLast(adj);
                    }
                    if (visited.Contains(n1.ID) == false)
                    {
                        visited.AddLast(n1.ID);
                    }
                    string nextN = stack.Last();
                    //Reruns the dfs function
                    DFS(nextN, ref stack, ref visited);
                }
            }
            
        }
    }
}
