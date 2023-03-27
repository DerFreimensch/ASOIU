using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASOIU.Models;

public class Feedback
{
    [Key] public int ID { get; set; }
    public string text { get; set; }
    public DateTime date { get; set; }
    
    [ForeignKey(nameof(user))]
    [InverseProperty("Feedbacks")]
    public int user { get; set; }
    public virtual User t_user { get; set; }
    
    [ForeignKey(nameof(product))]
    [InverseProperty("Feedbacks")]
    public int product { get; set; }
    public virtual Product t_product { get; set; }
}