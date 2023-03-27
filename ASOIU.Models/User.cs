using System.ComponentModel.DataAnnotations;

namespace ASOIU.Models;

public class User
{
    [Key] public int ID { get; set; }
    public string surname { get; set; }
    public string name { get; set; }
    public string sec_name { get; set; }
    public DateTime reg_day { get; set; }
    public DateTime b_day { get; set; }
    public string number { get; set; }
    public string email { get; set; }
    public string login { get; set; }
    public string password {get; set; }
}