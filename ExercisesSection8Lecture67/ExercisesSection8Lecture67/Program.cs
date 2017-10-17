using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ExercisesSection8Lecture67
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
            //Exercise5();
        }

        // 1- Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
        public static void Exercise1()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen (ex. 5-6-7-8): ");
            var input = Console.ReadLine();

            bool isConsecutive = IsConsecutiveList(input);

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);
        }

        public static bool IsConsecutiveList(string input)
        {
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
            return isConsecutive;
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

        // 3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.
        public static void Exercise3()
        {
            Console.WriteLine("enter a time value in the 24-hour time format (e.g. 19:00): ");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }
            if (input.IndexOf(':') == -1)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var timeArr = input.Split(':');
            var hour = Convert.ToByte(timeArr[0]);
            var min = Convert.ToByte(timeArr[1]);
            if (hour > 24  || (hour < 24 && min > 59))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            Console.WriteLine("Ok");
        }

        // 4- Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents". If the user doesn't supply any words, display "Error".
        public static void Exercise4()
        {
            Console.WriteLine("Enter a few words separated by a space: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            var inList = new List<string>();
            foreach (var ch in input.Split(' '))
            {
                inList.Add(ch.ToLower());
            }

            var variableName = "";
            foreach (var word in inList)
            {
                variableName += (word.Substring(0, 1).ToUpper() + "" + word.Substring(1));
            }
            Console.WriteLine();
            Console.WriteLine(variableName);
        }

        // 5- Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.
        public static void Exercise5()
        {
            Console.WriteLine("Enter an English word: ");
            var input = Console.ReadLine().ToLower();

            string[] vowels = { "a", "e", "o", "u", "i" };
            char[] charArray = input.ToCharArray();
            int count = 0;
            foreach (var c in charArray)
            {
                foreach (var v in vowels)
                {
                    if (Convert.ToChar(v) == Convert.ToChar(c))
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
