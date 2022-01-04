using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
    class GraphNode
    {
        //Variable initializer
        private string id;
        //Adjacency linked list
        private LinkedList<string> adjList;

        //Constructor
        public GraphNode(string id)
        {
            this.id = id;
            adjList = new LinkedList<string>();
        }

        //Getter and setter of ID
        public string ID
        {
            set { id = value; }
            get { return id; }
        }


        //Add Edge function
        public void AddEdge(GraphNode to)
        {
            //Adds to end of the linked adjacency list
            adjList.AddLast(to.ID);
        }

        //Simply returns adjacency list for display
        public LinkedList<string> GetAdjList()
        {
            return adjList;
        }

        //Removes an edge from adjacency list
        public void RemoveEdge(GraphNode to)
        {
            //Uses remove function of list to remove specific id
            adjList.Remove(to.ID);
        }

    }
}
