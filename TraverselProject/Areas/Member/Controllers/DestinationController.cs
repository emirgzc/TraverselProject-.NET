using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraverselProject.Areas.Member.Controllers
{
	[Area("Member")]
	[AllowAnonymous]
	public class DestinationController : Controller
	{
		DestinationManager dm = new DestinationManager(new EfDestinationRepository());
		public IActionResult Index()
		{
			var values = dm.TGetList();
			return View(values);
		}
	}
}
