using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Jeff_Flanegan.Models
{
    public class Package : Person
    {
        public Person Sender { get; set; }
        public Person Receiver { get; set; }
        public Decimal weight { get; set; }
        public Decimal costPerOz { get; set; }
        public string shippingType { get; set; }

        virtual public Decimal shippingCost
        {
            get
            {
                return weight * costPerOz;
            }
        } 
        public string ShippingLabel
        {
            get
            {
                return Sender.MailingLabel + "\r\n\r\n" + Receiver.MailingLabel;
            }
        }
        

        public Package()
        {
            Sender = new Person();
            Receiver = new Person();
            weight = 1;
            costPerOz = 1;
            shippingType = "Standard";
        }
        
    }
}