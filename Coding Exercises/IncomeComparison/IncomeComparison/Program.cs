using System;


namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly rate?");
            float hourlyRate1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            float hoursPerWeek1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate?");
            float hourlyRate2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            float hoursPerWeek2 = Convert.ToSingle(Console.ReadLine());
            float annualSalary1 = hourlyRate1 * hoursPerWeek1 * 52;
            float annualSalary2 = hourlyRate2 * hoursPerWeek2 * 52;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool salaryComp = annualSalary1 > annualSalary2;
            Console.WriteLine(salaryComp);
            Console.ReadLine();
        }
    }
}
