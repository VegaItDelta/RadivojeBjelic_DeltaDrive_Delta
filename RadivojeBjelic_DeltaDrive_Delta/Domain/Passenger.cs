using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadivojeBjelic_DeltaDrive_Delta.Models
{
    public class Passenger
    {
        [Key]
        public Guid PassengerId { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        public string PassengerName { get; set; }
        public string PassengerLastname { get; set; }
        public double PassengersLatitude { get; set; }
        public double PassengersLongitude { get; set; }
        public DateTime Birthday { get; set; }

        public Guid Driver_ID { get; set; }
        public ICollection<Driver>? Driver { get; set; }

        public Passenger()
        {

        }

    }
}

