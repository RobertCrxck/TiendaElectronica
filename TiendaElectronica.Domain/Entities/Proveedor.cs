using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TiendaElectronica.Domain.Entities;

public class Proveedor
{
    [Key]
    public int IdProveedor { get; set; }

    [Required]
    [StringLength(120)]
    public string Nombre { get; set; } = string.Empty;

    [StringLength(20)]
    public string? Telefono { get; set; }

    [StringLength(100)]
    [EmailAddress]
    public string? Correo { get; set; }

    public ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
