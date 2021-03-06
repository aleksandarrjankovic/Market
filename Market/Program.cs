using System;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            var bronze = new Bronze(0,150);
            Console.WriteLine("Purchase value  : $"+bronze.purchaseValue);
            Console.WriteLine("Discount rate : " + bronze.DiscountRate() + "%");
            Console.WriteLine("Discount : $"+ bronze.Discount());
            Console.WriteLine("Total : $" + bronze.TotalPurchase());

            Console.WriteLine("\n");
            var silver = new Silver(600, 850);
            Console.WriteLine("Purchase value  : $" + silver.purchaseValue);
            Console.WriteLine("Discount rate : " + silver.DiscountRate() + "%");
            Console.WriteLine("Discount : $" + silver.Discount());
            Console.WriteLine("Total : $" + silver.TotalPurchase());

            Console.WriteLine("\n");

            var gold = new Gold(400, 1300);
            Console.WriteLine("Purchase value  : $" + gold.purchaseValue);
            Console.WriteLine("Discount rate : " + gold.DiscountRate() + "%");
            Console.WriteLine("Discount : $" + gold.Discount());
            Console.WriteLine("Total : $" + gold.TotalPurchase());

            Console.WriteLine("\n");

        }
    }
}
