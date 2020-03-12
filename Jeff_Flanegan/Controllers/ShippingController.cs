using Jeff_Flanegan.Models;
using System.Web.Mvc;


namespace Jeff_Flanegan.Controllers
{
    public class ShippingController : Controller
    {
        // GET: Shipping
        public ActionResult Index()
        {
            PackageViewModel model = new PackageViewModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(PackageViewModel model)
        {
            //if (ModelState.IsValid)
            //return View(model);

            //PackageViewModel notmodel = new PackageViewModel();
            //return View(notmodel);

            switch (model.Package.shippingType)
            {
                case "Standard":
                    Package Package = new Package();
                    LoadPackageFromForm(Package, model);
                    break;
                case "Two Day":
                    TwoDay twoday = new TwoDay();
                    LoadPackageFromForm(twoday, model);
                    break;            
                case "Overnight":
                    Overnight over = new Overnight();
                    LoadPackageFromForm(over, model);
                    break;
            }
            return View(model);
        }
        public void LoadPackageFromForm(Package myPackage, PackageViewModel model)
        {
            myPackage.Sender = model.Package.Sender;
            myPackage.Receiver = model.Package.Receiver;
            myPackage.weight = model.Package.weight;
            myPackage.costPerOz = model.Package.costPerOz;
            myPackage.shippingType = model.Package.shippingType;
            model.Package = myPackage;

        }
    }
}