
namespace PointOfSaleMidTerm
{
    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Qty { get; set; }
        public Product(string name, string category, string description, double price, double qty)
        {
            Name = name;
            Category = category;
            Description = description;
            Price = price;
            Qty = qty;
        }
    }
}