using System;
namespace RadivojeBjelic_DeltaDrive_Delta.Models
{
    public class Ride
    {
        public Guid RideId { get; set; }
        public Guid PassengerId { get; set; }
        public Passenger Passenger { get; set; }
        public Guid VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public Location StartLocation { get; set; }
        public Location EndLocation { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public RideStatus Status { get; set; }
        public Rating PassengerRating { get; set; }


        public enum RideStatus
        {
            Requested,
            Accepted,
            Rejected,
            InProgress,
            Completed
        }
    }
}

