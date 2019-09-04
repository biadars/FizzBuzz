using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class OutputCalculator
    {
        public static string ComputeOutput(int x, Dictionary<String, bool> options)
        {
            List<String> words = new List<string>();
            if (options["fizz"])
                ApplyFizz(words, x);
            if (options["buzz"])
                ApplyBuzz(words, x);
            if (options["bang"])
                ApplyBang(words, x);
            if (options["bong"])
                ApplyBong(words, x);
            if (options["fezz"])
                ApplyFezz(words, x);
            if (options["reverse"])
                ApplyReverse(words, x);
            if (words.Count == 0)
                words.Add(x.ToString());
            return string.Concat(words);
        }

        private static List<String> ApplyFizz(List<String> words, int x)
        {
            if (x % 3 == 0)
                words.Add("Fizz");
            return words;
        }

        private static List<String> ApplyBuzz(List<String> words, int x)
        {
            if (x % 5 == 0)
                words.Add("Buzz");
            return words;
        }

        private static List<String> ApplyBang(List<String> words, int x)
        {
            if (x % 7 == 0)
                words.Add("Bang");
            return words;
        }

        private static List<String> ApplyBong(List<String> words, int x)
        {
            if (x % 11 == 0)
            {
                words.Clear();
                words.Add("Bong");
            }
            return words;
        }

        private static List<String> ApplyFezz(List<String> words, int x)
        {
            if (x % 13 == 0)
            {
                int index = words.FindIndex(word => word[0] == 'B');
                if (index < 0)
                    index = words.Count;
                words.Insert(index, "Fezz");
            }
            return words;
        }

        private static List<String> ApplyReverse(List<String> words, int x)
        {
            if (x % 17 == 0)
                words.Reverse();
            return words;
        }
    }
}
