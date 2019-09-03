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
            Dictionary<String, bool> options = new Dictionary<string, bool>();
            List<String> rules = new List<String>(new string[] { "fizz", "buzz", "bang", "bong", "fezz", "reverse"});
            for (var i = 0; i < rules.Count; i++)
                options[rules[i]] = false;

            Console.WriteLine("What number should the program count up to?");
            if (!Int32.TryParse(Console.ReadLine(), out n)) {
                Console.WriteLine("Input must be an integer.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Which rules should be applied? (options: fizz, buzz, bang, bong, fezz, reverse)");
            String[] arguments = Console.ReadLine().Split(' ');
            for (int i = 0; i < arguments.Length; i++)
            {
                if (rules.Contains(arguments[i]))
                    options[arguments[i]] = true;
                else
                {
                    Console.WriteLine("Invalid rule: " + arguments[i]);
                    Console.ReadLine();
                    return;
                }
            }
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(ComputeOutput(i, options));
            }
            Console.ReadLine();
        }

        static string ComputeOutput(int x, Dictionary<String, bool> options)
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
