using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileInputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any number: ");
            string x = Console.ReadLine();
            File.WriteAllText(@"D:\Natasha\Coding\GitHub\Basic-C-Sharp-Projects\FileInputOutput\Sample.txt", x);
            string y = File.ReadAllText(@"D:\Natasha\Coding\GitHub\Basic-C-Sharp-Projects\FileInputOutput\Sample.txt");
            Console.WriteLine("We are practicing File I/O in C#.This is your number: " + y);
            Console.ReadLine();

        }
    }
}
