using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RadivojeBjelic_DeltaDrive_Delta.Models
{
    public class Driver
    {
        [Key]
        public Guid Driver_ID { get; set; }
        public string Brand { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public decimal StartPrice { get; set; }
        public decimal PricePerKM { get; set; }
        //public Vehicle Vehicle { get; set; }
        //public Location Location { get; set; }

        public Driver()
        {

        }
    }
}

