using HomeWorkNumberFour.BLL.Interfaces.Repository;
using HomeWorkNumberFour.BLL.Models;
using HomeWorkNumberFour.BLL.UnitOfWork;
using HomeWorkNumberFour.ClientLayer.Context;
using System.Collections.Generic;
using System.Linq;

namespace HomeWorkNumberFour.ClientLayer.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DBContext _context = new DBContext();

        private IUnitOfWork _unitOfWork;

        public UserRepository(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Update(User user)
        {
            var changedItem = _context.Users
                .Where(x => x.Id == user.Id)
                .FirstOrDefault();

            changedItem.FirstName = user.FirstName;
            changedItem.LastName = user.LastName;
            changedItem.Title = user.Title;
            changedItem.Phone = user.Phone;
            changedItem.Email = user.Email;
            changedItem.Address.CountryName = user.Address.CountryName;
            changedItem.Address.CityName = user.Address.CityName;
            changedItem.Comments = user.Comments;

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Users.Remove(GetUserById(id));

            _context.SaveChanges();
        }

        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return _context.Users
                .Where(x => x.Id == id)
                .FirstOrDefault();
        }
    }
}
