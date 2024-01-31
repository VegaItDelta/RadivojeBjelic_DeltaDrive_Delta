using System;
namespace RadivojeBjelic_DeltaDrive_Delta.Models
{
    public class Ride
    {
        public Guid RideId { get; set; }
        public Guid PassengerId { get; set; }
        public Guid Driver_ID { get; set; }
        public Guid RatingId { get; set; }
        public double StartLatitude { get; set; }
        public double StartLongitude { get; set; }
        public double EndLatitude { get; set; }
        public double EndLongitude { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public RideStatus Status { get; set; }
        public string StatusMessage { get; set; }
        public Passenger? Passenger { get; set; }
        public Rating? PassengerRating { get; set; }
        public Driver? Driver { get; set; }

        public Ride()
        {
            Status = RideStatus.Requested;
        }
        public enum RideStatus
        {
            Requested,
            Accepted,
            Rejected,
            RejectedDriverIsLogedOut,
            MailfunctionedVehicle,
            PassengerRejected,
            InProgress,
            Completed
        }
    }
}

