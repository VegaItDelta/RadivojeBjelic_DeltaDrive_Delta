using System;
using Domain;
using RadivojeBjelic_DeltaDrive_Delta.Models;

namespace RadivojeBjelic_DeltaDrive_Delta.Interfaces
{
    public interface IRideInterface
    {
        Ride BookARide(Ride ride,Guid driverId);
        Ride GetById(Guid id);
        decimal CalculateTotalPrice(Guid driverId,double startLatitude, double startLongitude, double endLatitude, double endLongitude);
        IEnumerable<Driver> GetNearestTenDrivers(double passengerLatitude, double passengerLongitude);
        Task SimulateRide(Guid rideId);
        void AddRating(Rating rating);
    }
}

