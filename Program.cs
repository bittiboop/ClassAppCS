using ClassAppCS.Entities;

namespace ClassAppCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            bool result = Class.IsPhibonacciAndPrime(num);
            Console.WriteLine($"Number {num} is a Phibonacci number and prime: {result}");

            num = 14;
            result = Class.IsPhibonacciAndPrime(num);
            Console.WriteLine($"Number {num} is a Phibonacci number and prime: {result}");
        }
    }
}
