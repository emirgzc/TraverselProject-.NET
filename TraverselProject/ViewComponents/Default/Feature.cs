using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraverselProject.ViewComponents.Default
{
	public class Feature : ViewComponent
	{
		FeatureManager fm = new FeatureManager(new EfFeatureRepository());
		public IViewComponentResult Invoke()
		{
			var values = fm.TGetList();
			return View(values);
		}
	}
}
