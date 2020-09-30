using HomeWorkNumberFour.BLL.Interfaces.Repository;
using HomeWorkNumberFour.BLL.Interfaces.Services;
using HomeWorkNumberFour.BLL.Models;
using HomeWorkNumberFour.BLL.UnitOfWork;
using System.Collections.Generic;

namespace HomeWorkNumberFour.BLL.Services
{
    public class UserService : IUserService
    {
        private IUserRepository userRepository;
        private IUnitOfWork _unitOfWork;

        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            this.userRepository = userRepository;
            this._unitOfWork = unitOfWork;
        }

        public void AddUser(User user)
        {
            userRepository.Create(user);
            _unitOfWork.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            userRepository.AddOrUpdate(user);
        }

        public void DeleteUser(int id)
        {
            userRepository.Delete(GetUserById(id));
        }

        public List<User> GetUsers()
        {
            return userRepository.GetAll();
        }

        public User GetUserById(int id)
        {
            return userRepository.GetUserById(id);
        }
    }
}
