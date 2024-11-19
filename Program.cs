using ClassAppCS.Entities;

namespace ClassAppCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 5;
            int product = NumRange.Product(start, end);
            Console.WriteLine($"Product of numbers from {start} to {end} is {product}");
        }
    }
}
