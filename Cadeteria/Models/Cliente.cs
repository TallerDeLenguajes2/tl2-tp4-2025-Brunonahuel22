namespace Cadeteria.Models;

public class Cliente
{
    public string? Nombre { get; private set; }
    public string? _direccion { get; private set; }
    public string? _telefono { get; private set; }
    public string? _datosReferenciaDireccion { get; private set; }


    public Cliente() { }






    public Cliente(string nombre, string direccion, string telefono, string referencia)
    {
        Nombre = nombre;
        _direccion = direccion;
        _telefono = telefono;
        _datosReferenciaDireccion = referencia;
    }
}