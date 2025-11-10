using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFreamworkAssigment.E_Shop.Models
{
    public class ShippingAddresses
    {
        [Key]
        public int AddressID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        [ForeignKey(nameof(CustomerID))]
        public Customrs customers { get; set; }
        public int CustomerID { get; set; }
        //public List<Customrs> customrsList { get; set; } = new List<Customrs>();

        public ShippingAddresses(int addressID, string street, string city, string state, string postalCode, string country, Customrs customers, int customerID)
        {
            AddressID = addressID;
            Street = street;
            City = city;
            State = state;
            PostalCode = postalCode;
            Country = country;
            this.customers = customers;
            CustomerID = customerID;
        }

        public ShippingAddresses(){ }
    }
}
