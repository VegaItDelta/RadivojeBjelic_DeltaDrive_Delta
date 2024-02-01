using System;
using static RadivojeBjelic_DeltaDrive_Delta.Models.Ride;

namespace Domain
{
    public class RideDTO
    {
        public Guid RideId { get; set; }
        public double EndLatitude { get; set; }
        public double EndLongitude { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public RideStatus Status { get; set; }
        public string DriverFullName { get; set; }
        public string DriverBrand { get; set; }
        public int? Score { get; set; }//ocena moze biti null ukoliko nije odmah dodeljena
        public string? Comment { get; set; }//takodje opciono
    }
}

