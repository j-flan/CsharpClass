using Jeff_Flanegan.Models;
using System.Web.Mvc;

namespace Jeff_Flanegan.Controllers
{
    public class LabelController : Controller
    {
        public ActionResult Index()
        {
            LabelViewModel model = new LabelViewModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(LabelViewModel model)
        {
            return View(model);
        }
    }
}