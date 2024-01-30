using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RadivojeBjelic_DeltaDrive_Delta.Models
{
    public class Location
    {
        [Key]
        public Guid Location_ID { get; set; }
        [ForeignKey("Driver_ID")]
        [Required]
        public Guid Driver_ID { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        //public Driver? Driver { get; set; }
        public Location()
        {

        }
    }
    
}

