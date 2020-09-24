using ItAcademy.HomeWorkNumFour.Models.EntityFramework;
using System.Collections.Generic;

namespace ItAcademy.HomeWorkNumFour.Service.Interface
{
    public interface IUserPresentationService
    {
        List<UserViewModel> GetUserByLastName(string name);
    }
}
