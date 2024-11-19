using ClassAppCS.Entities;

namespace ClassAppCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3 };
            Console.WriteLine("Original array:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Choose by descending or ascending: ");
            string choice = Console.ReadLine();
            if (choice == "ascending")
            {
                Class.SortArray(arr, true);
            }
            else if (choice == "descending")
            {
                Class.SortArray(arr, false);
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }

        }
    }
}
