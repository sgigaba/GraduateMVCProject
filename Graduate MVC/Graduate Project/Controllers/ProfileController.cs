using Microsoft.AspNetCore.Mvc;
using Graduate_Project.Models;
using Graduate_Project.ViewModels;
using Microsoft.Identity.Client;

namespace Graduate_Project.Controllers
{
    public class ProfileController : Controller
    {

        private readonly ApplicationDbContext _dbContext;
        public ProfileController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        public IActionResult Index()
        {
            
            ProfileModel profile = new ProfileModel()
            {
                Name = "Samkelo",
                Surname = "Gigaba",
                Age = 22,
                Country = "South Africa",
                City = "Johannesburg"

            };

            ProfileViewModel profileViewModel = new ProfileViewModel()
            {
                Profile = profile
            };

            return View(profileViewModel);
        }
    }
}
