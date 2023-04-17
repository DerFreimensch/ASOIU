using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASOIU.Models;

public class Cart
{
    [Key]
    public int ID { get; set; }
    [InverseProperty("Carts")]
    [ForeignKey(nameof(orderID))]
    public int orderID { get; set; }

    //public virtual Order t_order { get; set; }

    [ForeignKey(nameof(productID))] 
    public int productID { get; set; }
    public virtual Product name { get; set; }
    
    public int count { get; set; }

    public override string ToString()
    {
        return ID.ToString();
    }
}