using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace TraverselProject.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class DestinationController : Controller
	{
		private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
		{
			var values = _destinationService.TGetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddDestination()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddDestination(Destination p)
		{
            _destinationService.TAdd(p);
			return RedirectToAction("Index", "Destination");
		}
		public IActionResult DeleteDestination(int id)
		{
			var values = _destinationService.TGetByID(id);
            _destinationService.TDelete(values);
			return RedirectToAction("Index", "Destination");
		}
		[HttpGet]
		public IActionResult UpdateDestination(int id)
		{
			var values = _destinationService.TGetByID(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdateDestination(Destination p)
		{
            _destinationService.TUpdate(p);
			return RedirectToAction("Index", "Destination");
		}
	}
}
