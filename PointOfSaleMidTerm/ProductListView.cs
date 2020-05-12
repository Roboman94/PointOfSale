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
                Console.WriteLine($"\t{i,-3}|{p.Name,-16}|{p.Category,-8}|{p.Description,-31}|${p.Price}");
            }
        }
    }
}