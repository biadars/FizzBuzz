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
            n = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(ComputeOutput(i));
            }
            Console.ReadLine();
        }

        static string ComputeOutput(int x)
        {
            List<String> words = new List<string>();
            if (x % 3 == 0)
                words.Add("Fizz");
            if (x % 5 == 0)
                words.Add("Buzz");
            if (x % 7 == 0)
                words.Add("Bang");
            if (x % 11 == 0)
            {
                words.Clear();
                words.Add("Bong");
            }
            if (x % 13 == 0)
            {
                int index = words.FindIndex(word => word[0] == 'B');
                if (index < 0)
                    index = words.Count;
                words.Insert(index, "Fezz");
            }
            if (words.Count == 0)
                words.Add(x.ToString());
            if (x % 17 == 0)
                words.Reverse();
            return string.Concat(words);
        }
    }
}
