using System;
using System.Reflection;

namespace ExercisesSection5Lecture48
{
    public class Program
    {
        static void Main(string[] args)
        //public void Exercise1()
        //   1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.

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

        // 2- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
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

        // 3- Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
        private static void factorial()
        {
            Console.Write("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;
            for (var i = 1; i <= number; i++)
                factorial *= i;

            Console.WriteLine("{0}! = {1}", number, factorial);
        }


        // 4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)
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


        // 5- Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
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
