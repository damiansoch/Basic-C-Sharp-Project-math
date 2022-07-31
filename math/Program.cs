using System;

namespace math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the whole number!");
            string num1 = Console.ReadLine();
            int num1N = Convert.ToInt32(num1);

            Console.WriteLine(num1N + " multiplied by 50 equals " + num1N * 50);
            Console.WriteLine("\n");

            Console.WriteLine(num1N + " plus 25 = " + num1N + 25);
            Console.WriteLine("\n");

            Console.WriteLine(num1N + " divided by 12.5 = " + (double)num1N / 12.5);
            Console.WriteLine("\n");

            string graterLower = num1N > 50 ? "grater" : "equal or lower";
            Console.WriteLine(num1N + " is " + graterLower + " than " + 50);
            Console.WriteLine("\n");

            Console.WriteLine(num1N + " divided by " + 7 + " gives the remainder of " + num1N % 7);



        }
    }
}
