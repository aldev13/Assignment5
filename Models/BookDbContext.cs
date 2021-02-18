//Model creates instance of Book Model for Database creation

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class BookDbContext : DbContext
    {
        public BookDbContext (DbContextOptions<BookDbContext> options) : base (options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
