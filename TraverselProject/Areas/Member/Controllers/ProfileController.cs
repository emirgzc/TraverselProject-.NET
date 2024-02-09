using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Threading.Tasks;
using TraverselProject.Areas.Member.Models;

namespace TraverselProject.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel model = new UserEditViewModel();
            model.name = values.Name;
            model.surname = values.Surname;
            model.phonenumber = values.PhoneNumber;
            model.mail = values.Email;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.image.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/Images/UserImages/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.image.CopyToAsync(stream);
                user.ImageUrl = "/Images/UserImages/" + imageName;
            }
            if ((p.password != null && p.confirmpassword != null) && (p.password == p.confirmpassword))
            {
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.password);
            }
            user.Name = p.name;
            user.Surname = p.surname;
            user.Email = p.mail;
            user.PhoneNumber = p.phonenumber;
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Destination");
            }
            return View();
        }
    }
}
