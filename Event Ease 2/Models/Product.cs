namespace Event_Ease_2.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Category { get; set; } = string.Empty;

        public string GetDetails()
        {
            return $"Product: {Name} | Price: ${Price:F2} | Category: {Category}";
        }
    }
}
