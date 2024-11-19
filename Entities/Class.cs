using ClassAppCS;

namespace ClassAppCS.Entities
{
    internal class Class
    {
        public enum Position
        {
            Guardian,
            SMM,
            Manager,
            Developer,
            Designer
        }

        public class Worker
        {
            private string name;
            private string surname;
            private string birthdate;
            private string email;
            private string phone;
            private string responsibilities;
            private List<Position> positions;

            public Worker(string name, string surname, string birthdate, string email, string phone, string responsibilities, List<Position> positions)
            {
                this.name = name;
                this.surname = surname;
                this.birthdate = birthdate;
                this.email = email;
                this.phone = phone;
                this.responsibilities = responsibilities;
                this.positions = positions ?? new List<Position>();
            }
            public void SetName(string name) => this.name = name;
            public void SetSurname(string surname) => this.surname = surname;
            public void SetBirthdate(string birthdate) => this.birthdate = birthdate;
            public void SetEmail(string email) => this.email = email;
            public void SetPhone(string phone) => this.phone = phone;
            public void SetResponsibilities(string responsibilities) => this.responsibilities = responsibilities;
            public void SetPositions(List<Position> positions) => this.positions = positions;


            //    public string GetName() => name;
            //    public string GetCountry() => country;
            //    public int GetPopulation() => population;
            //    public string GetPhoneCode() => phoneCode;
            //    public List<District> GetDistricts() => districts;

            //    public void DisplayInfo()
            //    {
            //        Console.WriteLine($"City: {name}");
            //        Console.WriteLine($"Country: {country}");
            //        Console.WriteLine($"Population: {population}");
            //        Console.WriteLine($"PhCode: {phoneCode}");
            //        Console.WriteLine("Districts:");
            //        foreach (var district in districts)
            //        {
            //            Console.WriteLine($"- {district}");
            //        }
            //    }
        }
    }
}
