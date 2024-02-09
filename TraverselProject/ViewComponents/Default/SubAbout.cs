using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraverselProject.ViewComponents.Default
{
    public class SubAbout : ViewComponent
    {
        SubAboutManager sbm = new SubAboutManager(new EfSubAboutRepository());
        public IViewComponentResult Invoke()
        {
            var values = sbm.TGetList();
            return View(values);
        }
    }
}
