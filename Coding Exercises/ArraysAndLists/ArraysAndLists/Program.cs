using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rainbowArray = { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };
            Console.WriteLine("Please select index for the rainbow colors:");
            int index = Convert.ToInt32(Console.ReadLine());
            if (index > (rainbowArray.Length - 1))
            {
                Console.WriteLine("Where are only seven colors in the Rainbow.");
                Console.WriteLine("Please press Enter");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(rainbowArray[index]);
                Console.WriteLine("Please press Enter");
                Console.ReadLine();
            }

            int[] evenArray = { 2, 4, 6, 8, 10 };
            Console.WriteLine("Please select index to display number from even numbers array");
            int indexInt = Convert.ToInt32(Console.ReadLine());
            if (indexInt > (evenArray.Length - 1))
            {
                Console.WriteLine("Where are only 5 even numbers in the array.");
                Console.WriteLine("Please press Enter");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(evenArray[indexInt]);
                Console.WriteLine("Please press Enter");
                Console.ReadLine();
                
            }

            List<string> weekDays = new List<string>();
            weekDays.Add("Monday");
            weekDays.Add("Tuesday");
            weekDays.Add("Wednesday");
            weekDays.Add("Thursday");
            weekDays.Add("Friday");
            weekDays.Add("Saturday");
            weekDays.Add("Sunday");
            Console.WriteLine("Please select index from 0 to 6 to display a weekday");
            int indexDay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(weekDays[indexDay]);
            Console.ReadLine();
            
        }
    }
}
