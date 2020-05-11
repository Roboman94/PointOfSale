using System;

namespace PointOfSaleMidTerm
{
    class PaymentView
    {
        public PaymentAbstract pa { get; set; }
        public PaymentView(PaymentAbstract pa) //double Subtotal, double Taxes, double GrandTotal)
        {
            this.pa = pa;
        }
        public void Display()
        {
            Console.WriteLine($"Grandtotal = {pa.GrandTotal}");
        }
    }
}