using Jeff_Flanegan.Models;
using System.Web.Mvc;

namespace Jeff_Flanegan.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            PersonViewModel model = new PersonViewModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(PersonViewModel model)
        {

            if (ModelState.IsValid)
                return View(model);

            PersonViewModel notmodel = new PersonViewModel();
            return View(notmodel);
        }
    }
}