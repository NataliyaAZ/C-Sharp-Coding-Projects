using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsPractice
{
    public struct Number
    {
        public decimal Amount;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Number num;
            num.Amount = 3.23m;
            Console.WriteLine("The amount assigned to the Number type object is: " + num.Amount);
            Console.ReadLine();
        }
    }
}
