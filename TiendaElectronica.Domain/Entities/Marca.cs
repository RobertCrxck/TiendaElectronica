using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TiendaElectronica.Domain.Entities;

public class Marca
{
    [Key]
    public int IdMarca { get; set; }

    [Required]
    [StringLength(80)]
    public string Nombre { get; set; } = string.Empty;

    [StringLength(60)]
    public string? PaisOrigen { get; set; }

    public ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
