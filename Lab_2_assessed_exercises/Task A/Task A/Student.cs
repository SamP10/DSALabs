using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
{
    class Student
    {
        //Initialises the variables of the student object.
        private string name;
        private int id;
        private int age;

        //sets the infomation of the student class for name, id and age.
        public Student(string name, int id, int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }

        //Getters and setters of the object variables
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //A function to return infomation of an isntance of an object.
        public string GetInfo()
        {
            string summary = "Name: " + name + " ID: " + id + " Age: " + age;
            return summary;
        }
    }
}
