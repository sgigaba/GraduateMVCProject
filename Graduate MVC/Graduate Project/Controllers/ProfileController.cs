﻿using Microsoft.AspNetCore.Mvc;
using Graduate_Project.Models;
using Graduate_Project.ViewModels;
using Microsoft.Identity.Client;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Graduate_Project.Controllers
{
    public class ProfileController : Controller
    {

        private readonly ApplicationDbContext _dbContext;
  
        public ProfileController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        public async Task<IActionResult> Index()
        {
            ProfileModel profile = new ProfileModel()
            {
              /*Name = "Samkelo",
                Surname = "Gigaba",
                Age = 22,
                Country = "South Africa",
                City = "Johannesburg"*/

            };

            ProfileViewModel profileViewModel = new ProfileViewModel()
            {
                Profile = profile
            };
            var profiles = await _dbContext.Profile.ToListAsync();


            return View(profiles);
            }
    }
}
