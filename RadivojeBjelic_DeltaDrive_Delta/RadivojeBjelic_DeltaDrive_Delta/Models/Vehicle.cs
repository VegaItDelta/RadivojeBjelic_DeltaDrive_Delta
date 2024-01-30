using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RadivojeBjelic_DeltaDrive_Delta.Models
{
    public class Vehicle
    {
        [Key]
        public Guid Vehicle_ID { get; set; }
        [ForeignKey("Driver_ID")]
        [Required]
        public Guid Driver_ID { get; set; }
        public string Brand { get; set; }
        public decimal StartPrice { get; set; }
        public decimal PricePerKM { get; set; }
        //public Driver Driver { get; set; }

    }
}

