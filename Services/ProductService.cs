using dotnet_notification.Interfaces;
using dotnet_notification.Models;

namespace dotnet_notification.Services
{
    public class ProductService : BaseServices, IProductService
    {
        public ProductService(INotification notification) : base(notification)
        {
        }

        public Product Find(int id)
        {
            var product = GetList().FirstOrDefault(i => i.Id == id);
            if (product == null)
            {
                Notify("Produto não encontrado");
            }
            return product;
        }

        public List<Product> GetList()
        {
            var result = new List<Product>
            {
                new (1, "Computador"),
                new (2, "Teclado"),
                new (3, "Mouse"),
                new (4, "Notebook"),
            };
            return result;

        }

    }
}