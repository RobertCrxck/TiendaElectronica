using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TiendaElectronica.Domain.Entities;

public class Categoria
{
    [Key]
    public int IdCategoria { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio")]
    [StringLength(80)]
    public string Nombre { get; set; } = string.Empty;

    [StringLength(250)]
    public string? Descripcion { get; set; }

    public ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
