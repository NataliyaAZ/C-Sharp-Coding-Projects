using InterfacePractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    class Employee:Person, IQuittable
    {

        public void Quit()
        {
            Console.WriteLine("Please submit a proper resignition letter when you would like to quit your job.");
            Console.ReadLine();
        }

        
    }
}
