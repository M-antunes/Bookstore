using Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Services
{
    public class BookService
    {
        private List<Book> _books = new List<Book>
        {
        new Book(1, "Bible", 900, null, null, null, null, new Category(1, "Holly")),
        new Book(2, "Paradise Lost", 700, null, null, null, null, new Category(2, "Fiction")),
        new Book(3, "The Naked Communist", 1000, null, null, null, null, new Category(3, "History")),
        new Book(4, "Koran", 850, null, null, null, null, new Category(1, "Holly"))
        };

    public List<Book> Books
        {
            get { return _books; }
            set { _books = value; }
        }
              
        public IEnumerable<Book> Get(string name, string category)
        {
            var response = Books;
            if (category != "" && category != null)
            {
                response = response.Where(x => x.Category.Name.ToLower() == category.ToLower()).ToList();
            }
            if (name != "" && name != null)
            {
                response = response.Where(x => x.Name.ToLower() == name.ToLower()).ToList();
            }
            return response;
        }
        public void Create(Book book)
        {
            Books.Add(book);
        }
        public void Delete(int id)
        {
            var bookRemove = Books.FindIndex(x => x.Id == id);
            Books.RemoveAt(bookRemove);
        }
        public Book GetById(int id)
        {
            return Books.Find(x => x.Id == id);
        }

        public void Edit(Book book)
        {
            
            var index = Books.FindIndex(x => x.Id == book.Id);
            Books[index] = new Book(book.Id, book.Name, book.NumberOfPages, book.Summary, 
            book.Author, book.Editor, book.Edition, book.Category);
        }
    }
}
