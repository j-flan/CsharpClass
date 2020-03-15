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
        
        public Decimal weight {
            set
            {

                if (value > 0 && value <= 100) weight = value;
            }
            get
            {
                return weight;
            }
        }
        
        public Decimal costPerOz {
            set
            {
                if (value > 0) costPerOz = value;
            }
            get
            {
                return costPerOz;
            }
        }

            
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