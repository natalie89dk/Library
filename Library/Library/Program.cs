using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            Console.WriteLine(System.Environment.NewLine + "Printing input from Exercise 1.2");
            controller.ReadBooks(@"C:\Natalie\CodeChallenge\Library\Library\Input.txt");

            Console.WriteLine(System.Environment.NewLine + "Generating test data!");
            Data.GenerateTestData();

            Console.WriteLine(System.Environment.NewLine + "Printing test data!");
            List<LibraryItem> testData = Data.GetTestData();
            foreach (LibraryItem item in testData) 
            {
                Console.WriteLine(item.title);
                Console.WriteLine(item.isbn);
            }
        }
    }
}
