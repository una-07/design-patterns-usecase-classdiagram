namespace OnlineStore.Models
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }

        public double GetFinalPrice()
        {
            return Price - (Price * Discount);
        }
    }
}
