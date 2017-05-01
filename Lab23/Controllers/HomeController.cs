using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab23.Models;

namespace Lab23.Controllers
{
    public class HomeController : Controller
    {
        private static CoffeeAPPDBEntities db = new CoffeeAPPDBEntities();

        private bool isAdmin = false;
        public ActionResult Index()
        {
            var items = DAO.GetItemsList();
            return View(items);
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Success(UserRegistration r)
        {
            ViewBag.SuccessMessage = "Hello, " + r.FirstName + ". Your email is " + r.Email + ".";
            if (r.FirstName.Equals("Admin"))
            {
                isAdmin = true;
            }

            string fullName = r.FirstName + " " + r.LastName;

            db.Users.Add(new User { Name = fullName, Email = r.Email, Password = r.Password });
            db.SaveChanges();

            return View();
        }

    }
}