using System;
using ApplicationCore;
using Moq;
using RadivojeBjelic_DeltaDrive_Delta.Interfaces;
using RadivojeBjelic_DeltaDrive_Delta.Models;
using static RadivojeBjelic_DeltaDrive_Delta.Models.Driver;

namespace RadivojeBjelic_DeltaDrive_Delta_Test
{
    public class RideServiceTests
    {
        [Fact]
        public void BookRide_ValidData()
        {
            var mockRideRepository = new Mock<IRideRepository>();
            var service = new RideService(mockRideRepository.Object);

            var driverId = Guid.NewGuid();
            var passengerId = Guid.NewGuid();

            var ride = new Ride
            {
                PassengerId = passengerId,
                StartLatitude = 45.223345554,
                StartLongitude = 19.8933332,
                EndLatitude = 45.56643222,
                EndLongitude = 20.00222111,
            };

            var driver = new Driver
            {
                Driver_ID = driverId,
                DriverStatus = DriversStatus.Available,
                PricePerKM = 2M,
                StartPrice = 10M
            };

            var passenger = new Passenger
            {
                PassengerId = passengerId
            };

            mockRideRepository.Setup(r => r.GetDriverById(driverId)).Returns(driver);
            mockRideRepository.Setup(r => r.GetPassengerById(passengerId)).Returns(passenger);

            var result = service.BookARide(ride, driverId);

            Assert.NotNull(result);
            Assert.Equal(driverId, result.Driver_ID);
            Assert.Equal(passengerId, result.PassengerId);
            mockRideRepository.Verify(r => r.SaveRide(It.IsAny<Ride>()), Times.Once);
        }

        [Fact]
        public void BookRide_DriverNotFound()
        {
            var mockRideRepository = new Mock<IRideRepository>();
            var service = new RideService(mockRideRepository.Object);

            var driverId = Guid.NewGuid();
            var passengerId = Guid.NewGuid();

            var ride = new Ride
            {
                PassengerId = passengerId,
                StartLatitude = 45.223345554,
                StartLongitude = 19.8933332,
                EndLatitude = 45.56643222,
                EndLongitude = 20.00222111,
            };

            mockRideRepository.Setup(r => r.GetDriverById(driverId)).Returns((Driver)null);

            var exception = Assert.Throws<Exception>(() => service.BookARide(ride, driverId));
            Assert.Equal("Selected driver not found!", exception.Message);
        }

        [Fact]
        public async Task SimulateRide_ValidDataAsync()
        {
            var mockRideRepository = new Mock<IRideRepository>();
            var service = new RideService(mockRideRepository.Object);

            var rideId = Guid.NewGuid();
            var passengerId = Guid.NewGuid();
            var driverId = Guid.NewGuid();


            var ride = new Ride
            {
                PassengerId = passengerId,
                StartLatitude = 45.223345554,
                StartLongitude = 19.8933332,
                EndLatitude = 45.56643222,
                EndLongitude = 20.00222111,
            };
            var driver = new Driver
            {
                Driver_ID = driverId,
                Latitude = ride.EndLatitude,
                Longitude = ride.EndLongitude
            };

            mockRideRepository.Setup(r => r.GetById(rideId)).Returns(ride);
            mockRideRepository.Setup(r => r.GetDriverById(driverId)).Returns(driver);
            mockRideRepository.Setup(r => r.UpdateRideAndDriver(ride, driver)).Verifiable();

            await service.SimulateRide(rideId);

            mockRideRepository.Verify(r => r.UpdateRideAndDriver(ride,driver), Times.Once);
        }

        [Fact]
        public async Task SimulateRide_RideNotFound()
        {
            var mockRideRepository = new Mock<IRideRepository>();
            var service = new RideService(mockRideRepository.Object);

            var rideId = Guid.NewGuid();

            mockRideRepository.Setup(r => r.GetById(rideId)).Returns((Ride)null);

            await Assert.ThrowsAsync<Exception>(() => service.SimulateRide(rideId));
        }
    }
}

