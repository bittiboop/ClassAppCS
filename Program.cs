using ClassAppCS.Entities;

namespace ClassAppCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "John";
            Console.WriteLine(person.Name);
        }
    }
}
