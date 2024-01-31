using System;
using System.ComponentModel.DataAnnotations;

namespace RadivojeBjelic_DeltaDrive_Delta.Models
{
    public class Rating
    {
        [Key]
        public Guid RatingId { get; set; }
        public Guid RideId { get; set; }
        public int Score { get; set; }
        public string? Comment { get; set; } //Comment is optional
    }
}

