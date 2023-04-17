using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASOIU.Models;

public class Order
{
    [Key] public int ID { get; set; }
     public string address { get; set; }
     public DateTime date { get; set; }
     public string comm { get; set; }
    
     [ForeignKey(nameof(userID))]
     [InverseProperty("Orders")]
     public int userID { get; set; }
     public virtual User username { get; set; }

     public override string ToString()
     {
         return ID.ToString();
     }
}