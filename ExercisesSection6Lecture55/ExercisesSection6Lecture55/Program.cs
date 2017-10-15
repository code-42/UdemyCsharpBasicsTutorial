using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ExercisesSection6Lecture55
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Exercise5();
        }

        /* 
         * 1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

        If no one likes your post, it doesn't display anything.
            If only one person likes your post, it displays: [Friend's Name] likes your post.
            If two people like your post, it displays: [Friend 1]
        and[Friend 2] like your post.
            If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
            Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
        */
        public static void Exercise1()
        {
            var names = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter your friends names (press Enter key to finish): ");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                names.Add(input);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name); 
            }
        }

        public static void Exercise2()
        {
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            var revName = new string(name.ToCharArray().Reverse().ToArray());
            Console.WriteLine(revName);
        }

        // 3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
        public static void Exercise3()
        {
            int[] numArr = new int[5];
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter 5 numbers: ");
                var input = int.Parse(Console.ReadLine());
                if (numArr.Contains(input))
                {
                    Console.WriteLine("Please enter unique numbers.");
                    Array.Resize(ref numArr, numArr.Length - 1);
                    Array.Resize(ref numArr, numArr.Length + 1);
                    i--;
                    continue;
                }
                numArr[i] = input;
            }
            Array.Sort(numArr);
            Console.WriteLine();
            foreach (var num in numArr)
            {
                Console.WriteLine(num);
            }
        }

        // 4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.
        public static void Exercise4()
        {
            var numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number (or type Quit to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "q" || String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("input was " + input);
                    break;
                }
                    
                var number = int.Parse(input);
                numbers.Add(number);
            }

            var uniqueNumbers = numbers.Distinct();
            foreach (var number in uniqueNumbers)
            {
                Console.WriteLine(number);
            }

        }

        // 5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
        public static void Exercise5()
        {
            string[] numbers;
            while (true)
            {
                Console.WriteLine("Enter a list of numbers separated by commas: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    numbers = input.Split(',');
                    if (numbers.Length >= 5)
                        break;
                }
                Console.WriteLine("Invalid List, please re-try");
            }

            var numList = new List<int>();
            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                numList.Add(number);
            }

            numList.Sort();
            var shortList = numList.Take(3);
            foreach (var numbr in shortList)
            {
                Console.WriteLine(numbr);
            }  
        }
    }
}
