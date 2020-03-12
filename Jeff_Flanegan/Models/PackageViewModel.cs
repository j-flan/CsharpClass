using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Jeff_Flanegan.Models
{
    public class PackageViewModel :PersonViewModel
    {

        public Package Package { get; set; }

        public List<Item> ShippingList
        {
            get
            {
                List<Item> shipping = new List<Item>();

                shipping.Add(new Item("Standard", "std"));
                shipping.Add(new Item("Two Day", "2d"));
                shipping.Add(new Item("Overnight", "ov"));

                return shipping;
            }
        }

        public PackageViewModel()
        {
            Package = new Package();
        }
    }
    public class Item
    {
      public string Description { get; set; }
        public string Value { get; set; }
        public Item(string D, string V)
        {
            Description = D;
            Value = V;
        }
    }

}