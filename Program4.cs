using EntityFreamworkAssigment.E_Shop.Context;
using EntityFreamworkAssigment.E_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFreamworkAssigment
{
    public class Program4
    {
        static void Main(string[] args)
        {
            ApplicationDbContext _context = new ApplicationDbContext();
            AddFunction addFunction = new AddFunction(_context);
            _context.Database.EnsureCreated();

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

        int userValue = int.Parse(Console.ReadLine());

        switch (userValue)
        {
            case 1:
                addFunction.AddCategory();
                break;
            case 2:
                addFunction.AddProduct();
                break;
            case 3:
                addFunction.AddCustomer();
                break;
            case 4:
                addFunction.AddShippingAddress();
                break;
            case 5:
                addFunction.AddPaymentInformation();
                break;
            case 6:
                addFunction.AddOrder();
                break;
            case 7:
                addFunction.AddOrderItem();
                break;
            case 8:
                addFunction.AddReview();
                break;
            case 0:
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
