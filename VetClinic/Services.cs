using System;
using System.Data.Entity;

namespace VetClinic
{
    public class Services
    {
        public int Id { get; set; }
        public string Service { get; set; }
        public DateTime Time { get; set; }
    }
}