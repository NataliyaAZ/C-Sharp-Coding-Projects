using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any number:");
            double inputNum = Convert.ToDouble(Console.ReadLine());
            double mult = inputNum * 50;
            Console.WriteLine("Your number multiplied by 50 = " + mult);
            double add = inputNum + 25;
            Console.WriteLine("Your number plus 25 = " + add);
            double div = inputNum / (double)12.5;
            Console.WriteLine("Your number divided by 12.5 = " + div);
            bool check = inputNum > 50;
            Console.WriteLine("Your number is greater than 50: " + check);
            double reminder = inputNum % 7;
            Console.WriteLine("Your number was divided by 7 and the reminder is: " + reminder);
            Console.ReadLine();


        }
    }
}
