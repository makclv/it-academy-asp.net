using ClassLibrary1.Services.Interfaces;
using Domain.Entites;
using Domain.Repository;
using Domain.UnitOfWork;
using System.Collections.Generic;

namespace ClassLibrary1.Services
{
    public class UserDomainService : IUserDomainService
    {
        private readonly IUserRepository userRepository;
        private readonly IUnitOfWork unitOfWork;

        public UserDomainService(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.userRepository = userRepository;
        }

        public List<User> GetUserByLastName(string name)
        {
            return userRepository.GetUserByLastName(name);
        }

        public void Create(User user)
        {
            userRepository.CreateUser(user);
        }

        public User GetById(int Id)
        {
            return userRepository.GetById(Id);
        }

        public void EditUser(User user)
        {
            userRepository.EditUser(user);
        }

        public List<User> GetAll()
        {
            return userRepository.GetAll();
        }

        public void DeleteUser(int Id)
        {
            userRepository.Delete(
                userRepository.GetById(Id)
                );

        }
    }
}
