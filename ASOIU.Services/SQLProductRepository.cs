using ASOIU.Models;
using Microsoft.EntityFrameworkCore;

namespace ASOIU.Services;

public class SqlProductRepository : IProductRepository
{
    private readonly AppDbContext _context;

    public SqlProductRepository(AppDbContext context)
    {
        context.Database.CanConnect();
        _context = context;
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return _context.Products;
    }

    public Product GetProduct(int id)
    {
        var temp = _context.Products.Include(c => c.maker).Where(x=>x.ID == id);
        return temp.First() ?? throw new InvalidOperationException();
    }

    public IEnumerable<Product> Search(string searchTerm)
    {
        if (string.IsNullOrWhiteSpace(searchTerm))
        {
            return _context.Products.Include(c => c.maker);
        }

        return _context.Products.Include(c => c.maker).Where(x => x.name.Contains(searchTerm)) ??
               throw new NotImplementedException();
    }
}