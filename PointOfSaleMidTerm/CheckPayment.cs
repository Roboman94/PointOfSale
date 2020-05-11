using System;

namespace PointOfSaleMidTerm
{
    class CheckPayment : PaymentAbstract
    {
        public string CheckNumber { get; set; }
        public CheckPayment()
        {
            base.GrandTotal = 0;
            this.CheckNumber = "";
        }
        public override void GetPayment(double grandtotal)
        {
            this.GrandTotal = grandtotal;
            this.CheckNumber = InputUtil.GetInputString("Check number: ");
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"\nCheck number: {CheckNumber}\n");
        }
    }
}