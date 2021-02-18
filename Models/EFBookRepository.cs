//Model brings all other models for Database

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookDbContext _context;

        //Contstructor
        public EFBookRepository (BookDbContext context)
        {
            _context = context;
        }

        public IQueryable<Book> Books => _context.Books;
    }
}
