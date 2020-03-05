using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jeff_Flanegan.Models;

namespace Jeff_Flanegan.Controllers
{
    public class WageCalculatorController : Controller
    {
        // GET: Wage
        public ActionResult Index()
        {
            WageCalculator model = new WageCalculator();
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(WageCalculator model)
        {
            return View(model);
        }
    }
}