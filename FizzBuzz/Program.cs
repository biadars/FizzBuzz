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
                if (i % 3 != 0 && i % 5 != 0)
                {
                    WriteNonSpecial(i);
                    continue;
                }
                WriteSpecialCase(i);
            }
            Console.ReadLine();
        }
        static void WriteNonSpecial(int x)
        {
            Console.WriteLine(x);
        }

        static void WriteSpecialCase(int x)
        {
            if (x % 3 == 0)
                Console.Write("Fizz");
            if (x % 5 == 0)
                Console.Write("Buzz");
            Console.Write("\n");
        }
    }
}
