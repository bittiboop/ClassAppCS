using ClassAppCS;
namespace ClassAppCS.Entities
{
    internal class Class
    {
        public static bool IsPhibonacci(int n)
        {
            if (n < 0) return false;

            return (IsPerfectSquare(5 * n * n + 4) || IsPerfectSquare(5 * n * n - 4));
        }
        private static bool IsPerfectSquare(int x)
        {
            int sqrt = (int)Math.Sqrt(x);
            return sqrt * sqrt == x;
        }
        public static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public static bool IsPhibonacciAndPrime(int n)
        {

            if (IsPhibonacci(n) && IsPrime(n))
            {
                return true;
            }
            return false;

        }
    }
}
