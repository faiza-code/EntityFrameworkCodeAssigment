using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFreamworkAssigment.E_Shop.Models
{
    public class Customrs
    {
        [Key]
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactInfo { get; set; }
        public ICollection<Orders> orders { get; set; }
        public ICollection<ShippingAddresses> shippingAddresses { get; set; }
        public ICollection<PaymentInformation> paymentInformations { get; set; }
        public ICollection<Reviews> reviews { get; set; }


        public Customrs(int customerID, string name, string email, string contactInfo)
        {
            CustomerID = customerID;
            Name = name;
            Email = email;
            ContactInfo = contactInfo;
        }
        public Customrs() { }
    }
}
