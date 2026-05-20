using GraphQLDemo.Data;
using GraphQLDemo.Models;

namespace GraphQLDemo.Services
{
    public class ProductoService
    {
        private readonly ProductoDbContext _context;

        public ProductoService(ProductoDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Producto> GetAll() => _context.Productos.ToList();

        public Producto Add(Producto p)
        {
            _context.Productos.Add(p);
            _context.SaveChanges();
            return p;
        }

        public Producto Update(int id, Producto p)
        {
            var existing = _context.Productos.Find(id);
            if (existing == null) throw new Exception("Producto no encontrado");

            existing.Nombre = p.Nombre;
            existing.Descripcion = p.Descripcion;
            existing.Precio = p.Precio;
            _context.SaveChanges();
            return existing;
        }

        public bool Delete(int id)
        {
            var producto = _context.Productos.Find(id);
            if (producto == null) throw new Exception("Producto no encontrado");

            _context.Productos.Remove(producto);
            _context.SaveChanges();
            return true;
        }
    }
}