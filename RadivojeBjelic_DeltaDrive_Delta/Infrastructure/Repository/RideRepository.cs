using System;
using Domain;
using GeoCoordinatePortable;
using Microsoft.EntityFrameworkCore;
using RadivojeBjelic_DeltaDrive_Delta.Interfaces;
using RadivojeBjelic_DeltaDrive_Delta.Models;
using static RadivojeBjelic_DeltaDrive_Delta.Models.Driver;
using static RadivojeBjelic_DeltaDrive_Delta.Models.Ride;

namespace RadivojeBjelic_DeltaDrive_Delta.Repository
{
    public class RideRepository : IRideRepository
    {
        private readonly DriversDBContext _context;
        private readonly Random _random = new Random();//koristim je na vise mesta i da se ne poziva na vise mesta objekat iznova,
                                                       //zbog performansi inicijalizovao sam je ovde

        public RideRepository(DriversDBContext context)
        {
            this._context = context;
        }

        public void AddRating(Rating rating)
        {
            _context.Ratings.Add(rating);
            _context.SaveChanges();
        }

        public Ride GetById(Guid id)
        {
            return _context.Rides
                .Include(p => p.Passenger)
                .Include(r => r.Driver)
                .Include(rtg => rtg.PassengerRating)
                .FirstOrDefault(r => r.RideId == id);
        }

        public Driver? GetDriverById(Guid driverId)
        {
            return _context.Drivers.Find(driverId);
        }

        public IEnumerable<Driver> GetDriversInRange(double minLatitude, double minLongitude, double maxLatitude, double maxLongitude,GeoCoordinate userLocation)
        {
            var driversInRange = _context.Drivers
            .Where(d => d.DriverStatus == DriversStatus.Available &&
                        d.Latitude >= minLatitude && d.Latitude <= maxLatitude &&
                        d.Longitude >= minLongitude && d.Longitude <= maxLongitude)
            .ToList();

            var nearestDrivers = driversInRange
            .Select(d => new
            {
                Driver = d,
                Distance = userLocation.GetDistanceTo(new GeoCoordinate(d.Latitude, d.Longitude))
            })
            .OrderBy(d => d.Distance) // Sortiranje vozača po udaljenosti
            .Take(10) // Uzimanje prvih 10
            .Select(d => d.Driver) // Vraćanje samo vozača
            .ToList();

            return nearestDrivers;
        }

        public Passenger? GetPassengerById(Guid passengerId)
        {
            return _context.Passengers.Find(passengerId);
        }

        public void SaveRide(Ride ride)
        {
            _context.Add(ride);
            _context.SaveChanges();
        }

        public void UpdateRideAndDriver(Ride ride, Driver driver)
        {
            // azuriranje lokacije vozača i statusa vožnje
            driver.Latitude = ride.EndLatitude;
            driver.Longitude = ride.EndLongitude;
            ride.Status = RideStatus.Completed; // Menjanje statusa vožnje u completed
            _context.SaveChanges();
        }
    }
}

