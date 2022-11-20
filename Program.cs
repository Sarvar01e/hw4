using System;

namespace hw4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");

            int number;

            number = int.Parse(Console.ReadLine());

            if( number%2 == 0)
            {
                Console.WriteLine("Your number is honest");
            }
            else
            {
                Console.WriteLine("Your number is odd");
            }
   


        }
    }
}