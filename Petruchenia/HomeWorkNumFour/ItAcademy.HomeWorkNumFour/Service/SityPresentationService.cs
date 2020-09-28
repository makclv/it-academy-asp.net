using ClassLibrary1.Services.Interfaces;
using ItAcademy.HomeWorkNumFour.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ItAcademy.HomeWorkNumFour.Service
{
    public class SityPresentationService : ISityPresentationService
    {
        private readonly ISityDomainService sityDomainService;

        public SityPresentationService(ISityDomainService sityDomainService)
        {
            this.sityDomainService = sityDomainService;
        }

        public IEnumerable<SelectListItem> GetAllSities()
        {
            return (IEnumerable<SelectListItem>)sityDomainService.GetAllSities();
        }
    }

}