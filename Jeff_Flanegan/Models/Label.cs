using System;

namespace Jeff_Flanegan.Models
{
    public class Label
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string MailingLabel
        {
            get { return Fname + " " + Lname + "\r\n"
                    + Address + "\r\n"
                    + City + ", " + State + " " + Zip; }
        }

        public Label()
        {
            Fname = "first";
            Lname = "last";
            Address = "addr";
            City = "city";
            State = "state";
            Zip = "zip";
        }
    }
}