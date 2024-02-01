using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RadivojeBjelic_DeltaDrive_Delta.Models
{
    public class Driver
    {
        [Key]
        public Guid Driver_ID { get; set; }
        [Required]
        [StringLength(100)]
        public string Brand { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [Range(-90,90)]
        public double Latitude { get; set; }
        [Required]
        [Range(-180,180)]
        public double Longitude { get; set; }
        [Required]
        [Range(1,40)]
        public decimal StartPrice { get; set; }
        [Required]
        [Range(1,2.5)]
        public decimal PricePerKM { get; set; }

        public DriversStatus DriverStatus { get; set; } = DriversStatus.Available;


        public Driver()
        {

        }

        public enum DriversStatus
        {
            Available,
            Busy,
            OffDuty
        }
    }
}

