using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("What number should the program count up to?");
            if (!Int32.TryParse(Console.ReadLine(), out n))
                Console.WriteLine("Input must be an integer.");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(ComputeOutput(i));
            }
            Console.ReadLine();
        }

        static string ComputeOutput(int x)
        {
            List<String> words = new List<string>();
            ApplyFizz(words, x);
            ApplyBuzz(words, x);
            ApplyBang(words, x);
            ApplyBong(words, x);
            ApplyFezz(words, x);
            ApplyReverse(words, x);
            if (words.Count == 0)
                words.Add(x.ToString());
            return string.Concat(words);
        }

        static List<String> ApplyFizz(List<String> words, int x)
        {
            if (x % 3 == 0)
                words.Add("Fizz");
            return words;
        }

        static List<String> ApplyBuzz(List<String> words, int x)
        {
            if (x % 5 == 0)
                words.Add("Buzz");
            return words;
        }

        static List<String> ApplyBang(List<String> words, int x)
        {
            if (x % 7 == 0)
                words.Add("Bang");
            return words;
        }

        static List<String> ApplyBong(List<String> words, int x)
        {
            if (x % 11 == 0)
            {
                words.Clear();
                words.Add("Bong");
            }
            return words;
        }

        static List<String> ApplyFezz(List<String> words, int x)
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

        static List<String> ApplyReverse(List<String> words, int x)
        {
            if(x % 17 == 0)
                words.Reverse();
            return words;
        }
    }
}
