//Model creates an interface that can be iterated through

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}
