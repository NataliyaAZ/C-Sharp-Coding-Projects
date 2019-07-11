using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatTimePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTimeNow = DateTime.Now;
            Console.WriteLine(dateTimeNow);
            Console.ReadLine();

            Console.WriteLine("Please enter a whole number:");
            double x = Convert.ToDouble(Console.ReadLine());
            DateTime newDateTime = dateTimeNow.AddHours(x);

            Console.WriteLine("The date and time in {0} hours will be {1}.", x, newDateTime);
            Console.ReadLine();
        }
    }
}
