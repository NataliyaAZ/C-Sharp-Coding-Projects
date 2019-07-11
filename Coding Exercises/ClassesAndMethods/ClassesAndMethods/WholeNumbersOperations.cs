using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods
{
    class WholeNumbersOperations
    {
       
        public static int Addition(int num)
        {
            int result = num + num;
            return result;
        }
                
        public static int Multiplication(int num)
        {
            int result = num * num;
            return result;
        }

        public static int OddOrEven(int num)
        {
            int result = num % 2;
            return result;
        }

    }
}