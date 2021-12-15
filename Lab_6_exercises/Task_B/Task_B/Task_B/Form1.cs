using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_B
{
    public partial class Form1 : Form
    {
        Graph myGraph = new Graph();
        public Form1()
        {
            InitializeComponent();
            //Node adding
            myGraph.AddNode("ams");
            myGraph.AddNode("ber");
            myGraph.AddNode("bru");
            myGraph.AddNode("cdg");
            myGraph.AddNode("lcy");
            myGraph.AddNode("lis");
            myGraph.AddNode("lux");
            myGraph.AddNode("mad");
            myGraph.AddNode("mxp");
            myGraph.AddNode("waw");
            //Add direct flights
            myGraph.AddEdge("ams", "cdg");
            myGraph.AddEdge("ber", "mad");
            myGraph.AddEdge("cdg", "lis");
            myGraph.AddEdge("lux", "ams");
            myGraph.AddEdge("mad", "lcy");
            myGraph.AddEdge("mad", "cdg");
            myGraph.AddEdge("mad", "bru");
            myGraph.AddEdge("mxp", "lcy");
            myGraph.AddEdge("mxp", "ber");
            myGraph.AddEdge("mxp", "waw");
            myGraph.AddEdge("waw", "lux");
            //Display airports and connections
            LinkedList<GraphNode> nodes = myGraph.ListOfNodes();
            foreach (var n in nodes)
            {

                fromBox.Items.Add(n.ID);
                conBox1.Items.Add(n.ID);
                conBox2.Items.Add(n.ID);
                LinkedList<string> adjList = n.GetAdjList();
                foreach (string i in adjList)
                {
                    dirShow.Items.Add(Convert.ToString(n.ID) + " --> " + Convert.ToString(i));
                }

            }

        }

        private void addNode_Click(object sender, EventArgs e)
        {
            fromBox.Items.Clear();
            conBox1.Items.Clear();
            conBox2.Items.Clear();
            dirShow.Items.Clear();

            string idInp = addID.Text;
            if (idInp != "")
            {

                if (idInp.Length <= 3)
                {
                    string idAdd = idInp;
                    myGraph.AddNode(idAdd);
                    addID.Text = "";
                    errorM1.Text = "Node added!";
                    errorM1.ForeColor = Color.Green;

                }
                else
                {
                    errorM1.Text = "Greater than 3";
                    errorM1.ForeColor = Color.Red;
                }
            }
            else
            {
                errorM1.Text = "Please specify airport";
                errorM1.ForeColor = Color.Red;
            }

            LinkedList<GraphNode> nodes = myGraph.ListOfNodes();
            foreach (var n in nodes)
            {

                fromBox.Items.Add(n.ID);
                conBox1.Items.Add(n.ID);
                conBox2.Items.Add(n.ID);
                LinkedList<string> adjList = n.GetAdjList();
                foreach (string i in adjList)
                {
                    dirShow.Items.Add(Convert.ToString(n.ID) + " --> " + Convert.ToString(i));
                }

            }
        }

        private void addID_TextChanged(object sender, EventArgs e)
        {

        }

        private void fromBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void conBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void conBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dirShow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addDir_Click(object sender, EventArgs e)
        {
            
            if (conBox1.SelectedItem == null || conBox2.SelectedItem == null)
            {
                errorM2.Text = "Not a valid path";
                errorM2.ForeColor = Color.Red;
            }
            else
            {
                string from = Convert.ToString(conBox1.SelectedItem);
                string to = Convert.ToString(conBox2.SelectedItem);
                fromBox.Items.Clear();
                conBox1.Items.Clear();
                conBox2.Items.Clear();
                dirShow.Items.Clear();
                if (from != to)
                {
                    myGraph.AddEdge(from, to);
                    errorM2.Text = "Direct flight added!";
                    errorM2.ForeColor = Color.Green;
                }
                else
                {
                    errorM2.Text = "Not possible";
                    errorM2.ForeColor = Color.Red;
                }
            }
            LinkedList<GraphNode> nodes = myGraph.ListOfNodes();
            foreach (var n in nodes)
            {

                fromBox.Items.Add(n.ID);
                conBox1.Items.Add(n.ID);
                conBox2.Items.Add(n.ID);
                LinkedList<string> adjList = n.GetAdjList();
                foreach (string i in adjList)
                {
                    dirShow.Items.Add(Convert.ToString(n.ID) + " --> " + Convert.ToString(i));
                }

            }



        }

        private void delFlight_Click(object sender, EventArgs e)
        {
            if(dirShow.SelectedItem != null)
            {
                string flight = Convert.ToString(dirShow.SelectedItem);
                fromBox.Items.Clear();
                conBox1.Items.Clear();
                conBox2.Items.Clear();
                dirShow.Items.Clear();
                myGraph.delEdge(flight);


                LinkedList<GraphNode> nodes = myGraph.ListOfNodes();
                foreach (var n in nodes)
                {

                    fromBox.Items.Add(n.ID);
                    conBox1.Items.Add(n.ID);
                    conBox2.Items.Add(n.ID);
                    LinkedList<string> adjList = n.GetAdjList();
                    foreach (string i in adjList)
                    {
                        dirShow.Items.Add(Convert.ToString(n.ID) + " --> " + Convert.ToString(i));
                    }

                }
            }

        }
    }
}
