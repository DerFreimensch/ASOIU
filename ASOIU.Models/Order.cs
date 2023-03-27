using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASOIU.Models;

public class Order
{
    [Key] public int ID { get; set; }
     public string adress { get; set; }
     public DateTime date { get; set; }
     public string comm { get; set; }
    
     [ForeignKey(nameof(user))]
     [InverseProperty("Orders")]
     public int user { get; set; }
     public virtual User t_user { get; set; }
}