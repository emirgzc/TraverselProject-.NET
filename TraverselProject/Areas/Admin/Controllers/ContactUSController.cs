using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraverselProject.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class ContactUSController : Controller
	{
		IContactUSService _contactUSService;

		public ContactUSController(IContactUSService contactUSService)
		{
			_contactUSService = contactUSService;
		}

		public IActionResult Index()
		{
			var values = _contactUSService.TGetList();
			return View(values);
		}
		public IActionResult ContactUSDetail(int id)
		{
			var values = _contactUSService.GetContactUSByID(id);
			return View(values);
		}

	}
}
