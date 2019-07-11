using System;
using System.Text;


namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your favourite 3 colors.");
            Console.WriteLine("Color 1:");
            string color1 = Console.ReadLine();
            Console.WriteLine("Color 2:");
            string color2 = Console.ReadLine();
            Console.WriteLine("Color 3:");
            string color3 = Console.ReadLine();
            Console.WriteLine("Your colors are: " + color1.ToUpper() + " " + color2.ToUpper() + " " + color3.ToUpper());
            Console.WriteLine("Morning Poem.Please press Enter");
            Console.ReadLine();
            StringBuilder pr = new StringBuilder();
            pr.AppendLine("Bad Day? Coffee.");
            pr.AppendLine("Good Day? Coffee.");
            pr.AppendLine("Stressed? Coffee.");
            pr.AppendLine("Happy? Coffee.");
            pr.AppendLine("Inspired? Coffee.");
            pr.AppendLine("YOU CAN DO IT!");
            pr.AppendLine("          -Coffee");
            Console.WriteLine(pr);
            Console.ReadLine();
        }
    }
} 
