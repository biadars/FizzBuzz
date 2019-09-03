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
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0 && i % 5 != 0 && i % 7 != 0
                    && i % 11 != 0 && i % 13 != 0)
                {
                    Console.WriteLine(NonSpecial(i));
                    continue;
                }
                Console.WriteLine(SpecialCase(i));
            }
            Console.ReadLine();
        }
        static int NonSpecial(int x)
        {
            return x;
        }

        static string SpecialCase(int x)
        {
            string msg = "";
            if (x % 3 == 0)
                msg += "Fizz";
            if (x % 5 == 0)
                msg += "Buzz";
            if (x % 7 == 0)
                msg += "Bang";
            if (x % 11 == 0)
                msg = "Bong";
            if (x % 13 == 0)
            {
                int index = msg.LastIndexOf("B");
                if (index < 0)
                    index = msg.Length;
                msg = msg.Insert(index, "Fezz");
            }
            return msg;
        }
    }
}
