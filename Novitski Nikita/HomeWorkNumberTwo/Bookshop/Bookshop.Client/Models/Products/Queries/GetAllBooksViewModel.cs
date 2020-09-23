using Bookshop.Domain.Models.Entities;
using System.Collections.Generic;

namespace Bookshop.Client.Models.Products.Queries
{
    public class GetAllBooksViewModel
    {
        public List<Book> Books { get; set; }
    }
}