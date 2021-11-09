using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Library_1
{
    class Book
    {
        private string title;
        private Person author;

        public Book(string title)
        {
            this.title = title;
        }

        public Book(string title, Person author)
        {
            this.title = title;
            this.author = author;
        }

        public Person Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string GetSummary()
        {
            string summary = "Title: " + title + "  Author: " + author.Name+"  Age: " + author.Age;
            return summary;
        }
    }
}
