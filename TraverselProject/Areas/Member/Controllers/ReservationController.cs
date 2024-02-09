using BusinessLayer.Concrete;
using DaatAccessLayer.EntityFramework;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace TraverselProject.Areas.Member.Controllers
{
	[Area("Member")]
	[Route("Member/[controller]/[action]")]
	public class ReservationController : Controller
	{
		ReservationManager rm = new ReservationManager(new EfReservationRepository());
		DestinationManager dm = new DestinationManager(new EfDestinationRepository());
		private readonly UserManager<AppUser> _userManager;
		int approvalStatusID = 1;
		int previousStatusID = 2;
		int acceptedStatusID = 3;

        public ReservationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> MyCurrentReservation()
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			var items = rm.GetListStatusReservation(values.Id, acceptedStatusID);
			return View(items);
		}
		public async Task<IActionResult> MyOldReservation()
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			var items = rm.GetListStatusReservation(values.Id, previousStatusID);
			return View(items);
		}
		public async Task<IActionResult> MyApprovalReservation()
		{
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var items = rm.GetListStatusReservation(values.Id, approvalStatusID);
            return View(items);
		}
		[HttpGet]
		public IActionResult NewReservation()
		{
			List<SelectListItem> destinations = (from x in dm.TGetList()
												 select new SelectListItem
												 {
													 Text = x.City,
													 Value = x.DestinationID.ToString()
												 }).ToList();
			ViewBag.des = destinations;
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> NewReservation(Reservation p)
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			p.AppUserId = values.Id;
			p.ReserStatusID = 1;
			p.ReservationDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			rm.TAdd(p);
			return RedirectToAction("Index", "Destination");
		}
	}
}
