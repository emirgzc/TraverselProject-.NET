using Microsoft.AspNetCore.Mvc;

namespace TraverselProject.ViewComponents.Default
{
	public class SliderView : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
