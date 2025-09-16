namespace Cadeteria.Models;

class Cadete
{
    public int Id { get; }
    public string Nombre { get; }
    public string Direccion { get; }
    public string Telefono { get; }
    public List<Pedido> ListaDePedidos { get; private set; } = new List<Pedido>();
    public double PrecioPorPedido { get; } = 500;

    public Cadete(int id, string nombre, string direccion, string tel)
    {
        Id = id;
        Nombre = nombre;
        Direccion = direccion;
        Telefono = tel;
    }

}