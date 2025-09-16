namespace Cadeteria.Models;

public class Pedido
{
    public int Numero { get; set; }
    public string Observacion { get; set; } = string.Empty;
    public string Estado { get; set; } = "Pendiente";
    public Cliente Cliente { get; set; } = new Cliente();

   
    public Pedido() { }

  
    public Pedido(int numero, string obs, Cliente cliente)
    {
        Numero = numero;
        Observacion = obs;
        Estado = "Pendiente";
        Cliente = cliente;
    }

   
    public void CambiarEstado(string nuevoEstado)
    {
        if (nuevoEstado == "Pendiente" || nuevoEstado == "Realizado" || nuevoEstado == "Cancelado")
        {
            Estado = nuevoEstado; 
        }
    }
}
