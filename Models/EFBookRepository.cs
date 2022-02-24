using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BookSite.Models.BookRepository;

namespace BookSite.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookstoreContext context { get; set; }

        public EFBookRepository(BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Book> Books => context.Books;

    }
}
