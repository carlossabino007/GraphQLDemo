namespace GraphQLDemo.Models;

public class Producto
{
    public int Id { get; set; }              // identificador único
    public string Nombre { get; set; }       // nombre del producto
    public string Descripcion { get; set; }  // descripción breve
    public decimal Precio { get; set; }      // valor numérico
}