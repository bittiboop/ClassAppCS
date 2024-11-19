using ClassAppCS;
namespace ClassAppCS.Entities
{
    internal class Class
    {
        public static void SortArray(int[] arr, bool isAscending)
        {
            if (isAscending)
            {
                Array.Sort(arr); 
                Console.WriteLine("The array is sorted in ascending order:");
            }
            else if (!isAscending)
            {
                Array.Sort(arr);
                Array.Reverse(arr); 
                Console.WriteLine("The array is sorted in descending order:");
            }

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
