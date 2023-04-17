using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASOIU.Models;

public class Product
{
    [Key] public int ID { get; set; }
    public string name { get; set; }
    public int count { get; set; }
    public string info { get; set; }
    public string price { get; set; }       

    [ForeignKey(nameof(makerID))]
    [InverseProperty("Products")]
    public int makerID { get; set; }

    public virtual Specifications maker { get; set; }

    public override string ToString()
    {
        return name;
    }
}