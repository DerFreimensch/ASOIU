using ASOIU.Models;
using ASOIU.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASOIU.Pages.Products;

public class DetailsModel : PageModel
{
    private readonly IProductRepository _productRepository;
    public DetailsModel(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public Product Product { get; set; } = null!;

    public void OnGet(int id)
    {
        Product = _productRepository.GetProduct(id);
    }
}