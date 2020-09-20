using HomeWorkNumberFour.BLL.Models;
using System.Collections.Generic;

namespace HomeWorkNumberFour.BLL.Interfaces.Repository
{
	public interface IUserRepository
	{
		List<User> GetUsers();

		User GetUserById(int id);

		void Add(User user);

		void Update(User user);

		void Delete(int id);
	}
}
