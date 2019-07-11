using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsHandling
{
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age:");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x == 0)
                {
                    throw new ArgumentException();
                }
                if (x < 0)
                {
                    throw new ArithmeticException();
                }
                else
                {
                    int y = 2019 - x;
                    Console.WriteLine("You were born in " + y + " .");
                    Console.ReadLine();
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please do not enter 0.");
                Console.ReadLine();
                return;
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Please do not enter negative number.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Please check if the number you entered is actually your age.");
                Console.ReadLine();
                return;
            }
        }
        
    }
}
