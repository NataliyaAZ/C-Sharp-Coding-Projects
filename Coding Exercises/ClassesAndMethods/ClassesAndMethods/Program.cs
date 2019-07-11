using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any whole number to perform the math operations");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int addResult = WholeNumbersOperations.Addition(userNum);
            int multResult = WholeNumbersOperations.Multiplication(userNum);
            int result = WholeNumbersOperations.OddOrEven(userNum);
            Console.WriteLine(userNum + " + " + userNum + " = " + addResult);
            Console.WriteLine(userNum + " * " + userNum + " = " + multResult);
            if (result == 0)
            {
                Console.WriteLine(userNum + " is even number");
            }
            else
            {
                Console.WriteLine(userNum + " is odd number");
            }
            Console.ReadLine();

        }
    }
}
