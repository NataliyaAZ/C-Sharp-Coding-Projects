using System;


namespace ClassesAndMethods4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1-3
            MyClass x = new MyClass();
            Console.WriteLine("Please enter any whole number:");
            int userNum = Convert.ToInt32(Console.ReadLine());
            x.DivisionByTwo(userNum);

            //Task 4
            x.OutParameter(out int a);
            Console.WriteLine("The result of the method with output parameter: " + a);
            Console.ReadLine();

            //Task5
            string result1 = x.Overload("test");
            Console.WriteLine("The result is:" + result1);
            int result2  = x.Overload(12);
            Console.WriteLine("The result is:" + result2);
            Console.ReadLine();

            //Task 6
            StClass.Example();
            Console.ReadLine();
        }
    }
}
