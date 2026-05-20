using GraphQLDemo.Models;
using GraphQLDemo.Services;

namespace GraphQLDemo.GraphQL
{
    public class Query
    {
        public IEnumerable<Producto> GetProductos([Service] ProductoService service)
            => service.GetAll();
    }
}