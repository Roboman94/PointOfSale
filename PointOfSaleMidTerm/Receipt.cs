using System;

namespace PointOfSaleMidTerm
{
    class Receipt
    {
        public Cart ProductsCart { get; set; }
        public PaymentAbstract PaymentDetails { get; }
        public double Subtotal { get; set; }
        public double SalesTax { get; set; }
        public double GrandTotal { get; set; }

        protected double TaxRate = .06;
        public Receipt(Cart OrderedProducts, PaymentAbstract PaymentDetails)
        {
            this.ProductsCart = OrderedProducts;
            this.PaymentDetails = PaymentDetails;
            this.Subtotal = 0;
            this.SalesTax = 0;
            this.GrandTotal = 0;
        }
        private void DoTotal()
        {
            this.Subtotal = this.ProductsCart.GetTotal();
            double roundsubtotal = Math.Round(Subtotal, 2);
            this.Subtotal = roundsubtotal;
            this.SalesTax = this.Subtotal * this.TaxRate;
            double roundsalestax = Math.Round(SalesTax, 2);
            this.SalesTax = roundsalestax;
            this.GrandTotal = this.Subtotal + this.SalesTax;
            double roundgrandtotal = Math.Round(GrandTotal, 2);
            this.GrandTotal = roundgrandtotal;
        }
        public void Display()
        {
            this.DoTotal();
            PaymentDetails.Display();
            Console.WriteLine($"Subtotal: {Subtotal}\n");
            Console.WriteLine($"Sales Tax @ {TaxRate * 100} % : {SalesTax}\n");
            Console.WriteLine($"Grand Total: {GrandTotal}\n");
        }
    }
}