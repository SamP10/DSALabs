using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
{
    class Student
    {
        private string name;
        private int id;
        private int age;

        public Student(string name, int id, int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }

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

        public string GetInfo()
        {
            string summary = "Name: " + name + " ID: " + id + " Age: " + age;
            return summary;
        }
    }
}
