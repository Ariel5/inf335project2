using System;
using System.Data.Entity;

namespace Project2.Models
{
    public class Services
    {
        public int ID { get; set; }
        public string cityFrom { get; set; }
        public string cityTo { get; set; }
        public DateTime timeDeparture { get; set; }
        public DateTime timeArrival { get; set; }
        public double price { get; set; }
        public string description { get; set; }
    }

    public class ServicesDBContext: DbContext
    {
        public DbSet<Services> Services { get; set; }
    }
}