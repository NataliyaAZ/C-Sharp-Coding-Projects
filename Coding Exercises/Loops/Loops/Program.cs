using System;


namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Square numbers of 1,2,3...10.Press Enter.");
            Console.ReadLine();
            int x = 1;
            while ( x <=10 )
            {
                double y = Math.Pow(x, 2);
                Console.WriteLine(y);
                x++;
            }
            Console.WriteLine("Cube numbers of 1,2,3...10.Press Enter.");
            Console.ReadLine();
            x = 1;
            do
            {
                double y = Math.Pow(x, 3);
                Console.WriteLine(y);
                x++;
            } while (x <= 10);
            Console.ReadLine();

        }
    }
}
