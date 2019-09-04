using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Options
    {
        public static Dictionary<string, bool> ConstructRules()
        {
            Dictionary<string, bool> options = new Dictionary<string, bool>();
            List<string> rules = new List<String>(new string[] { "fizz", "buzz", "bang", "bong", "fezz", "reverse" });
            for (var i = 0; i < rules.Count; i++)
                options[rules[i]] = false;

            Console.WriteLine("Which rules should be applied? Enter them separated by spaces. (options: fizz, buzz, bang, bong, fezz, reverse)");
            string[] arguments = Console.ReadLine().Split(' ');
            for (int i = 0; i < arguments.Length; i++)
            {
                if (rules.Contains(arguments[i]))
                    options[arguments[i]] = true;
                else
                {
                    throw new Exception("Invalid rule: " + arguments[i]);
                }
            }
            return options;
        }

        public static int GetLimit()
        {
            int n;
            Console.WriteLine("What number should the program count up to?");
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                throw new Exception("Input must be an integer.");
            }
            return n;
        }
    }
}
