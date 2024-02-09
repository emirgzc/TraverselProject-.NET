using BusinessLayer.Concrete;
using DaatAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraverselProject.ViewComponents.Comment
{
	public class CommentList : ViewComponent
	{
		CommentManager cm = new CommentManager(new EfCommentRepository());
		public IViewComponentResult Invoke(int id)
		{
			var values = cm.GetCommentForAppUserWithDestination(id);
			return View(values);
		}
	}
}
