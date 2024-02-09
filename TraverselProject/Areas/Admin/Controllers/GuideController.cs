using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraverselProject.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class GuideController : Controller
	{
		private readonly IGuideService _guideService;

		public GuideController(IGuideService guideService)
		{
			_guideService = guideService;
		}

		public IActionResult Index()
		{
			var values = _guideService.TGetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddGuide()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddGuide(Guide guide)
		{
			_guideService.TAdd(guide);
			return RedirectToAction("Index", "Guide", new { area = "Admin" });
		}
		[HttpGet]
		public IActionResult EditGuide(int id)
		{
			var values = _guideService.TGetByID(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult EditGuide(Guide guide)
		{
			_guideService.TUpdate(guide);
			return RedirectToAction("Index", "Guide", new { area = "Admin" });
		}
		public IActionResult ChangeToTrue(int id)
		{
			var values = _guideService.TGetByID(id);
			values.Status = true;
			_guideService.TUpdate(values);
			return RedirectToAction("Index", "Guide", new { area = "Admin" });
		}
		public IActionResult ChangeToFalse(int id)
		{
			var values = _guideService.TGetByID(id);
			values.Status = false;
			_guideService.TUpdate(values);
			return RedirectToAction("Index", "Guide", new { area = "Admin" });
		}
		public IActionResult DeleteGuide(int id)
		{
			var values = _guideService.TGetByID(id);
			_guideService.TDelete(values);
			return RedirectToAction("Index", "Guide", new { area = "Admin" });
		}
	}
}
