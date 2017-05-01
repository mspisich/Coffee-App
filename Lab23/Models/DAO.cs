using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab23.Models
{
    public class DAO
    {
        private static CoffeeAPPDBEntities db = new CoffeeAPPDBEntities();
        public static List<Item> GetItemsList()
        {
            var items = db.Items.ToList();
            return items;
        }
        public static void CreateItem(string name, string desc, int quantity, float price)
        {
            db.Items.Add(new Item { Name = name, Description = desc, Quantity = quantity, Price = price });
            db.SaveChanges();
        }
        public static void EditItem(string name, string desc, int quantity, float price)
        {
            
        }
        public static void DeleteItem(string name)
        {
            
        }
    }
}