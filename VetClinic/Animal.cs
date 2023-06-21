using System.Data.Entity;

namespace VetClinic
{
    public class Animal
    {
        public int Id { get; set; }
        public string AnimalName { get; set; }
        public bool Vaccinations { get; set; }
    }
}