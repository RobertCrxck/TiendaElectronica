using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TiendaElectronica.Domain.Entities;

public class Producto
{
    [Key]
    public int IdProducto { get; set; }

    [Required]
    [StringLength(30)]
    public string Codigo { get; set; } = string.Empty;

    [Required]
    [StringLength(120)]
    public string Nombre { get; set; } = string.Empty;

    [StringLength(300)]
    public string? Descripcion { get; set; }

    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public decimal Precio { get; set; }

    [Required]
    public int Stock { get; set; }

    [Required]
    public int IdCategoria { get; set; }
    [ForeignKey(nameof(IdCategoria))]
    public Categoria? Categoria { get; set; }

    [Required]
    public int IdMarca { get; set; }
    [ForeignKey(nameof(IdMarca))]
    public Marca? Marca { get; set; }

    public int? IdProveedor { get; set; }
    [ForeignKey(nameof(IdProveedor))]
    public Proveedor? Proveedor { get; set; }
}
