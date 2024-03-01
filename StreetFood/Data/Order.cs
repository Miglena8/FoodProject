namespace StreetFood.Data
{
    public class Order
    {
        public int Id { get; set; }
        public string ClientsId { get; set; }
        public Client Clients { get; set; }
        public int FoodId { get; set; }
        public Food Foods { get; set; }
        public int Quantity { get; set; }
        public DateTime DateUpdate { get; set; } = DateTime.Now;
    }
}
