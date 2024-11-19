using ClassAppCS;

namespace ClassAppCS.Entities
{
    internal class NumRange
    {
        public static int Product(int startPr, int endPr)
        {
            int product = 1;
            for (int i = startPr; i <= endPr; i++)
            {
                product *= i;
            }
            return product;
        }

    }
}
