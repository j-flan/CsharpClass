using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Web.Mvc;

namespace Jeff_Flanegan.Models
{
    public class Person
    {
        [Required]
        public string Fname { get; set; }
        [Required]
        public string Lname { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        public string State { get; set; }
        [Required]
        [RegularExpression(@"[0-9]{5}")]
        public string Zip { get; set; }
        public string MailingLabel
        {
            get
            {

                return Fname + " " + Lname + "\r\n"
                    + Address + "\r\n"
                    + City + " " + State + " " + Zip;

            }
        }

    }
}