using System;
namespace RadivojeBjelic_DeltaDrive_Delta.Models
{
    /// <summary>
    /// DriveRowObject koristimo za mapiranje .csv redova u objekte
    /// koji nakon mapiranja razlažemo na objekte koji predstavljaju zasebne tabele u bazi
    /// </summary>
    public class DriveRowObject 
    {
        public Guid Driver_ID { get; set; }
        public string Brand { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string StartPrice { get; set; }
        public string PricePerKM { get; set; }
    }
}

