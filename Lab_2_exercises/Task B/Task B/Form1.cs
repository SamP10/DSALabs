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

        private void add_Click(object sender, EventArgs e)
        {
            if(Queue.isFull() == false)
            {
                
                string name = nameAdd.Text;
                if (name == "")
                {
                    errorLabel.Text = "Please specify a customer name";
                    errorLabel.ForeColor = Color.Red;
                }
                else
                {
                    Queue.Enqueue(name);
                    nameAdd.Text = "";
                    string list = Queue.getQueue();
                    displayBox.Text = list;
                    totQue.Text = Queue.Length();
                    errorLabel.Text = "Customer added!";
                    errorLabel.ForeColor = Color.AntiqueWhite;
                }
            }
            else
            {
                errorLabel.ForeColor = Color.Red;
                errorLabel.Text = "Queue is full";
                
            }
            
            


        }

        private void displayBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (Queue.isEmpty() == false)
            {
             
                    Queue.Dequeue();
                    string list = Queue.getQueue();
                    displayBox.Text = list;
                    totQue.Text = Queue.Length();
            }
            else
            {
                errorLabel.Text = "There are no customers in the queue!";
                errorLabel.ForeColor = Color.Red;
            }
        }

        private void reverseButton_Click(object sender, EventArgs e)
        {
            decimal k = fromVal.Value;
            int j = Convert.ToInt32(k);
            Queue.reverse(j);
            string list = Queue.getQueue();
            displayBox.Text = list;

        }
    }
}
