using System;
using System.ComponentModel.DataAnnotations;

namespace RadivojeBjelic_DeltaDrive_Delta.Models
{
    public class Passenger
    {
        [Key]
        public Guid PassengerId { get; set; }
        public string Email { get; set; }
        public string PassengerName { get; set; }
        public string PassengerLastname { get; set; }
        public Location PassengersLocation { get; set; }
        public DateTime Birthday { get; set; }

        public Passenger()
        {

        }

    }
}

