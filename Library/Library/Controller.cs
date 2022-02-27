using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Controller
    {

        //Exercise 1.2
        public List<Book> ReadBooks(string input)
        {
            List<Book> books = new List<Book>();
            int counter = 0;
            Book book = new Book();
            List<String> Authors = new List<string>();
            foreach (string line in System.IO.File.ReadLines(input))
            {
                if (line.StartsWith("Book"))
                {
                    book = new Book();
                    Authors = new List<string>();
                    continue;
                }
                if (line.StartsWith("Author"))
                {
                    string[] lineSplit = line.Split(":");
                    book.Authors.Add(lineSplit[1]);
                }
                if (line.StartsWith("Title"))
                {
                    string[] lineSplit = line.Split(":");
                    book.Title = lineSplit[1];
                }
                if (line.StartsWith("Publisher"))
                {
                    string[] lineSplit = line.Split(":");
                    book.Publisher = lineSplit[1];
                }
                if (line.StartsWith("Published"))
                {
                    string[] lineSplit = line.Split(":");
                    book.PublicationYear = Int32.Parse(lineSplit[1]);
                }
                if (line.StartsWith("NumberOfPages"))
                {
                    string[] lineSplit = line.Split(":");
                    book.NumberOfPages = Int32.Parse(lineSplit[1]);
                    books.Add(book);
                }
                System.Console.WriteLine(line);
                counter++;
            }
            return books;
        }

    }
}
