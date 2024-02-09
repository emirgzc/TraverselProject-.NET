using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using static System.Collections.Specialized.BitVector32;
using System.Threading;

namespace TraverselProject.ViewComponents.Default
{
    public class Statistic : ViewComponent
    {
        DestinationManager dm = new DestinationManager(new EfDestinationRepository());
        GuideManager gm = new GuideManager(new EfGuideRepository());
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = dm.TGetList().Count();
            ViewBag.v2 = gm.TGetList().Count();
			ViewBag.v3 = "285";
            return View();
        }
    }
}
