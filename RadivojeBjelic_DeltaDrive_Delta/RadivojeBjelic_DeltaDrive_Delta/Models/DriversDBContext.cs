using System;
using CsvHelper;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace RadivojeBjelic_DeltaDrive_Delta.Models
{
    public class DriversDBContext : DbContext
    {
        List<Driver> drivers = new List<Driver>();
        List<Vehicle> vehicles = new List<Vehicle>();
        List<Location> locations = new List<Location>();

        public DriversDBContext(DbContextOptions<DriversDBContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(DriversDBContext).Assembly);
            InitializeAndSeedDatabase(@"./data/delta-drive.csv");

            builder.Entity<Location>().ToTable("Locations");
            builder.Entity<Location>().HasData(locations);

            builder.Entity<Vehicle>().ToTable("Vehicles");
            builder.Entity<Vehicle>().HasData(vehicles);

            builder.Entity<Driver>().ToTable("Drivers");
            builder.Entity<Driver>().HasData(drivers);
        }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

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
                        //Location = location,
                        //Vehicle = vehicle

                    };
                    var location = new Location()
                    {
                        Location_ID = Guid.NewGuid(),
                        Latitude = driveRowObject.Latitude,
                        Longitude = driveRowObject.Longitude,
                        Driver_ID = driver.Driver_ID,
                    };
                    locations.Add(location);

                    var vehicle = new Vehicle()
                    {
                        Vehicle_ID = Guid.NewGuid(),
                        Brand = driveRowObject.Brand,
                        Driver_ID = driver.Driver_ID,
                        PricePerKM = Convert.ToDecimal(driveRowObject.PricePerKM.Replace("EUR", "")),
                        StartPrice = Convert.ToDecimal(driveRowObject.StartPrice.Replace("EUR", ""))
                    };
                    vehicles.Add(vehicle);
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

