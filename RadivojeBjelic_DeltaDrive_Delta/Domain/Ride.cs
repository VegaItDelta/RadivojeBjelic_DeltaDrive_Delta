using System;
using System.ComponentModel.DataAnnotations;

namespace RadivojeBjelic_DeltaDrive_Delta.Models
{
    public class Ride
    {
        [Key]
        public Guid RideId { get; set; }
        [Required]
        public Guid PassengerId { get; set; }
        [Required]
        public Guid Driver_ID { get; set; }
        public Guid RatingId { get; set; }
        [Required]
        [Range(-90,90)]
        public double StartLatitude { get; set; }
        [Required]
        [Range(-180,180)]
        public double StartLongitude { get; set; }
        [Required]
        [Range(-90,90)]
        public double EndLatitude { get; set; }
        [Required]
        [Range(-180,180)]
        public double EndLongitude { get; set; }
        [Required]
        [Range(1,double.MaxValue)]
        public decimal TotalPrice { get; set; }
        [Required]
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

