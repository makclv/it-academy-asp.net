using ClassLibrary1.Services.Interfaces;
using Domain.Entites;
using Domain.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ClassLibrary1.Services
{
    public class SityDomainService : ISityDomainService
    {
        private readonly ISityRepository sityRepository;

        public SityDomainService (ISityRepository sityRepository)
        {
            this.sityRepository = sityRepository;
        }
        public SelectList GetAllSities()
        {
            List<Sity> sities = sityRepository.GetAll();
            var listItems = new SelectList(sities, "SityId", "SityName");
            return listItems;
        }
    }
}
