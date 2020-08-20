using DomainLogics.DomainServices.Interface;
using DomainLogics.Models;
using DomainLogics.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogics.DomainServices
{
    public class BookDomainService : IBookDomainService
    {
        
        private readonly IBookRepository bookRepository;
        public BookDomainService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public List<Book> AllBooks()
        {
            return bookRepository.AllBooks();
        }

        public List<Book> FiveMostPopularBooks()
        {
           return bookRepository.GetMostPopular();
        }
    }
}
