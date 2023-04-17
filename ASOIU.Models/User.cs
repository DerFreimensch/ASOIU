using System.ComponentModel.DataAnnotations;

namespace ASOIU.Models;

public class User
{
    [Key]
    public int ID { get; set; }
    public string username { get; set; }
    public string email { get; set; }
    public string password { get; set; }
    public override string ToString()
    {
        return username;
    }
}