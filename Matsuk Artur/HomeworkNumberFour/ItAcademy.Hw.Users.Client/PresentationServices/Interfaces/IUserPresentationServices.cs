using ItAcademy.Hw.Users.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItAcademy.Hw.Users.Client.PresentationServices.Interfaces
{
   public interface IUserPresentationServices
    {
        void ChangeUser(UserView user);
    }
}
