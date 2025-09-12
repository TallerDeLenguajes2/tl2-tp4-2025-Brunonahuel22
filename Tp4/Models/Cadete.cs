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

    public void AsignarPedido(Pedido pedido)
    {
        ListaDePedidos.Add(pedido);
    }


    public bool QuitarPedido(int numeroPedido)
    {
        foreach (Pedido unPedido in ListaDePedidos)
        {
            if (unPedido.Numero == numeroPedido)
            {
                ListaDePedidos.Remove(unPedido);
                return true;
            }
        }
        return false;
    }

    public int ContarPedidos()
    {
        return ListaDePedidos.Count;
    }

    public double JornalAcobrar()
    {
        int cantidadPedidosRealizados = ListaDePedidos.Count(p => p.Estado == "Realizado");
        return cantidadPedidosRealizados * PrecioPorPedido;
    }
}