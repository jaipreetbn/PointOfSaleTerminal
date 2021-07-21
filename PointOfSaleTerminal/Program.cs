using System;

namespace PointOfSale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Point Of Sale Terminal!");

            PointOfSaleTerminal terminal = new PointOfSaleTerminal();
            terminal.SetPricing();


            var availableProducts = terminal.GetAvailableProducts();
            Console.WriteLine("Available Products are : " + String.Join(",", availableProducts));
            Console.WriteLine("Please Enter product code for scanning ");
            var key = Console.ReadKey();
            do
            {
                while (!availableProducts.Contains(char.ToUpper(key.KeyChar)) && key.Key != ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    Console.WriteLine("This is invalid code. Please Provide code from available products or press <Enter> to calculate price");
                    key = Console.ReadKey();
                }

                if (key.Key == ConsoleKey.Enter)
                    break;

                terminal.ScanProduct(char.ToUpper(key.KeyChar));
                Console.WriteLine();
                Console.WriteLine(" Please provide code from available products or press <Enter> to calculate price");
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Enter);

            var result = terminal.CalculateTotal();
            Console.WriteLine();
            Console.WriteLine("Result is : $" + result.ToString());
            Console.ReadKey();
        }
    }
}
