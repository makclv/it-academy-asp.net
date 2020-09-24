using ItAcademy.Hw.Users.Domain.Models;
using ItAcademy.Hw.Users.Domain.Repositories;
using ItAcademy.Hw.Users.Domain.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItAcademy.Hw.Users.Data.Repositories
{
   public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        private readonly IUnitOfWork unitOfWork;
        public CountryRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
