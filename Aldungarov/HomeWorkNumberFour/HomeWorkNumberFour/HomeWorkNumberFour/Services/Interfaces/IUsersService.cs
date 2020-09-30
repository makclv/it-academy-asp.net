using HomeWorkNumberFour.ViewModels;
using System.Collections.Generic;

namespace HomeWorkNumberFour.Services.Interfaces
{
    public interface IUsersService
    {
        List<UserViewModel> GetUsersList();

        UserViewModel GetUserById(int id);
        
        void AddUser(UserViewModel userViewModel);

        void UpdateUser(UserViewModel userViewModel);

        void DeleteUser(int id);
    }
}
