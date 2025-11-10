using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFreamworkAssigment.E_Shop.Models
{
    public class OrderItems
    {
        [Key]
        public int OrderItemID { get; set; }
        public int Quantity { get; set; }
        public double ItemPrice { get; set; }


        [ForeignKey(nameof(OrderID))]
        public Orders orders { get; set; }
        public int OrderID { get; set; }
        //public List<Orders> ordersList { get; set; } = new List<Orders>();


        [ForeignKey(nameof(ProductID))]
        public Products products{ get; set; }
        public int ProductID { get; set; }
        //public List<Products> productsList { get; set; } = new List<Products>();

        public OrderItems(int orderItemID, int quantity, double itemPrice, Orders orders, int orderID, Products products, int productID)
        {
            OrderItemID = orderItemID;
            Quantity = quantity;
            ItemPrice = itemPrice;
            this.orders = orders;
            OrderID = orderID;
            this.products = products;
            ProductID = productID;
        }

        public OrderItems() { }
    }
}
