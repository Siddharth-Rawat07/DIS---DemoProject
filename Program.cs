using System;

namespace Class2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many years experience do you have ...");
            try
            {
                string input = Console.ReadLine();
                int exp = int.Parse(input);
                if (exp == 0)
                {
                    Console.WriteLine("Need lots of practice");
                    Console.ReadLine();
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey(true);
                }
                else if (exp == 1)
                {
                    Console.WriteLine("Looks LIke you have a little experience");
                    Console.ReadLine();
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey(true);
                }
                else if (exp == 2)
                {
                    Console.WriteLine("Wow! You've been doing this for a little while");
                    Console.ReadLine();
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey(true);
                }
                else if (exp > 2)
                {
                    Console.WriteLine("You are an expert");
                    Console.ReadLine();
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Invalid Input Given");
                    Console.ReadLine();
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input Given");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey(true);
            }
        }
    }
}