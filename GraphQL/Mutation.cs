using GraphQLDemo.Models;
using GraphQLDemo.Services;

namespace GraphQLDemo.GraphQL
{
    public class Mutation
    {
        public Producto AddProducto(Producto input, [Service] ProductoService service)
    => service.Add(input);

        public Producto UpdateProducto(Producto input, [Service] ProductoService service)
    => service.Update(input.Id, input);

        public bool DeleteProducto(int id, [Service] ProductoService service)
            => service.Delete(id);

        //public Producto AddProducto(Producto input, [Service] ProductoService service)
        //    => service.Add(input);

        //public Producto UpdateProducto(int id, Producto input, [Service] ProductoService service)
        //    => service.Update(id, input);
    }
}