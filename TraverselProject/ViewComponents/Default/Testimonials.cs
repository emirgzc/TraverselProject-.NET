using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraverselProject.ViewComponents.Default
{
	public class Testimonials : ViewComponent
	{
		TestimonialsManager tm = new TestimonialsManager(new EfTestimonialRepository());
		public IViewComponentResult Invoke()
		{
			var values = tm.TGetList();
			return View(values);
		}
	}
}
