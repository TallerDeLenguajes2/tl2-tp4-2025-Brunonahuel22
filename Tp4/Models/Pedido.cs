

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