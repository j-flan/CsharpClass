using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jeff_Flanegan.Models
{
    public class TwoDay : Package
    {
        public Package Package { get; set; }
        public Decimal flatFee { get; set; }

        public override decimal shippingCost => base.shippingCost + flatFee;
        

        public TwoDay()
        {
            Package = new Package();
            flatFee = 5;
        }

    }
}