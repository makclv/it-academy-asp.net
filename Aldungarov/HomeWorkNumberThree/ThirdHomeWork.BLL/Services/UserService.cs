using System.Collections.Generic;
using ThirdHomeWork.BLL.Interfaces.Repository;
using ThirdHomeWork.BLL.Interfaces.Services;
using ThirdHomeWork.BLL.Models;

namespace ThirdHomeWork.BLL.Services
{
    public class UserService : IUserService
    {
        private IFakeRepository fakeRepository;

        public UserService(IFakeRepository fakeRepository)
        {
            this.fakeRepository = fakeRepository;
        }

        public void AddUser(User user)
        {
            fakeRepository.Add(user);
        }

        public void UpdateUser(User user)
        {
            fakeRepository.Update(user);
        }

        public void DeleteUser(int id)
        {
            fakeRepository.Delete(id);
        }

        public List<User> GetUsers()
        {
            return fakeRepository.GetUsers();
        }

        public User GetUserById(int id)
        {
            return fakeRepository.GetUserById(id);
        }
    }
}
