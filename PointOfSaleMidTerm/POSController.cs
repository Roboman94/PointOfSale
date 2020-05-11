using System;
using System.Collections.Generic;

namespace PointOfSaleMidTerm
{
    class POSController
    {
        public List<Product> Products { get; set; }
        public Cart SelectedProducts { get; set; }
        public POSController(List<Product> Products)
        {
            this.Products = Products;
            this.SelectedProducts = new Cart();
        }
        public void ProductAction(Product choice)
        {
            if (InputUtil.GetYesNo("Would you like to order this item?") == false)
            {
                return;
            }

            int qty = InputUtil.ReadInteger("\nHow many would you like?", 0, 25);

            if (qty > 0 && InputUtil.GetYesNo("Add purchase?"))
            {
                this.SelectedProducts.AddProduct(choice, qty);
            }

            if (InputUtil.GetYesNo("\nWould you like to check out?"))
            {
                int method = InputUtil.ReadInteger(
                    "How are you paying today?\n\t1 = cash\n\t2 = check\n\t3 = charge\n\t4 = cancel", 1, 4);
                PaymentAbstract paymentDetails = null;
                switch (method)
                {
                    case 1: paymentDetails = new CashPayment(); break;
                    case 2: paymentDetails = new CheckPayment(); break;
                    case 3: paymentDetails = new CreditPayment(); break;
                    case 4: break;
                }
                if (paymentDetails is null)
                {
                    // user cancelled payment - abort order
                }
                else
                {
                    paymentDetails.GetPayment(SelectedProducts.GetGrandTotal());
                    Receipt rcpt = new Receipt(SelectedProducts, paymentDetails);
                    rcpt.Display();
                    
                    SelectedProducts.Clear();
                }
            }
        }
        public void RunApp()
        {
            ProductListView plv = new ProductListView(this.Products);
            bool continueApp = true;
            while (continueApp)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the POS Console.\n\n");
                plv.Display();
                int productIndex = InputUtil.ReadInteger("\nPlease select a product", 0, plv.Products.Count - 1);
                Product choice = plv.Products[productIndex];
                this.ProductAction(choice);
                continueApp = InputUtil.GetYesNo("\nWould you like to purchase another product? (y/n)");
            }
        }
    }
}