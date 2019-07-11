using System;


namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            float weight = Convert.ToSingle(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                float width = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                float height = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                float length = Convert.ToSingle(Console.ReadLine());
                float sum = width + height + length;
                if (sum > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    float quote = sum*weight/100;
                    Console.WriteLine("Your estimated total for shipping this package is: $"+Math.Round(quote,2));
                    Console.ReadLine();
                }
            }
        }
    }
}
