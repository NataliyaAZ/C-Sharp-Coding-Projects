using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddFeaturesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            const int x = 5;
            var str = "This is test 1";

            Chain testOne = new Chain(str,x);
            Chain testTwo = new Chain("This is test 2");

            Console.WriteLine(testOne.outputText + ", " + testOne.outputInt);
            Console.WriteLine(testTwo.outputText + ", " + testTwo.outputInt);
            Console.ReadLine();



        }
    }
}
