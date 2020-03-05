using System.Collections.Generic;
using System.Web.Mvc;

namespace Jeff_Flanegan.Models
{
    public class PersonViewModel
    {
        public Person Person { get; set; }

        public SelectList StateList
        {
            get
            {

                List<ListItem> states = new List<ListItem>();
                //Add some items to the list
                states.Add(new ListItem("Colorado", "CO"));
                states.Add(new ListItem("Michigan", "MI"));
                states.Add(new ListItem("Oregon", "OR"));
                states.Add(new ListItem("Texas", "TX"));
                states.Add(new ListItem("Illinois", "IL"));

                //create a new SelectList passing in the list of ListItem, Value as the value field, 
                //Description as the description field
                return new SelectList(states, "Value", "Description");
            }
        }

        public PersonViewModel()
        {
            Person = new Person();
        }
    }

    public class ListItem
    {
        public string Description { get; set; }
        public string Value { get; set; }

        public ListItem(string description, string value)
        {
            Description = description;
            Value = value;
        }
    }
}