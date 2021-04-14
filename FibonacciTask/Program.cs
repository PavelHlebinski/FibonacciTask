using System;
using System.Threading.Tasks;

namespace FibonacciTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(1, 6, Calculate.FibParallel);
            Console.ReadKey();
        }
    }
}
