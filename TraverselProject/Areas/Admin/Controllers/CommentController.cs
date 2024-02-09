using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DaatAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraverselProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly ICommentService commentService;

        public CommentController(ICommentService commentService)
        {
            this.commentService = commentService;
        }

        public IActionResult Index()
        {
            var values = commentService.TGetList();
            return View(values);
        }
        public IActionResult DeleteComment(int id)
        {
            var values = commentService.TGetByID(id);
            commentService.TDelete(values);
            return RedirectToAction("Index","Comment");
        }
    }
}
