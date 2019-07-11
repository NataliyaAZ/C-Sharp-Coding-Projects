using System;


namespace OptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            IntParameters x = new IntParameters();
            Console.WriteLine("Please enter first number then press Enter: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number or leave it blank and press Enter: ");
            string str = Console.ReadLine();
            int result;
            if (str == "")
            {
                result = x.MathOperation(firstNum);
            }
            else
            {
                int secondNum = Convert.ToInt32(str);
                result = x.MathOperation(firstNum,secondNum);
            }
            
            Console.WriteLine("The result of the math operation: " + result);
            Console.ReadLine();
        }
    }
}
