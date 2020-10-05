using HW4.Client.Models.ViewModels;
using HW4.Domain.Models;

namespace HW4.Client.Util
{
    public interface IMapper
    {
        User CreateUserViewModelMapping(CreateUserViewModel user);
        AllUsersViewModel AllUsersViewModelMapping(User user);
        EditUserViewModel EditUserViewModelMapping(User user);
        User EditUserViewModelMappingToUser(EditUserViewModel tempUser, User user);
        DeleteUserViewModel DeleteUserViewModelMapping(User user);
    }
}
