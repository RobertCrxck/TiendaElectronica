using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TiendaElectronica.Domain.Entities;

public class Usuario
{
    [Key]
    public int IdUsuario { get; set; }

    [Required]
    [StringLength(50)]
    public string NombreUsuario { get; set; } = string.Empty;

    [Required]
    [StringLength(200)]
    public string Contrasena { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string NombreCompleto { get; set; } = string.Empty;

    [Required]
    [StringLength(30)]
    public string Rol { get; set; } = "Vendedor"; // Administrador / Vendedor

    public ICollection<Venta> Ventas { get; set; } = new List<Venta>();
}
