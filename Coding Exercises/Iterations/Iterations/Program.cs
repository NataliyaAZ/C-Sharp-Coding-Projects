using System;
using System.Collections.Generic;


namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //string[] fruitsArray = { "Apple", "Pear", "Mango" };
            //Console.Write("Please type the color - red, yellow,green or orange:");
            //string color = Console.ReadLine();
            //for (int i = 0; i < fruitsArray.Length; i++)
            //{
            //    fruitsArray[i] = color + fruitsArray[i]; 
            //}
            //foreach (string fruit in fruitsArray)
            //{
            //    Console.WriteLine(fruit);
            //}
            //Console.ReadLine();


            //Task2 -Infinite Loop
            //while (true)
            //{
            //    Console.WriteLine("Hello!");
            //}


            //Task3
            //int i = 1;
            //while (true)
            //{
            //    Console.WriteLine("Hello!");
            //    i++;
            //    if (i > 3)
            //        break;
            // }
            //Console.ReadLine();


            //Task4
            //int n = 0;
            //while (n < 3)
            //{
            //    Console.WriteLine("Hello!");
            //    n++;
            //}
            //Console.ReadLine();


            //Task5
            //int n = 0;
            //while (n <= 2)
            //{
            //   Console.WriteLine("Hello!");
            //   n++;
            //}
            //Console.ReadLine();


            //Task6
            //List<string> petsList = new List<string>();
            //petsList.Add("cat");
            //petsList.Add("dog");
            //petsList.Add("rabbit");
            //petsList.Add("lizard");
            //Console.WriteLine("Please select a pet you would like to have: cat, dog, rabbit or lizard");
            //string petChoice = Console.ReadLine();
            //for (int i = 0; i < petsList.Count; i++)
            //{
            //    if (petsList[i] == petChoice)
            //    {
            //        Console.WriteLine("Index for the pet you selected is: " + i);
            //    }
            //}
            //Console.ReadLine();


            ////Task7
            //List<string> petsList = new List<string>();
            //petsList.Add("cat");
            //petsList.Add("dog");
            //petsList.Add("rabbit");
            //petsList.Add("lizard");
            //Console.WriteLine("Please select a pet you would like to have: cat, dog, rabbit or lizard");
            //string petChoice = Console.ReadLine();
            //bool x = false;
            //for (int i = 0; i < petsList.Count; i++)
            //{
            //    if (petsList[i] == petChoice)
            //    {
            //        Console.WriteLine("Index for the pet you selected is: " + i);
            //        x = true;
            //    }

            //}
            //if (x == false)
            //{
            //    Console.WriteLine("The pet is not in the list");
            //}
            //Console.ReadLine();


            ////Task8
            //List<string> petsList = new List<string>();
            //petsList.Add("cat");
            //petsList.Add("dog");
            //petsList.Add("rabbit");
            //petsList.Add("lizard");
            //Console.WriteLine("Please select a pet you would like to have: cat, dog, rabbit or lizard");
            //string petChoice = Console.ReadLine();
            //bool x = false;
            //for (int i = 0; i < petsList.Count; i++)
            //{
            //    if (petsList[i] == petChoice)
            //    {
            //        Console.WriteLine("Index for the pet you selected is: " + i);
            //        x = true;
            //        break;
            //    }
            //}
            //if (x == false)
            //{
            //    Console.WriteLine("The pet is not in the list");
            //}
            //Console.ReadLine();


            ////Task9
            //List<string> petsList = new List<string>();
            //petsList.Add("cat");
            //petsList.Add("dog");
            //petsList.Add("rabbit");
            //petsList.Add("cat");
            //petsList.Add("lizard");
            //Console.WriteLine("Please select a pet you would like to have: cat, dog, rabbit or lizard");
            //string petChoice = Console.ReadLine();
            //List<int> indices = new List<int>();
            //for (int i = 0; i < petsList.Count; i++)
            //{
            //    if (petsList[i] == petChoice)
            //    {
            //        indices.Add(i);
            //    }

            //}
            //Console.WriteLine("Indices for the pet you selected are: ");
            //indices.ForEach(Console.WriteLine);
            //Console.ReadLine();


            ////Task10
            //List<string> petsList = new List<string>();
            //petsList.Add("cat");
            //petsList.Add("dog");
            //petsList.Add("rabbit");
            //petsList.Add("cat");
            //petsList.Add("lizard");
            //petsList.Add("dog");
            //Console.WriteLine("Please select a pet you would like to have: cat, dog, rabbit or lizard");
            //string petChoice = Console.ReadLine();
            //bool x = false;
            //List<int> indices = new List<int>();
            //for (int i = 0; i < petsList.Count; i++)
            //{
            //    if (petsList[i] == petChoice)
            //    {
            //        x = true;
            //        indices.Add(i);
            //    }
            //}
            //if (x == false)
            //{
            //    Console.WriteLine("The pet is not in the list");
            //}
            //else
            //{
            //    Console.WriteLine("Indices for the pet you selected are: ");
            //    indices.ForEach(Console.WriteLine);
            //}
            //Console.ReadLine();


            //Task11
            var petsList = new List<string>() { "cat", "dog", "rabbit", "cat", "dog", "lizard", "dog" };
            Console.WriteLine("Please select a pet you would like to have: cat, dog, rabbit or lizard");
            string petChoice = Console.ReadLine();
            int count = 0;
            foreach (string pet in petsList)
            {
                if (pet == petChoice)
                {
                    count++;
                }
            }
            if (count > 1)
            {
                Console.WriteLine("There are " + count + " " + petChoice + "s in the list.");
                Console.ReadLine();
            }
        }
    }
}