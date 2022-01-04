using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
    class nameQueue
    {
        //Variable initializers for an object instance
        private readonly int maxsize = 20;
        private string[] customers;
        private int head = 0;
        private int tail = 0;
        private int numCust;

        //Getters and setters of class instance.
        public nameQueue()
        {
            //Initializes a string of customers set to the maxsize
            customers = new string[maxsize];
        }

        //Enqueues a name too the queue.
        public void Enqueue(string value)
        {
            //Increases the variable to count the total in queue
            numCust++;
            //Adds value of to the tail position of the customer
            customers[tail] = value;
            //Adds one to tail and checks if the tail is max size
            if (++tail == maxsize)
            {
                //If tails is max size go back to start of queue
                tail = 0;
            }
        }

        //The dequeue function to remove a name from the queue
        public string Dequeue()
        {
            
            string headCust;
            //Removes count from the number of customers
            numCust--;
            //Assigns variable headCust to the head of the queue
            headCust = customers[head];
            //Clears the head of the queue to a blank entry
            customers[head] = "";

            //Increments the head by one
            head++;
            //Checks if head is maxsize, if so go back to start of the queue
            if (head == maxsize)
            {
                head = 0;
            }
            return headCust;
        }

        //Checks to see if the queue is empty for error catching
        public bool isEmpty()
        {
            return numCust == 0;
        }

        //Checks to see if the queue is full to throw error
        public bool isFull()
        {
            return numCust == maxsize;
        }

        //Function to return the queue for displaying
        public string getQueue()
        {
            //Joins all the entries in customers to on estring then outputs that string
            string names = string.Join(" ", customers);
            return names;
        }

        //Function returns size of queue.
        public string Length()
        {
           //Returns the value of numCust int variable
            return Convert.ToString(numCust);
        }

        //Function to reverse the order from a given point
        public string reverse(int k)
        {
            //Using the array.Reverse tool to start from position index 0 and to a given user point k
            Array.Reverse(customers, 0, k);
            //Returns the queue.
            string names = string.Join(" ", customers);
            return names;
        }
    }
}
