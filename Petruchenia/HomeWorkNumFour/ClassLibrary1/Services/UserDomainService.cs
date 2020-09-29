using ClassLibrary1.Services.Interfaces;
using Domain.Entites;
using Domain.Repository;
using Domain.UnitOfWork;
using System.Collections.Generic;
using System.Linq;

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
            unitOfWork.SaveChanges();
        }

        public User GetById(int Id)
        {
            return userRepository.GetById(Id);
        }

        public void EditUser(User user)
        {
            userRepository.EditUser(user);
            unitOfWork.SaveChanges();
        }

        public List<User> GetAll()
        {
            return userRepository.GetAll();
        }

        public void DeleteUser(int Id)
        {
            userRepository
                .Delete(userRepository
                .GetById(Id));
            unitOfWork.SaveChanges();

        }

        public bool IsUniqueName(string FirstName, string LastName)
        {
            var users = userRepository.GetAll();
            foreach (var a in users)
            {
                if (a.FirstName == FirstName)
                {
                    if (a.LastName == LastName)
                    {
                        return false;
                    }
                }                        
            }

            return true;
        }

        public bool IsUniqueEmail(string email)
        {
            return !userRepository.GetAll().Any(c => c.Email == email);
        }

        public bool IsUniquePhone(string phone)
        {
            return !userRepository.GetAll().Any(c => c.Phone == phone);
        }
    }
}
