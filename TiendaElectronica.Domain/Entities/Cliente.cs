using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TiendaElectronica.Domain.Entities;

public class Cliente
{
    [Key]
    public int IdCliente { get; set; }

    [Required]
    [StringLength(100)]
    public string Nombre { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string Apellido { get; set; } = string.Empty;

    [StringLength(20)]
    public string? Dui { get; set; }

    [StringLength(20)]
    public string? Telefono { get; set; }

    [StringLength(100)]
    [EmailAddress]
    public string? Correo { get; set; }

    public ICollection<Venta> Ventas { get; set; } = new List<Venta>();
}
