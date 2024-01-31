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
        private readonly Random _random = new Random();//koristim je na vise mesta i da se ne poziva na vise mesta objekat iznova,
                                                       //zbog performansi inicijalizovao sam je ovde

        public RideRepository(DriversDBContext context)
        {
            this._context = context;
        }

        public void BookARide(Ride ride,Guid driverId)
        {
            var selectedDriver = _context.Drivers.Find(driverId);
            if (selectedDriver == null)
            {
                throw new Exception("Selected driver not found");
            }
            bool isAccepted = TryAcceptRideRequest(driverId, ride.RideId);

            if (isAccepted)
            {
                ride.Driver_ID = driverId;
                ride.TotalPrice = CalculateTotalPrice(driverId,ride.StartLatitude, ride.StartLongitude, ride.EndLatitude, ride.EndLongitude);
                _context.Add(ride);
                _context.SaveChanges();
            }
            else
            {
                //poziva se samo kada je voznja odbijena i generise random razlog odluke,
                //u realnom scenariju vozac bi sam naveo razloge odbijanja, u ovom slucaju ide nasumicno
                GenerateRejectionReason(ride);
                _context.SaveChanges();
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

            var nearestDrivers = _context.Drivers
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

            double speed = 60.0 * 1000 / 3600; //60km/h pretvoreno u metre po sekundi

            var startCoord = new GeoCoordinate(ride.StartLatitude, ride.StartLongitude);
            var endCoord = new GeoCoordinate(ride.EndLatitude, ride.EndLongitude);

            double totalDistance = startCoord.GetDistanceTo(endCoord);
            double distanceCovered = 0.0;
            while (distanceCovered < totalDistance)
            {
                double distance = speed * 5;//predjeni put za 5 sekundi
                distanceCovered += distance;

                if (distanceCovered > totalDistance)
                {
                    distanceCovered = totalDistance;
                }
                await Task.Delay(5000);//osvezava se lokacija na svakih 5 sekundi
            }
            //ovde zadajem vozacu novu lokaciju, vodim se razmisljanjem da je njegova lokacija koja se azurira krajnja lokacija voznje
            //u realnom scenariju bi to bilo praceno konstantno jer nije realno da se sam vozac ne pomera sa te lokacije dok ceka sledecu voznju
            driver.Latitude = ride.EndLatitude;
            driver.Longitude = ride.EndLongitude;
            ride.Status = Ride.RideStatus.Completed;//menjam status voznje u completed kada se ona zavrsi

            _context.SaveChanges();
        }

        #region Private Methods

        private bool TryAcceptRideRequest(Guid driverId,Guid rideId)
        {
            var ride = _context.Rides.Find(rideId);
            var driver = _context.Drivers.Find(driverId);

            if (ride == null || driver == null)
            {
                throw new Exception("Ride or driver not found!");
            }

            if (_random.NextDouble() > 0.25)//25% sanse da se voznja ne prihvati
            {
                ride.Status = Ride.RideStatus.Accepted;
                ride.StatusMessage = "Ride is accepted by the driver";
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        private void GenerateRejectionReason(Ride ride)
        {

            int reason = _random.Next(1, 4); //imamo 3 razloga za odbijanje generisana

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
        }
        #endregion
    }
}

