namespace InventoryManagementSystemm.API.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderQuantity { get; set; }
        public string OrderName { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;

        // Foreign Keys
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
    }
}