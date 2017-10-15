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
s            */
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

            /**
             * 3- Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
             */
            Console.Write("Enter the width and height of an image: ");
            string dimensions = Console.ReadLine();
            string[] valuez = dimensions.Split(' ');
            int width = Convert.ToInt32(valuez[0]);
            int height = Convert.ToInt32(valuez[1]);
            //int orientation = width > height ? Console.WriteLine("Image is landscape") : Console.WriteLine("Image is portrait");
            if (width > height)
            {
                Console.WriteLine("Image is landscape");
            }
            else
            {
                Console.WriteLine("Image is portrait");
            }

            /*
             * 4- Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.
             */
            Console.Write("Enter the speed limit: ");
            int speedLimit;
            speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the speed of car: ");
            int carSpeed;
            carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                int over = carSpeed - speedLimit;
                double demerits = over / 5;

                if (demerits > 12)
                {
                    Console.WriteLine("License Suspended.");
                }
                else
                {
                    Console.WriteLine("Demerits: " + over/5);
                }
                
                
            }
        }
    }
}
