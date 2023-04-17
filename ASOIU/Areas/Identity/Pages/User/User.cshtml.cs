using ASOIU.Models;
using ASOIU.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASOIU.Pages.User;

public class User : PageModel
{
    private readonly IUserRepository _userRepository;

    public User(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public Models.User CurrentUser { get; set; } = null!;
    
    public void OnGet(int id)
    {
        CurrentUser = _userRepository.GetUser(id);
    }
}