using ASOIU.Models;
namespace ASOIU.Services;

public interface IUserRepository
{
    User GetUser(int id);
    public IEnumerable<User> GetAllUsers();
    bool UserExists(string login, string password);
    
}