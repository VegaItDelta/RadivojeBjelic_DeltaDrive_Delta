using System;
namespace RadivojeBjelic_DeltaDrive_Delta.Models
{
    public class PassengerDTO
    {
        public Guid PassengerId { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }
    }
}

