using BasicLibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicLibraryManagementSystem.Services
{
    public class BookServices
    {
        private static ICollection<Book> booksCollection;

        public BookServices()
        {
            booksCollection = new List<Book>();
        }

        private int GetNextId()
        {
            Book lastEntered = booksCollection.LastOrDefault();
            int lastId = lastEntered == null ? 0 : lastEntered.BookId;
            return lastId + 1;
        }
        
        public void BorrowBook(int id)
        {
            booksCollection.FirstOrDefault(e => e.BookId == id).Borrowed = true;
        }
        public IEnumerable<Book> GetAllBooks()
        {
            return booksCollection.Where(b=> b.Borrowed == false).ToList();
        }

        public Book GetBook(int id)
        {
            return booksCollection.FirstOrDefault(e => e.BookId == id);
        }

        public IEnumerable<Book> GetBook(string title)
        {
            return booksCollection.Where(e => e.Title.ToLower().Contains(title.ToLower()));
        }

        public void AddBook(Book book)
        {
            book.BookId = GetNextId();
            booksCollection.Add(book);
        }
    }
}
