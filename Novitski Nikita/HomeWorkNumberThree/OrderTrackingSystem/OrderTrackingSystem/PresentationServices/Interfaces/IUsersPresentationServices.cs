using OrderTrackingSystem.Domain.Models;
using OrderTrackingSystem.ViewModels.Users;
using System.Collections.Generic;

namespace OrderTrackingSystem.PresentationServices.Interfaces
{
    public interface IUsersPresentationServices
    {
        List<GetUsersViewModel> GetUsers();
        List<City> GetCitys();
        List<Country> GetCountrys();
        void AddUser(CreateUsersViewModel user);
        EditUsersViewModel GetEditUsersVm(int id);
        void EditUser(EditUsersViewModel userVm);
        DeleteUsersViewModel GetDeleteUsersVm(int id);
        void DeleteUser(int userId);
        CreateUsersViewModel GetCreateUsersVm();
        CreateUsersViewModel GetCreateUsersVm(CreateUsersViewModel usersVm);
        EditUsersViewModel GetEditUsersVm(EditUsersViewModel userVm);

    }
}
