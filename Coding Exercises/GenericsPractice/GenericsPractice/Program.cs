using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee <string> strList = new Employee<string>();
            strList.Things = new List<string>();
            strList.Things.Add("thing1");
            strList.Things.Add("thing2");
            strList.Things.Add("thing3"); 

            Employee<int> intList = new Employee<int>();
            intList.Things = new List<int>();
            intList.Things.AddRange(new int[] { 10, 20, 30,40,50 });

            Console.WriteLine("All Things:");

            foreach (string thing in strList.Things)
            {
                Console.WriteLine(thing);
            }
            foreach (int thing in intList.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
