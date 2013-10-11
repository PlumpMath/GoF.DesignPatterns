using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfValues = new Random().Next(5, 50);
            Console.WriteLine("Generating a Fibonacci sequence with {0} itens.", numberOfValues);

            var sequence = new FibonacciSequence(numberOfValues);

            var enumerator = sequence.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            Console.ReadKey();

        }
    }
}
