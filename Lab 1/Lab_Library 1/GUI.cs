using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Library_1
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            Book[] books = new Book[20];

            books[0] = new Book("Moby Dick");

            books[0].Author = new Person("Herman Melville");

            books[0].Author.Age = 53;

            books[0].ISBN = 123456789;

            books[1] = new Book("The Creeping");

            books[1].Author = new Person("Luke D");

            books[1].Author.Age = 43;

            books[1].ISBN = 123456781;

            books[2] = new Book("To Kill A Mockingbird");

            books[2].Author = new Person("Harper Lee");

            books[2].Author.Age = 90;

            books[2].ISBN = 123456782;

            string author = authorSearch.Text;
            string title = titleSearch.Text;

            for(int i = 0; i < 3; i++)
            {
                if (books[i].Title == title)
                {
                    resultsText.Text = books[i].GetSummary();
                }
                else if(books[i].Author.Name == author)
                {
                    resultsText.Text = books[i].GetSummary();
                }
                
            }

        }

        private void addBook_Click(object sender, EventArgs e)
        {
            
        }
    }
}
