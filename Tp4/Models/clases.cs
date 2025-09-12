class Cliente
{
    private string _nombre;
    private string _direccion;
    private string _telefono;
    private string _datosReferenciaDireccion;

    public string Nombre
    {
        get { return _nombre; }
    }
    public string Direccion
    {
        get { return _direccion; }
    }
    public string Telefono
    {
        get { return _telefono; }
    }
    public string DatosReferenciaDireccion
    {
        get { return _datosReferenciaDireccion; }
    }




    public Cliente(string nombre, string direccion, string telefono, string referencia)
    {
        _nombre = nombre;
        _direccion = direccion;
        _telefono = telefono;
        _datosReferenciaDireccion = referencia;
    }
}

class Pedido
{
    private int numero;
    private string observacion;
    private string estado;
    private Cliente cliente { get; }


    public int Numero
    {
        get { return numero; }
    }

    public string Observacion
    {
        get { return observacion; }
    }
    public string Estado
    {
        get { return estado; }
    }
    public Cliente Client
    {
        get { return cliente; }
    }

    public Pedido(int P_numero, string p_obs, Cliente P_cliente)
    {
        numero = P_numero;
        observacion = p_obs;
        estado = "Pendiente";
        cliente = P_cliente;
    }

    public void CambiarEstado(string nuevoEstado)
    {
        
        if (nuevoEstado == "Pendiente" || nuevoEstado == "Realizado" || nuevoEstado == "Cancelado")
        { estado = nuevoEstado; }
        else
        { Console.WriteLine("Error al cambiar estado"); }
    }

    public void VerDireccionCliente()
    {
        Console.WriteLine($"La dirección del cliente es: {cliente.Direccion}");
    }

    public void VerDatosCliente()
    {
        Console.WriteLine($"Nombre: {cliente.Nombre}");
        Console.WriteLine($"Dirección: {cliente.Direccion}");
        Console.WriteLine($"Teléfono: {cliente.Telefono}");
        Console.WriteLine($"Referencia: {cliente.DatosReferenciaDireccion}");
    }
}

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