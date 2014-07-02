using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            var list = Enumerable.Range(1, 100)
                .Select(n =>
                {
                    if (n % 15 == 0)
                    {
                        return "FizzBuzz";
                    }
                    if (n % 3 == 0)
                    {
                        return "Fizz";
                    }
                    if (n % 5 == 0)
                    {
                        return "Buzz";
                    }
                    return n.ToString();
                });

            foreach (string item in list)
                Console.WriteLine(item);
            Console.ReadKey();


        }
    }
}
