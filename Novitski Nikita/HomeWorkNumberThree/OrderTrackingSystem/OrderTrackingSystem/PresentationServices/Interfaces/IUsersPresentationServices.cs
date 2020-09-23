using OrderTrackingSystem.Domain.Models;
using OrderTrackingSystem.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTrackingSystem.PresentationServices.Interfaces
{
    public interface IUsersPresentationServices
    {
        List<GetUsersViewModel> GetUsers();
        List<City> GetCitys();

        List<Country> GetCountrys();

        void AddUser(CreateUsersViewModel user);

        bool VerificationUserId(Guid id);
        EditUsersViewModel GetEditUsersVm(Guid id);
        void EditUser(EditUsersViewModel userVm);
        DeleteUsersViewModel GetDeleteUsersVm(Guid id);
        void DeleteUser(Guid userId);

    }
}
