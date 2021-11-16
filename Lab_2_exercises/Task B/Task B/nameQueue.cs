using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
    class nameQueue
    {
        private readonly int maxsize = 20;
        private string[] customers;
        private int head = 0;
        private int tail = 0;
        private int numCust;

        public nameQueue()
        {
            customers = new string[maxsize];
        }


        public void Enqueue(string value)
        {
            numCust++;
            customers[tail] = value;
            if (++tail == maxsize)
            {
                tail = 0;
            }
        }

        public string Dequeue()
        {
            string headCust;
            numCust--;
            headCust = customers[head];
            customers[head] = "";
            head++;
            if (head == maxsize)
            {
                head = 0;
            }
            return headCust;
        }

        public bool isEmpty()
        {
            return numCust == 0;
        }

        public bool isFull()
        {
            return numCust == maxsize;
        }

        public string getQueue()
        {
            string names = string.Join(" ", customers);
            return names;
        }

        public string Length()
        {
            
            return Convert.ToString(numCust);
        }

        public string reverse(int k)
        {
            Array.Reverse(customers, 0, k);
            string names = string.Join(" ", customers);
            return names;
        }
    }
}
