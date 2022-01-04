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
        //Creates a new dictionary of instance Employee with type string
        //This stores all employee instances in the dictionary
        Dictionary<string, Employee> employeeDict = new Dictionary<string, Employee>();
        public Form1()
        {
            InitializeComponent();
            //Create new object instances of employee with variables of id, name & availability 
            Employee employee1 = new Employee("213242", "Sam", false);
            Employee employee2 = new Employee("213253", "Jordan", true);
            Employee employee3 = new Employee("12452", "Jess", true);

            //Stores the employee at the ID within the dictionary
            employeeDict[employee1.ID] = employee1;
            employeeDict[employee2.ID] = employee2;
            employeeDict[employee3.ID] = employee3;
        }

        //Click to view a selected employee by id and return their details
        private void view_Click(object sender, EventArgs e)
        {
            //Resets the display field
            detailsDisplay.Text = "";
            //Converts the selected ID of listbox to a string
            string emp = Convert.ToString(listBox1.SelectedItem);
            //Checks if the listbox item is not empty
            if (Convert.ToString(listBox1.SelectedItem) != "")
            {
                //Retrieves the instance of the object assosciated with the entry within the dictionary
                Employee E = employeeDict[emp];

                //Checks to see whether the availability is true or false to see if employee is available.
                if (E.Availability == false)
                {
                    //Retrieves and displays the variables of the employee object.
                    detailsDisplay.Text = "Name: " + E.Name + " ID: " + E.ID + " Available? No";
                }
                if (E.Availability == true)
                {
                    detailsDisplay.Text = "Name: " + E.Name + " ID: " + E.ID + " Available? No";
                }
            }
            //Clears the selection within the listbox
            listBox1.Items.Clear();
            //Retrieves all the employees from the dictionary and outputs them in the listbox
            Dictionary<string, Employee>.ValueCollection id = employeeDict.Values;
            foreach (Employee i in id)
            {
                listBox1.Items.Add(i.ID);
            }
        }

        //Delete an employee button to delete a selected employee fromt he dictionary
        private void delete_Click(object sender, EventArgs e)
        {
            //Takes employee from the selected listbox item converting it to string
            string emp = Convert.ToString(listBox1.SelectedItem);
            //Uses the remove function to remove the employee from a dictionary
            employeeDict.Remove(emp);
            listBox1.Items.Clear();
            Dictionary<string, Employee>.ValueCollection ids = employeeDict.Values;
            foreach (Employee i in ids)
            {
                listBox1.Items.Add(i.ID);
            }
            detailsDisplay.Text = "";
            //Throws error when successfully deleting employee
            errorLabel2.Text = "Employee Deleted successfully";
            errorLabel2.ForeColor = Color.Green;
        }

        //Add button which adds a employee.
        private void add_Click(object sender, EventArgs e)
        {
            //Gets the name and id variables from the input fields.
            string name = nameText.Text;
            string id = idText.Text;
            //Checks if the user has checked the availability throws error if not.
            if (availYes.Checked==true)
            {
                //Sets the availability if true to true
                bool available = true;
                //Checks the form fields aren't empty, throws error if either id or name are blank
                if (name == "" || id == "")
                {
                    //Error label message
                    errorLabel.Text = "Please ensure all fields are filled";
                    errorLabel.ForeColor = Color.Red;
                }
                else
                {
                    //Creates a new instance of object employee with the variables.
                    Employee employee = new Employee(id, name, available);
                    //Adds this employee to the dictionary
                    employeeDict[id] = employee;
                    //Clears input fields
                    nameText.Text = "";
                    idText.Text = "";
                    availYes.Checked = false;
                    listBox1.Items.Clear();
                    //Adds employees to the listbox and success message displayed
                    Dictionary<string, Employee>.ValueCollection ids = employeeDict.Values;
                    foreach (Employee i in ids)
                    {
                        listBox1.Items.Add(i.ID);
                        errorLabel.Text = "Employee Added";
                        errorLabel.ForeColor = Color.Green;
                    }
                }
            }
            if (availNo.Checked == true)
            {
                //If availability is false set availability is false
                bool available = false;
                //See above for functionality of code.
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
                    errorLabel.Text = "Employee Added";
                    errorLabel.ForeColor = Color.Green;
                }
            }     
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //Button displays all the users into a listbox
        private void show_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            //Gets all employees and displays them in the listbox
            Dictionary<string, Employee>.ValueCollection id = employeeDict.Values;
            foreach (Employee i in id)
            {
                listBox1.Items.Add(i.ID);
            }
        }
    }
}
