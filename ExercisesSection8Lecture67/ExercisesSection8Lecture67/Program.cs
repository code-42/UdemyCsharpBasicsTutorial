using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesSection8Lecture67
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            byte asc = Convert.ToByte('-');
            Console.WriteLine(asc);
            //Exercise1();
            Exercise2();
        }

        // 1- Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
        public static void Exercise1()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen (ex. 5-6-7-8): ");
            var input = Console.ReadLine();

            var inStr = new List<int>();
            foreach (var ch in input.Split('-'))
            {
                inStr.Add(Convert.ToInt32(ch));
            }
            inStr.Sort();
            foreach (var ch in inStr)
            {
                Console.WriteLine(ch);
            }
            var isConsecutive = true;
            for (var i = 1; i < inStr.Count; i++)
            {
                if (inStr[i] != inStr[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);
        }


        // 2- Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

        public static void Exercise2()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen (ex. 5-6-7-8): ");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
                return;

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
            {
                var dupItems = numbers.Contains(Convert.ToInt32(number));
                if (dupItems)
                {
                    Console.WriteLine("Duplicate found");
                    break;
                }
                numbers.Add(Convert.ToInt32(number));
            }
        }
    }
}
