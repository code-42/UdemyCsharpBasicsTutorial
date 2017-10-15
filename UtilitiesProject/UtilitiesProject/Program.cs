using System;

namespace UtilitiesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is a really very very long sentence.";
            var summary = StringSummarizer.SummarizeText(sentence, 25);
            Console.WriteLine(summary);
        }
    }
}
