using System.Collections.Generic;
using System.Linq;

namespace OnlineStore.Models
{
    public class Order
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public string Status { get; set; } = "Created";

        public double GetTotal()
        {
            return Products.Sum(p => p.GetFinalPrice());
        }
    }
}
