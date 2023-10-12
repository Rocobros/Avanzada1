using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Product{
    public int ProductId{ get; set; }
    [Required] //Anotation
    [StringLength(40)]
    public string? ProductName{ get; set; }
    [Column("UnitPrice", TypeName ="money")] //Especificar la columna y el tipo de valor si se quiere guardar con otro nombre
    public double? Cost { get; set; } //No es necesario que tenga el mismo nombre que la columna con la Anotation
    public bool Discontinued { get; set; }
    [Column("UnitsInStock")]
    public short Stock { get; set; }

    //Navigation Properties
    public int CategoryId { get; set; }
    public virtual Category Categories { get; set; } = null!;
}