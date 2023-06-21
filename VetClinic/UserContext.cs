using System.Data.Entity;

namespace VetClinic
{
    class UserContext : DbContext
    {
        public UserContext()
            : base("DbConnection")
        {
            Database.Delete();
            Database.Create();
        }
        
        public DbSet<Animal> Animal { get; set; } 
        
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Hosts> Hosts { get; set; }
        public DbSet<Services> Services { get; set; }

    }
}