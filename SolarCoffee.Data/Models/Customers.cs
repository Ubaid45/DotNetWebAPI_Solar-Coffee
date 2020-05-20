using System;

namespace SolarCoffee.Data.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }

        public CustomerAddress CustomerAddress { get; set; }
    }
}