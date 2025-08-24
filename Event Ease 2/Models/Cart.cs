using System.Text.Json;
using Event_Ease_2.Models; 

namespace Event_Ease_2.Models
{
    public class Cart
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(int productId)
        {
            var product = Products.FirstOrDefault(p => p.ProductID == productId);
            if (product != null)
            {
                Products.Remove(product);
            }
        }

        public void DisplayCartItems()
        {
            foreach (var p in Products)
            {
                Console.WriteLine(p.GetDetails());
            }
        }

        public decimal CalculateTotal()
        {
            return Products.Sum(p => p.Price);
        }
    }
}
