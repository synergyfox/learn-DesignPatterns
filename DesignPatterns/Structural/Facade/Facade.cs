namespace DesignPatterns.Structural.Facade
{
    public class Product
    {

        //Product Subsystem
        public void GetProductDetails()
        {
            Console.WriteLine("Fetching the Product Details");
        }

    }
        //Payment Subsystem
        public class Payment
        {
            public void MakePayment()
            {
                Console.WriteLine("Payment Done Successfully");
            }
        }

        //Invoice Subsystem
        public class Invoice
        {
            public void Sendinvoice()
            {
                Console.WriteLine("Invoice Send Successfully");
            }
        }


        //Create Facade Class
        public class Order { 
        public void PlaceOrder()
        {
            Console.WriteLine("Place order started");
            Product product = new Product();
            product.GetProductDetails();
            Payment payment = new Payment();
            payment.MakePayment();
            Invoice invoice = new Invoice();
            invoice.Sendinvoice();
            Console.WriteLine("Order Placed Successfully");       
        
        }


    }
}
