using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[10];
            students[0] = new Student("Sam", 122, 23);
            students[1] = new Student("Luke", 123, 18);
            students[2] = new Student("Jed", 124, 26);
            students[3] = new Student("Adele", 125, 22);
            students[4] = new Student("Harry", 126, 24);
            students[5] = new Student("Billy", 127, 20);
            students[6] = new Student("Ellie", 128, 19);
            students[7] = new Student("Milo", 129, 18);
            students[8] = new Student("Hannah", 130, 34);
            students[9] = new Student("Graham", 131, 22);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(students[i].GetInfo());
            }
            Console.ReadKey();
        }
    }
}
