using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jeff_Flanegan.Models
{
    public class Overnight : Package
    {
        public Package Package { get; set; }
        public Decimal overnightFee { get; set; }

        public override decimal shippingCost => base.shippingCost  + (weight * 5);


        public Overnight()
        {
            Package = new Package();
            overnightFee = 5 * weight;
        }
    }
}