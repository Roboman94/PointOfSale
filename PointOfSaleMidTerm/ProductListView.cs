using System;
using System.Collections.Generic;

namespace PointOfSaleMidTerm
{
    class ProductListView
    {
        public List<Product> Products { get; set; }
        public ProductListView(List<Product> Products)
        {
            this.Products = Products;
        }
        public void Display()
        {
            for (int i = 0; i < this.Products.Count; i++)
            {
                Product p = this.Products[i];
                Console.WriteLine($"\t{i}\t{p.Name}\t{p.Category}\t{p.Description}\t{p.Price}");
            }
        }
    }
}