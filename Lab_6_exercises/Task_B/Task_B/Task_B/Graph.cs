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
            foreach (GraphNode n in nodes)
            {
                if (id == n.ID)
                    return n;
            }

            return null;
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

            n1.remove(n2);
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
    }
}
