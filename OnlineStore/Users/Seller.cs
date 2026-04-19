using System.Collections.Generic;
using OnlineStore.Models;

namespace OnlineStore.Users
{
    public class Seller : User
    {
        public List<Product> Products = new List<Product>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void UpdateOrderStatus(Order order, string status)
        {
            order.Status = status;
        }
    }
}
