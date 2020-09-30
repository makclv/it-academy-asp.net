using HomeTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask.Repository
{
    public interface ICityRepository
    {
        List<City> GetAllCity();
    }
}
