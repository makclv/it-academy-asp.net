using HomeWorkNumberFour.BLL.Interfaces.Repository.Base;
using HomeWorkNumberFour.BLL.Models;

namespace HomeWorkNumberFour.BLL.Interfaces.Repository
{
	public interface IUserRepository : IBaseRepository<User>
	{
		//List<User> GetUsers();
		//
		//void Add(User user);
		//
		//void Update(User user);
		//
		//void Delete(int id);

		User GetUserById(int id);
	}
}
