using System;
using System.ComponentModel.DataAnnotations;

namespace RadivojeBjelic_DeltaDrive_Delta.Models
{
    public class Rating
    {
        [Key]
        public Guid RatingId { get; set; }
        [Required]
        public Guid RideId { get; set; }
        [Range(1,5)]
        public int Score { get; set; }
        [StringLength(500)]
        public string? Comment { get; set; } //Comment is optional
    }
}

