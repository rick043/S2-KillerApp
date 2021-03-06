﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using PMDB_docker.Interfaces;
using PMDB_docker.Models;
using PMDB_docker.ViewModels;
using System;
using System.IO;

namespace PMDB_docker.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserLogic _userRepository;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public UserController(IUserLogic userRepository, IWebHostEnvironment hostingEnvironment)
        {
            _userRepository = userRepository;
            _hostingEnvironment = hostingEnvironment;
        }

        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Register()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Register(UserRegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                UserDto user = new UserDto
                {
                    DateOfRegistration = DateTime.Now,
                    Email = model.Email,
                    Password = model.Password,
                    Username = model.Username
                };
                _userRepository.Add(user);
                return RedirectToAction("details", new { id = user.Id });
            }

            return View();
        }

        public ViewResult Details(int? id)
        {
            UserDto user = _userRepository.GetUser(id.Value);
            if (user == null)
            {
                Response.StatusCode = 404;
                return View("UserNotFound", id.Value);
            }
            UserDetailsViewModel userDetailsViewModel = new UserDetailsViewModel()
            {
                User = user,
                PageTitle = "Movie Details"
            };
            return View(userDetailsViewModel);
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            UserDto user = _userRepository.GetUser(id);
            
            UserEditViewModel userEditViewModel = new UserEditViewModel()
            {
                User = _userRepository.GetUser(id),
                ExistingPhotoPath = user.ProfileImage,
                FirstName = user.FirstName,
                LastName = user.LastName,
                DateOfBirth = user.DateOfBirth,
                Genders = user.Genders,
                Email = user.Email,
                Street = user.Street,
                Number = user.Number,
                PostalCode = user.PostalCode,
                Phone = user.Phone,
                Mobile = user.Mobile
            };
            return View(userEditViewModel);
        }

        [HttpPost]
        public IActionResult Edit(UserEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                UserDto user = _userRepository.GetUser(model.Id);
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.Genders = model.Genders;
                user.DateOfBirth = model.DateOfBirth;
                user.Email = model.Email;
                user.Street = model.Street;
                user.Number = model.Number;
                user.PostalCode = model.PostalCode;
                user.Phone = model.Phone;
                user.Mobile = model.Mobile;

                if (model.Photo != null)
                {
                    if (model.ExistingPhotoPath != null)
                    {
                        string filePath = Path.Combine(_hostingEnvironment.WebRootPath, "img/profile",
                            model.ExistingPhotoPath);
                        System.IO.File.Delete(filePath);
                    }
                    user.ProfileImage = ProcessUploadedFile(model);
                }
                _userRepository.Edit(user);
                return RedirectToAction("details", new { id = user.Id });
            }
            return View();
        }

        private string ProcessUploadedFile(UserEditViewModel model)
        {
            string uniqueFileName = null;
            if (model.Photo != null)
            {
                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "img/profile");
                uniqueFileName = Guid.NewGuid() + "_" + model.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
            }
            return uniqueFileName;
        }
    }
}