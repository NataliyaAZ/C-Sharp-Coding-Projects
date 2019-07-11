using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee x = new Employee();
            x.FirstName = "Sample";
            x.LastName = "Student";
            x.SayName();
        }
    }
}
