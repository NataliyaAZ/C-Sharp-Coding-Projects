using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    class Program
    {
        static void Main(string[] args)
        {   //Task1-2
            //Employee x = new Employee();
            //x.Quit();

            //Task3
            IQuittable y = new Employee();
            y.Quit();

        }
    }
}
