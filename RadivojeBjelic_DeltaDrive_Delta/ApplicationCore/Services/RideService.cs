using System;
using GeoCoordinatePortable;
using RadivojeBjelic_DeltaDrive_Delta.Interfaces;
using RadivojeBjelic_DeltaDrive_Delta.Models;
using static RadivojeBjelic_DeltaDrive_Delta.Models.Driver;
using static RadivojeBjelic_DeltaDrive_Delta.Models.Ride;

namespace ApplicationCore
{
    public class RideService : IRideService
    {
        private readonly IRideRepository _rideRepository;
        private readonly Random _random = new Random();//koristim je na vise mesta i da se ne poziva na vise mesta objekat iznova,
                                                       //zbog performansi inicijalizovao sam je ovde

        public RideService(IRideRepository rideRepository)
        {
            this._rideRepository = rideRepository;
        }
        public Ride GetById(Guid id)
        { 
            return _rideRepository.GetById(id);
        }
        public Ride BookARide(Ride ride, Guid driverId)
        {
            var selectedDriver = _rideRepository.GetDriverById(driverId);
            var passenger = _rideRepository.GetPassengerById(ride.PassengerId);

            if (passenger == null)
            {
                throw new Exception("Passenger not found!");
            }
            if (selectedDriver == null)
            {
                throw new Exception("Selected driver not found");
            }
            bool isAccepted = TryAcceptRideRequest(driverId);

            if (isAccepted)
            {
                try
                {
                    selectedDriver.DriverStatus = DriversStatus.Busy;
                    ride.Driver_ID = driverId;
                    ride.TotalPrice = CalculateTotalPrice(selectedDriver, ride.StartLatitude, ride.StartLongitude, ride.EndLatitude, ride.EndLongitude);
                    ride.Passenger = passenger;
                    ride.Driver = selectedDriver;
                    ride.Passenger.PassengersLatitude = ride.StartLatitude;
                    ride.Passenger.PassengersLongitude = ride.StartLongitude;
                    _rideRepository.SaveRide(ride);
                    return ride;

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                //poziva se samo kada je voznja odbijena i generise random razlog odluke,
                //u realnom scenariju vozac bi sam naveo razloge odbijanja, u ovom slucaju ide nasumicno
                return GenerateRejectionReason();
            }
        }
        public decimal CalculateTotalPrice(Driver driver, double startLatitude, double startLongitude, double endLatitude, double endLongitude)
        {
            var startCoord = new GeoCoordinate(startLatitude, startLongitude);
            var endCoord = new GeoCoordinate(endLatitude, endLongitude);

            double distance = startCoord.GetDistanceTo(endCoord) / 1000.0; // Udaljenost u kilometrima
            decimal totalPrice = driver.StartPrice + (decimal)distance * driver.PricePerKM;
            return totalPrice;
            //ovo moze biti i privatna metoda, ali sam je ostavio kao public jer se moze siriti aplikacija tako da putnik izracuna unapred
            //cenu svoje voznje i tek onda je bukira
        }
        public IEnumerable<Driver> GetNearestTenDrivers(double passengerLatitude, double passengerLongitude)
        {
            var userLocation = new GeoCoordinate(passengerLatitude, passengerLongitude);
            //pravi okvirnu razdaljinu od korisnikove lokacije recimo 10km priblizno, da se pribave vozaci
            //koji su u tom dometu zbog filtriranja iz baze, da se ne pribavljaju uvek
            //svi raspolozivi vozaci iz baze bez obzira na udaljenost
            double latitudeDistance = 0.1;//otprilike krug od 10km
            double longitudeDistance = 0.1;

            double minLatitude = passengerLatitude - latitudeDistance;
            double maxLatitude = passengerLatitude + latitudeDistance;
            double minLongitude = passengerLongitude - longitudeDistance;
            double maxLongitude = passengerLongitude + longitudeDistance;
            var nearestDrivers = _rideRepository.GetDriversInRange(minLatitude, minLongitude, maxLatitude, maxLongitude,userLocation);
            
            return nearestDrivers;
        }
        public async Task SimulateRide(Guid rideId)
        {
            var ride = _rideRepository.GetById(rideId);
            if (ride == null)
            {
                throw new Exception("Ride didn't started");
            }
            var driver = _rideRepository.GetDriverById(ride.Driver_ID);
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

            _rideRepository.UpdateRideAndDriver(ride,driver);//ovo ce odmah upisati sve podatke o simulaciji u bazu

            // Opciono, ako postoji potreba da se simulira zavrsetak voznje nakon odredjenog vremenskog perioda
            //await Task.Delay(TimeSpan.FromSeconds(totalTime));
        }

        public void AddRating(Rating rating)
        {
            _rideRepository.AddRating(rating);
        }
            #region Private Methods

        private bool TryAcceptRideRequest(Guid driverId)
        {
            var driver = _rideRepository.GetDriverById(driverId);

            if (driver == null || driver.DriverStatus != DriversStatus.Available)
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

