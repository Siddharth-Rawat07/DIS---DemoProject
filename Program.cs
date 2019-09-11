/*
 Author: Siddharth Rawat
 Date: 9/10/2019
 Comments: This C# Console application code demonstrates the use of 
           iterations statements after getting input from users
*/

using System;

namespace Catch22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many years of experience do you have?");
            try
            {
                int exp = int.Parse(Console.ReadLine());

                for (int i = 0; i < exp; i++)
                {
                    Console.WriteLine("You have " + (i + 1).ToString() + " years of Experience");
                }
                Console.ReadLine();
            }
            catch
            {

                Console.WriteLine("Invalid Input");
                Console.ReadLine();
            }
        }

    }
}
