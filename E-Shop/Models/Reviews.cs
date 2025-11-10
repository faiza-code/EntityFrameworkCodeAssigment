using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFreamworkAssigment.E_Shop.Models
{
    public class Reviews
    {
        [Key]
        public int ReviewID { get; set; }
        public double Rating { get; set; }
        public string Comments { get; set; }


        [ForeignKey(nameof(CustomerID))]
        public Customrs customers { get; set; }
        public int CustomerID { get; set; }
        //public List<Customrs> customrsList { get; set; } = new List<Customrs>();


        [ForeignKey(nameof(ProductID))]
        public Products products { get; set; }
        public int ProductID { get; set; }
        //public List<Products> productsList { get; set; } = new List<Products>();

        public Reviews(int reviewID, double rating, string comments, Customrs customers, int customerID, Products products, int productID)
        {
            ReviewID = reviewID;
            Rating = rating;
            Comments = comments;
            this.customers = customers;
            CustomerID = customerID;
            this.products = products;
            ProductID = productID;
        }

        public Reviews() { }
    }
}
