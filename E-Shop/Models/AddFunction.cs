using EntityFreamworkAssigment.E_Shop.Context;
using EntityFreamworkAssigment.E_Shop.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFreamworkAssigment.E_Shop.Models
{
    public class AddFunction
    {
        private ApplicationDbContext _context;

        public AddFunction(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddCategory()
        {
            Console.WriteLine("Enter category name:");
            var catName = Console.ReadLine();
            var category = new Categories { CategoryName = catName };
            _context.categories.Add(category);
            _context.SaveChanges();
            Console.WriteLine("Category added.");
        }

        public void AddProduct()
        {
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
            _context.products.Add(product);
            _context.SaveChanges();
            Console.WriteLine("Product added.");
        }

        public void AddCustomer()
        {
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
            _context.customrs.Add(customer);
            _context.SaveChanges();
            Console.WriteLine("Customer added.");
        }

        public void AddShippingAddress()
        {
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
            _context.shippingAddresses.Add(address);
            _context.SaveChanges();
            Console.WriteLine("Shipping address added.");
        }

        public void AddPaymentInformation()
        {
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
            _context.paymentInformations.Add(payment);
            _context.SaveChanges();
            Console.WriteLine("Payment information added.");
        }

        public void AddOrder()
        {
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
            _context.orders.Add(order);
            _context.SaveChanges();
            Console.WriteLine("Order added.");
        }

        public void AddOrderItem()
        {
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
            _context.orderItems.Add(orderItem);
            _context.SaveChanges();
            Console.WriteLine("Order item added.");
        }

        public void AddReview()
        {
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
            _context.reviews.Add(review);
            _context.SaveChanges();
            Console.WriteLine("Review added.");
        }
    }
}
