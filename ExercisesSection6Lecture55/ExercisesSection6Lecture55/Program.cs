using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesSection6Lecture55
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Exercise3();
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
    }
}
