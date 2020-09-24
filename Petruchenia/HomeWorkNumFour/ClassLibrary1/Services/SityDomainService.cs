using ClassLibrary1.Services.Interfaces;
using Domain.Entites;
using Domain.Repository;
using System.Collections.Generic;
namespace ClassLibrary1.Services
{
    public class SityDomainService : ISityDomainService
    {
        private readonly ISityRepository sityRepository;

        public SityDomainService (ISityRepository sityRepository)
        {
            this.sityRepository = sityRepository;
        }
        public List<User> GetUsersBySity(string sity)
        {
            return sityRepository.GetUsersBySity(sity);
        }
    }
}
