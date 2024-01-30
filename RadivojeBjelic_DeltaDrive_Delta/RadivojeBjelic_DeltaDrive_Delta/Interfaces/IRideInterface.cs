using System;
using RadivojeBjelic_DeltaDrive_Delta.Models;

namespace RadivojeBjelic_DeltaDrive_Delta.Interfaces
{
    public interface IRideInterface
    {
        void BookARide(Ride ride);
        decimal CalculateTotalPrice(double startLatitude, double startLongitude, double endLatitude, double endLongitude, decimal startPrice, decimal pricePerKM);
        IQueryable<Driver> GetNearestTenDrivers(double passengerLatitude, double passengerLongitude);
    }
}

