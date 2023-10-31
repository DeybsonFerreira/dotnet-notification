using dotnet_notification.Models;

namespace dotnet_notification.Interfaces
{
    public interface IProductService
    {
        List<Product> GetList();
        Product Find(int id);
    }
}