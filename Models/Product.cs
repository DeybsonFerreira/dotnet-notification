namespace dotnet_notification.Models
{
    public class Product
    {
        public Product(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public int Id { get; set; }
        public string Description { get; set; }
    }
}