using System;
using System.ComponentModel.DataAnnotations;
using RadivojeBjelic_DeltaDrive_Delta.Models;
using static RadivojeBjelic_DeltaDrive_Delta.Models.Ride;

namespace Domain
{
    public class RideDTO
    {
        //required parametri su za bukiranje same voznje
        public Guid RideId { get; set; }
        [Required]
        public Guid PassengerId { get; set; }
        [Required]
        public double StartLatitude { get; set; }
        [Required]
        public double StartLongitude { get; set; }
        [Required]
        public double EndLatitude { get; set; }
        [Required]
        public double EndLongitude { get; set; }
        [Required]
        public DateTime StartTime { get; set; }


        public DateTime EndTime { get; set; }
        public RideStatus Status { get; set; }
        public string? DriverFullName { get; set; }
        public string? DriverBrand { get; set; }
        public string? PassengerFullName { get; set; }
        public int? Score { get; set; }//ocena moze biti null ukoliko nije odmah dodeljena
        public string? Comment { get; set; }//takodje opciono
    }

}

