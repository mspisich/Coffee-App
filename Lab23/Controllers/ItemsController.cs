using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lab23.Models;

namespace Lab23.Controllers
{
    public class ItemsController : Controller
    {
        public ActionResult Admin()
        {
            var Items = DAO.GetItemsList();
            return View(Items);
            /*if (isAdmin == true)
            {
                var items = DAO.GetItemsList();
                return View(items);
            }
            else
            {
                return Error("You do not have admin privileges!"));
            }*/
        }
        public ActionResult Error(string message)
        {
            ViewBag.ErrorMessage = message;
            return View();
        }

        public ActionResult AddItem(string name, string desc, int quantity, float price)
        {
            DAO.CreateItem(name, desc, quantity, price);
            return View("Admin");
        }
    }
}
