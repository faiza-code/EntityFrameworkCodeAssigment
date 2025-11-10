using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFreamworkAssigment.E_Shop.Models
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        [ForeignKey(nameof(CategoryID))]
        public Categories categories { get; set; }
        public int CategoryID { get; set; }
        //public List<Categories> categoriesList { get; set; } = new List<Categories>();
        public ICollection<OrderItems> orderItems { get; set; }
        public ICollection<Reviews> reviews { get; set; }

        public Products(int productID, string name, string description, double price, Categories categories, int categoryID)
        {
            ProductID = productID;
            Name = name;
            Description = description;
            Price = price;
            this.categories = categories;
            CategoryID = categoryID;
        }

        public Products() { }
    }
}
