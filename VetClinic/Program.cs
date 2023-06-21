using System;
using System.Data.Entity;

namespace VetClinic
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (UserContext db = new UserContext())
            {
                
                Animal cat = new Animal { AnimalName = "Cat", Vaccinations = true };

                db.Animal.Add(cat);
                db.SaveChanges();
                
                Console.WriteLine("Сохранено");
                
                Console.WriteLine("Список объектов:");
                foreach(Animal u in db.Animal)
                { 
                    Console.WriteLine("{0} - {1}", u.AnimalName, u.Vaccinations); 
                }

            }
        }
    }
}