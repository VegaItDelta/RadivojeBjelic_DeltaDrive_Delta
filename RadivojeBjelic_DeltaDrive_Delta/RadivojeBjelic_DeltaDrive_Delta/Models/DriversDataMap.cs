namespace RadivojeBjelic_DeltaDrive_Delta.Models
{
    public class DriversDataMap : CsvHelper.Configuration.ClassMap<DriveRowObject>
    {
        public DriversDataMap()
        {
            Map(x => x.Brand).Name("brand");
            Map(x => x.FirstName).Name("firstName");
            Map(x => x.LastName).Name("lastName");
            Map(x => x.Latitude).Name("latitude");
            Map(x => x.Longitude).Name("longitude");
            Map(x => x.StartPrice).Name("startPrice");
            Map(x => x.PricePerKM).Name("pricePerKM");
        }
    }

    
}

