using ASOIU.Models;
using Microsoft.EntityFrameworkCore;

namespace ASOIU.Services;

public class SqlUserRepository : IUserRepository
{
    private readonly AppDbContext _context;
    
    public SqlUserRepository(AppDbContext context)
    {
        context.Database.CanConnect();
        _context = context;
    }
    
    public User GetUser(int id)
    {
        return _context.Users.FirstOrDefault(x=>x.ID == id) ?? throw new InvalidOperationException();
    }

    public IEnumerable<User> GetAllUsers()
    {
        return _context.Users;
    }

    public bool UserExists(string login, string password)
    {
        var temp =  _context.Users.FirstOrDefault(u => u.email.Equals(login));
        return temp != null;
    }
}