using System.Collections.Generic;
using ThirdHomeWork.BLL.Models;

namespace ThirdHomeWork.BLL.Interfaces.Repository
{
    public interface IFakeRepository
    {
		List<User> GetUsers();



		User GetUserById(int id);

		void Add(User user);

		void Update(User user);

		void Delete(int id);
	}
}
