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
        LinkedList<string> visited = new LinkedList<string>();
        LinkedList<string> stack = new LinkedList<string>();
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

        //Add node button 
        private void addNode_Click(object sender, EventArgs e)
        {
            fromBox.Items.Clear();
            conBox1.Items.Clear();
            conBox2.Items.Clear();
            dirShow.Items.Clear();

            //Gets the id from user input
            string idInp = addID.Text;
            //Checks the field is not empty
            if (idInp != "")
            {
                //Checks the length is less than or equal to 3
                if (idInp.Length <= 3)
                {
                    string idAdd = idInp;
                    //Adds id as a node with using the addnode function
                    myGraph.AddNode(idAdd);
                    addID.Text = "";
                    //Success message
                    errorM1.Text = "Node added!";
                    errorM1.ForeColor = Color.Green;

                }
                //Error message
                else
                {
                    errorM1.Text = "Greater than 3";
                    errorM1.ForeColor = Color.Red;
                }
            }
            else
            {
                //Error message
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

        //Add direct flight button
        private void addDir_Click(object sender, EventArgs e)
        {
            //Checks the selected items are not empty
            if (conBox1.SelectedItem == null || conBox2.SelectedItem == null)
            {
                //Error message
                errorM2.Text = "Not a valid path";
                errorM2.ForeColor = Color.Red;
            }
            else
            {
                //Get to and from destinations from selection box
                string from = Convert.ToString(conBox1.SelectedItem);
                string to = Convert.ToString(conBox2.SelectedItem);
                fromBox.Items.Clear();
                conBox1.Items.Clear();
                conBox2.Items.Clear();
                dirShow.Items.Clear();
                //Checks from is not the same as to
                if (from != to)
                {
                    //Adds edge via the add edge function of graph
                    myGraph.AddEdge(from, to);
                    //Success message
                    errorM2.Text = "Direct flight added!";
                    errorM2.ForeColor = Color.Green;
                }
                else
                {
                    //Error message
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

        //Remove a direct flight button
        private void delFlight_Click(object sender, EventArgs e)
        {
            //Ensures there is a valid selected item
            if(dirShow.SelectedItem != null)
            {
                //Since the direct flight box appears with a --> we split this into 3 parts and pass the two id's
                string s = Convert.ToString(dirShow.SelectedItem);
                string[] Splitter = s.Split(' ');
                string from = Splitter[0];
                string to = Splitter[2];

                fromBox.Items.Clear();
                conBox1.Items.Clear();
                conBox2.Items.Clear();
                dirShow.Items.Clear();
                //Using these split id's run with delEdge function of graph
                myGraph.delEdge(from, to);
                //Success message
                errorM3.Text = "Flight successfully deleted.";
                errorM3.ForeColor = Color.Green;

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
            else
            {
                errorM3.Text = "No flight to selected";
                errorM3.ForeColor = Color.Red;
            }

        }

        //This searches for either direct, connecting or both flights from a airport
        private void Search_Click(object sender, EventArgs e)
        {
            //Checks there is a valid selected item
            if (fromBox.SelectedItem != null)
            {
                dfsBox.Items.Clear();
                //Create an empty visited list to pass to functions
                visited = new LinkedList<string>();
                string f = Convert.ToString(fromBox.SelectedItem);
                //If direct flights only
                if (directSel.Checked == true)
                {
                    //Calls the directF function of graph
                    string dFlights = myGraph.DirectF(f);
                    //Checks direct flights arent none
                    if (dFlights.Length != 0)
                    {
                        //Adds this to list box
                        string path = "Direct flights: " + dFlights;
                        dfsBox.Items.Add(path);
                    }
                    else
                    {
                        //Error message for no direct flights
                        dfsBox.Items.Add("No direct flights available");
                    }
                }
                //Connecting flights only
                else if (conSel.Checked == true)
                {
                    //Gets the direct flights using directf
                    string dFlights = myGraph.DirectF(f);

                    //Then gets all nodes from the depth first search function of graph
                    myGraph.DFS(f, ref stack, ref visited);

                    string[] p = dFlights.Split(' ');
                    //Loops through the p list of direct flights
                    foreach (string v in p)
                    {
                        //Convert the direct flights to string
                        string x = Convert.ToString(v);
                        if (x != " ")
                        {
                            //Remove direct flights from the dfs returned visited list
                            visited.Remove(x);
                        }

                    }
                    //remove starting node from the DFS visited list
                    visited.Remove(f);
                    string option = "Connected flights:";
                    dfsBox.Items.Add(option);
                    //Appends the connecting flights to the listbox
                    foreach (string v in visited)
                    {
                        dfsBox.Items.Add(v);
                    }

                }
                //Both direct and connecting flights
                else if (bothSel.Checked == true)
                {
                    //Runs the depth first search
                    myGraph.DFS(f, ref stack, ref visited);
                    //Removes the starting node from the list
                    visited.Remove(f);
                    string option = "Both connected and direct flights:";
                    dfsBox.Items.Add(option);
                    //Loops and appends the items in the visited list
                    foreach (string v in visited)
                    {
                        dfsBox.Items.Add(v);
                    }
                }
                else
                {
                    //Error message
                    errorM4.Text = "Please select an option.";
                    errorM4.ForeColor = Color.Red;
                }
            }
            else
            {
                //Error message
                errorM4.Text = "Please select a airport";
                errorM4.ForeColor = Color.Red;
            }
        }
    }
}
