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
            this.userRepository = userRepository;
            this.unitOfWork = unitOfWork;
        }

        public List<User> GetUserByLastName(string name)
        {
            return userRepository.GetUserByLastName(name);
        }

        public void AddUser (User user)
        {
            userRepository.Create(user);
            unitOfWork.SaveChanges();
        }
    }
}
