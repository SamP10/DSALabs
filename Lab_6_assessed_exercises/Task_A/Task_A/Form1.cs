using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_A
{
    public partial class Form1 : Form
    {
        //Create a new graph called mygraph
        Graph myGraph = new Graph();
        int eCount;

        public Form1()
        {
            InitializeComponent();
            //Adding nodes using the addnode function of graph
            myGraph.AddNode(2134213);
            myGraph.AddNode(2567433);
            myGraph.AddNode(1523428);
            myGraph.AddNode(3241589);
            myGraph.AddNode(2967343);
            //Adding edges using the addedge function of graph
            myGraph.AddEdge(2134213, 2567433);
            myGraph.AddEdge(3241589, 2967343);
            myGraph.AddEdge(1523428, 2134213);

            //Getting the number of nodes in the graph
            int id = myGraph.NumOfNodes();
            nodeCount.Text = Convert.ToString(id);
            eCount = 0;
            //Gets the list of nodes to display in listboxes
            LinkedList<GraphNode> nodes = myGraph.ListOfNodes();
            foreach(var n in nodes)
            {
                
                Nodes1.Items.Add(Convert.ToString(n.ID));
                Nodes2.Items.Add(Convert.ToString(n.ID));
                //Gets the list of edges to display in listboxes
                LinkedList<int> adjList = n.GetAdjList();
                foreach(int i in adjList)
                {

                    Edge1.Items.Add(Convert.ToString(n.ID)+" --> "+Convert.ToString(i));
                    eCount++;
                    edgeCount.Text = Convert.ToString(eCount);
                }
               
            }
            
        }

        //Add node button 
        private void addN_Click(object sender, EventArgs e)
        {
            Nodes1.Items.Clear();
            Nodes2.Items.Clear();
            Edge1.Items.Clear();

            //Gets the id from user input
            string idInp = AddID.Text;
            //Checks the field is not empty
            if(idInp != "")
            {
                //Checks the length is not grater than 6
                if(idInp.Length < 6 )
                {
                    //Converts input to int from string
                    int idAdd = Convert.ToInt32(idInp);
                    //Calls the add node function of graph to add the node
                    myGraph.AddNode(idAdd);
                    AddID.Text = "";

                    //Success message
                    errorM1.Text = "Node added!";
                    errorM1.ForeColor = Color.Green;

                }
                else
                {
                    //Error message
                    errorM1.Text = "Greater than 6";
                    errorM1.ForeColor = Color.Red;
                }
            }
            //Node count
            int id = myGraph.NumOfNodes();
            nodeCount.Text = Convert.ToString(id);
            eCount = 0;
            LinkedList<GraphNode> nodes = myGraph.ListOfNodes();
            foreach (var n in nodes)
            {
                
                Nodes1.Items.Add(Convert.ToString(n.ID));
                Nodes2.Items.Add(Convert.ToString(n.ID));
                LinkedList<int> adjList = n.GetAdjList();
                foreach (int i in adjList)
                {
                    Edge1.Items.Add(Convert.ToString(n.ID) + " --> " + Convert.ToString(i));
                    eCount++;
                    edgeCount.Text = Convert.ToString(eCount);
                }

            }
        }


        //Add edge button
        private void addE_Click(object sender, EventArgs e)
        {
            //Gets the from and to nodes from the lsitboxes
            int from = Convert.ToInt32(Nodes1.SelectedItem);
            int to = Convert.ToInt32(Nodes2.SelectedItem);
            //Checks items are selected
            if(Nodes1.SelectedItem == null|| Nodes2.SelectedItem == null)
            {
                errorM2.Text = "Not a valid path";
                errorM2.ForeColor = Color.Red;
            }
            Nodes1.Items.Clear();
            Nodes2.Items.Clear();
            Edge1.Items.Clear();
            //Checks the from and to are not same
            if (from != to)
            {
                //uses the add edge function of graph to add edge
                myGraph.AddEdge(from, to);
                errorM2.Text = "Edge added!";
                errorM2.ForeColor = Color.Green;
            }

            int id = myGraph.NumOfNodes();
            nodeCount.Text = Convert.ToString(id);
            eCount = 0;
            LinkedList<GraphNode> nodes = myGraph.ListOfNodes();
            foreach (var n in nodes)
            {
                Nodes1.Items.Add(Convert.ToString(n.ID));
                Nodes2.Items.Add(Convert.ToString(n.ID));
                LinkedList<int> adjList = n.GetAdjList();
                foreach (int i in adjList)
                {
                    
                    Edge1.Items.Add(Convert.ToString(n.ID) + " --> " + Convert.ToString(i));
                    eCount++;
                    edgeCount.Text = Convert.ToString(eCount);
                }

            }
        }

        private void Nodes1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Nodes2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Edge1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nodeCount_Click(object sender, EventArgs e)
        {

        }

        private void edgeCount_Click(object sender, EventArgs e)
        {

        }
    }
}
