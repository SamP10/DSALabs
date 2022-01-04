using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
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
        public void AddNode(int id)
        {
            //Adds last a instance of graphnode to the nodes linked list
            nodes.AddLast(new GraphNode(id));
        }


        //Gets the object instance of a node from a given ID
        public GraphNode GetNodeByID(int id)
        {
            //Searches through every entry wihin nodes
            foreach(GraphNode n in nodes)
            {
                //If found returns the object instance
                if (id == n.ID)
                    return n;
            }
            //Otherwise return null
            return null;
        }

        //Add edge takes two variables from and to
        public void AddEdge(int from, int to)
        {
            //Calls getNodeID to return the object
            GraphNode n1 = GetNodeByID(from);

            GraphNode n2 = GetNodeByID(to);
            //Calls the add edge function from graphnode to add edge between n1 and n2
            n1.AddEdge(n2);


        }

        //Checks the graph is not empty
        public bool IsEmptyGraph()
        {
            if(nodes.Count == 0)
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
    }
}
