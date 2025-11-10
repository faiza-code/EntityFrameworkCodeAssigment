using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFreamworkAssigment.E_Shop.Models
{
    public  class Orders
    {
        [Key]
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }


        [ForeignKey(nameof(CustomerID))]
        public Customrs customers { get; set; }
        public int CustomerID { get; set; }
        public ICollection<OrderItems> orderItems { get; set; }

        public Orders(int orderID, DateTime orderDate, double totalPrice, Customrs customers, int customerID)
        {
            OrderID = orderID;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
            this.customers = customers;
            CustomerID = customerID;
        }

        public Orders()
        {
        }
    }
}
