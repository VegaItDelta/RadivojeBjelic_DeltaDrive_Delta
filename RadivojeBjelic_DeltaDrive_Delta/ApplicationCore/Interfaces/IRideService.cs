using System;
using RadivojeBjelic_DeltaDrive_Delta.Models;

namespace ApplicationCore
{
    public interface IRideService
    {
        Ride BookARide(Ride ride, Guid driverId);
        Ride GetById(Guid id);
        IEnumerable<Driver> GetNearestTenDrivers(double passengerLatitude, double passengerLongitude);
        Task SimulateRide(Guid rideId);
        void AddRating(Rating rating);
        decimal CalculateTotalPrice(Driver driver, double startLatitude, double startLongitude, double endLatitude, double endLongitude);
    }
}

