using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraverselProject.ViewComponents.Default
{
	public class PopularDestination : ViewComponent
	{
		DestinationManager dm = new DestinationManager(new EfDestinationRepository());
		public IViewComponentResult Invoke()
		{
			var values = dm.TGetList();
			return View(values);
		}
	}
}
