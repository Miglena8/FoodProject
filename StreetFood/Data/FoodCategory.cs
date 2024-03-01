namespace StreetFood.Data
{
    public class FoodCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateUpdate { get; set; } = DateTime.Now;
        public ICollection<Food> Foods { get; set; }
    }
}
