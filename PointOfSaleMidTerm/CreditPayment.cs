using System;

namespace PointOfSaleMidTerm
{
    class CreditPayment : PaymentAbstract
    {
        public string CreditCardNumber { get; set; }
        public DateTime Expiration { get; set; }
        public string Cvv { get; set; }
        public CreditPayment()
        {
            base.GrandTotal = GrandTotal;
            CreditCardNumber = "";
            Expiration = DateTime.Today;
            Cvv = "";
        }
        public override void GetPayment(double grandtotal)
        {
            grandtotal = Math.Round(grandtotal, 2);
            base.GrandTotal = grandtotal;
            this.CreditCardNumber = InputUtil.GetInputString("Credit card number: ");
            this.Expiration = InputUtil.GetInputDate("Expiration date (mm/dd/yyyy) :");
            this.Cvv = InputUtil.GetInputString("CVV: ");
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Credit card number: {this.CreditCardNumber}");
            Console.WriteLine($"Expiration: {this.Expiration}");
            Console.WriteLine($"Cvv: {this.Cvv}\n");
        }
    }
}