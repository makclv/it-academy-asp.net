using HomeTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask.Repository
{
   public interface IUserRepository
    {
        List<User> GetAllUsers();

        List<User> Add(User user);

        void Delete(int id);

        List<User> Edit(User user);
    }
}
