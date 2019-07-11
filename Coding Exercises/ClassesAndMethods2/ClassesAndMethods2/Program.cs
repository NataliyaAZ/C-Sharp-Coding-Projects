using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods2
{
    class Program
    {
        static void Main(string[] args)
        {
            intNumbers number = new intNumbers();
            number.intNumbersOperations(5,23);
            int a = 7;
            int b = 45;
            number.intNumbersOperations(a,b);
        }
    }
}
