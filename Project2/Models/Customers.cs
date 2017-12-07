using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Project2.Models
{
    public class Customers
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public DateTime dateOfBirth { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string email { get; set; }
        public string address { get; set; }
    }

    public class CustomersDBContext : DbContext
    {
        public DbSet<Customers> Customers { get; set; }
    }
}