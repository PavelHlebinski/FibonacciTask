using System;
using System.Threading.Tasks;

namespace FibonacciTask
{
    public class Calculate
    {
        private static int Fib(int i)
        {
            if (i <= 1)
            {
                return i;
            }
            else
            {
                return Fib(i - 1) + Fib(i - 2);
            }
        }

        public static async void FibAsync(int n)
        {
            Console.WriteLine($"Fibonacci number {n} is {await Task.Run(() => Fib(n))}");
        }

        public static void FibParallel(int i)
        {
            Console.WriteLine($"Task number: {Task.CurrentId}, Fibonacci number {i} is {Fib(i)}");
        }
    }
}
