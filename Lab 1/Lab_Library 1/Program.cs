using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Library_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[3];

            books[0] = new Book("Moby Dick");

            books[0].Author = new Person("Herman Melville");

            books[0].Author.Age = 53;

            books[1] = new Book("The Creeping");

            books[1].Author = new Person("Luke D");

            books[1].Author.Age = 43;

            books[2] = new Book("To Kill A Mockingbird");

            books[2].Author = new Person("Harper Lee");

            books[2].Author.Age = 90;

            for (int i = 0; i<3; i++)
            {
                Console.WriteLine(books[i].GetSummary());

            }

            if (books[0].Title.CompareTo(books[1].Title) < 0)
            {
                Console.WriteLine("Title of book in position 0 precedes (alphabetically) the title of " + books[1].Title + " book in position 1");
            }
            else if (books[0].Title.CompareTo(books[1].Title) > 0)
            {
                Console.WriteLine("Title of book in position 1 precedes (alphabetically) the title of " + books[0].Title + " book in position 0");
            }
            else if (books[0].Title.CompareTo(books[1].Title) == 0)
            {
                Console.WriteLine("Title of book in position 1 is the same as the title of " + books[0].Title + " book in position 0");
            }
            Console.ReadKey();
        }
    }
}
