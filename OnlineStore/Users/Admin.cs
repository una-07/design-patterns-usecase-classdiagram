using System.Collections.Generic;
using OnlineStore.Models;

namespace OnlineStore.Users
{
    public class Admin : User
    {
        public void DeleteProduct(List<Product> products, Product product)
        {
            products.Remove(product);
        }

        public void BlockUser(User user)
        {
            user.IsBlocked = true;
        }
    }
}
