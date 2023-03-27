using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASOIU.Models;

public class Cart
{
    [InverseProperty("Carts")]
    [ForeignKey(nameof(order))]
    public int order { get; set; }

    public virtual Order t_order { get; set; }

    [ForeignKey(nameof(product))] 
    public int product { get; set; }
    public virtual Product t_product { get; set; }
}