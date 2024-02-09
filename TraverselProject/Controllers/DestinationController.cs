using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraverselProject.Controllers
{
	[AllowAnonymous]
	public class DestinationController : Controller
	{
		DestinationManager dm = new DestinationManager(new EfDestinationRepository());
		private readonly UserManager<AppUser> _userManager;

		public DestinationController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		public IActionResult Index()
		{
			
			var values = dm.TGetList();
			return View(values);
		}
		public async Task<IActionResult> DestinationDetails(int id)
		{
			var value = await _userManager.FindByNameAsync(User.Identity.Name);
			ViewBag.userID = value.Id;
			var values = dm.TGetDestinationWithGuide(id);
			ViewBag.i = id;
			return View(values);
		}
	}
}
