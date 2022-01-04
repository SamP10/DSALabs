using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
    class Employee
    {
        //Initialize all employee vairables
        private string id;
        private string name;
        private bool availability;

        //Instance constructor
        public Employee(string id, string name, bool availability)
        {
            ID = id;
            Name = name;
            Availability = availability;
        }

        //Getters and setters
        public string ID
        {
            get { return this.id; }
            set { id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { name = value; }
        }

        public bool Availability
        {
            get { return this.availability; }
            set { availability = value; }
        }
    }
}
