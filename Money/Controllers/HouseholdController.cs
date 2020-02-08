using Money.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Money.Controllers
{
    [Authorize]
    public class HouseholdController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult NoHousehold()
        {
            return View(new NoHouseholdViewModel());
        }

        [HttpPost]
        public ActionResult NoHousehold(NoHouseholdViewModel Model)
        {
            if (ModelState.IsValid)
            {
                var household = new Household()
                {
                    Name = Model.Name
                };
                db.Households.Add(household);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(Model);
        }
    }
}