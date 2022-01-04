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
        nameQueue Queue = new nameQueue();
        public Form1()
        {
            InitializeComponent();
        }

        private void nameAdd_TextChanged(object sender, EventArgs e)
        {

        }

        //Once clicked proceeds to attempt to add instance of object.
        private void add_Click(object sender, EventArgs e)
        {
            //Checks if the queue is full
            if(Queue.isFull() == false)
            {
                //Grabs the name variable from user entry into nameAdd field.
                string name = nameAdd.Text;
                //Checks if name is empty or not
                if (name == "")
                {
                    //Throws error
                    errorLabel.Text = "Please specify a customer name";
                    errorLabel.ForeColor = Color.Red;
                }
                else
                {
                    //Add the name to the object calling the enqueue function.
                    Queue.Enqueue(name);
                    nameAdd.Text = "";
                    //Adds the queue to a list to display all the variables.
                    string list = Queue.getQueue();
                    displayBox.Text = list;
                    //Returns the length of the queue.
                    totQue.Text = Queue.Length();
                    //Prints a success message
                    errorLabel.Text = "Customer added!";
                    errorLabel.ForeColor = Color.AntiqueWhite;
                }
            }
            else
            {
                //Returns error if queue is full.
                errorLabel.ForeColor = Color.Red;
                errorLabel.Text = "Queue is full";
                
            }
            
            


        }

        private void displayBox_TextChanged(object sender, EventArgs e)
        {

        }

        //Removes the selected item from the list
        private void remove_Click(object sender, EventArgs e)
        {
            //Checks if queue is emtpy
            if (Queue.isEmpty() == false)
            {
             
                //Calls the dequeue function
                    Queue.Dequeue();
                //Gets queue 
                    string list = Queue.getQueue();
                    displayBox.Text = list;
                    totQue.Text = Queue.Length();
            }
            else
            {
                //Error message.
                errorLabel.Text = "There are no customers in the queue!";
                errorLabel.ForeColor = Color.Red;
            }
        }

        //Reverses the queue from a given position
        private void reverseButton_Click(object sender, EventArgs e)
        {
            //Gets the value of position.
            decimal k = fromVal.Value;
            int j = Convert.ToInt32(k);
            //Calls the reverse function
            Queue.reverse(j);
            string list = Queue.getQueue();
            displayBox.Text = list;

        }
    }
}
