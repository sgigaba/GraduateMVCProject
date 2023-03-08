using Microsoft.AspNetCore.Mvc;
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

       public ActionResult Edit(int ID)
       {
            ProfileModel profiles = _dbContext.Profile.Find(ID);
            return View(profiles);
       }

        [HttpPost]
        public ActionResult Edit(ProfileModel profile)
        {

             _dbContext.Update(profile);
             _dbContext.SaveChanges();

            return View(profile);
        }

        [HttpPost]
        public ActionResult Create(String Name,String Surname, DateTime DateOfBirth, int Age, String Country, String City)
        {
            ProfileModel profile = new ProfileModel()
            {
                Name = Name,
                Surname = Surname,
                DateOfBirth = DateOfBirth,
                Age = Age,
                Country = Country,
                City = City
            };

            _dbContext.Add(profile);
            _dbContext.SaveChanges();
            return View("Create");

        }

        public IActionResult Create() {
        
            return View();
        }
        public IActionResult Delete(int ID)
        {
            ProfileModel profiles = _dbContext.Profile.Find(ID);
            return View(profiles);
 
        }

        [HttpPost]
        public ActionResult Delete(ProfileModel profile)
        {
            ProfileModel profiles = _dbContext.Profile.Find(profile.ID);
            _dbContext.Remove(profiles);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");

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
