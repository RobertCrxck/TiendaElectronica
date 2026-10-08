using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TiendaElectronica.Domain.Entities;

public class DetalleVenta
{
    [Key]
    public int IdDetalle { get; set; }

    [Required]
    public int IdVenta { get; set; }
    [ForeignKey(nameof(IdVenta))]
    public Venta? Venta { get; set; }

    [Required]
    public int IdProducto { get; set; }
    [ForeignKey(nameof(IdProducto))]
    public Producto? Producto { get; set; }

    [Required]
    public int Cantidad { get; set; }

    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public decimal PrecioUnitario { get; set; }
}
