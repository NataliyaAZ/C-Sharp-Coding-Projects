using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EnumsPractice
{
    class Program
    {
        [FlagsAttribute]
        enum WeekDays
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

        static void Main(string[] args)
        {   
            start:
            Console.WriteLine("Please enter any week day:");
            string weekDay = Console.ReadLine();
            WeekDays day;
            try
            {
                day = (WeekDays)Enum.Parse(typeof(WeekDays), weekDay);
                Console.WriteLine("This is " + weekDay);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                goto start;
                   
            }
            
            
        }
    }
}
