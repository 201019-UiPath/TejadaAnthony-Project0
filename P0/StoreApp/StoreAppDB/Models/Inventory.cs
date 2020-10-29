namespace StoreAppLib.Models
{
    public class Inventory
    {
        public int ProductId { get; set; }
        public int LocationId { get; set; }
        public int Quantity { get; set; }

        public Inventory(int productId, int locationId, int quantity)
        {
            this.ProductId = productId;
            this.LocationId = locationId;
            this.Quantity = quantity;

        }
    }
}