using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using BookStore.Models;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id = 1, Title = "MVC", Author = "KMG"},
                new BookModel(){Id = 2, Title = "Dot Net Core", Author = "Laddu"},
                new BookModel(){Id = 3, Title = "PHP", Author = "Rasmus"},
                new BookModel(){Id = 4, Title = "PHP", Author = "Larry"},
                new BookModel(){Id = 5, Title = "C", Author = "Kanitkar"},
            };
        }
    }
}
