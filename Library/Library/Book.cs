using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book : LibraryItem
    {
        List<string> authors = new List<string>();
        int numberOfPages;
        public string _publisher;
        public int _publicationYear;

        public Book(string title, int isbn, List<string> authors, int numberOfPages, string _publisher, int _publicationYear)
        {
            this.title = title;
            this.isbn = isbn;
            this.authors = authors;
            this.numberOfPages = numberOfPages;
            this._publisher = _publisher;
            this._publicationYear = _publicationYear;
        }

        //Only to solve exercise 1.2
        public Book()
        {

        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string ISBN
        {
            get { return ISBN; }
            set { ISBN = value; }
        }
        public List<string> Authors
        {
            get { return authors; }
            set { authors = value; }
        }
        public int NumberOfPages
        {
            get { return numberOfPages; }
            set { numberOfPages = value; }
        }
        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }
        public int PublicationYear
        {
            get { return _publicationYear; }
            set { _publicationYear = value; }
        }
    }
}
