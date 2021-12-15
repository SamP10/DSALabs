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
        Graph myGraph = new Graph();
        int eCount;

        public Form1()
        {
            InitializeComponent();
            myGraph.AddNode(2134213);
            myGraph.AddNode(2567433);
            myGraph.AddNode(1523428);
            myGraph.AddNode(3241589);
            myGraph.AddNode(2967343);
            myGraph.AddEdge(2134213, 2567433);
            myGraph.AddEdge(3241589, 2967343);
            myGraph.AddEdge(1523428, 2134213);

            int id = myGraph.NumOfNodes();
            nodeCount.Text = Convert.ToString(id);
            eCount = 0;
            LinkedList<GraphNode> nodes = myGraph.ListOfNodes();
            foreach(var n in nodes)
            {
                
                Nodes1.Items.Add(Convert.ToString(n.ID));
                Nodes2.Items.Add(Convert.ToString(n.ID));
                LinkedList<int> adjList = n.GetAdjList();
                foreach(int i in adjList)
                {
                    Edge1.Items.Add(Convert.ToString(n.ID)+" --> "+Convert.ToString(i));
                    eCount++;
                    edgeCount.Text = Convert.ToString(eCount);
                }
               
            }
            
        }

        private void addN_Click(object sender, EventArgs e)
        {
            Nodes1.Items.Clear();
            Nodes2.Items.Clear();
            Edge1.Items.Clear();

            string idInp = AddID.Text;
            if(idInp != "")
            {

                if(idInp.Length < 6 )
                {
                    int idAdd = Convert.ToInt32(idInp);
                    myGraph.AddNode(idAdd);
                    AddID.Text = "";
                    errorM1.Text = "Node added!";
                    errorM1.ForeColor = Color.Green;

                }
                else
                {
                    errorM1.Text = "Greater than 6";
                    errorM1.ForeColor = Color.Red;
                }
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

        private void addE_Click(object sender, EventArgs e)
        {
            int from = Convert.ToInt32(Nodes1.SelectedItem);
            int to = Convert.ToInt32(Nodes2.SelectedItem);
            if(Nodes1.SelectedItem == null|| Nodes2.SelectedItem == null)
            {
                errorM2.Text = "Not a valid path";
                errorM2.ForeColor = Color.Red;
            }
            Nodes1.Items.Clear();
            Nodes2.Items.Clear();
            Edge1.Items.Clear();

            if (from != to)
            {
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
