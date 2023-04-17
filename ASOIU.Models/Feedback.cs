using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASOIU.Models;

public class Feedback
{
    [Key] public int ID { get; set; }
    public string text { get; set; }
    public DateTime date { get; set; }
    
    [ForeignKey(nameof(userID))]
    [InverseProperty("Feedbacks")]
    public int userID { get; set; }
    public virtual User username { get; set; }
    
    [ForeignKey(nameof(productID))]
    [InverseProperty("Feedbacks")]
    public int productID { get; set; }
    public virtual Product name { get; set; }
}