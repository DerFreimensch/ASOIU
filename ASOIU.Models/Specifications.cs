using System.ComponentModel.DataAnnotations;

namespace ASOIU.Models;

public class Specifications
{
    [Key]
    public int ID { get; set; }
    public string maker { get; set; }
}