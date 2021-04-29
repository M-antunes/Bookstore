using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class Book
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int NumberOfPages { get; set; }
        public string Summary { get; set; }
        public string Author { get; set; }
        public string Editor { get; set; }
        public string Edition { get; set; }
        public Category Category { get; set; }

        public Book(int id, string name, int numberOfPages, string summary, string author, string editor,
            string edition, Category category)
        {
            Id = id;
            Name = name;
            NumberOfPages = numberOfPages;
            Summary = summary;
            Author = author;
            Editor = editor;
            Edition = edition;
            Category = category;
        }
    }
}
