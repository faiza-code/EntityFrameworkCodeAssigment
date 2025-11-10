using EntityFreamworkAssigment.E_Shop.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFreamworkAssigment.E_Shop.Models
{
    public class PaymentInformation
    {
        [Key]
        public int PaymentID { get; set; }
        public PaymentMethod paymentMethod { get; set; }
        public int CardNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int CVV { get; set; }


        [ForeignKey(nameof(CustomerID))]
        public Customrs customers { get; set; }
        public int CustomerID { get; set; }
        //public List<Customrs> customrsList { get; set; } = new List<Customrs>();

        public PaymentInformation(int paymentID, PaymentMethod paymentMethod, int cardNumber, DateTime expirationDate, int cVV, Customrs customers, int customerID)
        {
            PaymentID = paymentID;
            this.paymentMethod = paymentMethod;
            CardNumber = cardNumber;
            ExpirationDate = expirationDate;
            CVV = cVV;
            this.customers = customers;
            CustomerID = customerID;
        }

        public PaymentInformation() { }
    }
}
