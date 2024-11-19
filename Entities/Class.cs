using ClassAppCS;

namespace ClassAppCS.Entities
{
    internal class Class
    {
        public enum District
        {
            Center,
            North,
            South,
            East,
            West
        }

        public class City
        {
            private string name;
            private string country;
            private int population;
            private string phoneCode;
            private List<District> districts;

            public City(string name, string country, int population, string phoneCode, List<District> districts)
            {
                this.name = name;
                this.country = country;
                this.population = population;
                this.phoneCode = phoneCode;
                this.districts = districts ?? new List<District>();
            }

            public void SetName(string name) => this.name = name;
            public void SetCountry(string country) => this.country = country;
            public void SetPopulation(int population) => this.population = population;
            public void SetPhoneCode(string phoneCode) => this.phoneCode = phoneCode;
            public void SetDistricts(List<District> districts) => this.districts = districts;

            public string GetName() => name;
            public string GetCountry() => country;
            public int GetPopulation() => population;
            public string GetPhoneCode() => phoneCode;
            public List<District> GetDistricts() => districts;

            public void DisplayInfo()
            {
                Console.WriteLine($"City: {name}");
                Console.WriteLine($"Country: {country}");
                Console.WriteLine($"Population: {population}");
                Console.WriteLine($"PhCode: {phoneCode}");
                Console.WriteLine("Districts:");
                foreach (var district in districts)
                {
                    Console.WriteLine($"- {district}");
                }
            }
        }
    }
}
