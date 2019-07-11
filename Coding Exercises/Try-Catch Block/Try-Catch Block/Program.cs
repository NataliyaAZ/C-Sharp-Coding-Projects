using System;
using System.Collections.Generic;

namespace Try_Catch_Block
{
    class Program
    {
        static void Main(string[] args)
        {

            input:
            try
            {
                var numList = new List<int>() { 15, 27, 24, 36, 48, 35, 50 };
                Console.WriteLine("Please enter any number: ");
                int userNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Division results:");
                foreach (int num in numList)
                {
                    int result = num / userNum;
                    Console.Write(result);
                    Console.Write(", ");
                }
                Console.Read();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number next time.");
                goto input;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not enter 0 next time");
                goto input;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto input;
            }
            finally
            {
                Console.WriteLine("The program has emerged from the try/catch block and continued on with program execution.Please press Enter.");
                Console.ReadLine();
            }
         
           
        }
    }
}
