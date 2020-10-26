namespace StoreAppLib.Models
{
    public class BaseballBats
    {

        public string ProductName { get; set; }
        public float ProductPrice { get; set; }
        public int ProductId { get; set; }
        public string ProductType { get; set; }
        public int LocationId { get; set; }

        public BaseballBats(string productName, float productPrice, int productId, string productType, int locationId)
        {
            this.ProductName = productName;
            this.ProductPrice = productPrice;
            this.ProductId = productId;
            this.ProductType = productType;
            this.LocationId = locationId;

        }

    }
}