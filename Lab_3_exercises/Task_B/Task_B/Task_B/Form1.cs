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
        Dictionary<string, Employee> employeeDict = new Dictionary<string, Employee>();
        public Form1()
        {
            InitializeComponent();
            Employee employee1 = new Employee("213242", "Sam", false);
            Employee employee2 = new Employee("213253", "Jordan", true);
            Employee employee3 = new Employee("12452", "Jess", true);
            employeeDict[employee1.ID] = employee1;
            employeeDict[employee2.ID] = employee2;
            employeeDict[employee3.ID] = employee3;
        }

        private void view_Click(object sender, EventArgs e)
        {
            detailsDisplay.Text = "";
            string emp = Convert.ToString(listBox1.SelectedItem);
            if (Convert.ToString(listBox1.SelectedItem) != "")
            {
                Employee E = employeeDict[emp];

                if (E.Availability == false)
                {
                    detailsDisplay.Text = "Name: " + E.Name + " ID: " + E.ID + " Available? No";
                }
                if (E.Availability == true)
                {
                    detailsDisplay.Text = "Name: " + E.Name + " ID: " + E.ID + " Available? No";
                }
            }
            listBox1.Items.Clear();
            Dictionary<string, Employee>.ValueCollection id = employeeDict.Values;
            foreach (Employee i in id)
            {
                listBox1.Items.Add(i.ID);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string emp = Convert.ToString(listBox1.SelectedItem);
            employeeDict.Remove(emp);
            listBox1.Items.Clear();
            Dictionary<string, Employee>.ValueCollection ids = employeeDict.Values;
            foreach (Employee i in ids)
            {
                listBox1.Items.Add(i.ID);
            }
            detailsDisplay.Text = "";
            errorLabel2.Text = "Employee Deleted successfully";
            errorLabel2.ForeColor = Color.Green;
        }

        private void add_Click(object sender, EventArgs e)
        {
            string name = nameText.Text;
            string id = idText.Text;
            if (availYes.Checked==true)
            {
                bool available = true;
                if (name == "" || id == "")
                {
                    errorLabel.Text = "Please ensure all fields are filled";
                    errorLabel.ForeColor = Color.Red;
                }
                else
                {
                    Employee employee = new Employee(id, name, available);
                    employeeDict[id] = employee;
                    nameText.Text = "";
                    idText.Text = "";
                    availYes.Checked = false;
                    listBox1.Items.Clear();
                    Dictionary<string, Employee>.ValueCollection ids = employeeDict.Values;
                    foreach (Employee i in ids)
                    {
                        listBox1.Items.Add(i.ID);
                    }
                }
            }
            if (availNo.Checked == true)
            {
                bool available = false;
                if (name == "" || id == "")
                {
                    errorLabel.Text = "Please ensure all fields are filled";
                    errorLabel.ForeColor = Color.Red;
                }
                else
                {
                    Employee employee = new Employee(id, name, available);
                    employeeDict[id] = employee;
                    nameText.Text = "";
                    idText.Text = "";
                    availNo.Checked = false;
                    listBox1.Items.Clear();
                    Dictionary<string, Employee>.ValueCollection ids = employeeDict.Values;
                    foreach (Employee i in ids)
                    {
                        listBox1.Items.Add(i.ID);
                    }
                }
            }
            if(availNo.Checked == false && availYes.Checked == false)
            {
                errorLabel.Text = "Please check the availability";
                errorLabel.ForeColor = Color.Red;
            }
            
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void show_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Dictionary<string, Employee>.ValueCollection id = employeeDict.Values;
            foreach (Employee i in id)
            {
                listBox1.Items.Add(i.ID);
            }
        }
    }
}
