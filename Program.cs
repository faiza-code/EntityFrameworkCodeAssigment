using EntityFreamworkAssigment.E_Shop.Context;
using EntityFreamworkAssigment.E_Shop.Enum;
using EntityFreamworkAssigment.E_Shop.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.IO;
using System.Net;
using System.Xml.Linq;

namespace EntityFreamworkAssigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            ApplicationDbContext _context = new ApplicationDbContext();


                Categories category = new Categories()
                {
                    CategoryName = "Food",
                };
                _context.categories.Add(category);
                _context.SaveChanges();
               

         
                Customrs customr = new Customrs()
                {
                    Name = "Faiza Alhandali",
                    Email = "f2iza.na20@gmail.com",
                    ContactInfo = "phoneNum :92972021",

                };
                _context.customrs.Add(customr);
                _context.SaveChanges();


            
               Products product = new Products()
               {
                   Name = "Apple",
                   Description = "One Apple from Categories Food",
                   Price = 8.09,
                   CategoryID = category.CategoryID,
                   categories = category,

               };
               _context.products.Add(product);
               _context.SaveChanges();

               Orders order = new Orders()
               {
                   OrderDate = new DateTime(2025, 11, 4, 12, 30, 50),
                   TotalPrice = 3,
                   CustomerID = customr.CustomerID,
                   customers = customr

               };
               _context.orders.Add(order);
               _context.SaveChanges();

               OrderItems orderItem = new OrderItems()
               {
                    Quantity = 2,
                    ItemPrice = 3.03,
                    OrderID = order.OrderID,
                    orders = order,
                    ProductID = product.ProductID,
                    products = product


               };
                _context.orderItems.Add(orderItem);
                _context.SaveChanges();
               
                PaymentInformation payment = new PaymentInformation()
                {
                    paymentMethod = PaymentMethod.Cach,
                    CardNumber = 1234568,
                    ExpirationDate = new DateTime(2025, 11, 4, 12, 30, 50),
                    CVV = 12345,
                    CustomerID = customr.CustomerID,
                    customers = customr

                };
                _context.paymentInformations.Add(payment);
                _context.SaveChanges();
               

                Reviews review = new Reviews()
                {
                    Rating = 2,
                    Comments = " ",
                    CustomerID = customr.CustomerID,
                    customers = customr,
                    ProductID = product.ProductID,
                    products = product


                };
                _context.reviews.Add(review);
                _context.SaveChanges();
                
          

                ShippingAddresses address = new ShippingAddresses()
                {
                    Street = "124SAL",
                    City = "Salalah",
                    State = "1246fg",
                    PostalCode = "SG1234",
                    Country = "Oman",
                    CustomerID = customr.CustomerID,
                    customers = customr

                };
                _context.shippingAddresses.Add(address);
                _context.SaveChanges();


            Console.WriteLine("Wellcome To E-Shop System!");
            Console.WriteLine($"Category: {category.CategoryName}");
            Console.WriteLine($"Product: {product.Name} in Category: {product.categories.CategoryName}");
            Console.WriteLine($"Customer: {customr.Name}");
            Console.WriteLine($"Address: {address.Street}, {address.City}");
            Console.WriteLine($"Payment: {payment.paymentMethod}, Card: {payment.CardNumber}");
            Console.WriteLine($"Order: {order.OrderID}, Date: {order.OrderDate}");
            Console.WriteLine($"OrderItem: {orderItem.Quantity} x {orderItem.products.Name}");
            Console.WriteLine($"Review: {review.Rating} stars, Comment: {review.Comments}");



        }
        }
    }

