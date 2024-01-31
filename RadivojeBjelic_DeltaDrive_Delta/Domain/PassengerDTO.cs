using System;
namespace RadivojeBjelic_DeltaDrive_Delta.Models
{
    public class PassengerDTO
    {
        public Guid PassengerId { get; set; }
        public string PassengerName { get; set; }
        public string PassengerLastname { get; set; }
        public DateTime Birthday { get; set; }
    }
}

