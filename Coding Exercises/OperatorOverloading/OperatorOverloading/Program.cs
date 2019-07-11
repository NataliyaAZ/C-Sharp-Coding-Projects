using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee x = new Employee();
            Employee y = new Employee();
            x.Id = 1;
            y.Id = 1;
            if (x == y)
            {
                Console.WriteLine("Employees have the same Id numbers.");
            }
            else
            {
                Console.WriteLine("Employees have different Id numbers.");
            }
            Console.ReadLine();

            x.Id = 1;
            y.Id = 3;
            if (x == y)
            {
                Console.WriteLine("Employees have the same Id numbers.");
            }
            else
            {
                Console.WriteLine("Employees have different Id numbers.");
            }
            Console.ReadLine();
        }
    }
}
