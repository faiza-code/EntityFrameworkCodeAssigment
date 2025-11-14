using EntityFreamworkAssigment.E_Shop.Context;
using EntityFreamworkAssigment.E_Shop.Enum;
using EntityFreamworkAssigment.E_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFreamworkAssigment
{
    public class ProgramUserInsert
    {   
        public static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            context.Database.EnsureCreated();

            // 1. Insert Category
            Console.WriteLine("Enter category name:");
            var catName = Console.ReadLine();
            var category = new Categories { CategoryName = catName };
            context.categories.Add(category);
            context.SaveChanges();

            // 2. Insert Product
            Console.WriteLine("Enter product name:");
            var prodName = Console.ReadLine();
            Console.WriteLine("Enter product description:");
            var prodDesc = Console.ReadLine();
            Console.WriteLine("Enter product price:");
            var prodPrice = double.Parse(Console.ReadLine());
            var product = new Products
            {
                Name = prodName,
                Description = prodDesc,
                Price = prodPrice,
                CategoryID = category.CategoryID
            };
            context.products.Add(product);
            context.SaveChanges();

            // 3. Insert Customer
            Console.WriteLine("Enter customer name:");
            var custName = Console.ReadLine();
            Console.WriteLine("Enter customer email:");
            var custEmail = Console.ReadLine();
            Console.WriteLine("Enter customer contact info:");
            var custContact = Console.ReadLine();
            var customer = new Customrs
            {
                Name = custName,
                Email = custEmail,
                ContactInfo = custContact
            };
            context.customrs.Add(customer);
            context.SaveChanges();

            // 4. Insert Shipping Address
            Console.WriteLine("Enter shipping street:");
            var street = Console.ReadLine();
            Console.WriteLine("Enter city:");
            var city = Console.ReadLine();
            Console.WriteLine("Enter state:");
            var state = Console.ReadLine();
            Console.WriteLine("Enter country:");
            var country = Console.ReadLine();
            Console.WriteLine("Enter postal code:");
            var postal = Console.ReadLine();
            var address = new ShippingAddresses
            {
                Street = street,
                City = city,
                State = state,
                Country = country,
                PostalCode = postal,
                CustomerID = customer.CustomerID
            };
            context.shippingAddresses.Add(address);
            context.SaveChanges();

            // 5. Insert Payment Information
            Console.WriteLine("Enter payment method:");
            var paymentMethodValue = Console.ReadLine();
            
            Console.WriteLine("Enter card number:");
            var cardNumber =int.Parse( Console.ReadLine());
            Console.WriteLine("Enter expiration date:");
            var expDate =DateTime.Parse( Console.ReadLine());
            Console.WriteLine("Enter CVV:");
            var cvv = int.Parse(Console.ReadLine());
            var payment = new PaymentInformation
            {
                paymentMethod = PaymentMethod.Cach,
                //PaymentMethod = paymentMethodValue,
                CardNumber = cardNumber,
                ExpirationDate = expDate,
                CVV = cvv,
                CustomerID = customer.CustomerID
            };
            context.paymentInformations.Add(payment);
            context.SaveChanges();
              
            
           

            // 6. Insert Order
            Console.WriteLine("Enter order total price:");
            var totalPrice = double.Parse(Console.ReadLine());
            var order = new Orders
            {
                OrderDate = DateTime.Now,
                TotalPrice = totalPrice,
                CustomerID = customer.CustomerID
            };
            context.orders.Add(order);
            context.SaveChanges();

            // 7. Insert OrderItem
            Console.WriteLine("Enter order item quantity:");
            var qty = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter item price:");
            var itemPrice = double.Parse(Console.ReadLine());
            var orderItem = new OrderItems
            {
                Quantity = qty,
                ItemPrice = itemPrice,
                OrderID = order.OrderID,
                ProductID = product.ProductID
            };
            context.orderItems.Add(orderItem);
            context.SaveChanges();

            // 8. Insert Review
            Console.WriteLine("Enter rating (1-5):");
            var rating = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter review comments:");
            var comments = Console.ReadLine();
            var review = new Reviews
            {
                Rating = rating,
                Comments = comments,
                CustomerID = customer.CustomerID,
                ProductID = product.ProductID
            };
            context.reviews.Add(review);
            context.SaveChanges();

            Console.WriteLine("All data inserted successfully.");


        }
    }
}


