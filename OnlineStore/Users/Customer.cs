using System.Collections.Generic;
using OnlineStore.Models;

namespace OnlineStore.Users
{
    public class Customer : User
    {
        public List<Product> Cart = new List<Product>();

        public void AddToCart(Product product)
        {
            Cart.Add(product);
        }

        public Order CreateOrder()
        {
            return new Order { Products = Cart };
        }

        public void CancelOrder(Order order)
        {
            order.Status = "Cancelled";
        }
    }
}
