using Domain.Entites;
using System.Collections.Generic;

namespace ClassLibrary1.Services.Interfaces
{
    public interface ISityDomainService : IBaseDomainService
    {
        List<User> GetUsersBySity(string sity);
    }
}
