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
    public class RideRepository : IRideInterface
    {
        private readonly DriversDBContext _context;
        private readonly Random _random = new Random();//koristim je na vise mesta i da se ne poziva na vise mesta objekat iznova,
                                                       //zbog performansi inicijalizovao sam je ovde

        public RideRepository(DriversDBContext context)
        {
            this._context = context;
        }
        public Ride GetById(Guid id)
        {
            return _context.Rides
                .Include(p => p.Passenger)
                .Include(r => r.Driver)
                .Include(rtg => rtg.PassengerRating)
                .FirstOrDefault(r => r.RideId == id);
        }
        public Ride BookARide(Ride ride, Guid driverId)
        {
            var selectedDriver = _context.Drivers.Find(driverId);
            var passenger = _context.Passengers.Find(ride.PassengerId);
            
            if (passenger == null)
            {
                throw new Exception("Passenger not found!");
            }
            if (selectedDriver == null)
            {
                throw new Exception("Selected driver not found");
            }
            bool isAccepted = TryAcceptRideRequest(driverId);

            //var ride = new Ride();
            if (isAccepted)
            {
                try
                {
                    selectedDriver.DriverStatus = DriversStatus.Busy;
                    ride.Driver_ID = driverId;
                    ride.TotalPrice = CalculateTotalPrice(driverId,ride.StartLatitude, ride.StartLongitude, ride.EndLatitude, ride.EndLongitude);
                    ride.Passenger = passenger;
                    ride.Driver = selectedDriver;
                    ride.Passenger.PassengersLatitude = ride.StartLatitude;
                    ride.Passenger.PassengersLongitude = ride.StartLongitude;
                    _context.Add(ride);
                    _context.SaveChanges();
                    return ride;

                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            else
            {
                //poziva se samo kada je voznja odbijena i generise random razlog odluke,
                //u realnom scenariju vozac bi sam naveo razloge odbijanja, u ovom slucaju ide nasumicno
                return GenerateRejectionReason();
                
                //_context.SaveChanges();
            }
        }

        public decimal CalculateTotalPrice(Guid driverId,double startLatitude, double startLongitude, double endLatitude, double endLongitude)
        {
            var driver = _context.Drivers.Find(driverId);
            var startCoord = new GeoCoordinate(startLatitude, startLongitude);
            var endCoord = new GeoCoordinate(endLatitude, endLongitude);

            double distance = startCoord.GetDistanceTo(endCoord) / 1000.0; // Udaljenost u kilometrima
            decimal totalPrice = driver.StartPrice + (decimal)distance * driver.PricePerKM;
            return totalPrice;
        }

        public IEnumerable<Driver> GetNearestTenDrivers(double passengerLatitude, double passengerLongitude)
        {
            var userLocation = new GeoCoordinate(passengerLatitude, passengerLongitude);
            //pravi okvirnu razdaljinu od korisnikove lokacije recimo 10km priblizno, da se pribave vozaci
            //koji su u tom dometu zbog filtriranja iz baze, da se ne pribavljaju uvek
            //svi raspolozivi vozaci iz baze bez obzira na udaljenost
            double latitudeDistance = 0.1;
            double longitudeDistance = 0.1;

            double minLatitude = passengerLatitude - latitudeDistance;
            double maxLatitude = passengerLatitude + latitudeDistance;
            double minLongitude = passengerLongitude - longitudeDistance;
            double maxLongitude = passengerLongitude + longitudeDistance;

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
        public async Task SimulateRide(Guid rideId)
        {
            var ride = _context.Rides.Find(rideId);
            if (ride == null)
            {
                throw new Exception("Ride didn't started");
            }
            var driver = _context.Drivers.Find(ride.Driver_ID);
            if (driver == null)
            {
                throw new Exception("Driver not found!");
            }

            double speed = 60.0 * 1000 / 3600; // 60 km/h prevedeno u metre po sekundi

            var startCoord = new GeoCoordinate(ride.StartLatitude, ride.StartLongitude);
            var endCoord = new GeoCoordinate(ride.EndLatitude, ride.EndLongitude);

            double totalDistance = startCoord.GetDistanceTo(endCoord);

            // izracunavanje ukupnog vremena potrebnog za vožnju na osnovu brzine i ukupne udaljenosti
            double totalTime = totalDistance / speed;

            // azuriranje lokacije vozača i statusa vožnje
            driver.Latitude = ride.EndLatitude;
            driver.Longitude = ride.EndLongitude;
            ride.Status = RideStatus.Completed; // Menjanje statusa vožnje u completed

            
            _context.SaveChanges();

            // Opciono, ako postoji potreba da se simulira zavrsetak voznje nakon odredjenog vremenskog perioda
            //await Task.Delay(TimeSpan.FromSeconds(totalTime));
        }

        public void AddRating(Rating rating)
        {
            _context.Ratings.Add(rating);
            _context.SaveChanges();
        }
        #region Private Methods

        private bool TryAcceptRideRequest(Guid driverId)
        {
            var driver = _context.Drivers.Find(driverId);

            if ( driver == null || driver.DriverStatus != DriversStatus.Available)
            {
                throw new Exception("Ride or driver not found!");
            }

            if (_random.NextDouble() > 0.01)//25% sanse da se voznja ne prihvati
            {
                return true;
            }
            
            return false;
            
        }
        private Ride GenerateRejectionReason()
        {

            int reason = _random.Next(1, 4); //imamo 3 razloga za odbijanje generisana
            var ride = new Ride();
            switch (reason)
            {
                case 1:
                    ride.Status = Ride.RideStatus.MailfunctionedVehicle;
                    ride.StatusMessage = "Ride rejected due to vehicle mailfunction!";
                    break;
                case 2:
                    ride.Status = Ride.RideStatus.RejectedDriverIsLogedOut;
                    ride.StatusMessage = "Ride rejected, driver is not available at the moment!";
                    break;
                case 3:
                    ride.Status = Ride.RideStatus.PassengerRejected;
                    ride.StatusMessage = "Passengers reviews are not good enough!";//kada bi se aplikacija recimo prosirila da vozaci mogu da ostave recenziju i za korisnika
                    break;
                default:
                    ride.Status = Ride.RideStatus.Rejected;
                    ride.StatusMessage = "Ride rejected!";
                    break;

            }
            return ride;
        }

        
        #endregion
    }
}

