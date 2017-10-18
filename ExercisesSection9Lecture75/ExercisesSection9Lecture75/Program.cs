using System;
using System.Collections.Generic;
using System.IO;

namespace ExercisesSection9Lecture75
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = (@"C:\C_sharp_projects\UdemyCsharpBasicsTutorial\ExercisesSection9Lecture75\ExercisesSection9Lecture75.txt");
            var fileInfo = new FileInfo(path);
            var content = File.ReadAllText(path);
            if (fileInfo.Exists)
            {
                Console.WriteLine(CountWords(content));
                Console.WriteLine(DisplayLongestWord(content));
            }
        }

        // 1- Write a program that reads a text file and displays the number of words. 
        public static int CountWords(string content)
        {
            var counter = 0;
            foreach (var word in content.Split(' '))
            {
                counter++;
            }
            return counter;
        }


        // 2- Write a program that reads a text file and displays the longest word in the file.
        public static string DisplayLongestWord(string content)
        {
            var wordList = new List<string>();
            foreach (var word in content.Split(' '))
            {
                wordList.Add(word);
            }

            string longestWord = " ";
            int wordLength = longestWord.Length;
            foreach (var word in wordList)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }              
            }
            return longestWord;
        }
    }
}
