namespace StoreAppLib.Models
{
    public class Orders
    {

        public string OrderNum { get; set; }
        public string OrderDate { get; set; }
        public int LocationId { get; set; } //foreign key
        public int OrderId { get; set; }  //Primary key
        public int CustomerId { get; set; } //foreign key
        public int TotalCost { get; set; }

        public Orders(string orderNum, string orderDate, int locationId, int orderId, int customerId, int totalCost)
        {
            this.OrderNum = orderNum;
            this.OrderDate = orderDate;
            this.LocationId = locationId;
            this.OrderId = orderId;
            this.CustomerId = customerId;
            this.TotalCost = totalCost;

        }
    }
}