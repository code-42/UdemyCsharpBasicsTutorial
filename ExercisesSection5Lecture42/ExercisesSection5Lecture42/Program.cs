using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace ExercisesSection5Lecture42
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1- Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)
s             */
            Console.Write("Enter a number:");
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            if (number > 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            /*
             * 2- Write a program which takes two numbers from the console and displays the maximum of the two.
             */
            Console.Write("Enter two numbers separated by space: ");
            string numbers = Console.ReadLine();
            string[] values = numbers.Split(' ');
            int a = Convert.ToInt32(values[0]);
            int b = Convert.ToInt32(values[1]);
            int max = a > b ? a : b;
            Console.WriteLine("Max number is " + max);

        }
    }
}
