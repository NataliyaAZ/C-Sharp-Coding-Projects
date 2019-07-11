using System;

namespace ClassesAndMethods3
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers x = new Numbers();
            int result1 = x.Operation1(12);
            Console.WriteLine(" The result of the first method: " + result1);
            Console.ReadLine();
            decimal result2 = x.Operation2(24.565m);
            Console.WriteLine(" The result of the second method: " + result2);
            Console.ReadLine();
            int result3 = x.Operation3("345");
            Console.WriteLine(" The result of the third method: " + result3);
            Console.ReadLine();
        }
    }
}
