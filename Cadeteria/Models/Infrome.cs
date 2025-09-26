namespace Cadeteria.Models;

public class Informe
{
    public int TotalPedidos { get; set; }
    public int PedidosPendientes { get; set; }
    public int PedidosRealizados { get; set; }
    public int PedidosCancelados { get; set; }
    public int TotalCadetes { get; set; }
    public double JornalTotal { get; set; }

    // Constructor simple
    public Informe() { }
    public Informe(int pedidos, int pedidospendientes, int pedidosrealizados, int pedidoscancelados, int totalCadetes, double jornal)
    {
        TotalPedidos = pedidos;
        PedidosPendientes = pedidospendientes;
        PedidosRealizados = pedidosrealizados;
        PedidosCancelados = pedidoscancelados;
        TotalCadetes = totalCadetes;
        JornalTotal = jornal;
     }
}