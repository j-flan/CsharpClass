using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Jeff_Flanegan.Models
{
    public class Package : Person
    {
        private Person _Sender = new Person();
        public Person Sender
        {
            get
            {
                return _Sender;
            }
        }
        private Person _Receiver = new Person();
        public Person Receiver {
            get
            {
                return _Receiver;
            }
        }
        [Range(1,100)]
        public Decimal weight { get; set; }
        
        [Range(1, 100000)]
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
            weight = 1;
            costPerOz = 1;
            shippingType = "Standard";
        }
        
    }
}