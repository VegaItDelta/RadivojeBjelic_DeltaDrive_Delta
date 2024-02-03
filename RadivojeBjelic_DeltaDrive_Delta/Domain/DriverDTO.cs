using System;
namespace Domain
{
    public class DriverDTO
    {
        public Guid Driver_ID { get; set; }
        public string Brand { get; set; }
        public string Driver { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string StartPrice { get; set; }
        public string PricePerKM { get; set; }
    }
}

