using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraverselProject.Areas.Member.ViewComponents.MemberDashboard
{
	public class GuideList : ViewComponent
	{
		GuideManager gm = new GuideManager(new EfGuideRepository());
		public IViewComponentResult Invoke()
		{
			var values = gm.TGetList();
			return View(values);
		}
	}
}
