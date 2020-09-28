using Domain.Entites;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ClassLibrary1.Services.Interfaces
{
    public interface ICountryDomainService : IBaseDomainService
    {
        SelectList GetAllCountries();
    }
}
