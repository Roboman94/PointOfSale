using System;

namespace PointOfSaleMidTerm
{
    abstract class PaymentAbstract
    {
        public double GrandTotal { get; set; }
        public PaymentAbstract()
        {
            this.GrandTotal = 0;
        }
        public abstract void GetPayment(double GrandTotal);
        public virtual void Display()
        {
            Console.WriteLine($"\tGrandtotal {GrandTotal}\n");
        }
    }
}