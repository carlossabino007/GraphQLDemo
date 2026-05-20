using GraphQLDemo.Models;
using GraphQLDemo.Services;

namespace GraphQLDemo.GraphQL
{
    public class Mutation
    {
        public Producto AddProducto(ProductoInput input, [Service] ProductoService service)
        {
            var producto = new Producto
            {
                Nombre = input.Nombre,
                Descripcion = input.Descripcion,
                Precio = input.Precio
            };
            return service.Add(producto);
        }

        public Producto UpdateProducto(int id, ProductoInput input, [Service] ProductoService service)
        {
            var producto = new Producto
            {
                Id = id,
                Nombre = input.Nombre,
                Descripcion = input.Descripcion,
                Precio = input.Precio
            };
            return service.Update(id, producto);
        }

        public bool DeleteProducto(int id, [Service] ProductoService service)
            => service.Delete(id);
    }
}