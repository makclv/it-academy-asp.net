using HW4.Client.Models.ViewModels;
using HW4.Domain.Models;
using System.Collections.Generic;

namespace HW4.Client.PresentationServices.Interfaces
{
    public interface IUserPresentationService
    {
        void AddUser(CreateUserViewModel user);
        List<AllUsersViewModel> AllUsers();
        EditUserViewModel GetEditUserViewModel(int id);
        EditUserViewModel GetEditUserViewModel(EditUserViewModel user);
        void EditUser(EditUserViewModel user);
        CreateUserViewModel CreateUserViewModel();
        CreateUserViewModel GetCreatedUserViewModel(CreateUserViewModel user);
        DeleteUserViewModel GetDeleteUserView(int id);
        void DeleteUser(int userId);
        List<Country> AllCountries();
        List<City> AllCities();
    }
}
