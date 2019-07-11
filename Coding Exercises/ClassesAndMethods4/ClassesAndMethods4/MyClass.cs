using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods4
{
    class MyClass
    {
        public void DivisionByTwo(int num)
        {
            int result = num / 2;
            Console.WriteLine("Your number divided by 2 = " + result);
            Console.ReadLine();
        }

        public void OutParameter(out int num )
        {
            num = 10;
            for (int i = 1; i < 10; i++)
            {
                num = num + 10;
            }
        }

        public int Overload(int x)
        {
            int result = x / 2;
            return result;
        }

        public string Overload(string x)
        {
            string result = x + 123;
            return result;
        }
    }
}
