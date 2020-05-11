using System.Collections.Generic;

namespace PointOfSaleMidTerm
{
    class Cart
    {
        Dictionary<Product, int> Items { get; set; }
        public Cart()
        {
            this.Items = new Dictionary<Product, int>();
        }
        public void AddProduct(Product product, int qty)
        {
            bool found = false;
            foreach (Product item in Items.Keys)
            {
                if (item.Name == product.Name)
                {
                    Items[item] += qty;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Items.Add(product, qty);
            }
        }
        public double GetTotal()
        {
            double total = 0;
            foreach (Product item in Items.Keys)
            {
                double qty = Items[item];
                total += item.Price * qty;
            }
            return total;
        }
        public double GetGrandTotal()
        {
            double grandtax = GetTotal() * .06;
            double grandtotal = grandtax + GetTotal();
            return grandtotal;

        }
        public void Clear()
        {
            this.Items.Clear();
        }
    }
}