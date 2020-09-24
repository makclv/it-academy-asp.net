using ItAcademy.Hw.Users.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItAcademy.Hw.Users.Domain.DomainServices.Interfaces
{
   public interface ICityDomainService
    {
        List<City> GetCities();
        City GetCity(int id);
    }
}
