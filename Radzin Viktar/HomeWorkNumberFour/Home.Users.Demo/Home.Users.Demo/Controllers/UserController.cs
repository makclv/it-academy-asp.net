﻿using Home.Users.Demo.Models;
using Home.Users.Demo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home.Users.Demo.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserPresentationService userPresentationService;

        public UserController(IUserPresentationService userPresentationService)
        {
            this.userPresentationService = userPresentationService;
        }

        public ActionResult Index()
        {
            return View(userPresentationService.SelectAllUsers());
        }

        [HttpGet]
        public ActionResult Create()
        {
            UserViewModel userViewModel = new UserViewModel();
            userViewModel.Countries = userPresentationService.GetCountries();
            userViewModel.Cities = userPresentationService.GetCities();
            return View(userViewModel);
        }

        [HttpPost]
        public ActionResult Create(UserViewModel userViewModel)
        {
            userPresentationService.InsertUser(userViewModel);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            UserViewModel userViewModel = userPresentationService.SelectUserByIdWithCountryandCity(id);
            userViewModel.Countries = userPresentationService.GetCountries();
            userViewModel.Cities = userPresentationService.GetCities();
            return View(userViewModel);
        }

        [HttpPost]
        public ActionResult Edit(UserViewModel userViewModel)
        {
            userPresentationService.UpdateUser(userViewModel);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            UserViewModel userViewModel = userPresentationService.SelectUserByIdWithCountryandCity(id);
            userViewModel.Countries = userPresentationService.GetCountries();
            userViewModel.Cities = userPresentationService.GetCities();
            return View(userViewModel);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            userPresentationService.DeleteUser(id);
            return RedirectToAction("Index");
        }
    }
}