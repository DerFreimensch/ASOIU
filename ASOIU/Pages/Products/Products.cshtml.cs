using ASOIU.Models;
using ASOIU.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASOIU.Pages.Products;

public class ProductsModel : PageModel
{
    private readonly IProductRepository _db;
    
    public ProductsModel(IProductRepository db)
    {
        _db = db;
    }
    
    public IEnumerable<Product> Products { get; set; } = null!;
    [BindProperty(SupportsGet = true)]
    public string SearchTerm { get; set; }
    
    public void OnGet()
    {
        Products = _db.Search(SearchTerm);
    }
}