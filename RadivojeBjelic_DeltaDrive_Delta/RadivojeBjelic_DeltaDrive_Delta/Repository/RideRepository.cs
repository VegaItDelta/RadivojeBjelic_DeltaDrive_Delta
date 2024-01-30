using System;
using GeoCoordinatePortable;
using Microsoft.EntityFrameworkCore;
using RadivojeBjelic_DeltaDrive_Delta.Interfaces;
using RadivojeBjelic_DeltaDrive_Delta.Models;

namespace RadivojeBjelic_DeltaDrive_Delta.Repository
{
    public class RideRepository : IRideInterface
    {
        private readonly DriversDBContext _context;

        public RideRepository(DriversDBContext context)
        {
            this._context = context;
        }

        public void BookARide(Ride ride)
        {
            _context.Add(ride);
            _context.SaveChanges();
        }

        public decimal CalculateTotalPrice(double startLatitude, double startLongitude, double endLatitude, double endLongitude, decimal startPrice, decimal pricePerKM)
        {
            var startCoord = new GeoCoordinate(startLatitude, startLongitude);
            var endCoord = new GeoCoordinate(endLatitude, endLongitude);

            double distance = startCoord.GetDistanceTo(endCoord) / 1000.0; // Udaljenost u kilometrima
            decimal totalPrice = startPrice + (decimal)distance * pricePerKM;
            return totalPrice;
        }

        public IQueryable<Driver> GetNearestTenDrivers(double passengerLatitude, double passengerLongitude)
        {
            var userLocation = new GeoCoordinate(passengerLatitude, passengerLongitude);

            var nearestDrivers = _context.Drivers.ToList()
            .Select(d => new
            {
                Driver = d,
                Distance = userLocation.GetDistanceTo(new GeoCoordinate(d.Latitude, d.Longitude))
            })
            .OrderBy(d => d.Distance) // Sortiranje vozača po udaljenosti
            .Take(10) // Uzimanje prvih 10
            .Select(d => d.Driver) // Vraćanje samo vozača
            .AsQueryable();

            return nearestDrivers;
        }
    }
}

