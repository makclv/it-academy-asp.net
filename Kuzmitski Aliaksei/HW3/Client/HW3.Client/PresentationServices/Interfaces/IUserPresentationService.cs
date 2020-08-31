using HW3.Client.Models;
using HW3.Domain.Models;
using System;
using System.Collections.Generic;

namespace HW3.Client.PresentationServices.Interfaces
{
    public interface IUserPresentationService
    {
        void AddUser(CreateUserViewModel user);
        List<AllUsersViewModel> AllUsers();
        EditUserViewModel GetEditUserView(Guid id);
        void EditUser(EditUserViewModel user);
        DeleteUserViewModel GetDeleteUserView(Guid id);
        void DeleteUser(Guid userId);

        List<Country> AllCountries();
        List<City> AllCities();

    }
}
