using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSite.Models
{
    public class BookRepository
    {
        public interface IBookRepository
        {
            IQueryable<Book> Books { get; }
        }
    }
}
