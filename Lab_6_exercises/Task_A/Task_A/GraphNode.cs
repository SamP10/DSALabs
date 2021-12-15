using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
{
    class GraphNode
    {
        private int id;

        private LinkedList<int> adjList;

        public GraphNode(int id)
        {
            this.id = id;
            adjList = new LinkedList<int>();
        }

        public int ID
        {
            set { id = value; }
            get { return id; }
        }

        public void AddEdge(GraphNode to)
        {
            adjList.AddLast(to.ID);
        }

        public LinkedList<int> GetAdjList()
        {
            return adjList;
        }

    }
}
