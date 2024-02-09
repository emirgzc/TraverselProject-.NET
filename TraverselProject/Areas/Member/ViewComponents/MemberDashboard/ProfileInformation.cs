using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraverselProject.Areas.Member.ViewComponents.MemberDashboard
{
    public class ProfileInformation : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileInformation(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(values);
        }
    }
}
