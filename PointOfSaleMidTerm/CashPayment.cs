using System;

namespace PointOfSaleMidTerm
{
    class CashPayment : PaymentAbstract
    {
        public double AmountTendered { get; set; }
        public double Change { get; set; }
        public CashPayment()
        {
            base.GrandTotal = GrandTotal;
            this.AmountTendered = 0;
            this.Change = 0;
        }
        public override void GetPayment(double grandtotal)
        {
            grandtotal = Math.Round(grandtotal, 2);
            this.GrandTotal = grandtotal;
            double roundgrandtotal = Math.Round(GrandTotal, 2);
            this.GrandTotal = roundgrandtotal;
            this.AmountTendered = InputUtil.ReadDouble($"Total is ${grandtotal}\nCash amount: ", grandtotal, 10000);
            this.Change = this.AmountTendered - grandtotal;
            double roundchange = Math.Round(Change, 2);
            this.Change = roundchange;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"\tAmountTendered: ${AmountTendered}\n\tChange: ${Change}\n");
        }
    }
}