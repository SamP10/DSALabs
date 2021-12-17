using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
    class Graph
    {
        private LinkedList<GraphNode> nodes;

        
        public Graph()
        {
            nodes = new LinkedList<GraphNode>();
        }

        public void AddNode(string id)
        {
            nodes.AddLast(new GraphNode(id));
        }

        public GraphNode GetNodeByID(string id)
        {
            if(id != null)
            {
                foreach (GraphNode n in nodes)
                {
                    if (id == n.ID)
                    {
                        return n;
                    }
                        
                }

                return null;
            }return null;
            
        }

        public void AddEdge(string from, string to)
        {
            GraphNode n1 = GetNodeByID(from);

            GraphNode n2 = GetNodeByID(to);

            n1.AddEdge(n2);
        }

        public void delEdge(string from, string to)
        {
            GraphNode n1 = GetNodeByID(from);

            GraphNode n2 = GetNodeByID(to);

            n1.RemoveEdge(n2);
        }

        public bool IsEmptyGraph()
        {
            if (nodes.Count == 0)
            {
                return true;
            }
            return false;
        }

        public int NumOfNodes()
        {
            if (nodes.Count != 0)
            {
                return nodes.Count;
            }
            return 0;
        }

        public LinkedList<GraphNode> ListOfNodes()
        {
            return nodes;

        }

        public string DirectF(string n)
        {
            string path = "";
            GraphNode n1 = GetNodeByID(n);
            LinkedList<string> adjList = n1.GetAdjList();
            
            foreach(string adj in adjList)
            {
                path = path +" "+  adj;
            }
            return path;
        }

        public void DFS(string n, ref LinkedList<string> stack, ref LinkedList<string> visited)
        {
            if (GetNodeByID(n) != null)
            {
                GraphNode n1 = GetNodeByID(n);
                LinkedList<string> adjList = n1.GetAdjList();

                if (adjList.Count == 0)
                {
                    if (stack.Count != 0)
                    {
                        if (visited.Contains(n1.ID)==false) 
                        {
                            visited.AddLast(n1.ID); 
                        }

                        string nextN = stack.Last();
                        stack.Remove(nextN);
                        DFS(nextN, ref stack, ref visited);
                    }
                }
                else if (adjList.Count != 0)
                {
                    foreach (string adj in adjList)
                    {
                        stack.AddLast(adj);
                    }
                    if (visited.Contains(n1.ID) == false)
                    {
                        visited.AddLast(n1.ID);
                    }
                    string nextN = stack.Last();
                    DFS(nextN, ref stack, ref visited);
                }
            }
            
        }
    }
}
