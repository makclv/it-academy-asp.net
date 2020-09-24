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
   public class CityRepository : BaseRepository<City>, ICityRepository
    {
        private readonly IUnitOfWork unitOfWork;
        public CityRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
