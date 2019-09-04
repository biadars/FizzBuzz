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
            Dictionary<string, bool> options = new Dictionary<string, bool>();
            try
            {
                n = Options.GetLimit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                return;
            }
            try
            {
                options = Options.ConstructRules();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(OutputCalculator.ComputeOutput(i, options));
            }
            Console.ReadLine();
        }
    }
}
