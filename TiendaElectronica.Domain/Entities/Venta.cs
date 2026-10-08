using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TiendaElectronica.Domain.Entities;

public class Venta
{
    [Key]
    public int IdVenta { get; set; }

    [Required]
    public DateTime Fecha { get; set; } = DateTime.Now;

    [Required]
    [Column(TypeName = "decimal(12,2)")]
    public decimal Total { get; set; }

    [Required]
    public int IdCliente { get; set; }
    [ForeignKey(nameof(IdCliente))]
    public Cliente? Cliente { get; set; }

    [Required]
    public int IdUsuario { get; set; }
    [ForeignKey(nameof(IdUsuario))]
    public Usuario? Usuario { get; set; }

    public ICollection<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();
}
