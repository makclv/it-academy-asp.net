using DomainLogics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogics.DomainServices.Interface
{
   public interface IBookDomainService
    {
        List<Book> FiveMostPopularBooks();

        List<Book> AllBooks();
    }
}
