using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Id = 1, FirstName = "Joe", LastName = "Willson" });
            employees.Add(new Employee() { Id = 2, FirstName = "Sarah", LastName = "Lee" });
            employees.Add(new Employee() { Id = 3, FirstName = "James", LastName = "Smith" });
            employees.Add(new Employee() { Id = 4, FirstName = "Amy", LastName = "Miller" });
            employees.Add(new Employee() { Id = 5, FirstName = "Nathan", LastName = "Williams" });
            employees.Add(new Employee() { Id = 6, FirstName = "Lisa", LastName = "Davis" });
            employees.Add(new Employee() { Id = 7, FirstName = "David", LastName = "Brown" });
            employees.Add(new Employee() { Id = 8, FirstName = "Susan", LastName = "Jones" });
            employees.Add(new Employee() { Id = 9, FirstName = "Joe", LastName = "Jackson" });
            employees.Add(new Employee() { Id = 10, FirstName = "Bob", LastName = "Johnson" });

            List<Employee> employeesJoe = new List<Employee>();
            foreach (Employee emp in employees)
            {
                if (emp.FirstName == "Joe")
                {
                    employeesJoe.Add(new Employee() { Id = emp.Id, FirstName = emp.FirstName, LastName = emp.LastName });
                }
            }
            //Test: if the new list created 
            foreach (Employee emp in employeesJoe)
            {
                Console.WriteLine(emp.LastName);
             }
            Console.ReadLine();

            //Lambda expression use
            List<Employee> empJoe= employees.FindAll(emp => emp.FirstName == "Joe");

            //Test: if the new list created 
            foreach (Employee emp in employeesJoe)
            {
                Console.WriteLine(emp.LastName);
            }
            Console.ReadLine();

            //Task4 -all employees with Id greater than 5
            List<Employee> empIdOver5 = employees.FindAll(emp => emp.Id>5);

            //Test: if the new list created 
            foreach (Employee emp in empIdOver5)
            {
                Console.WriteLine(emp.FirstName);
            }
            Console.ReadLine();
        }


    }
}
