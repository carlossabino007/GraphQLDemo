using GraphQLDemo.Models;

namespace GraphQLDemo.Services
{
    public class ProductoService
    {
        private readonly List<Producto> productos = new();

        public ProductoService()
        {
            // Datos iniciales
            productos.Add(new Producto { Id = 1, Nombre = "Laptop", Descripcion = "Portátil de 15 pulgadas", Precio = 1200 });
            productos.Add(new Producto { Id = 2, Nombre = "Tablet", Descripcion = "Pantalla de 10 pulgadas", Precio = 800 });
            productos.Add(new Producto { Id = 3, Nombre = "Smartphone", Descripcion = "Teléfono de última generación", Precio = 950 });
        }

        public IEnumerable<Producto> GetAll() => productos;

        public Producto Add(Producto p)
        {
            p.Id = productos.Count > 0 ? productos.Max(x => x.Id) + 1 : 1;
            productos.Add(p);
            return p;
        }

        public Producto Update(int id, Producto p)
        {
            var existing = productos.FirstOrDefault(x => x.Id == id);
            if (existing == null) return null;

            existing.Nombre = p.Nombre;
            existing.Descripcion = p.Descripcion;
            existing.Precio = p.Precio;
            return existing;
        }

        public bool Delete(int id)
        {
            var producto = productos.FirstOrDefault(x => x.Id == id);
            if (producto == null) return false;

            productos.Remove(producto);
            return true;
        }
    }
}