using ClassAppCS.Entities;
using static ClassAppCS.Entities.Class;

namespace ClassAppCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var districts = new List<District> { District.Center, District.North, District.South };
            var city = new City("Kyiv", "Ukraine", 2800000, "+38044", districts);

            city.DisplayInfo();

               
            city.SetName("Vinnytsia");
            city.SetPopulation(720000);
            city.SetPhoneCode("+380432");

            Console.WriteLine("\nUpdated info:");
            city.DisplayInfo();
            
            city.SetDistricts(new List<District> {District.South, District.Center});
            Console.WriteLine("\nUpdated districts:");
            city.DisplayInfo();
        }
    }
}
