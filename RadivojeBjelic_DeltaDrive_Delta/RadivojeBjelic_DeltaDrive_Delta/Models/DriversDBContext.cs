using System;
using CsvHelper;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Reflection.Emit;

namespace RadivojeBjelic_DeltaDrive_Delta.Models
{
    public class DriversDBContext : DbContext
    {
        List<Driver> drivers = new List<Driver>();

        public DriversDBContext(DbContextOptions<DriversDBContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(DriversDBContext).Assembly);
            InitializeAndSeedDatabase(@"./data/delta-drive.csv");

            builder.Entity<Driver>().ToTable("Drivers");
            builder.Entity<Driver>().HasData(drivers);

            builder.Entity<Passenger>()
                .HasIndex(p => p.Email)
                .IsUnique();

            builder.Entity<Passenger>().HasData(
                new Passenger()
                {
                    PassengerId = Guid.NewGuid(),
                    Email = "raca93@gmail.com",
                    PassengerName = "Radivoje",
                    PassengerLastname = "Bjelic",
                    PassengersLatitude = 45.29056828768189,
                    PassengersLongitude = 19.924187873005126,
                    Birthday = new DateTime(1993, 6, 22)
                },
                new Passenger()
                {
                    PassengerId = Guid.NewGuid(),
                    Email = "ana@example.com",
                    PassengerName = "Ana",
                    PassengerLastname = "Ivanovic",
                    PassengersLatitude = 44.78656828768189,
                    PassengersLongitude = 20.448921673005126,
                    Birthday = new DateTime(1987, 11, 6)
                },
                new Passenger()
                {
                    PassengerId = Guid.NewGuid(),
                    Email = "marko@example.com",
                    PassengerName = "Marko",
                    PassengerLastname = "Petrovic",
                    PassengersLatitude = 43.320902228768189,
                    PassengersLongitude = 21.895758973005126,
                    Birthday = new DateTime(1990, 5, 15)
                },
                new Passenger()
                {
                    PassengerId = Guid.NewGuid(),
                    Email = "jelena@example.com",
                    PassengerName = "Jelena",
                    PassengerLastname = "Jankovic",
                    PassengersLatitude = 44.012793528768189,
                    PassengersLongitude = 20.91142273005126,
                    Birthday = new DateTime(1992, 3, 22)
                },
                new Passenger()
                {
                    PassengerId = Guid.NewGuid(),
                    Email = "nikola@example.com",
                    PassengerName = "Nikola",
                    PassengerLastname = "Nikolic",
                    PassengersLatitude = 45.267135228768189,
                    PassengersLongitude = 19.833549673005126,
                    Birthday = new DateTime(1985, 8, 30)
                },
                new Passenger()
                {
                    PassengerId = Guid.NewGuid(),
                    Email = "marija@example.com",
                    PassengerName = "Marija",
                    PassengerLastname = "Maric",
                    PassengersLatitude = 44.01652128768189,
                    PassengersLongitude = 21.00585973005126,
                    Birthday = new DateTime(1994, 12, 10)
                }

            );
        }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet <Passenger> Passengers { get; set; }

        private void InitializeAndSeedDatabase(string csvFilePath)
        {
            try
            {
                LoadDriversFromCsv(csvFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Greška prilikom učitavanja ili seedinga: {ex.Message}");
            }
        }

        private void LoadDriversFromCsv(string filePath)
        {
            try
            {
                using var reader = new StreamReader(filePath);
                using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                csv.Context.RegisterClassMap<DriversDataMap>();
                var driveRowObjects = csv.GetRecords<DriveRowObject>().ToList();

                int i = 0;
                foreach (var driveRowObject in driveRowObjects)
                {
                    //Ograničen upis na 100 redova zbog pokretenja inicijalne migracije
                    if (i >= 100)
                    {
                        break;
                    }

                    var driver = new Driver()
                    {
                        Driver_ID = Guid.NewGuid(),
                        Brand = driveRowObject.Brand,
                        FirstName = driveRowObject.FirstName,
                        LastName = driveRowObject.LastName,
                        Latitude = driveRowObject.Latitude,
                        Longitude = driveRowObject.Longitude,
                        PricePerKM = Convert.ToDecimal(driveRowObject.PricePerKM.Replace("EUR", "")),
                        StartPrice = Convert.ToDecimal(driveRowObject.StartPrice.Replace("EUR", ""))

                    };
                    drivers.Add(driver);

                    i++;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Greška prilikom čitanja CSV fajla: {ex.Message}");
                throw;
            }
        }
    }
}

