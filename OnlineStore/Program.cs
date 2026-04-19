using System;
using OnlineStore.Models;
using OnlineStore.Users;

class Program
{
    static void Main()
    {
        var product = new Product { Name = "Laptop", Price = 1000, Discount = 0.1 };

        var customer = new Customer { Name = "Ali" };
        customer.AddToCart(product);

        var order = customer.CreateOrder();

        Console.WriteLine(order.GetTotal());

        customer.CancelOrder(order);
        Console.WriteLine(order.Status);
    }
}
