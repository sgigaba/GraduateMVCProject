using Microsoft.AspNetCore.Mvc;
using Graduate_Project.Models;
using Graduate_Project.ViewModels;

namespace Graduate_Project.Controllers
{
    public class ProfileController : Controller
    {
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
