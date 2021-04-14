using System.Threading.Tasks;

namespace FibonacciTask
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Calculate.FibAsync(5);
             Calculate.FibAsync(7);
             Calculate.FibAsync(9);*/

            Parallel.For(1, 6, Calculate.FibParallel);
        }
    }
}
