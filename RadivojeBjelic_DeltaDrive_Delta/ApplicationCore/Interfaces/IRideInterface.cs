using System;
using Domain;
using RadivojeBjelic_DeltaDrive_Delta.Models;

namespace RadivojeBjelic_DeltaDrive_Delta.Interfaces
{
    public interface IRideRepository
    {
        Ride GetById(Guid id);
        void AddRating(Rating rating);
        Driver? GetDriverById(Guid driverId);
        Passenger? GetPassengerById(Guid passengerId);
        void SaveRide(Ride ride);
        IEnumerable<Driver> GetDriversInRange(double minLatitude, double minLongitude, double maxLatitude, double maxLongitude,GeoCoordinatePortable.GeoCoordinate userLocation);
        void UpdateRideAndDriver(Ride ride, Driver driver);
    }
}

