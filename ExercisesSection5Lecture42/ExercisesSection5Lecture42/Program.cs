using System;

namespace ExercisesSection5Lecture42
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
