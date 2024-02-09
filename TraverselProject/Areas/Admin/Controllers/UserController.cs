using BusinessLayer.Abstract;
using DaatAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraverselProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly ICommentService _commentService;
        private readonly IReservationService _reservationService;

		public UserController(IAppUserService appUserService, ICommentService commentService, IReservationService reservationService)
		{
			_appUserService = appUserService;
			_commentService = commentService;
			_reservationService = reservationService;
		}

		public IActionResult Index()
        {
            var values = _appUserService.TGetList();
            return View(values);
        }
        public IActionResult DeleteUser(int id)
        {
            var values = _appUserService.TGetByID(id);
            _appUserService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var values = _appUserService.TGetByID(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditUser(AppUser appUser)
        {
            _appUserService.TUpdate(appUser);
            return RedirectToAction("Index");
        }
        public IActionResult CommentUser(int id)
		{
            var values = _commentService.GetCommentForAppUser(id);
            return View(values);
        }
        public IActionResult ReservationUser(int id)
		{
            var values = _reservationService.GetReservationForAppUser(id);
            return View(values);
        }
    }
}
