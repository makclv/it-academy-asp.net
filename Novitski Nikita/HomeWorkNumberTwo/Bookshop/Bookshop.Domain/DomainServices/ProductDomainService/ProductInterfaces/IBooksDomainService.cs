using Bookshop.Domain.Models.Entities;
using System.Collections.Generic;

namespace Bookshop.Domain.DomainServices.ProductDomainService.ProductInterfaces
{
    public interface IBooksDomainService
    {
        List<Book> GetAllBooks();
        List<Book> GetTopFiveBooks();
    }
}
