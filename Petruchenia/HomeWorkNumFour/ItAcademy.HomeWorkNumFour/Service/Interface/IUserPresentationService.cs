using ItAcademy.HomeWorkNumFour.Models.CRUD;
using ItAcademy.HomeWorkNumFour.Models.EntityFramework;
using System.Collections.Generic;

namespace ItAcademy.HomeWorkNumFour.Service.Interface
{
    public interface IUserPresentationService
    {
        List<UserViewModel> GetUserByLastName(string name);
        CreateUser AddToView();
        void AddToDb(CreateUser createUser);
        EditUser EditToView(int id);
        void EditToDb(EditUser editUser);
        List<UserViewModel> GetUsersViewList();
        DeleteUser GetUserByIdToDelete(int id);
        void DeleteUserById(int id);
    }
}
