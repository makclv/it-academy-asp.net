using ClassLibrary2;
using ClassLibrary2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.DomainServices
{
    public class BookDomainService : IBookDomainService
    {
        private readonly IBookRepository bookRepository;
        public BookDomainService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public BookBll Get5MostPopular()
        {
            BookData bookData = bookRepository.Show5MostPopular();
            // Mapper
            throw new NotImplementedException();
        }
    }
}
