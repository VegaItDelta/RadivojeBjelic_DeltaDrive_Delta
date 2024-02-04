using System;
using CsvHelper;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Reflection.Emit;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using EFCore.BulkExtensions;

namespace RadivojeBjelic_DeltaDrive_Delta.Models
{
    public class DriversDBContext : IdentityDbContext<ApplicationUser>
    {
        List<Driver> drivers = new List<Driver>();  

        public DriversDBContext(DbContextOptions<DriversDBContext> options)
            : base(options) { }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Ride> Rides { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Ride>()
                .HasOne(r => r.Passenger)
                .WithMany()
                .HasForeignKey(r => r.PassengerId);

            builder.Entity<Ride>()
                .HasOne(r => r.Driver)
                .WithMany()
                .HasForeignKey(r => r.Driver_ID);

            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(DriversDBContext).Assembly);
            InitializeAndSeedDatabase(@"./data/delta-drive.csv");

            builder.Entity<Driver>().ToTable("Drivers");
            builder.Entity<Driver>().HasData(drivers);

            builder.Entity<Passenger>()
                .HasIndex(p => p.Email)
                .IsUnique();
        }

        

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
                var driveRowObjects = csv.GetRecords<DriveRowObject>();

                const int batchSize = 20000; 
                List<Driver> batchList = new List<Driver>(batchSize);

                foreach (var driveRowObject in driveRowObjects)
                {
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

                    batchList.Add(driver);

                    if (batchList.Count == batchSize)
                    {
                        this.BulkInsert(batchList);
                        batchList.Clear(); 
                    }
                }

                if (batchList.Count > 0)
                {
                    this.BulkInsert(batchList);
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

