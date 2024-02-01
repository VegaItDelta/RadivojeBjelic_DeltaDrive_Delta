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
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        public string PassengerName { get; set; }
        [Required]
        [StringLength(50)]
        public string PassengerLastname { get; set; }
        [Required]
        [Range(-90,90)]
        public double PassengersLatitude { get; set; }
        [Required]
        [Range(-180,180)]
        public double PassengersLongitude { get; set; }
        [Required]
        public DateTime Birthday { get; set; }

        public ICollection<Driver>? Driver { get; set; }
        public ICollection<Ride>? Rides { get; set; }

        public Passenger()
        {
            Driver = new HashSet<Driver>();
            Rides = new HashSet<Ride>();
        }

    }
}

