using BusinessLayer.Concrete;
using DaatAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace TraverselProject.Controllers
{
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EfCommentRepository());
		

		[HttpGet]
		public async Task<PartialViewResult> AddComment()
		{			
			return PartialView();
		}
		[HttpPost]
		public IActionResult AddComment(Comment c)
		{
			c.CommentState = true;
			c.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            cm.TAdd(c);
			return RedirectToAction("Index","Destination");
		}
	}
}
