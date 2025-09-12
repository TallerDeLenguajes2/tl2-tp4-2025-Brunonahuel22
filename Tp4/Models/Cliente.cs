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