using Microsoft.EntityFrameworkCore;
using TiendaElectronica.Domain.Entities;
namespace TiendaElectronica.Infrastructure.Data;

public class TiendaDbContext : DbContext
{
    public TiendaDbContext(DbContextOptions<TiendaDbContext> options) : base(options) { }

    public DbSet<Categoria> Categorias => Set<Categoria>();
    public DbSet<Marca> Marcas => Set<Marca>();
    public DbSet<Proveedor> Proveedores => Set<Proveedor>();
    public DbSet<Producto> Productos => Set<Producto>();
    public DbSet<Cliente> Clientes => Set<Cliente>();
    public DbSet<Usuario> Usuarios => Set<Usuario>();
    public DbSet<Venta> Ventas => Set<Venta>();
    public DbSet<DetalleVenta> DetallesVenta => Set<DetalleVenta>();
}
