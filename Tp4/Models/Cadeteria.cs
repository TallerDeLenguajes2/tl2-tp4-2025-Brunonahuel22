class Cadeteria
{
    public string Nombre { get; }
    public string Telefono { get; }

    public List<Cadete> ListadoCadetes { get; private set; } = new List<Cadete>();

    public List<Pedido> ListadoPedidos { get; private set; } = new List<Pedido>();

    public Cadeteria(string nombre, string telefono)
    {
        Nombre = nombre;
        Telefono = telefono;
    }


    public void AgregarCadete(Cadete nuevoCadete)
    {
        ListadoCadetes.Add(nuevoCadete);
    }

    public void AgregarPedido(Pedido nuevoPedido)
    {
        ListadoPedidos.Add(nuevoPedido);
    }


}