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
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string Lastname { get; set; }
        [Range(-90,90)]
        public double? PassengersLatitude { get; set; }
        [Range(-180,180)]
        public double? PassengersLongitude { get; set; }
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

