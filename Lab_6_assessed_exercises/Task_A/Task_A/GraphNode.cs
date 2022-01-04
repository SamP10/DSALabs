using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
{
    class GraphNode
    {
        //Variable initializer
        private int id;

        //Linked adjacency list to store all edges
        private LinkedList<int> adjList;


        //Constructor
        public GraphNode(int id)
        {
            this.id = id;
            adjList = new LinkedList<int>();
        }

        //Getters and setters of ID
        public int ID
        {
            set { id = value; }
            get { return id; }
        }

        //Add edge function
        public void AddEdge(GraphNode to)
        {
            //Adds to end of the linked adjacency list
            adjList.AddLast(to.ID);
        }

        //Simply returns adjacency list for display
        public LinkedList<int> GetAdjList()
        {
            return adjList;
        }

    }
}
