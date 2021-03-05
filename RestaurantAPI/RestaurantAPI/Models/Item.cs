namespace RestaurantAPI.Models
{
    public class Item
    {
        public int IdItem { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
