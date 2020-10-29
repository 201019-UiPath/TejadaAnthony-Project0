namespace StoreAppLib.Models
{
    public class Locations
    {
        public string LocationName { get; set; }
        public int LocationId { get; set; }
        public string LocationCity { get; set; }

        public Locations(string locationName, int locationId, string locationCity)
        {
            this.LocationName = locationName;
            this.LocationId = locationId;
            this.LocationCity = locationCity;

        }


    }
}