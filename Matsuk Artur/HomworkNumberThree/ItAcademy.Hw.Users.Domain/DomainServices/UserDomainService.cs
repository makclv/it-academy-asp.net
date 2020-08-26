using ItAcademy.Hw.Users.Data.Repositories.Interfaces;
using ItAcademy.Hw.Users.Domain.DomainServices.Interfaces;
using ItAcademy.Hw.Users.Domain.Infrastructure;
using ItAcademy.Hw.Users.Domain.Models;

using System.Collections.Generic;


namespace ItAcademy.Hw.Users.Domain.DomainServices
{
    public class UserDomainService : IUserDomainService
    {
        private readonly IUserRepository UserRep;
        public UserDomainService(IUserRepository UserRep)
        {
            this.UserRep = UserRep;
        }
        public void AddUser(User User)
        {
            UserRep.AddUser(Mapper.UserToUserData(User));
        }

        public void ChangeUser( User User)
        {
            UserRep.ChangeUser( Mapper.UserToUserData(User));
        }

        public void DeleteUser(int a)
        {
            UserRep.DeleteUser(a);
        }

        public List<User> GetUsers()
        {
            var UserDataList = UserRep.GetUsers();
            List<User> UserList= new List<User>();
            foreach(var a in UserDataList)
            {
                UserList.Add(Mapper.UserDataToUser(a));
            }
            return UserList;

        }

        public User FindUser(int a)
        {
            return Mapper.UserDataToUser(UserRep.FindUser(a));
        }


    }
}
