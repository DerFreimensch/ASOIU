using ASOIU.Models;

namespace ASOIU.Services;

public interface IProductRepository
{
    IEnumerable<Product> GetAllProducts();
    Product GetProduct(int id);
    IEnumerable<Product> Search(string searchTerm);
}