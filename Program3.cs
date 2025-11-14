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
    internal class Program3
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            context.Database.EnsureCreated();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Add Category");
                Console.WriteLine("2. Add Product");
                Console.WriteLine("3. Add Customer");
                Console.WriteLine("4. Add Shipping Address");
                Console.WriteLine("5. Add Payment Information");
                Console.WriteLine("6. Add Order");
                Console.WriteLine("7. Add OrderItem");
                Console.WriteLine("8. Add Review");
                Console.WriteLine("0. Exit");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Enter category name:");
                        var catName = Console.ReadLine();
                        var category = new Categories { CategoryName = catName };
                        context.categories.Add(category);
                        context.SaveChanges();
                        Console.WriteLine("Category added.");
                        break;
                    case "2":
                        Console.WriteLine("Enter product name:");
                        var prodName = Console.ReadLine();
                        Console.WriteLine("Enter product description:");
                        var prodDesc = Console.ReadLine();
                        Console.WriteLine("Enter product price:");
                        var prodPrice = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter category ID:");
                        var prodCatId = int.Parse(Console.ReadLine());
                        var product = new Products
                        {
                            Name = prodName,
                            Description = prodDesc,
                            Price = prodPrice,
                            CategoryID = prodCatId
                        };
                        context.products.Add(product);
                        context.SaveChanges();
                        Console.WriteLine("Product added.");
                        break;
                    case "3":
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
                        Console.WriteLine("Customer added.");
                        break;
                    case "4":
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
                        Console.WriteLine("Enter customer ID:");
                        var addrCustId = int.Parse(Console.ReadLine());
                        var address = new ShippingAddresses
                        {
                            Street = street,
                            City = city,
                            State = state,
                            Country = country,
                            PostalCode = postal,
                            CustomerID = addrCustId
                        };
                        context.shippingAddresses.Add(address);
                        context.SaveChanges();
                        Console.WriteLine("Shipping address added.");
                        break;
                    case "5":
                        Console.WriteLine("Enter payment method:");
                        var paymentMethod = Console.ReadLine();
                        Console.WriteLine("Enter card number:");
                        var cardNumber =int.Parse( Console.ReadLine());
                        Console.WriteLine("Enter expiration date:");
                        var expDate =DateTime.Parse( Console.ReadLine());
                        Console.WriteLine("Enter CVV:");
                        var cvv = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter customer ID:");
                        var payCustId = int.Parse(Console.ReadLine());
                        var payment = new PaymentInformation
                        {
                            paymentMethod = PaymentMethod.Cach,
                            CardNumber = cardNumber,
                            ExpirationDate = expDate,
                            CVV = cvv,
                            CustomerID = payCustId
                        };
                        context.paymentInformations.Add(payment);
                        context.SaveChanges();
                        Console.WriteLine("Payment information added.");
                        break;
                    case "6":
                        Console.WriteLine("Enter order total price:");
                        var totalPrice = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter customer ID for order:");
                        var orderCustId = int.Parse(Console.ReadLine());
                        var order = new Orders
                        {
                            OrderDate = DateTime.Now,
                            TotalPrice = totalPrice,
                            CustomerID = orderCustId
                        };
                        context.orders.Add(order);
                        context.SaveChanges();
                        Console.WriteLine("Order added.");
                        break;
                    case "7":
                        Console.WriteLine("Enter order item quantity:");
                        var qty = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter item price:");
                        var itemPrice = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter order ID:");
                        var ordId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter product ID:");
                        var prodId = int.Parse(Console.ReadLine());
                        var orderItem = new OrderItems
                        {
                            Quantity = qty,
                            ItemPrice = itemPrice,
                            OrderID = ordId,
                            ProductID = prodId
                        };
                        context.orderItems.Add(orderItem);
                        context.SaveChanges();
                        Console.WriteLine("Order item added.");
                        break;
                    case "8":
                        Console.WriteLine("Enter rating (1-5):");
                        var rating = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter review comments:");
                        var comments = Console.ReadLine();
                        Console.WriteLine("Enter customer ID:");
                        var revCustId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter product ID:");
                        var revProdId = int.Parse(Console.ReadLine());
                        var review = new Reviews
                        {
                            Rating = rating,
                            Comments = comments,
                            CustomerID = revCustId,
                            ProductID = revProdId
                        };
                        context.reviews.Add(review);
                        context.SaveChanges();
                        Console.WriteLine("Review added.");
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }

            Console.WriteLine("Program terminated.");
        }
    }
}
