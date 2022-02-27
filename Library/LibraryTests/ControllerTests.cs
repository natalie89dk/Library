using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Tests
{
    [TestClass()]
    public class ControllerTests
    {
        [TestMethod()]
        public void ReadBooksTest()
        {
            // Arrange
            Controller controller = new Controller();

            // Act
            List<Book> books = controller.ReadBooks(@"C:\Natalie\CodeChallenge\Library\Library\Input.txt");

            // Assert
            Assert.AreEqual(2, books.Count());
        }

        [TestMethod()]
        public void ReadBooksTest2()
        {
            // Arrange
            Controller controller = new Controller();

            // Act
            List<Book> books = controller.ReadBooks(@"C:\Natalie\CodeChallenge\Library\Library\Input.txt");

            // Assert
            Assert.AreEqual(2, books[1].Authors.Count());
        }
    }
}