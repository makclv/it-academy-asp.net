using AutoMapper;
using ClassLibrary1.Services;
using ClassLibrary1.Services.Interfaces;
using Domain.Entites;
using Domain.UnitOfWork;
using ItAcademy.HomeWorkNumFour.Models.CRUD;
using ItAcademy.HomeWorkNumFour.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItAcademy.HomeWorkNumFour.Service.Interface
{
    public class UserPresentationService : IUserPresentationService
    {
        private readonly IUserDomainService userDomainService;
        private readonly IUnitOfWork unitOfWork;
        public UserPresentationService (IUserDomainService userDomainService, IUnitOfWork unitOfWork)
        {
            this.userDomainService = userDomainService;
            this.unitOfWork = unitOfWork;
        }
        public List<UserViewModel> GetUserByLastName(string name)
        {
            var users = userDomainService.GetUserByLastName(name);

            var usersViewModel = Mapper.Map<List<UserViewModel>>(users);

            return usersViewModel;
        }
        public void Create (User user)
        {
            userDomainService.Create(user);
            unitOfWork.SaveChanges();
        }
    }
}