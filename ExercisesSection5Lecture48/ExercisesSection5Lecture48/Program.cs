using System;
using System.Reflection;

namespace ExercisesSection5Lecture48
{
    public class Program
    {
        static void Main(string[] args)
        //public void Exercise1()
        {
            int count = 0;
            for (var i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
            Exercise5();
        }

        private static void Exercise2()
        {
            var sum = 0;
            while (true)
            {
                Console.Write("Enter a number (or 'ok' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);
            }

            Console.WriteLine(sum);

        }

        private static void factorial()
        {
            Console.Write("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;
            for (var i = 1; i <= number; i++)
                factorial *= i;

            Console.WriteLine("{0}! = {1}", number, factorial);
        }

        private static void Exercise4()
        {
            var random = new Random().Next(1, 10);

            for (var i = 0; i < 4; i++)
            {
                Console.Write("guess the number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (number == random)
                {
                    Console.WriteLine("You guessed right!");
                    return;
                } 
            }
            Console.WriteLine("You lose");
        }

        private static void Exercise5()
        {
            Console.WriteLine("Enter some numbers separated by commas: ");
            var input = Console.ReadLine();
            var numbers = input.Split(',');

            var max = Convert.ToInt32(numbers[0]);
            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine("Max is " + max);

        }
    }
}
