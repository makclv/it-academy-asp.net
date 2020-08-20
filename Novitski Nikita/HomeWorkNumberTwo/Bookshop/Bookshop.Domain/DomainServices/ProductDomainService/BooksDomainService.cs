using Bookshop.Domain.DomainServices.ProductDomainService.ProductInterfaces;
using Bookshop.Domain.Models.Entities;
using Bookshop.Domain.Repositories;
using System.Collections.Generic;

namespace Bookshop.Domain.DomainServices.ProductDomainService
{
    public class BooksDomainService : IBooksDomainService
    {
        private readonly IProductRepository productRepository;
        public BooksDomainService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public List<Book> GetAllBooks()
        {
            return productRepository.GetAllBooks();
        }

        public List<Book> GetTopFiveBooks()
        {
            return productRepository.GetTopBooks(5);
        }
    }
}