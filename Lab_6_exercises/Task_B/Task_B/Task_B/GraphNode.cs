using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
    class GraphNode
    {
        private string id;

        private LinkedList<string> adjList;

        public GraphNode(string id)
        {
            this.id = id;
            adjList = new LinkedList<string>();
        }

        public string ID
        {
            set { id = value; }
            get { return id; }
        }

        public void AddEdge(GraphNode to)
        {
            adjList.AddLast(to.ID);
        }

        public LinkedList<string> GetAdjList()
        {
            return adjList;
        }

        public void remove(GraphNode id)
        {
            adjList.Remove(id.ID);
        }

    }
}
